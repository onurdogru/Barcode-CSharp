using YGFCTBarkod.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text.RegularExpressions;
using YGFCTBarkod.Printer;
using System.Printing;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace YGFCTBarkod
{

    public partial class Main : Form
    {
        private string customMessageBoxTitle;
        string printerName;
        public AyarForm AyarFrm;
        public KurulumForm KurulumFrm;
        public Sifre SifreFrm;
        public ProgAyarForm ProgAyarFrm;
        private IntPtr ShellHwnd;
        private DateTime lastDateTime = DateTime.Now;

        int stepState = 0;
        int adminTimerCounter = 0;

        byte[] arrayRx = new byte[256];
        int counterRxByte = 0;

        public int yetki;

        string companyNo; //Barkoddan Karşılatırılan
        string SAPNo;  //Barkoddan Karşılatırılan
        string productionDate;  //Barkoddan Alınan
        string indexNo; //Barkoddan Alınan
        string productionNo; //Barkoddan Alınan
        string cardNo;  //Barkoddan Karşılatırılan
        string gerberVer;  //Sabit
        string BOMVer;  //Sabit
        string ICTRev;  //Sabit
        string FCTRev;  //Sabit
        string softwareVer;  //Sabit
        string softwareRev;  //Sabit
        string UniqId; //Kartdan Alınan
        string HSMId; //Kartdan Alınan
        string barcode72 = "";
        private static readonly string BaseUrl = "https://cdu.arcelik.com/CardDataApi/"; //PRODUCTION
        public Main()
        {
            this.AyarFrm = new AyarForm();
            this.AyarFrm.MainFrm = this;
            this.KurulumFrm = new KurulumForm();
            this.KurulumFrm.MainFrm = this;
            this.SifreFrm = new Sifre();
            this.SifreFrm.MainFrm = this;
            this.ProgAyarFrm = new ProgAyarForm();
            this.ProgAyarFrm.MainFrm = this;
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern byte ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string ClassName, string WindowName);

        private void Main_Load(object sender, EventArgs e)
        {
            /*
            this.ShellHwnd = Main.FindWindow("Shell TrayWnd", (string)null);
            IntPtr shellHwnd = this.ShellHwnd;
            int num1 = (int)Main.ShowWindow(this.ShellHwnd, 0);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Control.CheckForIllegalCrossThreadCalls = false;
            */
            this.customMessageBoxTitle = Ayarlar.Default.projectName;
            this.printerName = Ayarlar.Default.printerName;
            this.projectNameTxt.Text = customMessageBoxTitle;
            this.Text = customMessageBoxTitle;

            this.cardPicture.ImageLocation = Ayarlar.Default.PNGdosyayolu;

            foreach (string portName in SerialPort.GetPortNames())
            {
                this.AyarFrm.SerialPort1Com.Items.Add((object)portName);
                this.AyarFrm.SerialPort2Com.Items.Add((object)portName);
            }
            if (Kurulum.Default.chBoxProgramlama)
            {
                btnStartProgramming.Enabled = false;
                btnFCTInit.Enabled = false;
            }

            this.serialPort1.PortName = Ayarlar.Default.SerialPort1Com;
            this.serialPort1.BaudRate = Ayarlar.Default.SerialPort1Baud;
            this.serialPort1.DataBits = Ayarlar.Default.SerialPort1dataBits;
            this.serialPort1.StopBits = Ayarlar.Default.SerialPort1stopBit;
            this.serialPort1.Parity = Ayarlar.Default.SerialPort1Parity;
            this.serialPort1.ReceivedBytesThreshold = 1;
            this.serialPort2.PortName = Ayarlar.Default.SerialPort2Com;
            this.serialPort2.BaudRate = Ayarlar.Default.SerialPort2Baud;
            this.serialPort2.DataBits = Ayarlar.Default.SerialPort2dataBits;
            this.serialPort2.StopBits = Ayarlar.Default.SerialPort2stopBit;
            this.serialPort2.Parity = Ayarlar.Default.SerialPort2Parity;
            this.serialPort2.ReceivedBytesThreshold = 1;

            this.timerAdmin.Interval = Ayarlar.Default.timerAdmin;

            this.companyNo = Prog_Ayarlar.Default.companyNo;
         //   this.SAPNo = Prog_Ayarlar.Default.SAPNo;
            this.cardNo = Prog_Ayarlar.Default.cardNo;
            this.gerberVer= Prog_Ayarlar.Default.gerberVer;
            this.BOMVer = Prog_Ayarlar.Default.BOMVer;
            this.ICTRev = Prog_Ayarlar.Default.ICTRev;
            this.FCTRev = Prog_Ayarlar.Default.FCTRev;
            this.softwareVer = Prog_Ayarlar.Default.softwareVer;
            this.softwareRev = Prog_Ayarlar.Default.softwareRev;

            this.yetki = 0;
            this.yetkidegistir();

            if (Ayarlar.Default.chBoxSerial1)
            {
                try
                {
                    this.serialPort1.DtrEnable = true;
                    this.serialPort1.Open();
                    lblStatusCom1.Text = "ON";
                    lblStatusCom1.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    int num2 = (int)MessageBox.Show("Com1 Port Hatası: " + ex.ToString());
                    lblStatusCom1.Text = "OFF";
                    lblStatusCom1.BackColor = Color.Red;
                }
            }
            if (Ayarlar.Default.chBoxSerial2)
            {
                try
                {
                    this.serialPort2.Open();
                    lblStatusCom2.Text = "ON";
                    lblStatusCom2.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    int num2 = (int)MessageBox.Show("Com2 Port Hatası: " + ex.ToString());
                    lblStatusCom2.Text = "OFF";
                    lblStatusCom2.BackColor = Color.Red;
                }
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort2.BytesToRead > 0)
            {
                arrayRx[counterRxByte] = Convert.ToByte(serialPort2.ReadByte());
                counterRxByte++;
                Thread.Sleep(100);
            }
            this.Invoke(new EventHandler(ShowData2));
        }

        private void ShowData2(object sender, EventArgs e)
        {
            for (int i = 0; i < counterRxByte; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(arrayRx[i]) + "' ", Color.Green);
            }
            ConsoleAppendLine("COM2'den geldi.", Color.Green);
            ConsoleNewLine();

            if (Kurulum.Default.chBoxProgramlama && stepState == 0)
            {
                serialBufferClear();
                this.Invoke(new EventHandler(btnStartProgramming_Click));
            }
            else
            {
                serialBufferClear();
            }
        }

        private void btnStartProgramming_Click(object sender, EventArgs e)
        {
            string barcode = tbBarcodeCurrent.Text;
            Thread programThread = new Thread(ProgramThreadFunction);
            programThread.Start(barcode);
        }

        /* Tüm Ana İşlemlerin Yönlendirilmesi*/
        private void ProgramThreadFunction(object data)
        {
            bool result = false;
            ConsoleClean();

            string barcode = (string)data;
            string company_no = string.Empty;
            string SAP_no = string.Empty;
            string production_date = string.Empty;
            string index_no = string.Empty;
            string production_no = string.Empty;
            string card_no = string.Empty;

            // if barcode is true
            if (BarcodeCheck(barcode))
            {
                // Disable Programming Button
                btnStartProgramming.Invoke(new Action(delegate () { btnStartProgramming.Enabled = false; }));

                ConsoleAppendLine("Barkod: " + barcode, Color.White);
                ConsoleNewLine();
                ConsoleAppendLine("Barkod kriterlere uygun.", Color.Green);
                ConsoleNewLine();

                company_no = GetStringBetweenTwoSubStrings(barcode, "$01", "$02");
                SAP_no = (GetStringBetweenTwoSubStrings(barcode, "$02", "$03").Substring(0, 10));
                production_date = GetStringBetweenTwoSubStrings(barcode, "$03", "$04");
                productionDate = production_date;
                index_no = GetStringBetweenTwoSubStrings(barcode, "$04", "$05");
                indexNo = index_no;
                production_no = GetStringBetweenTwoSubStrings(barcode, "$05", "$06");
                productionNo = production_no;
                card_no = GetStringBetweenTwoSubStrings(barcode, "$06", "$07");

                ConsoleAppendLine("Company No: " + company_no, Color.White);
                ConsoleAppendLine("SAP No: " + SAP_no, Color.White);
                ConsoleAppendLine("Production Date: " + production_date, Color.White);
                ConsoleAppendLine("Index No: " + index_no, Color.White);
                ConsoleAppendLine("Product No: " + production_no, Color.White);
                ConsoleAppendLine("Card No: " + card_no, Color.White);

                ConsoleNewLine();

                ConsoleAppendLine(production_no + " kodlu ürünün barkod işlemi yapılıyor...", Color.Yellow);
                result = true;
            }
            else
            {
                if (barcode.Equals(""))
                {
                    // Show message box
                    DialogResult dialog_result = DialogResult.None;
                    this.Invoke(new Action(delegate ()
                    {
                        dialog_result = CustomMessageBox.ShowMessage("Barkod boş bırakılamaz!", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Yellow);
                    }));
                    if (dialog_result == DialogResult.OK)
                    {
                        ConsoleAppendLine("Barkod: " + barcode, Color.White);
                        ConsoleNewLine();
                        ConsoleAppendLine("Yanlış barkod! Barkod kriterlere uygun değil! Programlama yapılamadı!", Color.Red);
                        ConsoleNewLine();
                        result = false;
                    }
                }
                else
                {
                    // Show message box
                    DialogResult dialog_result = DialogResult.None;
                    this.Invoke(new Action(delegate ()
                    {
                        dialog_result = CustomMessageBox.ShowMessage("Yanlış barkod! Barkod kriterlere uygun değil!", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Yellow);
                    }));
                    if (dialog_result == DialogResult.OK)
                    {
                        ConsoleAppendLine("Barkod: " + barcode, Color.White);
                        ConsoleNewLine();
                        ConsoleAppendLine("Yanlış barkod! Barkod kriterlere uygun değil! Programlama yapılamadı!", Color.Red);
                        ConsoleNewLine();
                        All_Barkod_Fail();
                        result = false;
                    }
                }
            }

            // Update status bar
            if (result)
            {
                tbState.Invoke(new Action(delegate ()
                {
                    tbState.BackColor = Color.Green;
                    tbState.Text = "BARKOD BAŞARILI";
                    serialWriteRelayOff();
                }));
            }
            else
            {
                tbState.Invoke(new Action(delegate ()
                {
                    tbState.BackColor = Color.Red;
                    tbState.Text = "BARKOD BAŞARISIZ";
                }));

                // Show message box
                DialogResult dialog_result = DialogResult.None;
                this.Invoke(new Action(delegate ()
                {
                    dialog_result = CustomMessageBox.ShowMessage("BARKOD BAŞARISIZ", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Fail, Color.Red);
                }));
                if (dialog_result == DialogResult.OK)
                {
                    // do nothing only information.
                }
                All_Barkod_Fail();
            }

            // Assign Last Barcode with Current
            tbBarcodeLast.Invoke(new Action(delegate () { tbBarcodeLast.Text = barcode; }));

            tbBarcodeCurrent.Invoke(new Action(delegate ()
            {
                // Clean Current Barcode
                tbBarcodeCurrent.Text = "";
                // Focus Barcode textbox
                tbBarcodeCurrent.Focus();
                // Select all text in textbox
                tbBarcodeCurrent.SelectionStart = 0;
                tbBarcodeCurrent.SelectionLength = tbBarcodeCurrent.Text.Length;
            }));

            // Enable Programming Button
            btnStartProgramming.Invoke(new Action(delegate () { btnStartProgramming.Enabled = true; }));
        }

        /* Gelen Barcode Kontrol Edilir*/
        private bool BarcodeCheck(String barcode)
        {
            // Barcode length should be between 26-150.
            if (barcode.Length < 26 || barcode.Length > 150) return false;

            // Simple starting contains ending substring check.
            if (!(barcode.StartsWith("$01") && barcode.Contains("$02") && barcode.Contains("$03") && barcode.Contains("$04")
                && barcode.Contains("$05") && barcode.Contains("$06") && barcode.Contains("$07")
                && barcode.EndsWith("#")))
            {
                return false;
            }

            // Find the index of the substrings in Barcode. Value is -1, if substring is not exist.
            int[] index = new int[8];
            int count = 150;
            if (barcode.Length < 150) count = barcode.Length;
            index[0] = barcode.IndexOf("$01", 0, count);
            index[1] = barcode.IndexOf("$02", 0, count);
            index[2] = barcode.IndexOf("$03", 0, count);
            index[3] = barcode.IndexOf("$04", 0, count);
            index[4] = barcode.IndexOf("$05", 0, count);
            index[5] = barcode.IndexOf("$06", 0, count);
            index[6] = barcode.IndexOf("$07", 0, count);
            index[7] = barcode.IndexOf("#", 0, count);

            for (int i = 0; i < index.Length; ++i)
            {
                // if substring is not exist
                if (index[i] == -1)
                {
                    return false;
                }

                // if substring position is not correct
                for (int j = i + 1; j < index.Length; ++j)
                {
                    if (index[i] > index[j])
                    {
                        return false;
                    }
                }
            }
            //Karşılaştırma Kısmı
            string company_no = GetStringBetweenTwoSubStrings(barcode, "$01", "$02");
            string SAP_no = (GetStringBetweenTwoSubStrings(barcode, "$02", "$03").Substring(0, 10));
            string card_no = GetStringBetweenTwoSubStrings(barcode, "$06", "$07"); ;
            // check company no
            if (!company_no.Equals(companyNo))
            {
                return false;
            }

            if (radioButton1.Checked)
            {
                SAPNo = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                SAPNo = radioButton2.Text;
            }

            // check SAP no
            if (!SAP_no.Equals(SAPNo))
            {
                return false;
            }

            // check card no
            if (!card_no.Equals(cardNo))
            {
                return false;
            }

            // There is no problem
            return true;
        }

        /*Gelen Barkodu Ayıklanır*/
        private String GetStringBetweenTwoSubStrings(String source, String sub1, String sub2)
        {
            int pFrom = source.IndexOf(sub1) + sub1.Length;
            int pTo = source.LastIndexOf(sub2);
            String result = source.Substring(pFrom, pTo - pFrom);
            return result;
        }
        private void serialWriteRelayOff()
        {
            byte[] byteArray = new byte[8];
            byteArray[0] = 3;
            byteArray[1] = 0;
            byteArray[2] = 0;
            byteArray[3] = 1;
            byteArray[4] = 251;
            for (int i = 0; i < 5; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(byteArray[i]) + " '", Color.Blue);
            }
            ConsoleAppendLine("COM1'den gitti.", Color.Blue);
            serialPort1.Write(byteArray, 0, 5);
            waitTimer.Start();  //Burası gelene kadar veriler alındı silindi
        }

        private void serialWriteHSM()  //waitTimer.Start
        {
            byte[] byteArray = new byte[8];
            byteArray[0] = 4;
            byteArray[1] = 0;
            byteArray[2] = 0;
            byteArray[3] = 0;
            byteArray[4] = 251;
            for (int i = 0; i < 5; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(byteArray[i]) + " '", Color.Blue);
            }
            ConsoleAppendLine("COM1'den gitti.", Color.Blue);
            serialPort1.Write(byteArray, 0, 5);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 0)
            {
                arrayRx[counterRxByte] = Convert.ToByte(serialPort1.ReadByte());
                counterRxByte++;
                Thread.Sleep(100);
            }
            if (stepState == 77)
            {
                if (counterRxByte > 30)
                {
                    serialWriteBLE();
                }
            }
            else if (stepState == 79)
            {
                serialBufferClear();
            }
            else
            {
                this.Invoke(new EventHandler(ShowData1));
            }
        }

        private void ShowData1(object sender, EventArgs e)
        {
            for (int i = 0; i < counterRxByte; i++)
            {
                ConsoleAppendLine("' " + Convert.ToByte(arrayRx[i]) + "' ", Color.Green);
            }
            ConsoleAppendLine("COM1'den geldi.", Color.Green);
            ConsoleNewLine();
            serialBufferClear();
        }
         
        private void serialWriteBLE()
        {
            if (stepState == 77)
            {
                stepState = 79;
                // byte[] byteArray = new byte[10];
                string uniq_id = "";
                for (int i = 0; i < 9; i++)
                {
                    int number = int.Parse(Convert.ToString(arrayRx[20 + i]));
                    if (number < 16)
                    {
                        uniq_id = uniq_id + "0";
                    }
                    uniq_id = uniq_id + Convert.ToString(number, 16);
                    ConsoleAppendLine("' " + Convert.ToByte(arrayRx[20 + i]) + " '", Color.Blue);
                }
                HSMId = uniq_id;
                UniqId = uniq_id + "0000";
                ConsoleAppendLine("HwZ_" + uniq_id, Color.Blue);
            }
            serialBufferClear();  //Yeni
            cloudAction();
        }

        void cloudAction()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            //  var token = HttpClientExtentions.GetToken("ALPPLASTEST", "ALPPLASTEST*"); //TEST
            var token = HttpClientExtentions.GetToken("ALPPLAS", "AlpPlas1*"); //PRODUCTION
            barcode72 = companyNo + SAPNo + productionDate + indexNo + productionNo + cardNo + gerberVer + BOMVer + ICTRev + FCTRev + softwareVer + softwareRev + UniqId;
            ConsoleAppendLine("Barcode: " + barcode72, Color.Orange);
            barcode72Text.Text = barcode72;
            InsertConnectedCard(token);
        }

        public void InsertConnectedCard(string token)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(BaseUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var model = new CreateProductCardDataModel()
                {
                    FullBarcode = barcode72, // 72 characters card information
                    CertificateId = "", //If exist 
                    HsmId = HSMId, //If hsm exist
                    CertificatePublicData = "", //If hsm exist
                    MacId = "" //If barcode doesn't have macid
                };

                var json = JsonConvert.SerializeObject(model);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = httpClient.PostAsync("api/CardData/AddOrUpdateWifiCardData", httpContent).Result.Content.ReadAsStringAsync().Result;

                ReturnModel<string> result = JsonConvert.DeserializeObject<ReturnModel<string>>(response);
                if (result.Status == ReturnTypeStatus.Success)
                {
                    ConsoleAppendLine("Card Added to Arcelik successfully", Color.Green);
                    printAction();
                    All_Barkod_Success();
                }
                else if (result.Status == ReturnTypeStatus.Error)
                {
                    ConsoleAppendLine("Cloud ERROR:" + result.Message, Color.Red);
                    if (CustomMessageBox.ShowMessage("Cloud ERROR: Yine'de Devam Etmek İstiyor musunuz ?", customMessageBoxTitle, MessageBoxButtons.YesNo, CustomMessageBoxIcon.Question, Color.Yellow) == DialogResult.Yes)
                    {
                        printAction();
                        All_Barkod_Success();
                    }
                    else
                    {
                        All_Barkod_Fail();
                    }
                }
                Console.ReadLine();
            }
        }

        void printAction()
        {
            // ^XA: Start Format
            // ^XZ: End Format
            // ^LHx,y: Label Home Position, x = x-axis position (in dots), y = y-axis position (in dots), Values: 0 to 32000
            // ^FOx,y: Field Origin, x = x-axis position (in dots), y = y-axis position (in dots), Values: 0 to 32000
            // ^Afo,h,w: Scalable/Bitmapped Font, f = font name, o = field orientation, h = Character Height (in dots), w = width (in dots), Values: 10 to 32000
            // ^FD: Field Data
            // ^FS: Field Separator
            string s1 = companyNo + indexNo.Substring(0, 2);
            string s2 = indexNo.Substring(2, 4);
            string s3 = productionNo.Substring(0, 4);
            string s4 = productionNo.Substring(4, 4);
            string s5 = productionNo.Substring(8, 4);
            string s6 = productionNo.Substring(12, 2) + cardNo;
            string start = "^XA" + "^LH10,25";
            string qr = "^BQN,2,2" + "^FDQA," + barcode72 + "^FS";
            string veri1 = "^FO70,5" + "^A0,12,12" + "^FD" + "P/N: " + SAPNo + "^FS";   //İlki Pozisyon //İkincisi Boy-En
            string veri2 = "^FO70,25" + "^A0,12,12" + "^FD" + "S/N: " + s1 + "-" + s2 + "-" + s3 + "^FS";   //İlki Pozisyon //İkincisi Boy-En
            string veri3 = "^FO70,45" + "^A0,12,12" + "^FD" + "       " + s4 + "-" + s5 + "-" + s6 + "^FS";   //İlki Pozisyon //İkincisi Boy-En
            string veri4 = "^FO70,65" + "^A0,12,12" + "^FD" + "VER: " + softwareVer + "." + softwareRev + " G:" + gerberVer + " B:" + BOMVer + " T:" + productionDate + "^FS";   //İlki Pozisyon //İkincisi Boy-En
            string end = "^XZ";
            string test = start + qr + veri1 + veri2 + veri3 + veri4 + end;

            //Get local print server
            var server = new LocalPrintServer(); 

            //Load queue for correct printer
            PrintQueue pq = server.GetPrintQueue(printerName, new string[0] { });
            PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();
            foreach (PrintSystemJobInfo job in jobs)
            {
                job.Cancel();
            }

            if (!RawPrinterHelper.SendStringToPrinter(printerName, test))
            {
                // Show message box
                if (CustomMessageBox.ShowMessage("Printer Error: (" + printerName + ")", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.WhiteSmoke) == DialogResult.OK)
                {
                }
            }
        } 

        private void All_Barkod_Success()
        {
            CustomMessageBox.ShowMessage("Barkod Doğru Çıkarıldı", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Green);
            byte[] byteArray = new byte[8];
            byteArray[0] = 48;
            ConsoleAppendLine("BARKOD BAŞARILI SONUÇLANDI.", Color.Blue);
            serialPort2.Write(byteArray, 0, 1);
            FCT_Finish();
            serialBufferClear();
        }

        private void All_Barkod_Fail()
        {
            CustomMessageBox.ShowMessage("Kart Hatalı.Lütfen Kutuya Ayırınız!", customMessageBoxTitle, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            byte[] byteArray = new byte[8];
            byteArray[0] = 48;
            ConsoleAppendLine("BARKOD BAŞARISIZ SONUÇLANDI.", Color.Red);
            serialPort2.Write(byteArray, 0, 1);
            FCT_Finish();
            serialBufferClear();
        }
          
        private void serialBufferClear()
        {
            for (int i = 0; i <= counterRxByte; i++)
            {
                arrayRx[i] = 0x0;
            }
            counterRxByte = 0;
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            serialPort2.DiscardInBuffer();
            serialPort2.DiscardOutBuffer();
        }

        private void FCT_Finish()
        {
            counterRxByte = 0;
            stepState = 0;
            ConsoleClean();
        }

        /***********************************************************************************************************************/
        private void rtbConsole_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }
        
        /*Kullanıcı Arayüzüne Yazı Yazılır*/
        private void ConsoleAppendLine(string text, Color color)
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = color;
                    rtbConsole.AppendText(text + Environment.NewLine);
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = Color.White;
                }));
            }
            else
            {
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = color;
                rtbConsole.AppendText(text + Environment.NewLine);
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = Color.White;
            }
        }

        /*Kullanıcı Arayüzünde Bir Satır Boşluk Bırakılır*/
        private void ConsoleNewLine()
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.AppendText(Environment.NewLine);
                }));
            }
            else
            {
                rtbConsole.AppendText(Environment.NewLine);
            }
        }

        private void ConsoleClean()
        {
            if (rtbConsole.InvokeRequired)
            {
                rtbConsole.Invoke(new Action(delegate ()
                {
                    rtbConsole.Text = "";
                    rtbConsole.Select(rtbConsole.TextLength, 0);
                    rtbConsole.SelectionColor = Color.White;
                }));
            }
            else
            {
                rtbConsole.Text = "";
                rtbConsole.Select(rtbConsole.TextLength, 0);
                rtbConsole.SelectionColor = Color.White;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            int num = (int)this.AyarFrm.ShowDialog();
        }

        private void btnKurulum_Click(object sender, EventArgs e)
        {
            int num = (int)this.KurulumFrm.ShowDialog();
        }

        private void btnProgAyar_Click(object sender, EventArgs e)
        {
            int num = (int)this.ProgAyarFrm.ShowDialog();
        }

        public void yetkidegistir()
        {
            if (this.yetki == 0)
            {
                this.btnCikis.Enabled = false;
                this.btnAyar.Enabled = false;
                this.btnProgAyar.Enabled = false;
                this.btnKurulum.Enabled = false;
                this.btnCikis.BackColor = Color.Beige;
                this.btnAyar.BackColor = Color.Beige;
                this.btnProgAyar.BackColor = Color.Beige;
                this.btnKurulum.BackColor = Color.Beige;
            }
            if (this.yetki == 1)
            {
                this.btnCikis.Enabled = true;
                this.btnAyar.Enabled = true;
                this.btnProgAyar.Enabled = true;
                this.btnKurulum.Enabled = true;
                this.btnCikis.BackColor = Color.Red;
                this.btnAyar.BackColor = Color.Red;
                this.btnProgAyar.BackColor = Color.Red;
                this.btnKurulum.BackColor = Color.Red;
                timerAdmin.Start();
            }
            if (this.yetki == 2)
            {
                this.btnCikis.Enabled = true;
                this.btnCikis.BackColor = Color.Red;
                this.btnAyar.BackColor = Color.Beige;
                this.btnKurulum.BackColor = Color.Beige;
                this.btnProgAyar.BackColor = Color.Beige;
                timerAdmin.Start();
            }
        }

        private void tbUserLogin_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.L)
                return;
            if (this.yetki != 0)
            {
                timerAdmin.Stop();
                this.yetki = 0;
                this.yetkidegistir();
            }
            else
            {
                int num = (int)this.SifreFrm.ShowDialog();
                tbUserLogin.Clear();
            }
        }

        private void timerAdmin_Tick_1(object sender, EventArgs e)
        {
            adminTimerCounter++;
            if (adminTimerCounter == 1)
            {
                adminTimerCounter = 0;
                timerAdmin.Stop();
                this.yetki = 0;
                this.yetkidegistir();
            }
        }

        #region class declarations
        public class CreateProductCardDataModel
        {
            public string FullBarcode { get; set; }
            public string HsmId { get; set; }
            public string CertificateId { get; set; }
            public string CertificatePublicData { get; set; }
            public string MacId { get; set; }
        }

        public static class HttpClientExtentions
        {
            public static string GetToken(string userName, string password)
            {
                var client = new HttpClient { BaseAddress = new Uri(BaseUrl) };

                var response =
                  client.PostAsync("Token",
                    new StringContent(string.Format("grant_type=password&username={0}&password={1}",
                      HttpUtility.UrlEncode(userName),
                      HttpUtility.UrlEncode(password)), Encoding.UTF8,
                      "application/x-www-form-urlencoded")).Result;

                var resultJson = response.Content.ReadAsStringAsync().Result;

                var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(resultJson);

                return dict["access_token"].ToString();
            }
        }

        public class ReturnModel<T>
        {
            public T Data { get; set; }
            public ReturnTypeStatus Status { get; set; }
            public string Message { get; set; }
        }

        public enum ReturnTypeStatus
        {
            Success = 1,
            Error = 2,
            NotFound = 3,
            Working = 4
        }
        #endregion

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            if (stepState == 0)
            {
                ConsoleAppendLine("Wait Timer1'a girdi", Color.Blue);
                serialBufferClear();
                stepState = 77;
                waitTimer.Stop();
                serialWriteHSM(); 
            }
        }
    }
}

