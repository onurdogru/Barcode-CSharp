// Decompiled with JetBrains decompiler
// Type: EsdTurnikesi.AyarForm
// Assembly: EsdTurnikesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C8099926-BBEB-495E-ADF6-36B4F5F75BE8
// Assembly location: C:\Users\serkan.baki\Desktop\esd-rar\ESD\Release\EsdTurnikesi.exe

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

namespace YGFCTBarkod
{
    public class KurulumForm : Form
    {
        public Main MainFrm;
        private IContainer components;
        private ComboBox stepNum;
        private Label label30;
        private ComboBox step1Job;
        private Label label13;
        private ComboBox step2Job;
        private Label label14;
        private ComboBox step4Job;
        private Label label15;
        private ComboBox step3Job;
        private Label label16;
        private ComboBox step5Job;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label40;
        private Label label41;
        private ComboBox feedback1;
        private Label label42;
        private ComboBox feedback5;
        private ComboBox feedback4;
        private ComboBox feedback3;
        private Button btnKaydet;
        private ComboBox COM5;
        private Label label1;
        private ComboBox COM4;
        private Label label2;
        private ComboBox COM3;
        private Label label3;
        private ComboBox COM2;
        private Label label4;
        private ComboBox COM1;
        private Label label5;
        private ComboBox veri5;
        private Label label6;
        private ComboBox veri4;
        private Label label7;
        private ComboBox veri3;
        private Label label8;
        private ComboBox veri2;
        private Label label9;
        private ComboBox veri1;
        private Label label10;
        private TextBox kontrol1;
        private Label label11;
        private Label label12;
        private TextBox kontrol2;
        private Label label20;
        private TextBox kontrol3;
        private Label label21;
        private TextBox kontrol4;
        private Label label22;
        private TextBox kontrol5;
        private Label label23;
        private TextBox gorev5;
        private Label label24;
        private TextBox gorev4;
        private Label label25;
        private TextBox gorev3;
        private Label label26;
        private TextBox gorev2;
        private Label label27;
        private TextBox gorev1;
        private Label label28;
        private Label label29;
        private TextBox isim5;
        private Label label31;
        private TextBox isim4;
        private Label label32;
        private TextBox isim3;
        private Label label33;
        private TextBox isim2;
        private Label label34;
        private TextBox isim1;
        private Label label35;
        private TextBox isim10;
        private Label label36;
        private TextBox isim9;
        private Label label37;
        private TextBox isim8;
        private Label label38;
        private TextBox isim7;
        private Label label39;
        private TextBox isim6;
        private Label label43;
        private TextBox gorev10;
        private Label label44;
        private TextBox gorev9;
        private Label label45;
        private TextBox gorev8;
        private Label label46;
        private TextBox gorev7;
        private Label label47;
        private TextBox gorev6;
        private Label label48;
        private TextBox kontrol10;
        private Label label49;
        private TextBox kontrol9;
        private Label label50;
        private TextBox kontrol8;
        private Label label51;
        private TextBox kontrol7;
        private Label label52;
        private TextBox kontrol6;
        private ComboBox veri10;
        private Label label53;
        private ComboBox veri9;
        private Label label54;
        private ComboBox veri8;
        private Label label55;
        private ComboBox veri7;
        private Label label56;
        private ComboBox veri6;
        private Label label57;
        private ComboBox COM10;
        private Label label58;
        private ComboBox COM9;
        private Label label59;
        private ComboBox COM8;
        private Label label60;
        private ComboBox COM7;
        private Label label61;
        private ComboBox COM6;
        private Label label62;
        private ComboBox feedback10;
        private Label label63;
        private ComboBox feedback9;
        private Label label64;
        private ComboBox feedback8;
        private Label label65;
        private ComboBox feedback7;
        private Label label66;
        private ComboBox feedback6;
        private Label label67;
        private ComboBox step10Job;
        private Label label68;
        private ComboBox step9Job;
        private Label label69;
        private ComboBox step8Job;
        private Label label70;
        private ComboBox step7Job;
        private Label label71;
        private ComboBox step6Job;
        private Label label72;
        private Label label73;
        private TextBox isim20;
        private Label label74;
        private TextBox isim19;
        private Label label75;
        private TextBox isim18;
        private Label label76;
        private TextBox isim17;
        private Label label77;
        private TextBox isim16;
        private Label label78;
        private TextBox gorev20;
        private Label label79;
        private TextBox gorev19;
        private Label label80;
        private TextBox gorev18;
        private Label label81;
        private TextBox gorev17;
        private Label label82;
        private TextBox gorev16;
        private Label label83;
        private TextBox kontrol20;
        private Label label84;
        private TextBox kontrol19;
        private Label label85;
        private TextBox kontrol18;
        private Label label86;
        private TextBox kontrol17;
        private Label label87;
        private TextBox kontrol16;
        private ComboBox veri20;
        private Label label88;
        private ComboBox veri19;
        private Label label89;
        private ComboBox veri18;
        private Label label90;
        private ComboBox veri17;
        private Label label91;
        private ComboBox veri16;
        private Label label92;
        private ComboBox COM20;
        private Label label93;
        private ComboBox COM19;
        private Label label94;
        private ComboBox COM18;
        private Label label95;
        private ComboBox COM17;
        private Label label96;
        private ComboBox COM16;
        private Label label97;
        private ComboBox feedback20;
        private Label label98;
        private ComboBox feedback19;
        private Label label99;
        private ComboBox feedback18;
        private Label label100;
        private ComboBox feedback17;
        private Label label101;
        private ComboBox feedback16;
        private Label label102;
        private ComboBox step20Job;
        private Label label103;
        private ComboBox step19Job;
        private Label label104;
        private ComboBox step18Job;
        private Label label105;
        private ComboBox step17Job;
        private Label label106;
        private ComboBox step16Job;
        private Label label107;
        private Label label108;
        private TextBox isim15;
        private Label label109;
        private TextBox isim14;
        private Label label110;
        private TextBox isim13;
        private Label label111;
        private TextBox isim12;
        private Label label112;
        private TextBox isim11;
        private Label label113;
        private TextBox gorev15;
        private Label label114;
        private TextBox gorev14;
        private Label label115;
        private TextBox gorev13;
        private Label label116;
        private TextBox gorev12;
        private Label label117;
        private TextBox gorev11;
        private Label label118;
        private TextBox kontrol15;
        private Label label119;
        private TextBox kontrol14;
        private Label label120;
        private TextBox kontrol13;
        private Label label121;
        private TextBox kontrol12;
        private Label label122;
        private TextBox kontrol11;
        private ComboBox veri15;
        private Label label123;
        private ComboBox veri14;
        private Label label124;
        private ComboBox veri13;
        private Label label125;
        private ComboBox veri12;
        private Label label126;
        private ComboBox veri11;
        private Label label127;
        private ComboBox COM15;
        private Label label128;
        private ComboBox COM14;
        private Label label129;
        private ComboBox COM13;
        private Label label130;
        private ComboBox COM12;
        private Label label131;
        private ComboBox COM11;
        private Label label132;
        private ComboBox feedback15;
        private Label label133;
        private ComboBox feedback14;
        private Label label134;
        private ComboBox feedback13;
        private Label label135;
        private ComboBox feedback12;
        private Label label136;
        private ComboBox feedback11;
        private Label label137;
        private ComboBox step15Job;
        private Label label138;
        private ComboBox step14Job;
        private Label label139;
        private ComboBox step13Job;
        private Label label140;
        private ComboBox step12Job;
        private Label label141;
        private ComboBox step11Job;
        private Label label142;
        private Label label143;
        private TextBox isim30;
        private Label label144;
        private TextBox isim29;
        private Label label145;
        private TextBox isim28;
        private Label label146;
        private TextBox isim27;
        private Label label147;
        private TextBox isim26;
        private Label label148;
        private TextBox gorev30;
        private Label label149;
        private TextBox gorev29;
        private Label label150;
        private TextBox gorev28;
        private Label label151;
        private TextBox gorev27;
        private Label label152;
        private TextBox gorev26;
        private Label label153;
        private TextBox kontrol30;
        private Label label154;
        private TextBox kontrol29;
        private Label label155;
        private TextBox kontrol28;
        private Label label156;
        private TextBox kontrol27;
        private Label label157;
        private TextBox kontrol26;
        private ComboBox veri30;
        private Label label158;
        private ComboBox veri29;
        private Label label159;
        private ComboBox veri28;
        private Label label160;
        private ComboBox veri27;
        private Label label161;
        private ComboBox veri26;
        private Label label162;
        private ComboBox COM30;
        private Label label163;
        private ComboBox COM29;
        private Label label164;
        private ComboBox COM28;
        private Label label165;
        private ComboBox COM27;
        private Label label166;
        private ComboBox COM26;
        private Label label167;
        private ComboBox feedback30;
        private Label label168;
        private ComboBox feedback29;
        private Label label169;
        private ComboBox feedback28;
        private Label label170;
        private ComboBox feedback27;
        private Label label171;
        private ComboBox feedback26;
        private Label label172;
        private ComboBox step30Job;
        private Label label173;
        private ComboBox step29Job;
        private Label label174;
        private ComboBox step28Job;
        private Label label175;
        private ComboBox step27Job;
        private Label label176;
        private ComboBox step26Job;
        private Label label177;
        private Label label178;
        private TextBox isim25;
        private Label label179;
        private TextBox isim24;
        private Label label180;
        private TextBox isim23;
        private Label label181;
        private TextBox isim22;
        private Label label182;
        private TextBox isim21;
        private Label label183;
        private TextBox gorev25;
        private Label label184;
        private TextBox gorev24;
        private Label label185;
        private TextBox gorev23;
        private Label label186;
        private TextBox gorev22;
        private Label label187;
        private TextBox gorev21;
        private Label label188;
        private TextBox kontrol25;
        private Label label189;
        private TextBox kontrol24;
        private Label label190;
        private TextBox kontrol23;
        private Label label191;
        private TextBox kontrol22;
        private Label label192;
        private TextBox kontrol21;
        private ComboBox veri25;
        private Label label193;
        private ComboBox veri24;
        private Label label194;
        private ComboBox veri23;
        private Label label195;
        private ComboBox veri22;
        private Label label196;
        private ComboBox veri21;
        private Label label197;
        private ComboBox COM25;
        private Label label198;
        private ComboBox COM24;
        private Label label199;
        private ComboBox COM23;
        private Label label200;
        private ComboBox COM22;
        private Label label201;
        private ComboBox COM21;
        private Label label202;
        private ComboBox feedback25;
        private Label label203;
        private ComboBox feedback24;
        private Label label204;
        private ComboBox feedback23;
        private Label label205;
        private ComboBox feedback22;
        private Label label206;
        private ComboBox feedback21;
        private Label label207;
        private ComboBox step25Job;
        private Label label208;
        private ComboBox step24Job;
        private Label label209;
        private ComboBox step23Job;
        private Label label210;
        private ComboBox step22Job;
        private Label label211;
        private ComboBox step21Job;
        private Label label212;
        private Label label213;
        private TextBox isim31;
        private Label label214;
        private TextBox gorev31;
        private Label label215;
        private TextBox kontrol31;
        private ComboBox veri31;
        private Label label216;
        private ComboBox COM31;
        private Label label217;
        private ComboBox feedback31;
        private Label label218;
        private ComboBox step31Job;
        private Label label219;
        private PictureBox infoPicture1;
        private ToolTip toolTip1;
        private PictureBox infoPicture2;
        private ToolTip toolTip2;
        private PictureBox infoPicture3;
        private PictureBox infoPicture4;
        private PictureBox infoPicture5;
        private PictureBox infoPicture6;
        private PictureBox infoPicture7;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ToolTip toolTip6;
        private ToolTip toolTip7;
        private Label label223;
        private TextBox isim37;
        private Label label224;
        private TextBox isim36;
        private Label label228;
        private TextBox gorev37;
        private Label label229;
        private TextBox gorev36;
        private Label label233;
        private TextBox kontrol37;
        private Label label234;
        private TextBox kontrol36;
        private ComboBox veri37;
        private Label label238;
        private ComboBox veri36;
        private Label label239;
        private ComboBox COM37;
        private Label label243;
        private ComboBox COM36;
        private Label label244;
        private ComboBox feedback37;
        private Label label248;
        private ComboBox feedback36;
        private Label label249;
        private ComboBox step37Job;
        private Label label253;
        private ComboBox step36Job;
        private Label label254;
        private Label label255;
        private TextBox isim35;
        private Label label256;
        private TextBox isim34;
        private Label label257;
        private TextBox isim33;
        private Label label258;
        private TextBox isim32;
        private Label label259;
        private TextBox gorev35;
        private Label label260;
        private TextBox gorev34;
        private Label label261;
        private TextBox gorev33;
        private Label label262;
        private TextBox gorev32;
        private Label label263;
        private TextBox kontrol35;
        private Label label264;
        private TextBox kontrol34;
        private Label label265;
        private TextBox kontrol33;
        private Label label266;
        private TextBox kontrol32;
        private ComboBox veri35;
        private Label label267;
        private ComboBox veri34;
        private Label label268;
        private ComboBox veri33;
        private Label label269;
        private ComboBox veri32;
        private Label label270;
        private ComboBox COM35;
        private Label label271;
        private ComboBox COM34;
        private Label label272;
        private ComboBox COM33;
        private Label label273;
        private ComboBox COM32;
        private Label label274;
        private ComboBox feedback35;
        private Label label275;
        private ComboBox feedback34;
        private Label label276;
        private ComboBox feedback33;
        private Label label277;
        private ComboBox feedback32;
        private Label label278;
        private ComboBox step35Job;
        private Label label279;
        private ComboBox step34Job;
        private Label label280;
        private ComboBox step33Job;
        private Label label281;
        private ComboBox step32Job;
        private Label label282;
        private VScrollBar vScrollBar1;
        private Button btnKaydetIni;
        private Button btnOkuIni;
        private Button btnINIsec;
        private TextBox txtINIdosya;
        private Label label220;
        private CheckBox chBoxProgramlama;
        private GroupBox groupBox1;
        private Label label221;
        private TextBox isim38;
        private Label label222;
        private TextBox gorev38;
        private Label label225;
        private TextBox kontrol38;
        private ComboBox veri38;
        private Label label226;
        private ComboBox COM38;
        private Label label227;
        private ComboBox feedback38;
        private Label label230;
        private ComboBox step38Job;
        private Label label231;
        private Label label232;
        private TextBox isim39;
        private Label label235;
        private TextBox gorev39;
        private Label label236;
        private TextBox kontrol39;
        private ComboBox veri39;
        private ComboBox COM39;
        private Label label237;
        private ComboBox feedback39;
        private Label label240;
        private ComboBox step39Job;
        private Label label241;
        private Label label242;
        private TextBox isim40;
        private Label label245;
        private TextBox gorev40;
        private Label label246;
        private TextBox kontrol40;
        private ComboBox veri40;
        private ComboBox COM40;
        private Label label247;
        private ComboBox feedback40;
        private Label label250;
        private ComboBox step40Job;
        private Label label251;
        private Label label252;
        private Label label283;
        private ComboBox feedback2;

        public KurulumForm()
        {
            this.InitializeComponent();
        }

        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public INIKaydet(string dosyaYolu)
            {
                DOSYAYOLU = dosyaYolu;
            }
            private string DOSYAYOLU = String.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? string.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
            }
        }

        private void AyarForm_Load(object sender, EventArgs e)
        {
            toolTip_Load();
            this.chBoxProgramlama.Checked = Kurulum.Default.chBoxProgramlama;

            this.txtINIdosya.Text = Kurulum.Default.iniDosyaYolu;

            this.stepNum.Text = Kurulum.Default.stepNum;

            this.step1Job.Text = Kurulum.Default.step1Job;
            this.step2Job.Text = Kurulum.Default.step2Job;
            this.step3Job.Text = Kurulum.Default.step3Job;
            this.step4Job.Text = Kurulum.Default.step4Job;
            this.step5Job.Text = Kurulum.Default.step5Job;
            this.step6Job.Text = Kurulum.Default.step6Job;
            this.step7Job.Text = Kurulum.Default.step7Job;
            this.step8Job.Text = Kurulum.Default.step8Job;
            this.step9Job.Text = Kurulum.Default.step9Job;
            this.step10Job.Text = Kurulum.Default.step10Job;
            this.step11Job.Text = Kurulum.Default.step11Job;
            this.step12Job.Text = Kurulum.Default.step12Job;
            this.step13Job.Text = Kurulum.Default.step13Job;
            this.step14Job.Text = Kurulum.Default.step14Job;
            this.step15Job.Text = Kurulum.Default.step15Job;
            this.step16Job.Text = Kurulum.Default.step16Job;
            this.step17Job.Text = Kurulum.Default.step17Job;
            this.step18Job.Text = Kurulum.Default.step18Job;
            this.step19Job.Text = Kurulum.Default.step19Job;
            this.step20Job.Text = Kurulum.Default.step20Job;
            this.step21Job.Text = Kurulum.Default.step21Job;
            this.step22Job.Text = Kurulum.Default.step22Job;
            this.step23Job.Text = Kurulum.Default.step23Job;
            this.step24Job.Text = Kurulum.Default.step24Job;
            this.step25Job.Text = Kurulum.Default.step25Job;
            this.step26Job.Text = Kurulum.Default.step26Job;
            this.step27Job.Text = Kurulum.Default.step27Job;
            this.step28Job.Text = Kurulum.Default.step28Job;
            this.step29Job.Text = Kurulum.Default.step29Job;
            this.step30Job.Text = Kurulum.Default.step30Job;
            this.step31Job.Text = Kurulum.Default.step31Job;
            this.step32Job.Text = Kurulum.Default.step32Job;
            this.step33Job.Text = Kurulum.Default.step33Job;
            this.step34Job.Text = Kurulum.Default.step34Job;
            this.step35Job.Text = Kurulum.Default.step35Job;
            this.step36Job.Text = Kurulum.Default.step36Job;
            this.step37Job.Text = Kurulum.Default.step37Job;
            this.step38Job.Text = Kurulum.Default.step38Job;
            this.step39Job.Text = Kurulum.Default.step39Job;
            this.step40Job.Text = Kurulum.Default.step40Job;

            this.isim1.Text = Kurulum.Default.isim1;
            this.isim2.Text = Kurulum.Default.isim2;
            this.isim3.Text = Kurulum.Default.isim3;
            this.isim4.Text = Kurulum.Default.isim4;
            this.isim5.Text = Kurulum.Default.isim5;
            this.isim6.Text = Kurulum.Default.isim6;
            this.isim7.Text = Kurulum.Default.isim7;
            this.isim8.Text = Kurulum.Default.isim8;
            this.isim9.Text = Kurulum.Default.isim9;
            this.isim10.Text = Kurulum.Default.isim10;
            this.isim11.Text = Kurulum.Default.isim11;
            this.isim12.Text = Kurulum.Default.isim12;
            this.isim13.Text = Kurulum.Default.isim13;
            this.isim14.Text = Kurulum.Default.isim14;
            this.isim15.Text = Kurulum.Default.isim15;
            this.isim16.Text = Kurulum.Default.isim16;
            this.isim17.Text = Kurulum.Default.isim17;
            this.isim18.Text = Kurulum.Default.isim18;
            this.isim19.Text = Kurulum.Default.isim19;
            this.isim20.Text = Kurulum.Default.isim20;
            this.isim21.Text = Kurulum.Default.isim21;
            this.isim22.Text = Kurulum.Default.isim22;
            this.isim23.Text = Kurulum.Default.isim23;
            this.isim24.Text = Kurulum.Default.isim24;
            this.isim25.Text = Kurulum.Default.isim25;
            this.isim26.Text = Kurulum.Default.isim26;
            this.isim27.Text = Kurulum.Default.isim27;
            this.isim28.Text = Kurulum.Default.isim28;
            this.isim29.Text = Kurulum.Default.isim29;
            this.isim30.Text = Kurulum.Default.isim30;
            this.isim31.Text = Kurulum.Default.isim31;
            this.isim32.Text = Kurulum.Default.isim32;
            this.isim33.Text = Kurulum.Default.isim33;
            this.isim34.Text = Kurulum.Default.isim34;
            this.isim35.Text = Kurulum.Default.isim35;
            this.isim36.Text = Kurulum.Default.isim36;
            this.isim37.Text = Kurulum.Default.isim37;
            this.isim38.Text = Kurulum.Default.isim38;
            this.isim39.Text = Kurulum.Default.isim39;
            this.isim40.Text = Kurulum.Default.isim40;

            this.feedback1.Text = Kurulum.Default.feedback1;
            this.feedback2.Text = Kurulum.Default.feedback2;
            this.feedback3.Text = Kurulum.Default.feedback3;
            this.feedback4.Text = Kurulum.Default.feedback4;
            this.feedback5.Text = Kurulum.Default.feedback5;
            this.feedback6.Text = Kurulum.Default.feedback6;
            this.feedback7.Text = Kurulum.Default.feedback7;
            this.feedback8.Text = Kurulum.Default.feedback8;
            this.feedback9.Text = Kurulum.Default.feedback9;
            this.feedback10.Text = Kurulum.Default.feedback10;
            this.feedback11.Text = Kurulum.Default.feedback11;
            this.feedback12.Text = Kurulum.Default.feedback12;
            this.feedback13.Text = Kurulum.Default.feedback13;
            this.feedback14.Text = Kurulum.Default.feedback14;
            this.feedback15.Text = Kurulum.Default.feedback15;
            this.feedback16.Text = Kurulum.Default.feedback16;
            this.feedback17.Text = Kurulum.Default.feedback17;
            this.feedback18.Text = Kurulum.Default.feedback18;
            this.feedback19.Text = Kurulum.Default.feedback19;
            this.feedback20.Text = Kurulum.Default.feedback20;
            this.feedback21.Text = Kurulum.Default.feedback21;
            this.feedback22.Text = Kurulum.Default.feedback22;
            this.feedback23.Text = Kurulum.Default.feedback23;
            this.feedback24.Text = Kurulum.Default.feedback24;
            this.feedback25.Text = Kurulum.Default.feedback25;
            this.feedback26.Text = Kurulum.Default.feedback26;
            this.feedback27.Text = Kurulum.Default.feedback27;
            this.feedback28.Text = Kurulum.Default.feedback28;
            this.feedback29.Text = Kurulum.Default.feedback29;
            this.feedback30.Text = Kurulum.Default.feedback30;
            this.feedback31.Text = Kurulum.Default.feedback31;
            this.feedback32.Text = Kurulum.Default.feedback32;
            this.feedback33.Text = Kurulum.Default.feedback33;
            this.feedback34.Text = Kurulum.Default.feedback34;
            this.feedback35.Text = Kurulum.Default.feedback35;
            this.feedback36.Text = Kurulum.Default.feedback36;
            this.feedback37.Text = Kurulum.Default.feedback37;
            this.feedback38.Text = Kurulum.Default.feedback38;
            this.feedback39.Text = Kurulum.Default.feedback39;
            this.feedback40.Text = Kurulum.Default.feedback40;

            this.COM1.Text = Kurulum.Default.COM1;
            this.COM2.Text = Kurulum.Default.COM2;
            this.COM3.Text = Kurulum.Default.COM3;
            this.COM4.Text = Kurulum.Default.COM4;
            this.COM5.Text = Kurulum.Default.COM5;
            this.COM6.Text = Kurulum.Default.COM6;
            this.COM7.Text = Kurulum.Default.COM7;
            this.COM8.Text = Kurulum.Default.COM8;
            this.COM9.Text = Kurulum.Default.COM9;
            this.COM10.Text = Kurulum.Default.COM10;
            this.COM11.Text = Kurulum.Default.COM11;
            this.COM12.Text = Kurulum.Default.COM12;
            this.COM13.Text = Kurulum.Default.COM13;
            this.COM14.Text = Kurulum.Default.COM14;
            this.COM15.Text = Kurulum.Default.COM15;
            this.COM16.Text = Kurulum.Default.COM16;
            this.COM17.Text = Kurulum.Default.COM17;
            this.COM18.Text = Kurulum.Default.COM18;
            this.COM19.Text = Kurulum.Default.COM19;
            this.COM20.Text = Kurulum.Default.COM20;
            this.COM21.Text = Kurulum.Default.COM21;
            this.COM22.Text = Kurulum.Default.COM22;
            this.COM23.Text = Kurulum.Default.COM23;
            this.COM24.Text = Kurulum.Default.COM24;
            this.COM25.Text = Kurulum.Default.COM25;
            this.COM26.Text = Kurulum.Default.COM26;
            this.COM27.Text = Kurulum.Default.COM27;
            this.COM28.Text = Kurulum.Default.COM28;
            this.COM29.Text = Kurulum.Default.COM29;
            this.COM30.Text = Kurulum.Default.COM30;
            this.COM31.Text = Kurulum.Default.COM31;
            this.COM32.Text = Kurulum.Default.COM32;
            this.COM33.Text = Kurulum.Default.COM33;
            this.COM34.Text = Kurulum.Default.COM34;
            this.COM35.Text = Kurulum.Default.COM35;
            this.COM36.Text = Kurulum.Default.COM36;
            this.COM37.Text = Kurulum.Default.COM37;
            this.COM38.Text = Kurulum.Default.COM38;
            this.COM39.Text = Kurulum.Default.COM39;
            this.COM40.Text = Kurulum.Default.COM40;

            this.veri1.Text = Kurulum.Default.veri1;
            this.veri2.Text = Kurulum.Default.veri2;
            this.veri3.Text = Kurulum.Default.veri3;
            this.veri4.Text = Kurulum.Default.veri4;
            this.veri5.Text = Kurulum.Default.veri5;
            this.veri6.Text = Kurulum.Default.veri6;
            this.veri7.Text = Kurulum.Default.veri7;
            this.veri8.Text = Kurulum.Default.veri8;
            this.veri9.Text = Kurulum.Default.veri9;
            this.veri10.Text = Kurulum.Default.veri10;
            this.veri11.Text = Kurulum.Default.veri11;
            this.veri12.Text = Kurulum.Default.veri12;
            this.veri13.Text = Kurulum.Default.veri13;
            this.veri14.Text = Kurulum.Default.veri14;
            this.veri15.Text = Kurulum.Default.veri15;
            this.veri16.Text = Kurulum.Default.veri16;
            this.veri17.Text = Kurulum.Default.veri17;
            this.veri18.Text = Kurulum.Default.veri18;
            this.veri19.Text = Kurulum.Default.veri19;
            this.veri20.Text = Kurulum.Default.veri20;
            this.veri21.Text = Kurulum.Default.veri21;
            this.veri22.Text = Kurulum.Default.veri22;
            this.veri23.Text = Kurulum.Default.veri23;
            this.veri24.Text = Kurulum.Default.veri24;
            this.veri25.Text = Kurulum.Default.veri25;
            this.veri26.Text = Kurulum.Default.veri26;
            this.veri27.Text = Kurulum.Default.veri27;
            this.veri28.Text = Kurulum.Default.veri28;
            this.veri29.Text = Kurulum.Default.veri29;
            this.veri30.Text = Kurulum.Default.veri30;
            this.veri31.Text = Kurulum.Default.veri31;
            this.veri32.Text = Kurulum.Default.veri32;
            this.veri33.Text = Kurulum.Default.veri33;
            this.veri34.Text = Kurulum.Default.veri34;
            this.veri35.Text = Kurulum.Default.veri35;
            this.veri36.Text = Kurulum.Default.veri36;
            this.veri37.Text = Kurulum.Default.veri37;
            this.veri38.Text = Kurulum.Default.veri38;
            this.veri39.Text = Kurulum.Default.veri39;
            this.veri40.Text = Kurulum.Default.veri40;

            this.kontrol1.Text = Kurulum.Default.kontrol1;
            this.kontrol2.Text = Kurulum.Default.kontrol2;
            this.kontrol3.Text = Kurulum.Default.kontrol3;
            this.kontrol4.Text = Kurulum.Default.kontrol4;
            this.kontrol5.Text = Kurulum.Default.kontrol5;
            this.kontrol6.Text = Kurulum.Default.kontrol6;
            this.kontrol7.Text = Kurulum.Default.kontrol7;
            this.kontrol8.Text = Kurulum.Default.kontrol8;
            this.kontrol9.Text = Kurulum.Default.kontrol9;
            this.kontrol10.Text = Kurulum.Default.kontrol10;
            this.kontrol11.Text = Kurulum.Default.kontrol11;
            this.kontrol12.Text = Kurulum.Default.kontrol12;
            this.kontrol13.Text = Kurulum.Default.kontrol13;
            this.kontrol14.Text = Kurulum.Default.kontrol14;
            this.kontrol15.Text = Kurulum.Default.kontrol15;
            this.kontrol16.Text = Kurulum.Default.kontrol16;
            this.kontrol17.Text = Kurulum.Default.kontrol17;
            this.kontrol18.Text = Kurulum.Default.kontrol18;
            this.kontrol19.Text = Kurulum.Default.kontrol19;
            this.kontrol20.Text = Kurulum.Default.kontrol20;
            this.kontrol21.Text = Kurulum.Default.kontrol21;
            this.kontrol22.Text = Kurulum.Default.kontrol22;
            this.kontrol23.Text = Kurulum.Default.kontrol23;
            this.kontrol24.Text = Kurulum.Default.kontrol24;
            this.kontrol25.Text = Kurulum.Default.kontrol25;
            this.kontrol26.Text = Kurulum.Default.kontrol26;
            this.kontrol27.Text = Kurulum.Default.kontrol27;
            this.kontrol28.Text = Kurulum.Default.kontrol28;
            this.kontrol29.Text = Kurulum.Default.kontrol29;
            this.kontrol30.Text = Kurulum.Default.kontrol30;
            this.kontrol31.Text = Kurulum.Default.kontrol31;
            this.kontrol32.Text = Kurulum.Default.kontrol32;
            this.kontrol33.Text = Kurulum.Default.kontrol33;
            this.kontrol34.Text = Kurulum.Default.kontrol34;
            this.kontrol35.Text = Kurulum.Default.kontrol35;
            this.kontrol36.Text = Kurulum.Default.kontrol36;
            this.kontrol37.Text = Kurulum.Default.kontrol37;
            this.kontrol38.Text = Kurulum.Default.kontrol38;
            this.kontrol39.Text = Kurulum.Default.kontrol39;
            this.kontrol40.Text = Kurulum.Default.kontrol40;

            this.gorev1.Text = Kurulum.Default.gorev1;
            this.gorev2.Text = Kurulum.Default.gorev2;
            this.gorev3.Text = Kurulum.Default.gorev3;
            this.gorev4.Text = Kurulum.Default.gorev4;
            this.gorev5.Text = Kurulum.Default.gorev5;
            this.gorev6.Text = Kurulum.Default.gorev6;
            this.gorev7.Text = Kurulum.Default.gorev7;
            this.gorev8.Text = Kurulum.Default.gorev8;
            this.gorev9.Text = Kurulum.Default.gorev9;
            this.gorev10.Text = Kurulum.Default.gorev10;
            this.gorev11.Text = Kurulum.Default.gorev11;
            this.gorev12.Text = Kurulum.Default.gorev12;
            this.gorev13.Text = Kurulum.Default.gorev13;
            this.gorev14.Text = Kurulum.Default.gorev14;
            this.gorev15.Text = Kurulum.Default.gorev15;
            this.gorev16.Text = Kurulum.Default.gorev16;
            this.gorev17.Text = Kurulum.Default.gorev17;
            this.gorev18.Text = Kurulum.Default.gorev18;
            this.gorev19.Text = Kurulum.Default.gorev19;
            this.gorev20.Text = Kurulum.Default.gorev20;
            this.gorev21.Text = Kurulum.Default.gorev21;
            this.gorev22.Text = Kurulum.Default.gorev22;
            this.gorev23.Text = Kurulum.Default.gorev23;
            this.gorev24.Text = Kurulum.Default.gorev24;
            this.gorev25.Text = Kurulum.Default.gorev25;
            this.gorev26.Text = Kurulum.Default.gorev26;
            this.gorev27.Text = Kurulum.Default.gorev27;
            this.gorev28.Text = Kurulum.Default.gorev28;
            this.gorev29.Text = Kurulum.Default.gorev29;
            this.gorev30.Text = Kurulum.Default.gorev30;
            this.gorev31.Text = Kurulum.Default.gorev31;
            this.gorev32.Text = Kurulum.Default.gorev32;
            this.gorev33.Text = Kurulum.Default.gorev33;
            this.gorev34.Text = Kurulum.Default.gorev34;
            this.gorev35.Text = Kurulum.Default.gorev35;
            this.gorev36.Text = Kurulum.Default.gorev36;
            this.gorev37.Text = Kurulum.Default.gorev37;
            this.gorev38.Text = Kurulum.Default.gorev38;
            this.gorev39.Text = Kurulum.Default.gorev39;
            this.gorev40.Text = Kurulum.Default.gorev40;

            this.Invoke(new EventHandler(stepNum_SelectedIndexChanged));
        }

        private void toolTip_Load()
        {
            string[] toolTipTitle = new string[10];
            string[] toolTipTool = new string[10];

            toolTipTitle[1] = "Lütfen Adım Türünü Belirleyiniz";
            toolTipTitle[2] = "Lütfen Adım İsmini Giriniz";
            toolTipTitle[3] = "Lütfen Gönderilecek Veriyi Giriniz";
            toolTipTitle[4] = "Lütfen Gönderilecek Verinin Serial Port'unu Belirleyiniz";
            toolTipTitle[5] = "Lütfen Gelecek Feedback Verisini Giriniz";
            toolTipTitle[6] = "Lütfen Operatörün Kontrol Edeceği İşlemi Giriniz";
            toolTipTitle[7] = "Lütfen Operatörün Yapması Gereken Görevi Giriniz";

            toolTipTool[1] = "1-) Veri Gönder-Feedback Al \n2-) Veri Gönder-Onayla \n3-) Veri Gönder-Feedback Al-Onayla \n4-) Veri Gönder-Feedback Al-Onayla-Görev Yap \n5-) Sadece Feedback Al \n6-) Sadece Veri Gönder";
            toolTipTool[2] = "Örnek : 1 NUMARALI LED TESTİ";
            toolTipTool[3] = "Örnek : data[5] = {0,1,2,3,4}; \n5,0,1,2,3,4";
            toolTipTool[4] = "Örnek : COM1 = Ayarlar İlk Serial Port";
            toolTipTool[5] = "Örnek : data[2] = {180,75}; \n2,180,75";
            toolTipTool[6] = "Örnek : Eğer Tüm Ledler Yandıysa Lütfen 'Evet'e Tıklayınız";
            toolTipTool[7] = "Örnek : Lütfen 1 Nolu Buton'a Basınız.";

            toolTip1.Active = true;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 5000;
            toolTip1.IsBalloon = true;
            toolTip1.UseAnimation = true;
            toolTip1.UseFading = true;
            toolTip1.ShowAlways = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = toolTipTitle[1];
            toolTip1.SetToolTip(infoPicture1, toolTipTool[1]);

            toolTip2.Active = true;
            toolTip2.AutoPopDelay = 5000;
            toolTip2.InitialDelay = 1000;
            toolTip2.ReshowDelay = 5000;
            toolTip2.IsBalloon = true;
            toolTip2.UseAnimation = true;
            toolTip2.UseFading = true;
            toolTip2.ShowAlways = true;
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = toolTipTitle[2];
            toolTip2.SetToolTip(infoPicture2, toolTipTool[2]);

            toolTip3.Active = true;
            toolTip3.AutoPopDelay = 5000;
            toolTip3.InitialDelay = 1000;
            toolTip3.ReshowDelay = 5000;
            toolTip3.IsBalloon = true;
            toolTip3.UseAnimation = true;
            toolTip3.UseFading = true;
            toolTip3.ShowAlways = true;
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = toolTipTitle[3];
            toolTip3.SetToolTip(infoPicture3, toolTipTool[3]);

            toolTip4.Active = true;
            toolTip4.AutoPopDelay = 5000;
            toolTip4.InitialDelay = 1000;
            toolTip4.ReshowDelay = 5000;
            toolTip4.IsBalloon = true;
            toolTip4.UseAnimation = true;
            toolTip4.UseFading = true;
            toolTip4.ShowAlways = true;
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            toolTip4.ToolTipTitle = toolTipTitle[4];
            toolTip4.SetToolTip(infoPicture4, toolTipTool[4]);

            toolTip5.Active = true;
            toolTip5.AutoPopDelay = 5000;
            toolTip5.InitialDelay = 1000;
            toolTip5.ReshowDelay = 5000;
            toolTip5.IsBalloon = true;
            toolTip5.UseAnimation = true;
            toolTip5.UseFading = true;
            toolTip5.ShowAlways = true;
            toolTip5.ToolTipIcon = ToolTipIcon.Info;
            toolTip5.ToolTipTitle = toolTipTitle[5];
            toolTip5.SetToolTip(infoPicture5, toolTipTool[5]);

            toolTip6.Active = true;
            toolTip6.AutoPopDelay = 5000;
            toolTip6.InitialDelay = 1000;
            toolTip6.ReshowDelay = 5000;
            toolTip6.IsBalloon = true;
            toolTip6.UseAnimation = true;
            toolTip6.UseFading = true;
            toolTip6.ShowAlways = true;
            toolTip6.ToolTipIcon = ToolTipIcon.Info;
            toolTip6.ToolTipTitle = toolTipTitle[6];
            toolTip6.SetToolTip(infoPicture6, toolTipTool[6]);

            toolTip7.Active = true;
            toolTip7.AutoPopDelay = 5000;
            toolTip7.InitialDelay = 1000;
            toolTip7.ReshowDelay = 5000;
            toolTip7.IsBalloon = true;
            toolTip7.UseAnimation = true;
            toolTip7.UseFading = true;
            toolTip7.ShowAlways = true;
            toolTip7.ToolTipIcon = ToolTipIcon.Info;
            toolTip7.ToolTipTitle = toolTipTitle[7];
            toolTip7.SetToolTip(infoPicture7, toolTipTool[7]);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kurulum.Default.chBoxProgramlama = this.chBoxProgramlama.Checked;

                Kurulum.Default.iniDosyaYolu = this.txtINIdosya.Text;

                Kurulum.Default.stepNum = this.stepNum.Text;

                Kurulum.Default.step1Job = this.step1Job.Text;
                Kurulum.Default.step2Job = this.step2Job.Text;
                Kurulum.Default.step3Job = this.step3Job.Text;
                Kurulum.Default.step4Job = this.step4Job.Text;
                Kurulum.Default.step5Job = this.step5Job.Text;
                Kurulum.Default.step6Job = this.step6Job.Text;
                Kurulum.Default.step7Job = this.step7Job.Text;
                Kurulum.Default.step8Job = this.step8Job.Text;
                Kurulum.Default.step9Job = this.step9Job.Text;
                Kurulum.Default.step10Job = this.step10Job.Text;
                Kurulum.Default.step11Job = this.step11Job.Text;
                Kurulum.Default.step12Job = this.step12Job.Text;
                Kurulum.Default.step13Job = this.step13Job.Text;
                Kurulum.Default.step14Job = this.step14Job.Text;
                Kurulum.Default.step15Job = this.step15Job.Text;
                Kurulum.Default.step16Job = this.step16Job.Text;
                Kurulum.Default.step17Job = this.step17Job.Text;
                Kurulum.Default.step18Job = this.step18Job.Text;
                Kurulum.Default.step19Job = this.step19Job.Text;
                Kurulum.Default.step20Job = this.step20Job.Text;
                Kurulum.Default.step21Job = this.step21Job.Text;
                Kurulum.Default.step22Job = this.step22Job.Text;
                Kurulum.Default.step23Job = this.step23Job.Text;
                Kurulum.Default.step24Job = this.step24Job.Text;
                Kurulum.Default.step25Job = this.step25Job.Text;
                Kurulum.Default.step26Job = this.step26Job.Text;
                Kurulum.Default.step27Job = this.step27Job.Text;
                Kurulum.Default.step28Job = this.step28Job.Text;
                Kurulum.Default.step29Job = this.step29Job.Text;
                Kurulum.Default.step30Job = this.step30Job.Text;
                Kurulum.Default.step31Job = this.step31Job.Text;
                Kurulum.Default.step32Job = this.step32Job.Text;
                Kurulum.Default.step33Job = this.step33Job.Text;
                Kurulum.Default.step34Job = this.step34Job.Text;
                Kurulum.Default.step35Job = this.step35Job.Text;
                Kurulum.Default.step36Job = this.step36Job.Text;
                Kurulum.Default.step37Job = this.step37Job.Text;
                Kurulum.Default.step38Job = this.step38Job.Text;
                Kurulum.Default.step39Job = this.step39Job.Text;
                Kurulum.Default.step40Job = this.step40Job.Text;

                Kurulum.Default.isim1 = this.isim1.Text;
                Kurulum.Default.isim2 = this.isim2.Text;
                Kurulum.Default.isim3 = this.isim3.Text;
                Kurulum.Default.isim4 = this.isim4.Text;
                Kurulum.Default.isim5 = this.isim5.Text;
                Kurulum.Default.isim6 = this.isim6.Text;
                Kurulum.Default.isim7 = this.isim7.Text;
                Kurulum.Default.isim8 = this.isim8.Text;
                Kurulum.Default.isim9 = this.isim9.Text;
                Kurulum.Default.isim10 = this.isim10.Text;
                Kurulum.Default.isim11 = this.isim11.Text;
                Kurulum.Default.isim12 = this.isim12.Text;
                Kurulum.Default.isim13 = this.isim13.Text;
                Kurulum.Default.isim14 = this.isim14.Text;
                Kurulum.Default.isim15 = this.isim15.Text;
                Kurulum.Default.isim16 = this.isim16.Text;
                Kurulum.Default.isim17 = this.isim17.Text;
                Kurulum.Default.isim18 = this.isim18.Text;
                Kurulum.Default.isim19 = this.isim19.Text;
                Kurulum.Default.isim20 = this.isim20.Text;
                Kurulum.Default.isim21 = this.isim21.Text;
                Kurulum.Default.isim22 = this.isim22.Text;
                Kurulum.Default.isim23 = this.isim23.Text;
                Kurulum.Default.isim24 = this.isim24.Text;
                Kurulum.Default.isim25 = this.isim25.Text;
                Kurulum.Default.isim26 = this.isim26.Text;
                Kurulum.Default.isim27 = this.isim27.Text;
                Kurulum.Default.isim28 = this.isim28.Text;
                Kurulum.Default.isim29 = this.isim29.Text;
                Kurulum.Default.isim30 = this.isim30.Text;
                Kurulum.Default.isim31 = this.isim31.Text;
                Kurulum.Default.isim32 = this.isim32.Text;
                Kurulum.Default.isim33 = this.isim33.Text;
                Kurulum.Default.isim34 = this.isim34.Text;
                Kurulum.Default.isim35 = this.isim35.Text;
                Kurulum.Default.isim36 = this.isim36.Text;
                Kurulum.Default.isim37 = this.isim37.Text;
                Kurulum.Default.isim38 = this.isim38.Text;
                Kurulum.Default.isim39 = this.isim39.Text;
                Kurulum.Default.isim40 = this.isim40.Text;

                Kurulum.Default.feedback1 = this.feedback1.Text;
                Kurulum.Default.feedback2 = this.feedback2.Text;
                Kurulum.Default.feedback3 = this.feedback3.Text;
                Kurulum.Default.feedback4 = this.feedback4.Text;
                Kurulum.Default.feedback5 = this.feedback5.Text;
                Kurulum.Default.feedback6 = this.feedback6.Text;
                Kurulum.Default.feedback7 = this.feedback7.Text;
                Kurulum.Default.feedback8 = this.feedback8.Text;
                Kurulum.Default.feedback9 = this.feedback9.Text;
                Kurulum.Default.feedback10 = this.feedback10.Text;
                Kurulum.Default.feedback11 = this.feedback11.Text;
                Kurulum.Default.feedback12 = this.feedback12.Text;
                Kurulum.Default.feedback13 = this.feedback13.Text;
                Kurulum.Default.feedback14 = this.feedback14.Text;
                Kurulum.Default.feedback15 = this.feedback15.Text;
                Kurulum.Default.feedback16 = this.feedback16.Text;
                Kurulum.Default.feedback17 = this.feedback17.Text;
                Kurulum.Default.feedback18 = this.feedback18.Text;
                Kurulum.Default.feedback19 = this.feedback19.Text;
                Kurulum.Default.feedback20 = this.feedback20.Text;
                Kurulum.Default.feedback21 = this.feedback21.Text;
                Kurulum.Default.feedback22 = this.feedback22.Text;
                Kurulum.Default.feedback23 = this.feedback23.Text;
                Kurulum.Default.feedback24 = this.feedback24.Text;
                Kurulum.Default.feedback25 = this.feedback25.Text;
                Kurulum.Default.feedback26 = this.feedback26.Text;
                Kurulum.Default.feedback27 = this.feedback27.Text;
                Kurulum.Default.feedback28 = this.feedback28.Text;
                Kurulum.Default.feedback29 = this.feedback29.Text;
                Kurulum.Default.feedback30 = this.feedback30.Text;
                Kurulum.Default.feedback31 = this.feedback31.Text;
                Kurulum.Default.feedback32 = this.feedback32.Text;
                Kurulum.Default.feedback33 = this.feedback33.Text;
                Kurulum.Default.feedback34 = this.feedback34.Text;
                Kurulum.Default.feedback35 = this.feedback35.Text;
                Kurulum.Default.feedback36 = this.feedback36.Text;
                Kurulum.Default.feedback37 = this.feedback37.Text;
                Kurulum.Default.feedback38 = this.feedback38.Text;
                Kurulum.Default.feedback39 = this.feedback39.Text;
                Kurulum.Default.feedback40 = this.feedback40.Text;

                Kurulum.Default.COM1 = this.COM1.Text;
                Kurulum.Default.COM2 = this.COM2.Text;
                Kurulum.Default.COM3 = this.COM3.Text;
                Kurulum.Default.COM4 = this.COM4.Text;
                Kurulum.Default.COM5 = this.COM5.Text;
                Kurulum.Default.COM6 = this.COM6.Text;
                Kurulum.Default.COM7 = this.COM7.Text;
                Kurulum.Default.COM8 = this.COM8.Text;
                Kurulum.Default.COM9 = this.COM9.Text;
                Kurulum.Default.COM10 = this.COM10.Text;
                Kurulum.Default.COM11 = this.COM11.Text;
                Kurulum.Default.COM12 = this.COM12.Text;
                Kurulum.Default.COM13 = this.COM13.Text;
                Kurulum.Default.COM14 = this.COM14.Text;
                Kurulum.Default.COM15 = this.COM15.Text;
                Kurulum.Default.COM16 = this.COM16.Text;
                Kurulum.Default.COM17 = this.COM17.Text;
                Kurulum.Default.COM18 = this.COM18.Text;
                Kurulum.Default.COM19 = this.COM19.Text;
                Kurulum.Default.COM20 = this.COM20.Text;
                Kurulum.Default.COM21 = this.COM21.Text;
                Kurulum.Default.COM22 = this.COM22.Text;
                Kurulum.Default.COM23 = this.COM23.Text;
                Kurulum.Default.COM24 = this.COM24.Text;
                Kurulum.Default.COM25 = this.COM25.Text;
                Kurulum.Default.COM26 = this.COM26.Text;
                Kurulum.Default.COM27 = this.COM27.Text;
                Kurulum.Default.COM28 = this.COM28.Text;
                Kurulum.Default.COM29 = this.COM29.Text;
                Kurulum.Default.COM30 = this.COM30.Text;
                Kurulum.Default.COM31 = this.COM31.Text;
                Kurulum.Default.COM32 = this.COM32.Text;
                Kurulum.Default.COM33 = this.COM33.Text;
                Kurulum.Default.COM34 = this.COM34.Text;
                Kurulum.Default.COM35 = this.COM35.Text;
                Kurulum.Default.COM36 = this.COM36.Text;
                Kurulum.Default.COM37 = this.COM37.Text;
                Kurulum.Default.COM38 = this.COM38.Text;
                Kurulum.Default.COM39 = this.COM39.Text;
                Kurulum.Default.COM40 = this.COM40.Text;

                Kurulum.Default.veri1 = this.veri1.Text;
                Kurulum.Default.veri2 = this.veri2.Text;
                Kurulum.Default.veri3 = this.veri3.Text;
                Kurulum.Default.veri4 = this.veri4.Text;
                Kurulum.Default.veri5 = this.veri5.Text;
                Kurulum.Default.veri6 = this.veri6.Text;
                Kurulum.Default.veri7 = this.veri7.Text;
                Kurulum.Default.veri8 = this.veri8.Text;
                Kurulum.Default.veri9 = this.veri9.Text;
                Kurulum.Default.veri10 = this.veri10.Text;
                Kurulum.Default.veri11 = this.veri11.Text;
                Kurulum.Default.veri12 = this.veri12.Text;
                Kurulum.Default.veri13 = this.veri13.Text;
                Kurulum.Default.veri14 = this.veri14.Text;
                Kurulum.Default.veri15 = this.veri15.Text;
                Kurulum.Default.veri16 = this.veri16.Text;
                Kurulum.Default.veri17 = this.veri17.Text;
                Kurulum.Default.veri18 = this.veri18.Text;
                Kurulum.Default.veri19 = this.veri19.Text;
                Kurulum.Default.veri20 = this.veri20.Text;
                Kurulum.Default.veri21 = this.veri21.Text;
                Kurulum.Default.veri22 = this.veri22.Text;
                Kurulum.Default.veri23 = this.veri23.Text;
                Kurulum.Default.veri24 = this.veri24.Text;
                Kurulum.Default.veri25 = this.veri25.Text;
                Kurulum.Default.veri26 = this.veri26.Text;
                Kurulum.Default.veri27 = this.veri27.Text;
                Kurulum.Default.veri28 = this.veri28.Text;
                Kurulum.Default.veri29 = this.veri29.Text;
                Kurulum.Default.veri30 = this.veri30.Text;
                Kurulum.Default.veri31 = this.veri31.Text;
                Kurulum.Default.veri32 = this.veri32.Text;
                Kurulum.Default.veri33 = this.veri33.Text;
                Kurulum.Default.veri34 = this.veri34.Text;
                Kurulum.Default.veri35 = this.veri35.Text;
                Kurulum.Default.veri36 = this.veri36.Text;
                Kurulum.Default.veri37 = this.veri37.Text;
                Kurulum.Default.veri38 = this.veri38.Text;
                Kurulum.Default.veri39 = this.veri39.Text;
                Kurulum.Default.veri40 = this.veri40.Text;

                Kurulum.Default.kontrol1 = this.kontrol1.Text;
                Kurulum.Default.kontrol2 = this.kontrol2.Text;
                Kurulum.Default.kontrol3 = this.kontrol3.Text;
                Kurulum.Default.kontrol4 = this.kontrol4.Text;
                Kurulum.Default.kontrol5 = this.kontrol5.Text;
                Kurulum.Default.kontrol6 = this.kontrol6.Text;
                Kurulum.Default.kontrol7 = this.kontrol7.Text;
                Kurulum.Default.kontrol8 = this.kontrol8.Text;
                Kurulum.Default.kontrol9 = this.kontrol9.Text;
                Kurulum.Default.kontrol10 = this.kontrol10.Text;
                Kurulum.Default.kontrol11 = this.kontrol11.Text;
                Kurulum.Default.kontrol12 = this.kontrol12.Text;
                Kurulum.Default.kontrol13 = this.kontrol13.Text;
                Kurulum.Default.kontrol14 = this.kontrol14.Text;
                Kurulum.Default.kontrol15 = this.kontrol15.Text;
                Kurulum.Default.kontrol16 = this.kontrol16.Text;
                Kurulum.Default.kontrol17 = this.kontrol17.Text;
                Kurulum.Default.kontrol18 = this.kontrol18.Text;
                Kurulum.Default.kontrol19 = this.kontrol19.Text;
                Kurulum.Default.kontrol20 = this.kontrol20.Text;
                Kurulum.Default.kontrol21 = this.kontrol21.Text;
                Kurulum.Default.kontrol22 = this.kontrol22.Text;
                Kurulum.Default.kontrol23 = this.kontrol23.Text;
                Kurulum.Default.kontrol24 = this.kontrol24.Text;
                Kurulum.Default.kontrol25 = this.kontrol25.Text;
                Kurulum.Default.kontrol26 = this.kontrol26.Text;
                Kurulum.Default.kontrol27 = this.kontrol27.Text;
                Kurulum.Default.kontrol28 = this.kontrol28.Text;
                Kurulum.Default.kontrol29 = this.kontrol29.Text;
                Kurulum.Default.kontrol30 = this.kontrol30.Text;
                Kurulum.Default.kontrol31 = this.kontrol31.Text;
                Kurulum.Default.kontrol32 = this.kontrol32.Text;
                Kurulum.Default.kontrol33 = this.kontrol33.Text;
                Kurulum.Default.kontrol34 = this.kontrol34.Text;
                Kurulum.Default.kontrol35 = this.kontrol35.Text;
                Kurulum.Default.kontrol36 = this.kontrol36.Text;
                Kurulum.Default.kontrol37 = this.kontrol37.Text;
                Kurulum.Default.kontrol38 = this.kontrol38.Text;
                Kurulum.Default.kontrol39 = this.kontrol39.Text;
                Kurulum.Default.kontrol40 = this.kontrol40.Text;

                Kurulum.Default.gorev1 = this.gorev1.Text;
                Kurulum.Default.gorev2 = this.gorev2.Text;
                Kurulum.Default.gorev3 = this.gorev3.Text;
                Kurulum.Default.gorev4 = this.gorev4.Text;
                Kurulum.Default.gorev5 = this.gorev5.Text;
                Kurulum.Default.gorev6 = this.gorev6.Text;
                Kurulum.Default.gorev7 = this.gorev7.Text;
                Kurulum.Default.gorev8 = this.gorev8.Text;
                Kurulum.Default.gorev9 = this.gorev9.Text;
                Kurulum.Default.gorev10 = this.gorev10.Text;
                Kurulum.Default.gorev11 = this.gorev11.Text;
                Kurulum.Default.gorev12 = this.gorev12.Text;
                Kurulum.Default.gorev13 = this.gorev13.Text;
                Kurulum.Default.gorev14 = this.gorev14.Text;
                Kurulum.Default.gorev15 = this.gorev15.Text;
                Kurulum.Default.gorev16 = this.gorev16.Text;
                Kurulum.Default.gorev17 = this.gorev17.Text;
                Kurulum.Default.gorev18 = this.gorev18.Text;
                Kurulum.Default.gorev19 = this.gorev19.Text;
                Kurulum.Default.gorev20 = this.gorev20.Text;
                Kurulum.Default.gorev21 = this.gorev21.Text;
                Kurulum.Default.gorev22 = this.gorev22.Text;
                Kurulum.Default.gorev23 = this.gorev23.Text;
                Kurulum.Default.gorev24 = this.gorev24.Text;
                Kurulum.Default.gorev25 = this.gorev25.Text;
                Kurulum.Default.gorev26 = this.gorev26.Text;
                Kurulum.Default.gorev27 = this.gorev27.Text;
                Kurulum.Default.gorev28 = this.gorev28.Text;
                Kurulum.Default.gorev29 = this.gorev29.Text;
                Kurulum.Default.gorev30 = this.gorev30.Text;
                Kurulum.Default.gorev31 = this.gorev31.Text;
                Kurulum.Default.gorev32 = this.gorev32.Text;
                Kurulum.Default.gorev33 = this.gorev33.Text;
                Kurulum.Default.gorev34 = this.gorev34.Text;
                Kurulum.Default.gorev35 = this.gorev35.Text;
                Kurulum.Default.gorev36 = this.gorev36.Text;
                Kurulum.Default.gorev37 = this.gorev37.Text;
                Kurulum.Default.gorev38 = this.gorev38.Text;
                Kurulum.Default.gorev39 = this.gorev39.Text;
                Kurulum.Default.gorev40 = this.gorev40.Text;
                Kurulum.Default.Save();

                CustomMessageBox.ShowMessage("Bütün Ayarlar Başarıyla Kaydedildi.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
                this.Close();

                Application.Restart();
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessage("Ayarlar Kayıt Hatası: " + ex.ToString(), Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void stepNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            step1Job.Enabled = false;
            step2Job.Enabled = false;
            step3Job.Enabled = false;
            step4Job.Enabled = false;
            step5Job.Enabled = false;
            step6Job.Enabled = false;
            step7Job.Enabled = false;
            step8Job.Enabled = false;
            step9Job.Enabled = false;
            step10Job.Enabled = false;
            step11Job.Enabled = false;
            step12Job.Enabled = false;
            step13Job.Enabled = false;
            step14Job.Enabled = false;
            step15Job.Enabled = false;
            step16Job.Enabled = false;
            step17Job.Enabled = false;
            step18Job.Enabled = false;
            step19Job.Enabled = false;
            step20Job.Enabled = false;
            step21Job.Enabled = false;
            step22Job.Enabled = false;
            step23Job.Enabled = false;
            step24Job.Enabled = false;
            step25Job.Enabled = false;
            step26Job.Enabled = false;
            step27Job.Enabled = false;
            step28Job.Enabled = false;
            step29Job.Enabled = false;
            step30Job.Enabled = false;
            step31Job.Enabled = false;
            step32Job.Enabled = false;
            step33Job.Enabled = false;
            step34Job.Enabled = false;
            step35Job.Enabled = false;
            step36Job.Enabled = false;
            step37Job.Enabled = false;
            step38Job.Enabled = false;
            step39Job.Enabled = false;
            step40Job.Enabled = false;
            isim1.Enabled = false;
            isim2.Enabled = false;
            isim3.Enabled = false;
            isim4.Enabled = false;
            isim5.Enabled = false;
            isim6.Enabled = false;
            isim7.Enabled = false;
            isim8.Enabled = false;
            isim9.Enabled = false;
            isim10.Enabled = false;
            isim11.Enabled = false;
            isim12.Enabled = false;
            isim13.Enabled = false;
            isim14.Enabled = false;
            isim15.Enabled = false;
            isim16.Enabled = false;
            isim17.Enabled = false;
            isim18.Enabled = false;
            isim19.Enabled = false;
            isim20.Enabled = false;
            isim21.Enabled = false;
            isim22.Enabled = false;
            isim23.Enabled = false;
            isim24.Enabled = false;
            isim25.Enabled = false;
            isim26.Enabled = false;
            isim27.Enabled = false;
            isim28.Enabled = false;
            isim29.Enabled = false;
            isim30.Enabled = false;
            isim31.Enabled = false;
            isim32.Enabled = false;
            isim33.Enabled = false;
            isim34.Enabled = false;
            isim35.Enabled = false;
            isim36.Enabled = false;
            isim37.Enabled = false;
            isim38.Enabled = false;
            isim39.Enabled = false;
            isim40.Enabled = false;
            veri1.Enabled = false;
            veri2.Enabled = false;
            veri3.Enabled = false;
            veri4.Enabled = false;
            veri5.Enabled = false;
            veri6.Enabled = false;
            veri7.Enabled = false;
            veri8.Enabled = false;
            veri9.Enabled = false;
            veri10.Enabled = false;
            veri11.Enabled = false;
            veri12.Enabled = false;
            veri13.Enabled = false;
            veri14.Enabled = false;
            veri15.Enabled = false;
            veri16.Enabled = false;
            veri17.Enabled = false;
            veri18.Enabled = false;
            veri19.Enabled = false;
            veri20.Enabled = false;
            veri21.Enabled = false;
            veri22.Enabled = false;
            veri23.Enabled = false;
            veri24.Enabled = false;
            veri25.Enabled = false;
            veri26.Enabled = false;
            veri27.Enabled = false;
            veri28.Enabled = false;
            veri29.Enabled = false;
            veri30.Enabled = false;
            veri31.Enabled = false;
            veri32.Enabled = false;
            veri33.Enabled = false;
            veri34.Enabled = false;
            veri35.Enabled = false;
            veri36.Enabled = false;
            veri37.Enabled = false;
            veri38.Enabled = false;
            veri39.Enabled = false;
            veri40.Enabled = false;
            feedback1.Enabled = false;
            feedback2.Enabled = false;
            feedback3.Enabled = false;
            feedback4.Enabled = false;
            feedback5.Enabled = false;
            feedback6.Enabled = false;
            feedback7.Enabled = false;
            feedback8.Enabled = false;
            feedback9.Enabled = false;
            feedback10.Enabled = false;
            feedback11.Enabled = false;
            feedback12.Enabled = false;
            feedback13.Enabled = false;
            feedback14.Enabled = false;
            feedback15.Enabled = false;
            feedback16.Enabled = false;
            feedback17.Enabled = false;
            feedback18.Enabled = false;
            feedback19.Enabled = false;
            feedback20.Enabled = false;
            feedback21.Enabled = false;
            feedback22.Enabled = false;
            feedback23.Enabled = false;
            feedback24.Enabled = false;
            feedback25.Enabled = false;
            feedback26.Enabled = false;
            feedback27.Enabled = false;
            feedback28.Enabled = false;
            feedback29.Enabled = false;
            feedback30.Enabled = false;
            feedback31.Enabled = false;
            feedback32.Enabled = false;
            feedback33.Enabled = false;
            feedback34.Enabled = false;
            feedback35.Enabled = false;
            feedback36.Enabled = false;
            feedback37.Enabled = false;
            feedback38.Enabled = false;
            feedback39.Enabled = false;
            feedback40.Enabled = false;
            COM1.Enabled = false;
            COM2.Enabled = false;
            COM3.Enabled = false;
            COM4.Enabled = false;
            COM5.Enabled = false;
            COM6.Enabled = false;
            COM7.Enabled = false;
            COM8.Enabled = false;
            COM9.Enabled = false;
            COM10.Enabled = false;
            COM11.Enabled = false;
            COM12.Enabled = false;
            COM13.Enabled = false;
            COM14.Enabled = false;
            COM15.Enabled = false;
            COM16.Enabled = false;
            COM17.Enabled = false;
            COM18.Enabled = false;
            COM19.Enabled = false;
            COM20.Enabled = false;
            COM21.Enabled = false;
            COM22.Enabled = false;
            COM23.Enabled = false;
            COM24.Enabled = false;
            COM25.Enabled = false;
            COM26.Enabled = false;
            COM27.Enabled = false;
            COM28.Enabled = false;
            COM29.Enabled = false;
            COM30.Enabled = false;
            COM31.Enabled = false;
            COM32.Enabled = false;
            COM33.Enabled = false;
            COM34.Enabled = false;
            COM35.Enabled = false;
            COM36.Enabled = false;
            COM37.Enabled = false;
            COM38.Enabled = false;
            COM39.Enabled = false;
            COM40.Enabled = false;
            kontrol1.Enabled = false;
            kontrol2.Enabled = false;
            kontrol3.Enabled = false;
            kontrol4.Enabled = false;
            kontrol5.Enabled = false;
            kontrol6.Enabled = false;
            kontrol7.Enabled = false;
            kontrol8.Enabled = false;
            kontrol9.Enabled = false;
            kontrol10.Enabled = false;
            kontrol11.Enabled = false;
            kontrol12.Enabled = false;
            kontrol13.Enabled = false;
            kontrol14.Enabled = false;
            kontrol15.Enabled = false;
            kontrol16.Enabled = false;
            kontrol17.Enabled = false;
            kontrol18.Enabled = false;
            kontrol19.Enabled = false;
            kontrol20.Enabled = false;
            kontrol21.Enabled = false;
            kontrol22.Enabled = false;
            kontrol23.Enabled = false;
            kontrol24.Enabled = false;
            kontrol25.Enabled = false;
            kontrol26.Enabled = false;
            kontrol27.Enabled = false;
            kontrol28.Enabled = false;
            kontrol29.Enabled = false;
            kontrol30.Enabled = false;
            kontrol31.Enabled = false;
            kontrol32.Enabled = false;
            kontrol33.Enabled = false;
            kontrol34.Enabled = false;
            kontrol35.Enabled = false;
            kontrol36.Enabled = false;
            kontrol37.Enabled = false;
            kontrol38.Enabled = false;
            kontrol39.Enabled = false;
            kontrol40.Enabled = false;
            gorev1.Enabled = false;
            gorev2.Enabled = false;
            gorev3.Enabled = false;
            gorev4.Enabled = false;
            gorev5.Enabled = false;
            gorev6.Enabled = false;
            gorev7.Enabled = false;
            gorev8.Enabled = false;
            gorev9.Enabled = false;
            gorev10.Enabled = false;
            gorev11.Enabled = false;
            gorev12.Enabled = false;
            gorev13.Enabled = false;
            gorev14.Enabled = false;
            gorev15.Enabled = false;
            gorev16.Enabled = false;
            gorev17.Enabled = false;
            gorev18.Enabled = false;
            gorev19.Enabled = false;
            gorev20.Enabled = false;
            gorev21.Enabled = false;
            gorev22.Enabled = false;
            gorev23.Enabled = false;
            gorev24.Enabled = false;
            gorev25.Enabled = false;
            gorev26.Enabled = false;
            gorev27.Enabled = false;
            gorev28.Enabled = false;
            gorev29.Enabled = false;
            gorev30.Enabled = false;
            gorev31.Enabled = false;
            gorev32.Enabled = false;
            gorev33.Enabled = false;
            gorev34.Enabled = false;
            gorev35.Enabled = false;
            gorev36.Enabled = false;
            gorev37.Enabled = false;
            gorev38.Enabled = false;
            gorev39.Enabled = false;
            gorev40.Enabled = false;

            if (Convert.ToInt32(stepNum.Text) >= 1)
            {
                step1Job.Enabled = true;
                isim1.Enabled = true;
                veri1.Enabled = true;
                feedback1.Enabled = true;
                COM1.Enabled = true;
                kontrol1.Enabled = true;
                gorev1.Enabled = true;
                this.Invoke(new EventHandler(step1Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 2)
            {
                step2Job.Enabled = true;
                isim2.Enabled = true;
                veri2.Enabled = true;
                feedback2.Enabled = true;
                COM2.Enabled = true;
                kontrol2.Enabled = true;
                gorev2.Enabled = true;
                this.Invoke(new EventHandler(step2Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 3)
            {
                step3Job.Enabled = true;
                isim3.Enabled = true;
                veri3.Enabled = true;
                feedback3.Enabled = true;
                COM3.Enabled = true;
                kontrol3.Enabled = true;
                gorev3.Enabled = true;
                this.Invoke(new EventHandler(step3Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 4)
            {
                step4Job.Enabled = true;
                isim4.Enabled = true;
                veri4.Enabled = true;
                feedback4.Enabled = true;
                COM4.Enabled = true;
                kontrol4.Enabled = true;
                gorev4.Enabled = true;
                this.Invoke(new EventHandler(step4Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 5)
            {
                step5Job.Enabled = true;
                isim5.Enabled = true;
                veri5.Enabled = true;
                feedback5.Enabled = true;
                COM5.Enabled = true;
                kontrol5.Enabled = true;
                gorev5.Enabled = true;
                this.Invoke(new EventHandler(step5Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 6)
            {
                step6Job.Enabled = true;
                isim6.Enabled = true;
                veri6.Enabled = true;
                feedback6.Enabled = true;
                COM6.Enabled = true;
                kontrol6.Enabled = true;
                gorev6.Enabled = true;
                this.Invoke(new EventHandler(step6Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 7)
            {
                step7Job.Enabled = true;
                isim7.Enabled = true;
                veri7.Enabled = true;
                feedback7.Enabled = true;
                COM7.Enabled = true;
                kontrol7.Enabled = true;
                gorev7.Enabled = true;
                this.Invoke(new EventHandler(step7Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 8)
            {
                step8Job.Enabled = true;
                isim8.Enabled = true;
                veri8.Enabled = true;
                feedback8.Enabled = true;
                COM8.Enabled = true;
                kontrol8.Enabled = true;
                gorev8.Enabled = true;
                this.Invoke(new EventHandler(step8Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 9)
            {
                step9Job.Enabled = true;
                isim9.Enabled = true;
                veri9.Enabled = true;
                feedback9.Enabled = true;
                COM9.Enabled = true;
                kontrol9.Enabled = true;
                gorev9.Enabled = true;
                this.Invoke(new EventHandler(step9Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 10)
            {
                step10Job.Enabled = true;
                isim10.Enabled = true;
                veri10.Enabled = true;
                feedback10.Enabled = true;
                COM10.Enabled = true;
                kontrol10.Enabled = true;
                gorev10.Enabled = true;
                this.Invoke(new EventHandler(step10Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 11)
            {
                step11Job.Enabled = true;
                isim11.Enabled = true;
                veri11.Enabled = true;
                feedback11.Enabled = true;
                COM11.Enabled = true;
                kontrol11.Enabled = true;
                gorev11.Enabled = true;
                this.Invoke(new EventHandler(step11Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 12)
            {
                step12Job.Enabled = true;
                isim12.Enabled = true;
                veri12.Enabled = true;
                feedback12.Enabled = true;
                COM12.Enabled = true;
                kontrol12.Enabled = true;
                gorev12.Enabled = true;
                this.Invoke(new EventHandler(step12Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 13)
            {
                step13Job.Enabled = true;
                isim13.Enabled = true;
                veri13.Enabled = true;
                feedback13.Enabled = true;
                COM13.Enabled = true;
                kontrol13.Enabled = true;
                gorev13.Enabled = true;
                this.Invoke(new EventHandler(step13Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 14)
            {
                step14Job.Enabled = true;
                isim14.Enabled = true;
                veri14.Enabled = true;
                feedback14.Enabled = true;
                COM14.Enabled = true;
                kontrol14.Enabled = true;
                gorev14.Enabled = true;
                this.Invoke(new EventHandler(step14Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 15)
            {
                step15Job.Enabled = true;
                isim15.Enabled = true;
                veri15.Enabled = true;
                feedback15.Enabled = true;
                COM15.Enabled = true;
                kontrol15.Enabled = true;
                gorev15.Enabled = true;
                this.Invoke(new EventHandler(step15Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 16)
            {
                step16Job.Enabled = true;
                isim16.Enabled = true;
                veri16.Enabled = true;
                feedback16.Enabled = true;
                COM16.Enabled = true;
                kontrol16.Enabled = true;
                gorev16.Enabled = true;
                this.Invoke(new EventHandler(step16Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 17)
            {
                step17Job.Enabled = true;
                isim17.Enabled = true;
                veri17.Enabled = true;
                feedback17.Enabled = true;
                COM17.Enabled = true;
                kontrol17.Enabled = true;
                gorev17.Enabled = true;
                this.Invoke(new EventHandler(step17Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 18)
            {
                step18Job.Enabled = true;
                isim18.Enabled = true;
                veri18.Enabled = true;
                feedback18.Enabled = true;
                COM18.Enabled = true;
                kontrol18.Enabled = true;
                gorev18.Enabled = true;
                this.Invoke(new EventHandler(step18Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 19)
            {
                step19Job.Enabled = true;
                isim19.Enabled = true;
                veri19.Enabled = true;
                feedback19.Enabled = true;
                COM19.Enabled = true;
                kontrol19.Enabled = true;
                gorev19.Enabled = true;
                this.Invoke(new EventHandler(step19Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 20)
            {
                step20Job.Enabled = true;
                isim20.Enabled = true;
                veri20.Enabled = true;
                feedback20.Enabled = true;
                COM20.Enabled = true;
                kontrol20.Enabled = true;
                gorev20.Enabled = true;
                this.Invoke(new EventHandler(step20Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 21)
            {
                step21Job.Enabled = true;
                isim21.Enabled = true;
                veri21.Enabled = true;
                feedback21.Enabled = true;
                COM21.Enabled = true;
                kontrol21.Enabled = true;
                gorev21.Enabled = true;
                this.Invoke(new EventHandler(step21Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 22)
            {
                step22Job.Enabled = true;
                isim22.Enabled = true;
                veri22.Enabled = true;
                feedback22.Enabled = true;
                COM22.Enabled = true;
                kontrol22.Enabled = true;
                gorev22.Enabled = true;
                this.Invoke(new EventHandler(step22Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 23)
            {
                step23Job.Enabled = true;
                isim23.Enabled = true;
                veri23.Enabled = true;
                feedback23.Enabled = true;
                COM23.Enabled = true;
                kontrol23.Enabled = true;
                gorev23.Enabled = true;
                this.Invoke(new EventHandler(step23Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 24)
            {
                step24Job.Enabled = true;
                isim24.Enabled = true;
                veri24.Enabled = true;
                feedback24.Enabled = true;
                COM24.Enabled = true;
                kontrol24.Enabled = true;
                gorev24.Enabled = true;
                this.Invoke(new EventHandler(step24Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 25)
            {
                step25Job.Enabled = true;
                isim25.Enabled = true;
                veri25.Enabled = true;
                feedback25.Enabled = true;
                COM25.Enabled = true;
                kontrol25.Enabled = true;
                gorev25.Enabled = true;
                this.Invoke(new EventHandler(step25Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 26)
            {
                step26Job.Enabled = true;
                isim26.Enabled = true;
                veri26.Enabled = true;
                feedback26.Enabled = true;
                COM26.Enabled = true;
                kontrol26.Enabled = true;
                gorev26.Enabled = true;
                this.Invoke(new EventHandler(step26Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 27)
            {
                step27Job.Enabled = true;
                isim27.Enabled = true;
                veri27.Enabled = true;
                feedback27.Enabled = true;
                COM27.Enabled = true;
                kontrol27.Enabled = true;
                gorev27.Enabled = true;
                this.Invoke(new EventHandler(step27Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 28)
            {
                step28Job.Enabled = true;
                isim28.Enabled = true;
                veri28.Enabled = true;
                feedback28.Enabled = true;
                COM28.Enabled = true;
                kontrol28.Enabled = true;
                gorev28.Enabled = true;
                this.Invoke(new EventHandler(step28Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 29)
            {
                step29Job.Enabled = true;
                isim29.Enabled = true;
                veri29.Enabled = true;
                feedback29.Enabled = true;
                COM29.Enabled = true;
                kontrol29.Enabled = true;
                gorev29.Enabled = true;
                this.Invoke(new EventHandler(step29Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 30)
            {
                step30Job.Enabled = true;
                isim30.Enabled = true;
                veri30.Enabled = true;
                feedback30.Enabled = true;
                COM30.Enabled = true;
                kontrol30.Enabled = true;
                gorev30.Enabled = true;
                this.Invoke(new EventHandler(step30Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 31)
            {
                step31Job.Enabled = true;
                isim31.Enabled = true;
                veri31.Enabled = true;
                feedback31.Enabled = true;
                COM31.Enabled = true;
                kontrol31.Enabled = true;
                gorev31.Enabled = true;
                this.Invoke(new EventHandler(step31Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 32)
            {
                step32Job.Enabled = true;
                isim32.Enabled = true;
                veri32.Enabled = true;
                feedback32.Enabled = true;
                COM32.Enabled = true;
                kontrol32.Enabled = true;
                gorev32.Enabled = true;
                this.Invoke(new EventHandler(step32Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 33)
            {
                step33Job.Enabled = true;
                isim33.Enabled = true;
                veri33.Enabled = true;
                feedback33.Enabled = true;
                COM33.Enabled = true;
                kontrol33.Enabled = true;
                gorev33.Enabled = true;
                this.Invoke(new EventHandler(step33Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 34)
            {
                step34Job.Enabled = true;
                isim34.Enabled = true;
                veri34.Enabled = true;
                feedback34.Enabled = true;
                COM34.Enabled = true;
                kontrol34.Enabled = true;
                gorev34.Enabled = true;
                this.Invoke(new EventHandler(step34Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 35)
            {
                step35Job.Enabled = true;
                isim35.Enabled = true;
                veri35.Enabled = true;
                feedback35.Enabled = true;
                COM35.Enabled = true;
                kontrol35.Enabled = true;
                gorev35.Enabled = true;
                this.Invoke(new EventHandler(step35Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 36)
            {
                step36Job.Enabled = true;
                isim36.Enabled = true;
                veri36.Enabled = true;
                feedback36.Enabled = true;
                COM36.Enabled = true;
                kontrol36.Enabled = true;
                gorev36.Enabled = true;
                this.Invoke(new EventHandler(step36Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 37)
            {
                step37Job.Enabled = true;
                isim37.Enabled = true;
                veri37.Enabled = true;
                feedback37.Enabled = true;
                COM37.Enabled = true;
                kontrol37.Enabled = true;
                gorev37.Enabled = true;
                this.Invoke(new EventHandler(step37Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 38)
            {
                step38Job.Enabled = true;
                isim38.Enabled = true;
                veri38.Enabled = true;
                feedback38.Enabled = true;
                COM38.Enabled = true;
                kontrol38.Enabled = true;
                gorev38.Enabled = true;
                this.Invoke(new EventHandler(step38Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 39)
            {
                step39Job.Enabled = true;
                isim39.Enabled = true;
                veri39.Enabled = true;
                feedback39.Enabled = true;
                COM39.Enabled = true;
                kontrol39.Enabled = true;
                gorev39.Enabled = true;
                this.Invoke(new EventHandler(step39Job_SelectedIndexChanged));
            }
            if (Convert.ToInt32(stepNum.Text) >= 40)
            {
                step40Job.Enabled = true;
                isim40.Enabled = true;
                veri40.Enabled = true;
                feedback40.Enabled = true;
                COM40.Enabled = true;
                kontrol40.Enabled = true;
                gorev40.Enabled = true;
                this.Invoke(new EventHandler(step40Job_SelectedIndexChanged));
            }
        }
     
        private void step1Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri1.Enabled = true;
            if (step1Job.Text == "5")
                veri1.Enabled = false;

            feedback1.Enabled = true;
            if (step1Job.Text == "2" || step1Job.Text == "6")
                feedback1.Enabled = false;

            kontrol1.Enabled = true;
            if (step1Job.Text == "1" || step1Job.Text == "5" || step1Job.Text == "6")
                kontrol1.Enabled = false;

            gorev1.Enabled = false;
            if (step1Job.Text == "4")
                gorev1.Enabled = true;
        }

        private void step2Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri2.Enabled = true;
            if (step2Job.Text == "5")
                veri2.Enabled = false;

            feedback2.Enabled = true;
            if (step2Job.Text == "2" || step2Job.Text == "6")
                feedback2.Enabled = false;

            kontrol2.Enabled = true;
            if (step2Job.Text == "1" || step2Job.Text == "5" || step2Job.Text == "6")
                kontrol2.Enabled = false;

            gorev2.Enabled = false;
            if (step2Job.Text == "4")
                gorev2.Enabled = true;
        }

        private void step3Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri3.Enabled = true;
            if (step3Job.Text == "5")
                veri3.Enabled = false;

            feedback3.Enabled = true;
            if (step3Job.Text == "2" || step3Job.Text == "6")
                feedback3.Enabled = false;

            kontrol3.Enabled = true;
            if (step3Job.Text == "1" || step3Job.Text == "5" || step3Job.Text == "6")
                kontrol3.Enabled = false;

            gorev3.Enabled = false;
            if (step3Job.Text == "4")
                gorev3.Enabled = true;
        }

        private void step4Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri4.Enabled = true;
            if (step4Job.Text == "5")
                veri4.Enabled = false;

            feedback4.Enabled = true;
            if (step4Job.Text == "2" || step4Job.Text == "6")
                feedback4.Enabled = false;

            kontrol4.Enabled = true;
            if (step4Job.Text == "1" || step4Job.Text == "5" || step4Job.Text == "6")
                kontrol4.Enabled = false;

            gorev4.Enabled = false;
            if (step4Job.Text == "4")
                gorev4.Enabled = true;
        }

        private void step5Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri5.Enabled = true;
            if (step5Job.Text == "5")
                veri5.Enabled = false;

            feedback5.Enabled = true;
            if (step5Job.Text == "2" || step5Job.Text == "6")
                feedback5.Enabled = false;

            kontrol5.Enabled = true;
            if (step5Job.Text == "1" || step5Job.Text == "5" || step5Job.Text == "6")
                kontrol5.Enabled = false;

            gorev5.Enabled = false;
            if (step5Job.Text == "4")
                gorev5.Enabled = true;
        }

        private void step6Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri6.Enabled = true;
            if (step6Job.Text == "5")
                veri6.Enabled = false;

            feedback6.Enabled = true;
            if (step6Job.Text == "2" || step6Job.Text == "6")
                feedback6.Enabled = false;

            kontrol6.Enabled = true;
            if (step6Job.Text == "1" || step6Job.Text == "5" || step6Job.Text == "6")
                kontrol6.Enabled = false;

            gorev6.Enabled = false;
            if (step6Job.Text == "4")
                gorev6.Enabled = true;
        }

        private void step7Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri7.Enabled = true;
            if (step7Job.Text == "5")
                veri7.Enabled = false;

            feedback7.Enabled = true;
            if (step7Job.Text == "2" || step7Job.Text == "6")
                feedback7.Enabled = false;

            kontrol7.Enabled = true;
            if (step7Job.Text == "1" || step7Job.Text == "5" || step7Job.Text == "6")
                kontrol7.Enabled = false;

            gorev7.Enabled = false;
            if (step7Job.Text == "4")
                gorev7.Enabled = true;
        }

        private void step8Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri8.Enabled = true;
            if (step8Job.Text == "5")
                veri8.Enabled = false;

            feedback8.Enabled = true;
            if (step8Job.Text == "2" || step8Job.Text == "6")
                feedback8.Enabled = false;

            kontrol8.Enabled = true;
            if (step8Job.Text == "1" || step8Job.Text == "5" || step8Job.Text == "6")
                kontrol8.Enabled = false;

            gorev8.Enabled = false;
            if (step8Job.Text == "4")
                gorev8.Enabled = true;
        }

        private void step9Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri9.Enabled = true;
            if (step9Job.Text == "5")
                veri9.Enabled = false;

            feedback9.Enabled = true;
            if (step9Job.Text == "2" || step9Job.Text == "6")
                feedback9.Enabled = false;

            kontrol9.Enabled = true;
            if (step9Job.Text == "1" || step9Job.Text == "5" || step9Job.Text == "6")
                kontrol9.Enabled = false;

            gorev9.Enabled = false;
            if (step9Job.Text == "4")
                gorev9.Enabled = true;
        }

        private void step10Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri10.Enabled = true;
            if (step10Job.Text == "5")
                veri10.Enabled = false;

            feedback10.Enabled = true;
            if (step10Job.Text == "2" || step10Job.Text == "6")
                feedback10.Enabled = false;

            kontrol10.Enabled = true;
            if (step10Job.Text == "1" || step10Job.Text == "5" || step10Job.Text == "6")
                kontrol10.Enabled = false;

            gorev10.Enabled = false;
            if (step10Job.Text == "4")
                gorev10.Enabled = true;
        }

        private void step11Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri11.Enabled = true;
            if (step11Job.Text == "5")
                veri11.Enabled = false;

            feedback11.Enabled = true;
            if (step11Job.Text == "2" || step11Job.Text == "6")
                feedback11.Enabled = false;

            kontrol11.Enabled = true;
            if (step11Job.Text == "1" || step11Job.Text == "5" || step11Job.Text == "6")
                kontrol11.Enabled = false;

            gorev11.Enabled = false;
            if (step11Job.Text == "4")
                gorev11.Enabled = true;
        }

        private void step12Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri12.Enabled = true;
            if (step12Job.Text == "5")
                veri12.Enabled = false;

            feedback12.Enabled = true;
            if (step12Job.Text == "2" || step12Job.Text == "6")
                feedback12.Enabled = false;

            kontrol12.Enabled = true;
            if (step12Job.Text == "1" || step12Job.Text == "5" || step12Job.Text == "6")
                kontrol12.Enabled = false;

            gorev12.Enabled = false;
            if (step12Job.Text == "4")
                gorev12.Enabled = true;
        }

        private void step13Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri13.Enabled = true;
            if (step13Job.Text == "5")
                veri13.Enabled = false;

            feedback13.Enabled = true;
            if (step13Job.Text == "2" || step13Job.Text == "6")
                feedback13.Enabled = false;

            kontrol13.Enabled = true;
            if (step13Job.Text == "1" || step13Job.Text == "5" || step13Job.Text == "6")
                kontrol13.Enabled = false;

            gorev13.Enabled = false;
            if (step13Job.Text == "4")
                gorev13.Enabled = true;
        }

        private void step14Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri14.Enabled = true;
            if (step14Job.Text == "5")
                veri14.Enabled = false;

            feedback14.Enabled = true;
            if (step14Job.Text == "2" || step14Job.Text == "6")
                feedback14.Enabled = false;

            kontrol14.Enabled = true;
            if (step14Job.Text == "1" || step14Job.Text == "5" || step14Job.Text == "6")
                kontrol14.Enabled = false;

            gorev14.Enabled = false;
            if (step14Job.Text == "4")
                gorev14.Enabled = true;
        }

        private void step15Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri15.Enabled = true;
            if (step15Job.Text == "5")
                veri15.Enabled = false;

            feedback15.Enabled = true;
            if (step15Job.Text == "2" || step15Job.Text == "6")
                feedback15.Enabled = false;

            kontrol15.Enabled = true;
            if (step15Job.Text == "1" || step15Job.Text == "5" || step15Job.Text == "6")
                kontrol15.Enabled = false;

            gorev15.Enabled = false;
            if (step15Job.Text == "4")
                gorev15.Enabled = true;
        }

        private void step16Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri16.Enabled = true;
            if (step16Job.Text == "5")
                veri16.Enabled = false;

            feedback16.Enabled = true;
            if (step16Job.Text == "2" || step16Job.Text == "6")
                feedback16.Enabled = false;

            kontrol16.Enabled = true;
            if (step16Job.Text == "1" || step16Job.Text == "5" || step16Job.Text == "6")
                kontrol16.Enabled = false;

            gorev16.Enabled = false;
            if (step16Job.Text == "4")
                gorev16.Enabled = true;
        }

        private void step17Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri17.Enabled = true;
            if (step17Job.Text == "5")
                veri17.Enabled = false;

            feedback17.Enabled = true;
            if (step17Job.Text == "2" || step17Job.Text == "6")
                feedback17.Enabled = false;

            kontrol17.Enabled = true;
            if (step17Job.Text == "1" || step17Job.Text == "5" || step17Job.Text == "6")
                kontrol17.Enabled = false;

            gorev17.Enabled = false;
            if (step17Job.Text == "4")
                gorev17.Enabled = true;
        }

        private void step18Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri18.Enabled = true;
            if (step18Job.Text == "5")
                veri18.Enabled = false;

            feedback18.Enabled = true;
            if (step18Job.Text == "2" || step18Job.Text == "6")
                feedback18.Enabled = false;

            kontrol18.Enabled = true;
            if (step18Job.Text == "1" || step18Job.Text == "5" || step18Job.Text == "6")
                kontrol18.Enabled = false;

            gorev18.Enabled = false;
            if (step18Job.Text == "4")
                gorev18.Enabled = true;
        }

        private void step19Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri19.Enabled = true;
            if (step19Job.Text == "5")
                veri19.Enabled = false;

            feedback19.Enabled = true;
            if (step19Job.Text == "2" || step19Job.Text == "6")
                feedback19.Enabled = false;

            kontrol19.Enabled = true;
            if (step19Job.Text == "1" || step19Job.Text == "5" || step19Job.Text == "6")
                kontrol19.Enabled = false;

            gorev19.Enabled = false;
            if (step19Job.Text == "4")
                gorev19.Enabled = true;
        }

        private void step20Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri20.Enabled = true;
            if (step20Job.Text == "5")
                veri20.Enabled = false;

            feedback20.Enabled = true;
            if (step20Job.Text == "2" || step20Job.Text == "6")
                feedback20.Enabled = false;

            kontrol20.Enabled = true;
            if (step20Job.Text == "1" || step20Job.Text == "5" || step20Job.Text == "6")
                kontrol20.Enabled = false;

            gorev20.Enabled = false;
            if (step20Job.Text == "4")
                gorev20.Enabled = true;
        }

        private void step21Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri21.Enabled = true;
            if (step21Job.Text == "5")
                veri21.Enabled = false;

            feedback21.Enabled = true;
            if (step21Job.Text == "2" || step21Job.Text == "6")
                feedback21.Enabled = false;

            kontrol21.Enabled = true;
            if (step21Job.Text == "1" || step21Job.Text == "5" || step21Job.Text == "6")
                kontrol21.Enabled = false;

            gorev21.Enabled = false;
            if (step21Job.Text == "4")
                gorev21.Enabled = true;
        }

        private void step22Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri22.Enabled = true;
            if (step22Job.Text == "5")
                veri22.Enabled = false;

            feedback22.Enabled = true;
            if (step22Job.Text == "2" || step22Job.Text == "6")
                feedback22.Enabled = false;

            kontrol22.Enabled = true;
            if (step22Job.Text == "1" || step22Job.Text == "5" || step22Job.Text == "6")
                kontrol22.Enabled = false;

            gorev22.Enabled = false;
            if (step22Job.Text == "4")
                gorev22.Enabled = true;
        }

        private void step23Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri23.Enabled = true;
            if (step23Job.Text == "5")
                veri23.Enabled = false;

            feedback23.Enabled = true;
            if (step23Job.Text == "2" || step23Job.Text == "6")
                feedback23.Enabled = false;

            kontrol23.Enabled = true;
            if (step23Job.Text == "1" || step23Job.Text == "5" || step23Job.Text == "6")
                kontrol23.Enabled = false;

            gorev23.Enabled = false;
            if (step23Job.Text == "4")
                gorev23.Enabled = true;
        }

        private void step24Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri24.Enabled = true;
            if (step24Job.Text == "5")
                veri24.Enabled = false;

            feedback24.Enabled = true;
            if (step24Job.Text == "2" || step24Job.Text == "6")
                feedback24.Enabled = false;

            kontrol24.Enabled = true;
            if (step24Job.Text == "1" || step24Job.Text == "5" || step24Job.Text == "6")
                kontrol24.Enabled = false;

            gorev24.Enabled = false;
            if (step24Job.Text == "4")
                gorev24.Enabled = true;
        }

        private void step25Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri25.Enabled = true;
            if (step25Job.Text == "5")
                veri25.Enabled = false;

            feedback25.Enabled = true;
            if (step25Job.Text == "2" || step25Job.Text == "6")
                feedback25.Enabled = false;

            kontrol25.Enabled = true;
            if (step25Job.Text == "1" || step25Job.Text == "5" || step25Job.Text == "6")
                kontrol25.Enabled = false;

            gorev25.Enabled = false;
            if (step25Job.Text == "4")
                gorev25.Enabled = true;
        }

        private void step26Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri26.Enabled = true;
            if (step26Job.Text == "5")
                veri26.Enabled = false;

            feedback26.Enabled = true;
            if (step26Job.Text == "2" || step26Job.Text == "6")
                feedback26.Enabled = false;

            kontrol26.Enabled = true;
            if (step26Job.Text == "1" || step26Job.Text == "5" || step26Job.Text == "6")
                kontrol26.Enabled = false;

            gorev26.Enabled = false;
            if (step26Job.Text == "4")
                gorev26.Enabled = true;
        }

        private void step27Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri27.Enabled = true;
            if (step27Job.Text == "5")
                veri27.Enabled = false;

            feedback27.Enabled = true;
            if (step27Job.Text == "2" || step27Job.Text == "6")
                feedback27.Enabled = false;

            kontrol27.Enabled = true;
            if (step27Job.Text == "1" || step27Job.Text == "5" || step27Job.Text == "6")
                kontrol27.Enabled = false;

            gorev27.Enabled = false;
            if (step27Job.Text == "4")
                gorev27.Enabled = true;
        }

        private void step28Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri28.Enabled = true;
            if (step28Job.Text == "5")
                veri28.Enabled = false;

            feedback28.Enabled = true;
            if (step28Job.Text == "2" || step28Job.Text == "6")
                feedback28.Enabled = false;

            kontrol28.Enabled = true;
            if (step28Job.Text == "1" || step28Job.Text == "5" || step28Job.Text == "6")
                kontrol28.Enabled = false;

            gorev28.Enabled = false;
            if (step28Job.Text == "4")
                gorev28.Enabled = true;
        }

        private void step29Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri29.Enabled = true;
            if (step29Job.Text == "5")
                veri29.Enabled = false;

            feedback29.Enabled = true;
            if (step29Job.Text == "2" || step29Job.Text == "6")
                feedback29.Enabled = false;

            kontrol29.Enabled = true;
            if (step29Job.Text == "1" || step29Job.Text == "5" || step29Job.Text == "6")
                kontrol29.Enabled = false;

            gorev29.Enabled = false;
            if (step29Job.Text == "4")
                gorev29.Enabled = true;
        }

        private void step30Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri30.Enabled = true;
            if (step30Job.Text == "5")
                veri30.Enabled = false;

            feedback30.Enabled = true;
            if (step30Job.Text == "2" || step30Job.Text == "6")
                feedback30.Enabled = false;

            kontrol30.Enabled = true;
            if (step30Job.Text == "1" || step30Job.Text == "5" || step30Job.Text == "6")
                kontrol30.Enabled = false;

            gorev30.Enabled = false;
            if (step30Job.Text == "4")
                gorev30.Enabled = true;
        }

        private void step31Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri31.Enabled = true;
            if (step31Job.Text == "5")
                veri31.Enabled = false;

            feedback31.Enabled = true;
            if (step31Job.Text == "2" || step31Job.Text == "6")
                feedback31.Enabled = false;

            kontrol31.Enabled = true;
            if (step31Job.Text == "1" || step31Job.Text == "5" || step31Job.Text == "6")
                kontrol31.Enabled = false;

            gorev31.Enabled = false;
            if (step31Job.Text == "4")
                gorev31.Enabled = true;
        }

        private void step32Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri32.Enabled = true;
            if (step32Job.Text == "5")
                veri32.Enabled = false;

            feedback32.Enabled = true;
            if (step32Job.Text == "2" || step32Job.Text == "6")
                feedback32.Enabled = false;

            kontrol32.Enabled = true;
            if (step32Job.Text == "1" || step32Job.Text == "5" || step32Job.Text == "6")
                kontrol32.Enabled = false;

            gorev32.Enabled = false;
            if (step32Job.Text == "4")
                gorev32.Enabled = true;
        }

        private void step33Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri33.Enabled = true;
            if (step33Job.Text == "5")
                veri33.Enabled = false;

            feedback33.Enabled = true;
            if (step33Job.Text == "2" || step33Job.Text == "6")
                feedback33.Enabled = false;

            kontrol33.Enabled = true;
            if (step33Job.Text == "1" || step33Job.Text == "5" || step33Job.Text == "6")
                kontrol33.Enabled = false;

            gorev33.Enabled = false;
            if (step33Job.Text == "4")
                gorev33.Enabled = true;
        }

        private void step34Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri34.Enabled = true;
            if (step34Job.Text == "5")
                veri34.Enabled = false;

            feedback34.Enabled = true;
            if (step34Job.Text == "2" || step34Job.Text == "6")
                feedback34.Enabled = false;

            kontrol34.Enabled = true;
            if (step34Job.Text == "1" || step34Job.Text == "5" || step34Job.Text == "6")
                kontrol34.Enabled = false;

            gorev34.Enabled = false;
            if (step34Job.Text == "4")
                gorev34.Enabled = true;
        }

        private void step35Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri35.Enabled = true;
            if (step35Job.Text == "5")
                veri35.Enabled = false;

            feedback35.Enabled = true;
            if (step35Job.Text == "2" || step35Job.Text == "6")
                feedback35.Enabled = false;

            kontrol35.Enabled = true;
            if (step35Job.Text == "1" || step35Job.Text == "5" || step35Job.Text == "6")
                kontrol35.Enabled = false;

            gorev35.Enabled = false;
            if (step35Job.Text == "4")
                gorev35.Enabled = true;
        }

        private void step36Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri36.Enabled = true;
            if (step36Job.Text == "5")
                veri36.Enabled = false;

            feedback36.Enabled = true;
            if (step36Job.Text == "2" || step36Job.Text == "6")
                feedback36.Enabled = false;

            kontrol36.Enabled = true;
            if (step36Job.Text == "1" || step36Job.Text == "5" || step36Job.Text == "6")
                kontrol36.Enabled = false;

            gorev36.Enabled = false;
            if (step36Job.Text == "4")
                gorev36.Enabled = true;
        }

        private void step37Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri37.Enabled = true;
            if (step37Job.Text == "5")
                veri37.Enabled = false;

            feedback37.Enabled = true;
            if (step37Job.Text == "2" || step37Job.Text == "6")
                feedback37.Enabled = false;

            kontrol37.Enabled = true;
            if (step37Job.Text == "1" || step37Job.Text == "5" || step37Job.Text == "6")
                kontrol37.Enabled = false;

            gorev37.Enabled = false;
            if (step37Job.Text == "4")
                gorev37.Enabled = true;
        }

        private void step38Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri38.Enabled = true;
            if (step38Job.Text == "5")
                veri38.Enabled = false;

            feedback38.Enabled = true;
            if (step38Job.Text == "2" || step38Job.Text == "6")
                feedback38.Enabled = false;

            kontrol38.Enabled = true;
            if (step38Job.Text == "1" || step38Job.Text == "5" || step38Job.Text == "6")
                kontrol38.Enabled = false;

            gorev38.Enabled = false;
            if (step38Job.Text == "4")
                gorev38.Enabled = true;
        }

        private void step39Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri39.Enabled = true;
            if (step39Job.Text == "5")
                veri39.Enabled = false;

            feedback39.Enabled = true;
            if (step39Job.Text == "2" || step39Job.Text == "6")
                feedback39.Enabled = false;

            kontrol39.Enabled = true;
            if (step39Job.Text == "1" || step39Job.Text == "5" || step39Job.Text == "6")
                kontrol39.Enabled = false;

            gorev39.Enabled = false;
            if (step39Job.Text == "4")
                gorev39.Enabled = true;
        }

        private void step40Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri40.Enabled = true;
            if (step40Job.Text == "5")
                veri40.Enabled = false;

            feedback40.Enabled = true;
            if (step40Job.Text == "2" || step40Job.Text == "6")
                feedback40.Enabled = false;

            kontrol40.Enabled = true;
            if (step40Job.Text == "1" || step40Job.Text == "5" || step40Job.Text == "6")
                kontrol40.Enabled = false;

            gorev40.Enabled = false;
            if (step40Job.Text == "4")
                gorev40.Enabled = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurulumForm));
            this.stepNum = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.step1Job = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.step2Job = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.step4Job = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.step3Job = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.step5Job = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.feedback1 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.feedback5 = new System.Windows.Forms.ComboBox();
            this.feedback4 = new System.Windows.Forms.ComboBox();
            this.feedback3 = new System.Windows.Forms.ComboBox();
            this.feedback2 = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.COM5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COM4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COM3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.COM2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.COM1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.veri5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.veri4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.veri3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.veri2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.veri1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kontrol1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kontrol2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.kontrol3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.kontrol4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.kontrol5 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.gorev5 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.gorev4 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.gorev3 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.gorev2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.gorev1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.isim5 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.isim4 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.isim3 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.isim2 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.isim1 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.isim10 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.isim9 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.isim8 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.isim7 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.isim6 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.gorev10 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.gorev9 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.gorev8 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.gorev7 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.gorev6 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.kontrol10 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.kontrol9 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.kontrol8 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.kontrol7 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.kontrol6 = new System.Windows.Forms.TextBox();
            this.veri10 = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.veri9 = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.veri8 = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.veri7 = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.veri6 = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.COM10 = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.COM9 = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.COM8 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.COM7 = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.COM6 = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.feedback10 = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.feedback9 = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.feedback8 = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.feedback7 = new System.Windows.Forms.ComboBox();
            this.label66 = new System.Windows.Forms.Label();
            this.feedback6 = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.step10Job = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.step9Job = new System.Windows.Forms.ComboBox();
            this.label69 = new System.Windows.Forms.Label();
            this.step8Job = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.step7Job = new System.Windows.Forms.ComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.step6Job = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.isim20 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.isim19 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.isim18 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.isim17 = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.isim16 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.gorev20 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.gorev19 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.gorev18 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.gorev17 = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.gorev16 = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.kontrol20 = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.kontrol19 = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.kontrol18 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.kontrol17 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.kontrol16 = new System.Windows.Forms.TextBox();
            this.veri20 = new System.Windows.Forms.ComboBox();
            this.label88 = new System.Windows.Forms.Label();
            this.veri19 = new System.Windows.Forms.ComboBox();
            this.label89 = new System.Windows.Forms.Label();
            this.veri18 = new System.Windows.Forms.ComboBox();
            this.label90 = new System.Windows.Forms.Label();
            this.veri17 = new System.Windows.Forms.ComboBox();
            this.label91 = new System.Windows.Forms.Label();
            this.veri16 = new System.Windows.Forms.ComboBox();
            this.label92 = new System.Windows.Forms.Label();
            this.COM20 = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.COM19 = new System.Windows.Forms.ComboBox();
            this.label94 = new System.Windows.Forms.Label();
            this.COM18 = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.COM17 = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.COM16 = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.feedback20 = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.feedback19 = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.feedback18 = new System.Windows.Forms.ComboBox();
            this.label100 = new System.Windows.Forms.Label();
            this.feedback17 = new System.Windows.Forms.ComboBox();
            this.label101 = new System.Windows.Forms.Label();
            this.feedback16 = new System.Windows.Forms.ComboBox();
            this.label102 = new System.Windows.Forms.Label();
            this.step20Job = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.step19Job = new System.Windows.Forms.ComboBox();
            this.label104 = new System.Windows.Forms.Label();
            this.step18Job = new System.Windows.Forms.ComboBox();
            this.label105 = new System.Windows.Forms.Label();
            this.step17Job = new System.Windows.Forms.ComboBox();
            this.label106 = new System.Windows.Forms.Label();
            this.step16Job = new System.Windows.Forms.ComboBox();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.isim15 = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.isim14 = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.isim13 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.isim12 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.isim11 = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.gorev15 = new System.Windows.Forms.TextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.gorev14 = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.gorev13 = new System.Windows.Forms.TextBox();
            this.label116 = new System.Windows.Forms.Label();
            this.gorev12 = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.gorev11 = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.kontrol15 = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.kontrol14 = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.kontrol13 = new System.Windows.Forms.TextBox();
            this.label121 = new System.Windows.Forms.Label();
            this.kontrol12 = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.kontrol11 = new System.Windows.Forms.TextBox();
            this.veri15 = new System.Windows.Forms.ComboBox();
            this.label123 = new System.Windows.Forms.Label();
            this.veri14 = new System.Windows.Forms.ComboBox();
            this.label124 = new System.Windows.Forms.Label();
            this.veri13 = new System.Windows.Forms.ComboBox();
            this.label125 = new System.Windows.Forms.Label();
            this.veri12 = new System.Windows.Forms.ComboBox();
            this.label126 = new System.Windows.Forms.Label();
            this.veri11 = new System.Windows.Forms.ComboBox();
            this.label127 = new System.Windows.Forms.Label();
            this.COM15 = new System.Windows.Forms.ComboBox();
            this.label128 = new System.Windows.Forms.Label();
            this.COM14 = new System.Windows.Forms.ComboBox();
            this.label129 = new System.Windows.Forms.Label();
            this.COM13 = new System.Windows.Forms.ComboBox();
            this.label130 = new System.Windows.Forms.Label();
            this.COM12 = new System.Windows.Forms.ComboBox();
            this.label131 = new System.Windows.Forms.Label();
            this.COM11 = new System.Windows.Forms.ComboBox();
            this.label132 = new System.Windows.Forms.Label();
            this.feedback15 = new System.Windows.Forms.ComboBox();
            this.label133 = new System.Windows.Forms.Label();
            this.feedback14 = new System.Windows.Forms.ComboBox();
            this.label134 = new System.Windows.Forms.Label();
            this.feedback13 = new System.Windows.Forms.ComboBox();
            this.label135 = new System.Windows.Forms.Label();
            this.feedback12 = new System.Windows.Forms.ComboBox();
            this.label136 = new System.Windows.Forms.Label();
            this.feedback11 = new System.Windows.Forms.ComboBox();
            this.label137 = new System.Windows.Forms.Label();
            this.step15Job = new System.Windows.Forms.ComboBox();
            this.label138 = new System.Windows.Forms.Label();
            this.step14Job = new System.Windows.Forms.ComboBox();
            this.label139 = new System.Windows.Forms.Label();
            this.step13Job = new System.Windows.Forms.ComboBox();
            this.label140 = new System.Windows.Forms.Label();
            this.step12Job = new System.Windows.Forms.ComboBox();
            this.label141 = new System.Windows.Forms.Label();
            this.step11Job = new System.Windows.Forms.ComboBox();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.isim30 = new System.Windows.Forms.TextBox();
            this.label144 = new System.Windows.Forms.Label();
            this.isim29 = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.isim28 = new System.Windows.Forms.TextBox();
            this.label146 = new System.Windows.Forms.Label();
            this.isim27 = new System.Windows.Forms.TextBox();
            this.label147 = new System.Windows.Forms.Label();
            this.isim26 = new System.Windows.Forms.TextBox();
            this.label148 = new System.Windows.Forms.Label();
            this.gorev30 = new System.Windows.Forms.TextBox();
            this.label149 = new System.Windows.Forms.Label();
            this.gorev29 = new System.Windows.Forms.TextBox();
            this.label150 = new System.Windows.Forms.Label();
            this.gorev28 = new System.Windows.Forms.TextBox();
            this.label151 = new System.Windows.Forms.Label();
            this.gorev27 = new System.Windows.Forms.TextBox();
            this.label152 = new System.Windows.Forms.Label();
            this.gorev26 = new System.Windows.Forms.TextBox();
            this.label153 = new System.Windows.Forms.Label();
            this.kontrol30 = new System.Windows.Forms.TextBox();
            this.label154 = new System.Windows.Forms.Label();
            this.kontrol29 = new System.Windows.Forms.TextBox();
            this.label155 = new System.Windows.Forms.Label();
            this.kontrol28 = new System.Windows.Forms.TextBox();
            this.label156 = new System.Windows.Forms.Label();
            this.kontrol27 = new System.Windows.Forms.TextBox();
            this.label157 = new System.Windows.Forms.Label();
            this.kontrol26 = new System.Windows.Forms.TextBox();
            this.veri30 = new System.Windows.Forms.ComboBox();
            this.label158 = new System.Windows.Forms.Label();
            this.veri29 = new System.Windows.Forms.ComboBox();
            this.label159 = new System.Windows.Forms.Label();
            this.veri28 = new System.Windows.Forms.ComboBox();
            this.label160 = new System.Windows.Forms.Label();
            this.veri27 = new System.Windows.Forms.ComboBox();
            this.label161 = new System.Windows.Forms.Label();
            this.veri26 = new System.Windows.Forms.ComboBox();
            this.label162 = new System.Windows.Forms.Label();
            this.COM30 = new System.Windows.Forms.ComboBox();
            this.label163 = new System.Windows.Forms.Label();
            this.COM29 = new System.Windows.Forms.ComboBox();
            this.label164 = new System.Windows.Forms.Label();
            this.COM28 = new System.Windows.Forms.ComboBox();
            this.label165 = new System.Windows.Forms.Label();
            this.COM27 = new System.Windows.Forms.ComboBox();
            this.label166 = new System.Windows.Forms.Label();
            this.COM26 = new System.Windows.Forms.ComboBox();
            this.label167 = new System.Windows.Forms.Label();
            this.feedback30 = new System.Windows.Forms.ComboBox();
            this.label168 = new System.Windows.Forms.Label();
            this.feedback29 = new System.Windows.Forms.ComboBox();
            this.label169 = new System.Windows.Forms.Label();
            this.feedback28 = new System.Windows.Forms.ComboBox();
            this.label170 = new System.Windows.Forms.Label();
            this.feedback27 = new System.Windows.Forms.ComboBox();
            this.label171 = new System.Windows.Forms.Label();
            this.feedback26 = new System.Windows.Forms.ComboBox();
            this.label172 = new System.Windows.Forms.Label();
            this.step30Job = new System.Windows.Forms.ComboBox();
            this.label173 = new System.Windows.Forms.Label();
            this.step29Job = new System.Windows.Forms.ComboBox();
            this.label174 = new System.Windows.Forms.Label();
            this.step28Job = new System.Windows.Forms.ComboBox();
            this.label175 = new System.Windows.Forms.Label();
            this.step27Job = new System.Windows.Forms.ComboBox();
            this.label176 = new System.Windows.Forms.Label();
            this.step26Job = new System.Windows.Forms.ComboBox();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.isim25 = new System.Windows.Forms.TextBox();
            this.label179 = new System.Windows.Forms.Label();
            this.isim24 = new System.Windows.Forms.TextBox();
            this.label180 = new System.Windows.Forms.Label();
            this.isim23 = new System.Windows.Forms.TextBox();
            this.label181 = new System.Windows.Forms.Label();
            this.isim22 = new System.Windows.Forms.TextBox();
            this.label182 = new System.Windows.Forms.Label();
            this.isim21 = new System.Windows.Forms.TextBox();
            this.label183 = new System.Windows.Forms.Label();
            this.gorev25 = new System.Windows.Forms.TextBox();
            this.label184 = new System.Windows.Forms.Label();
            this.gorev24 = new System.Windows.Forms.TextBox();
            this.label185 = new System.Windows.Forms.Label();
            this.gorev23 = new System.Windows.Forms.TextBox();
            this.label186 = new System.Windows.Forms.Label();
            this.gorev22 = new System.Windows.Forms.TextBox();
            this.label187 = new System.Windows.Forms.Label();
            this.gorev21 = new System.Windows.Forms.TextBox();
            this.label188 = new System.Windows.Forms.Label();
            this.kontrol25 = new System.Windows.Forms.TextBox();
            this.label189 = new System.Windows.Forms.Label();
            this.kontrol24 = new System.Windows.Forms.TextBox();
            this.label190 = new System.Windows.Forms.Label();
            this.kontrol23 = new System.Windows.Forms.TextBox();
            this.label191 = new System.Windows.Forms.Label();
            this.kontrol22 = new System.Windows.Forms.TextBox();
            this.label192 = new System.Windows.Forms.Label();
            this.kontrol21 = new System.Windows.Forms.TextBox();
            this.veri25 = new System.Windows.Forms.ComboBox();
            this.label193 = new System.Windows.Forms.Label();
            this.veri24 = new System.Windows.Forms.ComboBox();
            this.label194 = new System.Windows.Forms.Label();
            this.veri23 = new System.Windows.Forms.ComboBox();
            this.label195 = new System.Windows.Forms.Label();
            this.veri22 = new System.Windows.Forms.ComboBox();
            this.label196 = new System.Windows.Forms.Label();
            this.veri21 = new System.Windows.Forms.ComboBox();
            this.label197 = new System.Windows.Forms.Label();
            this.COM25 = new System.Windows.Forms.ComboBox();
            this.label198 = new System.Windows.Forms.Label();
            this.COM24 = new System.Windows.Forms.ComboBox();
            this.label199 = new System.Windows.Forms.Label();
            this.COM23 = new System.Windows.Forms.ComboBox();
            this.label200 = new System.Windows.Forms.Label();
            this.COM22 = new System.Windows.Forms.ComboBox();
            this.label201 = new System.Windows.Forms.Label();
            this.COM21 = new System.Windows.Forms.ComboBox();
            this.label202 = new System.Windows.Forms.Label();
            this.feedback25 = new System.Windows.Forms.ComboBox();
            this.label203 = new System.Windows.Forms.Label();
            this.feedback24 = new System.Windows.Forms.ComboBox();
            this.label204 = new System.Windows.Forms.Label();
            this.feedback23 = new System.Windows.Forms.ComboBox();
            this.label205 = new System.Windows.Forms.Label();
            this.feedback22 = new System.Windows.Forms.ComboBox();
            this.label206 = new System.Windows.Forms.Label();
            this.feedback21 = new System.Windows.Forms.ComboBox();
            this.label207 = new System.Windows.Forms.Label();
            this.step25Job = new System.Windows.Forms.ComboBox();
            this.label208 = new System.Windows.Forms.Label();
            this.step24Job = new System.Windows.Forms.ComboBox();
            this.label209 = new System.Windows.Forms.Label();
            this.step23Job = new System.Windows.Forms.ComboBox();
            this.label210 = new System.Windows.Forms.Label();
            this.step22Job = new System.Windows.Forms.ComboBox();
            this.label211 = new System.Windows.Forms.Label();
            this.step21Job = new System.Windows.Forms.ComboBox();
            this.label212 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.isim31 = new System.Windows.Forms.TextBox();
            this.label214 = new System.Windows.Forms.Label();
            this.gorev31 = new System.Windows.Forms.TextBox();
            this.label215 = new System.Windows.Forms.Label();
            this.kontrol31 = new System.Windows.Forms.TextBox();
            this.veri31 = new System.Windows.Forms.ComboBox();
            this.label216 = new System.Windows.Forms.Label();
            this.COM31 = new System.Windows.Forms.ComboBox();
            this.label217 = new System.Windows.Forms.Label();
            this.feedback31 = new System.Windows.Forms.ComboBox();
            this.label218 = new System.Windows.Forms.Label();
            this.step31Job = new System.Windows.Forms.ComboBox();
            this.label219 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.label223 = new System.Windows.Forms.Label();
            this.isim37 = new System.Windows.Forms.TextBox();
            this.label224 = new System.Windows.Forms.Label();
            this.isim36 = new System.Windows.Forms.TextBox();
            this.label228 = new System.Windows.Forms.Label();
            this.gorev37 = new System.Windows.Forms.TextBox();
            this.label229 = new System.Windows.Forms.Label();
            this.gorev36 = new System.Windows.Forms.TextBox();
            this.label233 = new System.Windows.Forms.Label();
            this.kontrol37 = new System.Windows.Forms.TextBox();
            this.label234 = new System.Windows.Forms.Label();
            this.kontrol36 = new System.Windows.Forms.TextBox();
            this.veri37 = new System.Windows.Forms.ComboBox();
            this.label238 = new System.Windows.Forms.Label();
            this.veri36 = new System.Windows.Forms.ComboBox();
            this.label239 = new System.Windows.Forms.Label();
            this.COM37 = new System.Windows.Forms.ComboBox();
            this.label243 = new System.Windows.Forms.Label();
            this.COM36 = new System.Windows.Forms.ComboBox();
            this.label244 = new System.Windows.Forms.Label();
            this.feedback37 = new System.Windows.Forms.ComboBox();
            this.label248 = new System.Windows.Forms.Label();
            this.feedback36 = new System.Windows.Forms.ComboBox();
            this.label249 = new System.Windows.Forms.Label();
            this.step37Job = new System.Windows.Forms.ComboBox();
            this.label253 = new System.Windows.Forms.Label();
            this.step36Job = new System.Windows.Forms.ComboBox();
            this.label254 = new System.Windows.Forms.Label();
            this.label255 = new System.Windows.Forms.Label();
            this.isim35 = new System.Windows.Forms.TextBox();
            this.label256 = new System.Windows.Forms.Label();
            this.isim34 = new System.Windows.Forms.TextBox();
            this.label257 = new System.Windows.Forms.Label();
            this.isim33 = new System.Windows.Forms.TextBox();
            this.label258 = new System.Windows.Forms.Label();
            this.isim32 = new System.Windows.Forms.TextBox();
            this.label259 = new System.Windows.Forms.Label();
            this.gorev35 = new System.Windows.Forms.TextBox();
            this.label260 = new System.Windows.Forms.Label();
            this.gorev34 = new System.Windows.Forms.TextBox();
            this.label261 = new System.Windows.Forms.Label();
            this.gorev33 = new System.Windows.Forms.TextBox();
            this.label262 = new System.Windows.Forms.Label();
            this.gorev32 = new System.Windows.Forms.TextBox();
            this.label263 = new System.Windows.Forms.Label();
            this.kontrol35 = new System.Windows.Forms.TextBox();
            this.label264 = new System.Windows.Forms.Label();
            this.kontrol34 = new System.Windows.Forms.TextBox();
            this.label265 = new System.Windows.Forms.Label();
            this.kontrol33 = new System.Windows.Forms.TextBox();
            this.label266 = new System.Windows.Forms.Label();
            this.kontrol32 = new System.Windows.Forms.TextBox();
            this.veri35 = new System.Windows.Forms.ComboBox();
            this.label267 = new System.Windows.Forms.Label();
            this.veri34 = new System.Windows.Forms.ComboBox();
            this.label268 = new System.Windows.Forms.Label();
            this.veri33 = new System.Windows.Forms.ComboBox();
            this.label269 = new System.Windows.Forms.Label();
            this.veri32 = new System.Windows.Forms.ComboBox();
            this.label270 = new System.Windows.Forms.Label();
            this.COM35 = new System.Windows.Forms.ComboBox();
            this.label271 = new System.Windows.Forms.Label();
            this.COM34 = new System.Windows.Forms.ComboBox();
            this.label272 = new System.Windows.Forms.Label();
            this.COM33 = new System.Windows.Forms.ComboBox();
            this.label273 = new System.Windows.Forms.Label();
            this.COM32 = new System.Windows.Forms.ComboBox();
            this.label274 = new System.Windows.Forms.Label();
            this.feedback35 = new System.Windows.Forms.ComboBox();
            this.label275 = new System.Windows.Forms.Label();
            this.feedback34 = new System.Windows.Forms.ComboBox();
            this.label276 = new System.Windows.Forms.Label();
            this.feedback33 = new System.Windows.Forms.ComboBox();
            this.label277 = new System.Windows.Forms.Label();
            this.feedback32 = new System.Windows.Forms.ComboBox();
            this.label278 = new System.Windows.Forms.Label();
            this.step35Job = new System.Windows.Forms.ComboBox();
            this.label279 = new System.Windows.Forms.Label();
            this.step34Job = new System.Windows.Forms.ComboBox();
            this.label280 = new System.Windows.Forms.Label();
            this.step33Job = new System.Windows.Forms.ComboBox();
            this.label281 = new System.Windows.Forms.Label();
            this.step32Job = new System.Windows.Forms.ComboBox();
            this.label282 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.infoPicture7 = new System.Windows.Forms.PictureBox();
            this.infoPicture6 = new System.Windows.Forms.PictureBox();
            this.infoPicture5 = new System.Windows.Forms.PictureBox();
            this.infoPicture4 = new System.Windows.Forms.PictureBox();
            this.infoPicture3 = new System.Windows.Forms.PictureBox();
            this.infoPicture2 = new System.Windows.Forms.PictureBox();
            this.infoPicture1 = new System.Windows.Forms.PictureBox();
            this.btnKaydetIni = new System.Windows.Forms.Button();
            this.btnOkuIni = new System.Windows.Forms.Button();
            this.btnINIsec = new System.Windows.Forms.Button();
            this.txtINIdosya = new System.Windows.Forms.TextBox();
            this.label220 = new System.Windows.Forms.Label();
            this.chBoxProgramlama = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label221 = new System.Windows.Forms.Label();
            this.isim38 = new System.Windows.Forms.TextBox();
            this.label222 = new System.Windows.Forms.Label();
            this.gorev38 = new System.Windows.Forms.TextBox();
            this.label225 = new System.Windows.Forms.Label();
            this.kontrol38 = new System.Windows.Forms.TextBox();
            this.veri38 = new System.Windows.Forms.ComboBox();
            this.label226 = new System.Windows.Forms.Label();
            this.COM38 = new System.Windows.Forms.ComboBox();
            this.label227 = new System.Windows.Forms.Label();
            this.feedback38 = new System.Windows.Forms.ComboBox();
            this.label230 = new System.Windows.Forms.Label();
            this.step38Job = new System.Windows.Forms.ComboBox();
            this.label231 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.isim39 = new System.Windows.Forms.TextBox();
            this.label235 = new System.Windows.Forms.Label();
            this.gorev39 = new System.Windows.Forms.TextBox();
            this.label236 = new System.Windows.Forms.Label();
            this.kontrol39 = new System.Windows.Forms.TextBox();
            this.veri39 = new System.Windows.Forms.ComboBox();
            this.COM39 = new System.Windows.Forms.ComboBox();
            this.label237 = new System.Windows.Forms.Label();
            this.feedback39 = new System.Windows.Forms.ComboBox();
            this.label240 = new System.Windows.Forms.Label();
            this.step39Job = new System.Windows.Forms.ComboBox();
            this.label241 = new System.Windows.Forms.Label();
            this.label242 = new System.Windows.Forms.Label();
            this.isim40 = new System.Windows.Forms.TextBox();
            this.label245 = new System.Windows.Forms.Label();
            this.gorev40 = new System.Windows.Forms.TextBox();
            this.label246 = new System.Windows.Forms.Label();
            this.kontrol40 = new System.Windows.Forms.TextBox();
            this.veri40 = new System.Windows.Forms.ComboBox();
            this.COM40 = new System.Windows.Forms.ComboBox();
            this.label247 = new System.Windows.Forms.Label();
            this.feedback40 = new System.Windows.Forms.ComboBox();
            this.label250 = new System.Windows.Forms.Label();
            this.step40Job = new System.Windows.Forms.ComboBox();
            this.label251 = new System.Windows.Forms.Label();
            this.label252 = new System.Windows.Forms.Label();
            this.label283 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stepNum
            // 
            this.stepNum.FormattingEnabled = true;
            this.stepNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.stepNum.Location = new System.Drawing.Point(78, 20);
            this.stepNum.Name = "stepNum";
            this.stepNum.Size = new System.Drawing.Size(58, 23);
            this.stepNum.TabIndex = 2;
            this.stepNum.SelectedIndexChanged += new System.EventHandler(this.stepNum_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 17);
            this.label30.TabIndex = 1;
            this.label30.Text = "Adım";
            // 
            // step1Job
            // 
            this.step1Job.FormattingEnabled = true;
            this.step1Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step1Job.Location = new System.Drawing.Point(78, 140);
            this.step1Job.Name = "step1Job";
            this.step1Job.Size = new System.Drawing.Size(58, 23);
            this.step1Job.TabIndex = 16;
            this.step1Job.SelectedIndexChanged += new System.EventHandler(this.step1Job_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Step1:";
            // 
            // step2Job
            // 
            this.step2Job.FormattingEnabled = true;
            this.step2Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step2Job.Location = new System.Drawing.Point(78, 175);
            this.step2Job.Name = "step2Job";
            this.step2Job.Size = new System.Drawing.Size(58, 23);
            this.step2Job.TabIndex = 18;
            this.step2Job.SelectedIndexChanged += new System.EventHandler(this.step2Job_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Step2:";
            // 
            // step4Job
            // 
            this.step4Job.FormattingEnabled = true;
            this.step4Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step4Job.Location = new System.Drawing.Point(78, 245);
            this.step4Job.Name = "step4Job";
            this.step4Job.Size = new System.Drawing.Size(58, 23);
            this.step4Job.TabIndex = 22;
            this.step4Job.SelectedIndexChanged += new System.EventHandler(this.step4Job_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Step4:";
            // 
            // step3Job
            // 
            this.step3Job.FormattingEnabled = true;
            this.step3Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step3Job.Location = new System.Drawing.Point(78, 210);
            this.step3Job.Name = "step3Job";
            this.step3Job.Size = new System.Drawing.Size(58, 23);
            this.step3Job.TabIndex = 20;
            this.step3Job.SelectedIndexChanged += new System.EventHandler(this.step3Job_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Step3:";
            // 
            // step5Job
            // 
            this.step5Job.FormattingEnabled = true;
            this.step5Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step5Job.Location = new System.Drawing.Point(78, 280);
            this.step5Job.Name = "step5Job";
            this.step5Job.Size = new System.Drawing.Size(58, 23);
            this.step5Job.TabIndex = 24;
            this.step5Job.SelectedIndexChanged += new System.EventHandler(this.step5Job_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "Step5:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(747, 282);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Feedback5:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(747, 247);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "Feedback4:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(747, 212);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(72, 17);
            this.label40.TabIndex = 29;
            this.label40.Text = "Feedback3:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(747, 177);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 17);
            this.label41.TabIndex = 27;
            this.label41.Text = "Feedback2:";
            // 
            // feedback1
            // 
            this.feedback1.FormattingEnabled = true;
            this.feedback1.Location = new System.Drawing.Point(842, 140);
            this.feedback1.Name = "feedback1";
            this.feedback1.Size = new System.Drawing.Size(167, 23);
            this.feedback1.TabIndex = 26;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(747, 142);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(72, 17);
            this.label42.TabIndex = 25;
            this.label42.Text = "Feedback1:";
            // 
            // feedback5
            // 
            this.feedback5.FormattingEnabled = true;
            this.feedback5.Items.AddRange(new object[] {
            ""});
            this.feedback5.Location = new System.Drawing.Point(842, 280);
            this.feedback5.Name = "feedback5";
            this.feedback5.Size = new System.Drawing.Size(167, 23);
            this.feedback5.TabIndex = 34;
            // 
            // feedback4
            // 
            this.feedback4.FormattingEnabled = true;
            this.feedback4.Location = new System.Drawing.Point(842, 245);
            this.feedback4.Name = "feedback4";
            this.feedback4.Size = new System.Drawing.Size(167, 23);
            this.feedback4.TabIndex = 32;
            // 
            // feedback3
            // 
            this.feedback3.FormattingEnabled = true;
            this.feedback3.Items.AddRange(new object[] {
            ""});
            this.feedback3.Location = new System.Drawing.Point(842, 210);
            this.feedback3.Name = "feedback3";
            this.feedback3.Size = new System.Drawing.Size(167, 23);
            this.feedback3.TabIndex = 30;
            // 
            // feedback2
            // 
            this.feedback2.FormattingEnabled = true;
            this.feedback2.Location = new System.Drawing.Point(842, 175);
            this.feedback2.Name = "feedback2";
            this.feedback2.Size = new System.Drawing.Size(167, 23);
            this.feedback2.TabIndex = 28;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(210, 17);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(174, 80);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kurulumu Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // COM5
            // 
            this.COM5.FormattingEnabled = true;
            this.COM5.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM5.Location = new System.Drawing.Point(689, 280);
            this.COM5.Name = "COM5";
            this.COM5.Size = new System.Drawing.Size(52, 23);
            this.COM5.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "COM:";
            // 
            // COM4
            // 
            this.COM4.FormattingEnabled = true;
            this.COM4.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM4.Location = new System.Drawing.Point(689, 245);
            this.COM4.Name = "COM4";
            this.COM4.Size = new System.Drawing.Size(52, 23);
            this.COM4.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "COM:";
            // 
            // COM3
            // 
            this.COM3.FormattingEnabled = true;
            this.COM3.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM3.Location = new System.Drawing.Point(689, 210);
            this.COM3.Name = "COM3";
            this.COM3.Size = new System.Drawing.Size(52, 23);
            this.COM3.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "COM:";
            // 
            // COM2
            // 
            this.COM2.FormattingEnabled = true;
            this.COM2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM2.Location = new System.Drawing.Point(689, 175);
            this.COM2.Name = "COM2";
            this.COM2.Size = new System.Drawing.Size(52, 23);
            this.COM2.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "COM:";
            // 
            // COM1
            // 
            this.COM1.FormattingEnabled = true;
            this.COM1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM1.Location = new System.Drawing.Point(689, 140);
            this.COM1.Name = "COM1";
            this.COM1.Size = new System.Drawing.Size(52, 23);
            this.COM1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "COM:";
            // 
            // veri5
            // 
            this.veri5.FormattingEnabled = true;
            this.veri5.Items.AddRange(new object[] {
            ""});
            this.veri5.Location = new System.Drawing.Point(447, 280);
            this.veri5.Name = "veri5";
            this.veri5.Size = new System.Drawing.Size(185, 23);
            this.veri5.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Veri5:";
            // 
            // veri4
            // 
            this.veri4.FormattingEnabled = true;
            this.veri4.Location = new System.Drawing.Point(447, 245);
            this.veri4.Name = "veri4";
            this.veri4.Size = new System.Drawing.Size(185, 23);
            this.veri4.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Veri4:";
            // 
            // veri3
            // 
            this.veri3.FormattingEnabled = true;
            this.veri3.Items.AddRange(new object[] {
            ""});
            this.veri3.Location = new System.Drawing.Point(447, 210);
            this.veri3.Name = "veri3";
            this.veri3.Size = new System.Drawing.Size(185, 23);
            this.veri3.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Veri3:";
            // 
            // veri2
            // 
            this.veri2.FormattingEnabled = true;
            this.veri2.Location = new System.Drawing.Point(447, 175);
            this.veri2.Name = "veri2";
            this.veri2.Size = new System.Drawing.Size(185, 23);
            this.veri2.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Veri2:";
            // 
            // veri1
            // 
            this.veri1.FormattingEnabled = true;
            this.veri1.Location = new System.Drawing.Point(447, 140);
            this.veri1.Name = "veri1";
            this.veri1.Size = new System.Drawing.Size(185, 23);
            this.veri1.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Veri1:";
            // 
            // kontrol1
            // 
            this.kontrol1.Location = new System.Drawing.Point(1103, 140);
            this.kontrol1.Name = "kontrol1";
            this.kontrol1.Size = new System.Drawing.Size(100, 24);
            this.kontrol1.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1021, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Kontrol1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1021, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "Kontrol2:";
            // 
            // kontrol2
            // 
            this.kontrol2.Location = new System.Drawing.Point(1103, 175);
            this.kontrol2.Name = "kontrol2";
            this.kontrol2.Size = new System.Drawing.Size(100, 24);
            this.kontrol2.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1021, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 17);
            this.label20.TabIndex = 60;
            this.label20.Text = "Kontrol3:";
            // 
            // kontrol3
            // 
            this.kontrol3.Location = new System.Drawing.Point(1103, 210);
            this.kontrol3.Name = "kontrol3";
            this.kontrol3.Size = new System.Drawing.Size(100, 24);
            this.kontrol3.TabIndex = 59;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1021, 247);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 17);
            this.label21.TabIndex = 62;
            this.label21.Text = "Kontrol4:";
            // 
            // kontrol4
            // 
            this.kontrol4.Location = new System.Drawing.Point(1103, 245);
            this.kontrol4.Name = "kontrol4";
            this.kontrol4.Size = new System.Drawing.Size(100, 24);
            this.kontrol4.TabIndex = 61;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1021, 282);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 17);
            this.label22.TabIndex = 64;
            this.label22.Text = "Kontrol5:";
            // 
            // kontrol5
            // 
            this.kontrol5.Location = new System.Drawing.Point(1103, 280);
            this.kontrol5.Name = "kontrol5";
            this.kontrol5.Size = new System.Drawing.Size(100, 24);
            this.kontrol5.TabIndex = 63;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1209, 282);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 17);
            this.label23.TabIndex = 74;
            this.label23.Text = "Görev5:";
            // 
            // gorev5
            // 
            this.gorev5.Location = new System.Drawing.Point(1281, 280);
            this.gorev5.Name = "gorev5";
            this.gorev5.Size = new System.Drawing.Size(100, 24);
            this.gorev5.TabIndex = 73;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1209, 247);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 17);
            this.label24.TabIndex = 72;
            this.label24.Text = "Görev4:";
            // 
            // gorev4
            // 
            this.gorev4.Location = new System.Drawing.Point(1281, 245);
            this.gorev4.Name = "gorev4";
            this.gorev4.Size = new System.Drawing.Size(100, 24);
            this.gorev4.TabIndex = 71;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1209, 212);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 17);
            this.label25.TabIndex = 70;
            this.label25.Text = "Görev3:";
            // 
            // gorev3
            // 
            this.gorev3.Location = new System.Drawing.Point(1280, 210);
            this.gorev3.Name = "gorev3";
            this.gorev3.Size = new System.Drawing.Size(100, 24);
            this.gorev3.TabIndex = 69;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1209, 177);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 17);
            this.label26.TabIndex = 68;
            this.label26.Text = "Görev2:";
            // 
            // gorev2
            // 
            this.gorev2.Location = new System.Drawing.Point(1281, 175);
            this.gorev2.Name = "gorev2";
            this.gorev2.Size = new System.Drawing.Size(100, 24);
            this.gorev2.TabIndex = 67;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1209, 142);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 17);
            this.label27.TabIndex = 66;
            this.label27.Text = "Görev1:";
            // 
            // gorev1
            // 
            this.gorev1.Location = new System.Drawing.Point(1281, 140);
            this.gorev1.Name = "gorev1";
            this.gorev1.Size = new System.Drawing.Size(100, 24);
            this.gorev1.TabIndex = 65;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 34);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 17);
            this.label28.TabIndex = 75;
            this.label28.Text = "Sayısı:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(151, 282);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 17);
            this.label29.TabIndex = 85;
            this.label29.Text = "İsim5:";
            // 
            // isim5
            // 
            this.isim5.Location = new System.Drawing.Point(210, 280);
            this.isim5.Name = "isim5";
            this.isim5.Size = new System.Drawing.Size(174, 24);
            this.isim5.TabIndex = 84;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(151, 247);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 17);
            this.label31.TabIndex = 83;
            this.label31.Text = "İsim4:";
            // 
            // isim4
            // 
            this.isim4.Location = new System.Drawing.Point(210, 245);
            this.isim4.Name = "isim4";
            this.isim4.Size = new System.Drawing.Size(174, 24);
            this.isim4.TabIndex = 82;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(151, 212);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 17);
            this.label32.TabIndex = 81;
            this.label32.Text = "İsim3:";
            // 
            // isim3
            // 
            this.isim3.Location = new System.Drawing.Point(210, 210);
            this.isim3.Name = "isim3";
            this.isim3.Size = new System.Drawing.Size(174, 24);
            this.isim3.TabIndex = 80;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(151, 177);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 17);
            this.label33.TabIndex = 79;
            this.label33.Text = "İsim2:";
            // 
            // isim2
            // 
            this.isim2.Location = new System.Drawing.Point(210, 175);
            this.isim2.Name = "isim2";
            this.isim2.Size = new System.Drawing.Size(174, 24);
            this.isim2.TabIndex = 78;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(151, 142);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 17);
            this.label34.TabIndex = 77;
            this.label34.Text = "İsim1:";
            // 
            // isim1
            // 
            this.isim1.Location = new System.Drawing.Point(210, 140);
            this.isim1.Name = "isim1";
            this.isim1.Size = new System.Drawing.Size(174, 24);
            this.isim1.TabIndex = 76;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(151, 457);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 17);
            this.label35.TabIndex = 155;
            this.label35.Text = "İsim10:";
            // 
            // isim10
            // 
            this.isim10.Location = new System.Drawing.Point(210, 455);
            this.isim10.Name = "isim10";
            this.isim10.Size = new System.Drawing.Size(174, 24);
            this.isim10.TabIndex = 154;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(151, 422);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(42, 17);
            this.label36.TabIndex = 153;
            this.label36.Text = "İsim9:";
            // 
            // isim9
            // 
            this.isim9.Location = new System.Drawing.Point(210, 420);
            this.isim9.Name = "isim9";
            this.isim9.Size = new System.Drawing.Size(174, 24);
            this.isim9.TabIndex = 152;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(151, 387);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 17);
            this.label37.TabIndex = 151;
            this.label37.Text = "İsim8:";
            // 
            // isim8
            // 
            this.isim8.Location = new System.Drawing.Point(210, 385);
            this.isim8.Name = "isim8";
            this.isim8.Size = new System.Drawing.Size(174, 24);
            this.isim8.TabIndex = 150;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(151, 352);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(42, 17);
            this.label38.TabIndex = 149;
            this.label38.Text = "İsim7:";
            // 
            // isim7
            // 
            this.isim7.Location = new System.Drawing.Point(210, 350);
            this.isim7.Name = "isim7";
            this.isim7.Size = new System.Drawing.Size(174, 24);
            this.isim7.TabIndex = 148;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(151, 317);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(42, 17);
            this.label39.TabIndex = 147;
            this.label39.Text = "İsim6:";
            // 
            // isim6
            // 
            this.isim6.Location = new System.Drawing.Point(210, 315);
            this.isim6.Name = "isim6";
            this.isim6.Size = new System.Drawing.Size(174, 24);
            this.isim6.TabIndex = 146;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(1209, 457);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(60, 17);
            this.label43.TabIndex = 145;
            this.label43.Text = "Görev10:";
            // 
            // gorev10
            // 
            this.gorev10.Location = new System.Drawing.Point(1281, 455);
            this.gorev10.Name = "gorev10";
            this.gorev10.Size = new System.Drawing.Size(100, 24);
            this.gorev10.TabIndex = 144;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1209, 422);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(53, 17);
            this.label44.TabIndex = 143;
            this.label44.Text = "Görev9:";
            // 
            // gorev9
            // 
            this.gorev9.Location = new System.Drawing.Point(1281, 420);
            this.gorev9.Name = "gorev9";
            this.gorev9.Size = new System.Drawing.Size(100, 24);
            this.gorev9.TabIndex = 142;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1209, 387);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 17);
            this.label45.TabIndex = 141;
            this.label45.Text = "Görev8:";
            // 
            // gorev8
            // 
            this.gorev8.Location = new System.Drawing.Point(1280, 385);
            this.gorev8.Name = "gorev8";
            this.gorev8.Size = new System.Drawing.Size(100, 24);
            this.gorev8.TabIndex = 140;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(1209, 352);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(53, 17);
            this.label46.TabIndex = 139;
            this.label46.Text = "Görev7:";
            // 
            // gorev7
            // 
            this.gorev7.Location = new System.Drawing.Point(1281, 350);
            this.gorev7.Name = "gorev7";
            this.gorev7.Size = new System.Drawing.Size(100, 24);
            this.gorev7.TabIndex = 138;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(1209, 317);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 17);
            this.label47.TabIndex = 137;
            this.label47.Text = "Görev6:";
            // 
            // gorev6
            // 
            this.gorev6.Location = new System.Drawing.Point(1281, 315);
            this.gorev6.Name = "gorev6";
            this.gorev6.Size = new System.Drawing.Size(100, 24);
            this.gorev6.TabIndex = 136;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(1021, 457);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(67, 17);
            this.label48.TabIndex = 135;
            this.label48.Text = "Kontrol10:";
            // 
            // kontrol10
            // 
            this.kontrol10.Location = new System.Drawing.Point(1103, 455);
            this.kontrol10.Name = "kontrol10";
            this.kontrol10.Size = new System.Drawing.Size(100, 24);
            this.kontrol10.TabIndex = 134;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(1021, 422);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 17);
            this.label49.TabIndex = 133;
            this.label49.Text = "Kontrol9:";
            // 
            // kontrol9
            // 
            this.kontrol9.Location = new System.Drawing.Point(1103, 420);
            this.kontrol9.Name = "kontrol9";
            this.kontrol9.Size = new System.Drawing.Size(100, 24);
            this.kontrol9.TabIndex = 132;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(1021, 387);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 17);
            this.label50.TabIndex = 131;
            this.label50.Text = "Kontrol8:";
            // 
            // kontrol8
            // 
            this.kontrol8.Location = new System.Drawing.Point(1103, 385);
            this.kontrol8.Name = "kontrol8";
            this.kontrol8.Size = new System.Drawing.Size(100, 24);
            this.kontrol8.TabIndex = 130;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(1021, 352);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(60, 17);
            this.label51.TabIndex = 129;
            this.label51.Text = "Kontrol7:";
            // 
            // kontrol7
            // 
            this.kontrol7.Location = new System.Drawing.Point(1103, 350);
            this.kontrol7.Name = "kontrol7";
            this.kontrol7.Size = new System.Drawing.Size(100, 24);
            this.kontrol7.TabIndex = 128;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(1021, 317);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(60, 17);
            this.label52.TabIndex = 127;
            this.label52.Text = "Kontrol6:";
            // 
            // kontrol6
            // 
            this.kontrol6.Location = new System.Drawing.Point(1103, 315);
            this.kontrol6.Name = "kontrol6";
            this.kontrol6.Size = new System.Drawing.Size(100, 24);
            this.kontrol6.TabIndex = 126;
            // 
            // veri10
            // 
            this.veri10.FormattingEnabled = true;
            this.veri10.Items.AddRange(new object[] {
            ""});
            this.veri10.Location = new System.Drawing.Point(447, 455);
            this.veri10.Name = "veri10";
            this.veri10.Size = new System.Drawing.Size(185, 23);
            this.veri10.TabIndex = 125;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(390, 457);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(48, 17);
            this.label53.TabIndex = 124;
            this.label53.Text = "Veri10:";
            // 
            // veri9
            // 
            this.veri9.FormattingEnabled = true;
            this.veri9.Location = new System.Drawing.Point(447, 420);
            this.veri9.Name = "veri9";
            this.veri9.Size = new System.Drawing.Size(185, 23);
            this.veri9.TabIndex = 123;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(390, 422);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 17);
            this.label54.TabIndex = 122;
            this.label54.Text = "Veri9:";
            // 
            // veri8
            // 
            this.veri8.FormattingEnabled = true;
            this.veri8.Items.AddRange(new object[] {
            ""});
            this.veri8.Location = new System.Drawing.Point(447, 385);
            this.veri8.Name = "veri8";
            this.veri8.Size = new System.Drawing.Size(185, 23);
            this.veri8.TabIndex = 121;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(390, 387);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(41, 17);
            this.label55.TabIndex = 120;
            this.label55.Text = "Veri8:";
            // 
            // veri7
            // 
            this.veri7.FormattingEnabled = true;
            this.veri7.Location = new System.Drawing.Point(447, 350);
            this.veri7.Name = "veri7";
            this.veri7.Size = new System.Drawing.Size(185, 23);
            this.veri7.TabIndex = 119;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(390, 352);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(41, 17);
            this.label56.TabIndex = 118;
            this.label56.Text = "Veri7:";
            // 
            // veri6
            // 
            this.veri6.FormattingEnabled = true;
            this.veri6.Location = new System.Drawing.Point(447, 315);
            this.veri6.Name = "veri6";
            this.veri6.Size = new System.Drawing.Size(185, 23);
            this.veri6.TabIndex = 117;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(390, 317);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(41, 17);
            this.label57.TabIndex = 116;
            this.label57.Text = "Veri6:";
            // 
            // COM10
            // 
            this.COM10.FormattingEnabled = true;
            this.COM10.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM10.Location = new System.Drawing.Point(689, 455);
            this.COM10.Name = "COM10";
            this.COM10.Size = new System.Drawing.Size(52, 23);
            this.COM10.TabIndex = 115;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(638, 457);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(40, 17);
            this.label58.TabIndex = 114;
            this.label58.Text = "COM:";
            // 
            // COM9
            // 
            this.COM9.FormattingEnabled = true;
            this.COM9.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM9.Location = new System.Drawing.Point(689, 420);
            this.COM9.Name = "COM9";
            this.COM9.Size = new System.Drawing.Size(52, 23);
            this.COM9.TabIndex = 113;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(638, 422);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(40, 17);
            this.label59.TabIndex = 112;
            this.label59.Text = "COM:";
            // 
            // COM8
            // 
            this.COM8.FormattingEnabled = true;
            this.COM8.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM8.Location = new System.Drawing.Point(689, 385);
            this.COM8.Name = "COM8";
            this.COM8.Size = new System.Drawing.Size(52, 23);
            this.COM8.TabIndex = 111;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(638, 387);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(40, 17);
            this.label60.TabIndex = 110;
            this.label60.Text = "COM:";
            // 
            // COM7
            // 
            this.COM7.FormattingEnabled = true;
            this.COM7.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM7.Location = new System.Drawing.Point(689, 350);
            this.COM7.Name = "COM7";
            this.COM7.Size = new System.Drawing.Size(52, 23);
            this.COM7.TabIndex = 109;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(638, 352);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(40, 17);
            this.label61.TabIndex = 108;
            this.label61.Text = "COM:";
            // 
            // COM6
            // 
            this.COM6.FormattingEnabled = true;
            this.COM6.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM6.Location = new System.Drawing.Point(689, 315);
            this.COM6.Name = "COM6";
            this.COM6.Size = new System.Drawing.Size(52, 23);
            this.COM6.TabIndex = 107;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(638, 317);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(40, 17);
            this.label62.TabIndex = 106;
            this.label62.Text = "COM:";
            // 
            // feedback10
            // 
            this.feedback10.FormattingEnabled = true;
            this.feedback10.Items.AddRange(new object[] {
            ""});
            this.feedback10.Location = new System.Drawing.Point(842, 455);
            this.feedback10.Name = "feedback10";
            this.feedback10.Size = new System.Drawing.Size(167, 23);
            this.feedback10.TabIndex = 105;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(747, 457);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(79, 17);
            this.label63.TabIndex = 104;
            this.label63.Text = "Feedback10:";
            // 
            // feedback9
            // 
            this.feedback9.FormattingEnabled = true;
            this.feedback9.Location = new System.Drawing.Point(842, 420);
            this.feedback9.Name = "feedback9";
            this.feedback9.Size = new System.Drawing.Size(167, 23);
            this.feedback9.TabIndex = 103;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(747, 422);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(72, 17);
            this.label64.TabIndex = 102;
            this.label64.Text = "Feedback9:";
            // 
            // feedback8
            // 
            this.feedback8.FormattingEnabled = true;
            this.feedback8.Items.AddRange(new object[] {
            ""});
            this.feedback8.Location = new System.Drawing.Point(842, 385);
            this.feedback8.Name = "feedback8";
            this.feedback8.Size = new System.Drawing.Size(167, 23);
            this.feedback8.TabIndex = 101;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(747, 387);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(72, 17);
            this.label65.TabIndex = 100;
            this.label65.Text = "Feedback8:";
            // 
            // feedback7
            // 
            this.feedback7.FormattingEnabled = true;
            this.feedback7.Location = new System.Drawing.Point(842, 350);
            this.feedback7.Name = "feedback7";
            this.feedback7.Size = new System.Drawing.Size(167, 23);
            this.feedback7.TabIndex = 99;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(747, 352);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(72, 17);
            this.label66.TabIndex = 98;
            this.label66.Text = "Feedback7:";
            // 
            // feedback6
            // 
            this.feedback6.FormattingEnabled = true;
            this.feedback6.Location = new System.Drawing.Point(842, 315);
            this.feedback6.Name = "feedback6";
            this.feedback6.Size = new System.Drawing.Size(167, 23);
            this.feedback6.TabIndex = 97;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(747, 317);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(72, 17);
            this.label67.TabIndex = 96;
            this.label67.Text = "Feedback6:";
            // 
            // step10Job
            // 
            this.step10Job.FormattingEnabled = true;
            this.step10Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step10Job.Location = new System.Drawing.Point(78, 455);
            this.step10Job.Name = "step10Job";
            this.step10Job.Size = new System.Drawing.Size(58, 23);
            this.step10Job.TabIndex = 95;
            this.step10Job.SelectedIndexChanged += new System.EventHandler(this.step10Job_SelectedIndexChanged);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(17, 457);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(51, 17);
            this.label68.TabIndex = 94;
            this.label68.Text = "Step10:";
            // 
            // step9Job
            // 
            this.step9Job.FormattingEnabled = true;
            this.step9Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step9Job.Location = new System.Drawing.Point(78, 420);
            this.step9Job.Name = "step9Job";
            this.step9Job.Size = new System.Drawing.Size(58, 23);
            this.step9Job.TabIndex = 93;
            this.step9Job.SelectedIndexChanged += new System.EventHandler(this.step9Job_SelectedIndexChanged);
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(17, 422);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(44, 17);
            this.label69.TabIndex = 92;
            this.label69.Text = "Step9:";
            // 
            // step8Job
            // 
            this.step8Job.FormattingEnabled = true;
            this.step8Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step8Job.Location = new System.Drawing.Point(78, 385);
            this.step8Job.Name = "step8Job";
            this.step8Job.Size = new System.Drawing.Size(58, 23);
            this.step8Job.TabIndex = 91;
            this.step8Job.SelectedIndexChanged += new System.EventHandler(this.step8Job_SelectedIndexChanged);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(17, 387);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(44, 17);
            this.label70.TabIndex = 90;
            this.label70.Text = "Step8:";
            // 
            // step7Job
            // 
            this.step7Job.FormattingEnabled = true;
            this.step7Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step7Job.Location = new System.Drawing.Point(78, 350);
            this.step7Job.Name = "step7Job";
            this.step7Job.Size = new System.Drawing.Size(58, 23);
            this.step7Job.TabIndex = 89;
            this.step7Job.SelectedIndexChanged += new System.EventHandler(this.step7Job_SelectedIndexChanged);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(17, 352);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(44, 17);
            this.label71.TabIndex = 88;
            this.label71.Text = "Step7:";
            // 
            // step6Job
            // 
            this.step6Job.FormattingEnabled = true;
            this.step6Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step6Job.Location = new System.Drawing.Point(78, 315);
            this.step6Job.Name = "step6Job";
            this.step6Job.Size = new System.Drawing.Size(58, 23);
            this.step6Job.TabIndex = 87;
            this.step6Job.SelectedIndexChanged += new System.EventHandler(this.step6Job_SelectedIndexChanged);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(17, 317);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(44, 17);
            this.label72.TabIndex = 86;
            this.label72.Text = "Step6:";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(151, 807);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(49, 17);
            this.label73.TabIndex = 295;
            this.label73.Text = "İsim20:";
            // 
            // isim20
            // 
            this.isim20.Location = new System.Drawing.Point(210, 805);
            this.isim20.Name = "isim20";
            this.isim20.Size = new System.Drawing.Size(174, 24);
            this.isim20.TabIndex = 294;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(151, 772);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(49, 17);
            this.label74.TabIndex = 293;
            this.label74.Text = "İsim19:";
            // 
            // isim19
            // 
            this.isim19.Location = new System.Drawing.Point(210, 770);
            this.isim19.Name = "isim19";
            this.isim19.Size = new System.Drawing.Size(174, 24);
            this.isim19.TabIndex = 292;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(151, 737);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(49, 17);
            this.label75.TabIndex = 291;
            this.label75.Text = "İsim18:";
            // 
            // isim18
            // 
            this.isim18.Location = new System.Drawing.Point(210, 735);
            this.isim18.Name = "isim18";
            this.isim18.Size = new System.Drawing.Size(174, 24);
            this.isim18.TabIndex = 290;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(151, 702);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(49, 17);
            this.label76.TabIndex = 289;
            this.label76.Text = "İsim17:";
            // 
            // isim17
            // 
            this.isim17.Location = new System.Drawing.Point(210, 700);
            this.isim17.Name = "isim17";
            this.isim17.Size = new System.Drawing.Size(174, 24);
            this.isim17.TabIndex = 288;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(151, 667);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(49, 17);
            this.label77.TabIndex = 287;
            this.label77.Text = "İsim16:";
            // 
            // isim16
            // 
            this.isim16.Location = new System.Drawing.Point(210, 665);
            this.isim16.Name = "isim16";
            this.isim16.Size = new System.Drawing.Size(174, 24);
            this.isim16.TabIndex = 286;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(1209, 807);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(60, 17);
            this.label78.TabIndex = 285;
            this.label78.Text = "Görev20:";
            // 
            // gorev20
            // 
            this.gorev20.Location = new System.Drawing.Point(1281, 805);
            this.gorev20.Name = "gorev20";
            this.gorev20.Size = new System.Drawing.Size(100, 24);
            this.gorev20.TabIndex = 284;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(1209, 772);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(60, 17);
            this.label79.TabIndex = 283;
            this.label79.Text = "Görev19:";
            // 
            // gorev19
            // 
            this.gorev19.Location = new System.Drawing.Point(1281, 770);
            this.gorev19.Name = "gorev19";
            this.gorev19.Size = new System.Drawing.Size(100, 24);
            this.gorev19.TabIndex = 282;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(1209, 737);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(60, 17);
            this.label80.TabIndex = 281;
            this.label80.Text = "Görev18:";
            // 
            // gorev18
            // 
            this.gorev18.Location = new System.Drawing.Point(1280, 735);
            this.gorev18.Name = "gorev18";
            this.gorev18.Size = new System.Drawing.Size(100, 24);
            this.gorev18.TabIndex = 280;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(1209, 702);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(60, 17);
            this.label81.TabIndex = 279;
            this.label81.Text = "Görev17:";
            // 
            // gorev17
            // 
            this.gorev17.Location = new System.Drawing.Point(1281, 700);
            this.gorev17.Name = "gorev17";
            this.gorev17.Size = new System.Drawing.Size(100, 24);
            this.gorev17.TabIndex = 278;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(1209, 667);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(60, 17);
            this.label82.TabIndex = 277;
            this.label82.Text = "Görev16:";
            // 
            // gorev16
            // 
            this.gorev16.Location = new System.Drawing.Point(1281, 665);
            this.gorev16.Name = "gorev16";
            this.gorev16.Size = new System.Drawing.Size(100, 24);
            this.gorev16.TabIndex = 276;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(1021, 807);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(67, 17);
            this.label83.TabIndex = 275;
            this.label83.Text = "Kontrol20:";
            // 
            // kontrol20
            // 
            this.kontrol20.Location = new System.Drawing.Point(1103, 805);
            this.kontrol20.Name = "kontrol20";
            this.kontrol20.Size = new System.Drawing.Size(100, 24);
            this.kontrol20.TabIndex = 274;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(1021, 772);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(67, 17);
            this.label84.TabIndex = 273;
            this.label84.Text = "Kontrol19:";
            // 
            // kontrol19
            // 
            this.kontrol19.Location = new System.Drawing.Point(1103, 770);
            this.kontrol19.Name = "kontrol19";
            this.kontrol19.Size = new System.Drawing.Size(100, 24);
            this.kontrol19.TabIndex = 272;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(1021, 737);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(67, 17);
            this.label85.TabIndex = 271;
            this.label85.Text = "Kontrol18:";
            // 
            // kontrol18
            // 
            this.kontrol18.Location = new System.Drawing.Point(1103, 735);
            this.kontrol18.Name = "kontrol18";
            this.kontrol18.Size = new System.Drawing.Size(100, 24);
            this.kontrol18.TabIndex = 270;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(1021, 702);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(67, 17);
            this.label86.TabIndex = 269;
            this.label86.Text = "Kontrol17:";
            // 
            // kontrol17
            // 
            this.kontrol17.Location = new System.Drawing.Point(1103, 700);
            this.kontrol17.Name = "kontrol17";
            this.kontrol17.Size = new System.Drawing.Size(100, 24);
            this.kontrol17.TabIndex = 268;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(1021, 667);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(67, 17);
            this.label87.TabIndex = 267;
            this.label87.Text = "Kontrol16:";
            // 
            // kontrol16
            // 
            this.kontrol16.Location = new System.Drawing.Point(1103, 665);
            this.kontrol16.Name = "kontrol16";
            this.kontrol16.Size = new System.Drawing.Size(100, 24);
            this.kontrol16.TabIndex = 266;
            // 
            // veri20
            // 
            this.veri20.FormattingEnabled = true;
            this.veri20.Items.AddRange(new object[] {
            ""});
            this.veri20.Location = new System.Drawing.Point(447, 805);
            this.veri20.Name = "veri20";
            this.veri20.Size = new System.Drawing.Size(185, 23);
            this.veri20.TabIndex = 265;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(390, 807);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(48, 17);
            this.label88.TabIndex = 264;
            this.label88.Text = "Veri20:";
            // 
            // veri19
            // 
            this.veri19.FormattingEnabled = true;
            this.veri19.Location = new System.Drawing.Point(447, 770);
            this.veri19.Name = "veri19";
            this.veri19.Size = new System.Drawing.Size(185, 23);
            this.veri19.TabIndex = 263;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(390, 772);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(48, 17);
            this.label89.TabIndex = 262;
            this.label89.Text = "Veri19:";
            // 
            // veri18
            // 
            this.veri18.FormattingEnabled = true;
            this.veri18.Items.AddRange(new object[] {
            ""});
            this.veri18.Location = new System.Drawing.Point(447, 735);
            this.veri18.Name = "veri18";
            this.veri18.Size = new System.Drawing.Size(185, 23);
            this.veri18.TabIndex = 261;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(390, 737);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(48, 17);
            this.label90.TabIndex = 260;
            this.label90.Text = "Veri18:";
            // 
            // veri17
            // 
            this.veri17.FormattingEnabled = true;
            this.veri17.Location = new System.Drawing.Point(447, 700);
            this.veri17.Name = "veri17";
            this.veri17.Size = new System.Drawing.Size(185, 23);
            this.veri17.TabIndex = 259;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(390, 702);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(48, 17);
            this.label91.TabIndex = 258;
            this.label91.Text = "Veri17:";
            // 
            // veri16
            // 
            this.veri16.FormattingEnabled = true;
            this.veri16.Location = new System.Drawing.Point(447, 665);
            this.veri16.Name = "veri16";
            this.veri16.Size = new System.Drawing.Size(185, 23);
            this.veri16.TabIndex = 257;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(390, 667);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(48, 17);
            this.label92.TabIndex = 256;
            this.label92.Text = "Veri16:";
            // 
            // COM20
            // 
            this.COM20.FormattingEnabled = true;
            this.COM20.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM20.Location = new System.Drawing.Point(689, 805);
            this.COM20.Name = "COM20";
            this.COM20.Size = new System.Drawing.Size(52, 23);
            this.COM20.TabIndex = 255;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(638, 807);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(40, 17);
            this.label93.TabIndex = 254;
            this.label93.Text = "COM:";
            // 
            // COM19
            // 
            this.COM19.FormattingEnabled = true;
            this.COM19.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM19.Location = new System.Drawing.Point(689, 770);
            this.COM19.Name = "COM19";
            this.COM19.Size = new System.Drawing.Size(52, 23);
            this.COM19.TabIndex = 253;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(638, 772);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(40, 17);
            this.label94.TabIndex = 252;
            this.label94.Text = "COM:";
            // 
            // COM18
            // 
            this.COM18.FormattingEnabled = true;
            this.COM18.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM18.Location = new System.Drawing.Point(689, 735);
            this.COM18.Name = "COM18";
            this.COM18.Size = new System.Drawing.Size(52, 23);
            this.COM18.TabIndex = 251;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(638, 737);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(40, 17);
            this.label95.TabIndex = 250;
            this.label95.Text = "COM:";
            // 
            // COM17
            // 
            this.COM17.FormattingEnabled = true;
            this.COM17.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM17.Location = new System.Drawing.Point(689, 700);
            this.COM17.Name = "COM17";
            this.COM17.Size = new System.Drawing.Size(52, 23);
            this.COM17.TabIndex = 249;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(638, 702);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(40, 17);
            this.label96.TabIndex = 248;
            this.label96.Text = "COM:";
            // 
            // COM16
            // 
            this.COM16.FormattingEnabled = true;
            this.COM16.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM16.Location = new System.Drawing.Point(689, 665);
            this.COM16.Name = "COM16";
            this.COM16.Size = new System.Drawing.Size(52, 23);
            this.COM16.TabIndex = 247;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(638, 667);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(40, 17);
            this.label97.TabIndex = 246;
            this.label97.Text = "COM:";
            // 
            // feedback20
            // 
            this.feedback20.FormattingEnabled = true;
            this.feedback20.Items.AddRange(new object[] {
            ""});
            this.feedback20.Location = new System.Drawing.Point(842, 805);
            this.feedback20.Name = "feedback20";
            this.feedback20.Size = new System.Drawing.Size(167, 23);
            this.feedback20.TabIndex = 245;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(747, 807);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(79, 17);
            this.label98.TabIndex = 244;
            this.label98.Text = "Feedback20:";
            // 
            // feedback19
            // 
            this.feedback19.FormattingEnabled = true;
            this.feedback19.Location = new System.Drawing.Point(842, 770);
            this.feedback19.Name = "feedback19";
            this.feedback19.Size = new System.Drawing.Size(167, 23);
            this.feedback19.TabIndex = 243;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(747, 772);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(79, 17);
            this.label99.TabIndex = 242;
            this.label99.Text = "Feedback19:";
            // 
            // feedback18
            // 
            this.feedback18.FormattingEnabled = true;
            this.feedback18.Items.AddRange(new object[] {
            ""});
            this.feedback18.Location = new System.Drawing.Point(842, 735);
            this.feedback18.Name = "feedback18";
            this.feedback18.Size = new System.Drawing.Size(167, 23);
            this.feedback18.TabIndex = 241;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(747, 737);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(79, 17);
            this.label100.TabIndex = 240;
            this.label100.Text = "Feedback18:";
            // 
            // feedback17
            // 
            this.feedback17.FormattingEnabled = true;
            this.feedback17.Location = new System.Drawing.Point(842, 700);
            this.feedback17.Name = "feedback17";
            this.feedback17.Size = new System.Drawing.Size(167, 23);
            this.feedback17.TabIndex = 239;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(747, 702);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(79, 17);
            this.label101.TabIndex = 238;
            this.label101.Text = "Feedback17:";
            // 
            // feedback16
            // 
            this.feedback16.FormattingEnabled = true;
            this.feedback16.Location = new System.Drawing.Point(842, 665);
            this.feedback16.Name = "feedback16";
            this.feedback16.Size = new System.Drawing.Size(167, 23);
            this.feedback16.TabIndex = 237;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(747, 667);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(79, 17);
            this.label102.TabIndex = 236;
            this.label102.Text = "Feedback16:";
            // 
            // step20Job
            // 
            this.step20Job.FormattingEnabled = true;
            this.step20Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step20Job.Location = new System.Drawing.Point(78, 805);
            this.step20Job.Name = "step20Job";
            this.step20Job.Size = new System.Drawing.Size(58, 23);
            this.step20Job.TabIndex = 235;
            this.step20Job.SelectedIndexChanged += new System.EventHandler(this.step20Job_SelectedIndexChanged);
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(17, 807);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(51, 17);
            this.label103.TabIndex = 234;
            this.label103.Text = "Step20:";
            // 
            // step19Job
            // 
            this.step19Job.FormattingEnabled = true;
            this.step19Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step19Job.Location = new System.Drawing.Point(78, 770);
            this.step19Job.Name = "step19Job";
            this.step19Job.Size = new System.Drawing.Size(58, 23);
            this.step19Job.TabIndex = 233;
            this.step19Job.SelectedIndexChanged += new System.EventHandler(this.step19Job_SelectedIndexChanged);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(17, 772);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(51, 17);
            this.label104.TabIndex = 232;
            this.label104.Text = "Step19:";
            // 
            // step18Job
            // 
            this.step18Job.FormattingEnabled = true;
            this.step18Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step18Job.Location = new System.Drawing.Point(78, 735);
            this.step18Job.Name = "step18Job";
            this.step18Job.Size = new System.Drawing.Size(58, 23);
            this.step18Job.TabIndex = 231;
            this.step18Job.SelectedIndexChanged += new System.EventHandler(this.step18Job_SelectedIndexChanged);
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(17, 737);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(51, 17);
            this.label105.TabIndex = 230;
            this.label105.Text = "Step18:";
            // 
            // step17Job
            // 
            this.step17Job.FormattingEnabled = true;
            this.step17Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step17Job.Location = new System.Drawing.Point(78, 700);
            this.step17Job.Name = "step17Job";
            this.step17Job.Size = new System.Drawing.Size(58, 23);
            this.step17Job.TabIndex = 229;
            this.step17Job.SelectedIndexChanged += new System.EventHandler(this.step17Job_SelectedIndexChanged);
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(17, 702);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(51, 17);
            this.label106.TabIndex = 228;
            this.label106.Text = "Step17:";
            // 
            // step16Job
            // 
            this.step16Job.FormattingEnabled = true;
            this.step16Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step16Job.Location = new System.Drawing.Point(78, 665);
            this.step16Job.Name = "step16Job";
            this.step16Job.Size = new System.Drawing.Size(58, 23);
            this.step16Job.TabIndex = 227;
            this.step16Job.SelectedIndexChanged += new System.EventHandler(this.step16Job_SelectedIndexChanged);
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(17, 667);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(51, 17);
            this.label107.TabIndex = 226;
            this.label107.Text = "Step16:";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(151, 632);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(49, 17);
            this.label108.TabIndex = 225;
            this.label108.Text = "İsim15:";
            // 
            // isim15
            // 
            this.isim15.Location = new System.Drawing.Point(210, 630);
            this.isim15.Name = "isim15";
            this.isim15.Size = new System.Drawing.Size(174, 24);
            this.isim15.TabIndex = 224;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(151, 597);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(49, 17);
            this.label109.TabIndex = 223;
            this.label109.Text = "İsim14:";
            // 
            // isim14
            // 
            this.isim14.Location = new System.Drawing.Point(210, 595);
            this.isim14.Name = "isim14";
            this.isim14.Size = new System.Drawing.Size(174, 24);
            this.isim14.TabIndex = 222;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(151, 562);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(49, 17);
            this.label110.TabIndex = 221;
            this.label110.Text = "İsim13:";
            // 
            // isim13
            // 
            this.isim13.Location = new System.Drawing.Point(210, 560);
            this.isim13.Name = "isim13";
            this.isim13.Size = new System.Drawing.Size(174, 24);
            this.isim13.TabIndex = 220;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(151, 527);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(49, 17);
            this.label111.TabIndex = 219;
            this.label111.Text = "İsim12:";
            // 
            // isim12
            // 
            this.isim12.Location = new System.Drawing.Point(210, 525);
            this.isim12.Name = "isim12";
            this.isim12.Size = new System.Drawing.Size(174, 24);
            this.isim12.TabIndex = 218;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(151, 492);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(49, 17);
            this.label112.TabIndex = 217;
            this.label112.Text = "İsim11:";
            // 
            // isim11
            // 
            this.isim11.Location = new System.Drawing.Point(210, 490);
            this.isim11.Name = "isim11";
            this.isim11.Size = new System.Drawing.Size(174, 24);
            this.isim11.TabIndex = 216;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(1209, 632);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(60, 17);
            this.label113.TabIndex = 215;
            this.label113.Text = "Görev15:";
            // 
            // gorev15
            // 
            this.gorev15.Location = new System.Drawing.Point(1281, 630);
            this.gorev15.Name = "gorev15";
            this.gorev15.Size = new System.Drawing.Size(100, 24);
            this.gorev15.TabIndex = 214;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(1209, 597);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(60, 17);
            this.label114.TabIndex = 213;
            this.label114.Text = "Görev14:";
            // 
            // gorev14
            // 
            this.gorev14.Location = new System.Drawing.Point(1281, 595);
            this.gorev14.Name = "gorev14";
            this.gorev14.Size = new System.Drawing.Size(100, 24);
            this.gorev14.TabIndex = 212;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(1209, 562);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(60, 17);
            this.label115.TabIndex = 211;
            this.label115.Text = "Görev13:";
            // 
            // gorev13
            // 
            this.gorev13.Location = new System.Drawing.Point(1280, 560);
            this.gorev13.Name = "gorev13";
            this.gorev13.Size = new System.Drawing.Size(100, 24);
            this.gorev13.TabIndex = 210;
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(1209, 527);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(60, 17);
            this.label116.TabIndex = 209;
            this.label116.Text = "Görev12:";
            // 
            // gorev12
            // 
            this.gorev12.Location = new System.Drawing.Point(1281, 525);
            this.gorev12.Name = "gorev12";
            this.gorev12.Size = new System.Drawing.Size(100, 24);
            this.gorev12.TabIndex = 208;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(1209, 492);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(60, 17);
            this.label117.TabIndex = 207;
            this.label117.Text = "Görev11:";
            // 
            // gorev11
            // 
            this.gorev11.Location = new System.Drawing.Point(1281, 490);
            this.gorev11.Name = "gorev11";
            this.gorev11.Size = new System.Drawing.Size(100, 24);
            this.gorev11.TabIndex = 206;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(1021, 632);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(67, 17);
            this.label118.TabIndex = 205;
            this.label118.Text = "Kontrol15:";
            // 
            // kontrol15
            // 
            this.kontrol15.Location = new System.Drawing.Point(1103, 630);
            this.kontrol15.Name = "kontrol15";
            this.kontrol15.Size = new System.Drawing.Size(100, 24);
            this.kontrol15.TabIndex = 204;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(1021, 597);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(67, 17);
            this.label119.TabIndex = 203;
            this.label119.Text = "Kontrol14:";
            // 
            // kontrol14
            // 
            this.kontrol14.Location = new System.Drawing.Point(1103, 595);
            this.kontrol14.Name = "kontrol14";
            this.kontrol14.Size = new System.Drawing.Size(100, 24);
            this.kontrol14.TabIndex = 202;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(1021, 562);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(67, 17);
            this.label120.TabIndex = 201;
            this.label120.Text = "Kontrol13:";
            // 
            // kontrol13
            // 
            this.kontrol13.Location = new System.Drawing.Point(1103, 560);
            this.kontrol13.Name = "kontrol13";
            this.kontrol13.Size = new System.Drawing.Size(100, 24);
            this.kontrol13.TabIndex = 200;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(1021, 527);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(67, 17);
            this.label121.TabIndex = 199;
            this.label121.Text = "Kontrol12:";
            // 
            // kontrol12
            // 
            this.kontrol12.Location = new System.Drawing.Point(1103, 525);
            this.kontrol12.Name = "kontrol12";
            this.kontrol12.Size = new System.Drawing.Size(100, 24);
            this.kontrol12.TabIndex = 198;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(1021, 492);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(67, 17);
            this.label122.TabIndex = 197;
            this.label122.Text = "Kontrol11:";
            // 
            // kontrol11
            // 
            this.kontrol11.Location = new System.Drawing.Point(1103, 490);
            this.kontrol11.Name = "kontrol11";
            this.kontrol11.Size = new System.Drawing.Size(100, 24);
            this.kontrol11.TabIndex = 196;
            // 
            // veri15
            // 
            this.veri15.FormattingEnabled = true;
            this.veri15.Items.AddRange(new object[] {
            ""});
            this.veri15.Location = new System.Drawing.Point(447, 630);
            this.veri15.Name = "veri15";
            this.veri15.Size = new System.Drawing.Size(185, 23);
            this.veri15.TabIndex = 195;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(390, 632);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(48, 17);
            this.label123.TabIndex = 194;
            this.label123.Text = "Veri15:";
            // 
            // veri14
            // 
            this.veri14.FormattingEnabled = true;
            this.veri14.Location = new System.Drawing.Point(447, 595);
            this.veri14.Name = "veri14";
            this.veri14.Size = new System.Drawing.Size(185, 23);
            this.veri14.TabIndex = 193;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(390, 597);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(48, 17);
            this.label124.TabIndex = 192;
            this.label124.Text = "Veri14:";
            // 
            // veri13
            // 
            this.veri13.FormattingEnabled = true;
            this.veri13.Items.AddRange(new object[] {
            ""});
            this.veri13.Location = new System.Drawing.Point(447, 560);
            this.veri13.Name = "veri13";
            this.veri13.Size = new System.Drawing.Size(185, 23);
            this.veri13.TabIndex = 191;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(390, 562);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(48, 17);
            this.label125.TabIndex = 190;
            this.label125.Text = "Veri13:";
            // 
            // veri12
            // 
            this.veri12.FormattingEnabled = true;
            this.veri12.Location = new System.Drawing.Point(447, 525);
            this.veri12.Name = "veri12";
            this.veri12.Size = new System.Drawing.Size(185, 23);
            this.veri12.TabIndex = 189;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(390, 527);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(48, 17);
            this.label126.TabIndex = 188;
            this.label126.Text = "Veri12:";
            // 
            // veri11
            // 
            this.veri11.FormattingEnabled = true;
            this.veri11.Location = new System.Drawing.Point(447, 490);
            this.veri11.Name = "veri11";
            this.veri11.Size = new System.Drawing.Size(185, 23);
            this.veri11.TabIndex = 187;
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(390, 492);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(48, 17);
            this.label127.TabIndex = 186;
            this.label127.Text = "Veri11:";
            // 
            // COM15
            // 
            this.COM15.FormattingEnabled = true;
            this.COM15.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM15.Location = new System.Drawing.Point(689, 630);
            this.COM15.Name = "COM15";
            this.COM15.Size = new System.Drawing.Size(52, 23);
            this.COM15.TabIndex = 185;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(638, 632);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(40, 17);
            this.label128.TabIndex = 184;
            this.label128.Text = "COM:";
            // 
            // COM14
            // 
            this.COM14.FormattingEnabled = true;
            this.COM14.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM14.Location = new System.Drawing.Point(689, 595);
            this.COM14.Name = "COM14";
            this.COM14.Size = new System.Drawing.Size(52, 23);
            this.COM14.TabIndex = 183;
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(638, 597);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(40, 17);
            this.label129.TabIndex = 182;
            this.label129.Text = "COM:";
            // 
            // COM13
            // 
            this.COM13.FormattingEnabled = true;
            this.COM13.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM13.Location = new System.Drawing.Point(689, 560);
            this.COM13.Name = "COM13";
            this.COM13.Size = new System.Drawing.Size(52, 23);
            this.COM13.TabIndex = 181;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(638, 562);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(40, 17);
            this.label130.TabIndex = 180;
            this.label130.Text = "COM:";
            // 
            // COM12
            // 
            this.COM12.FormattingEnabled = true;
            this.COM12.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM12.Location = new System.Drawing.Point(689, 525);
            this.COM12.Name = "COM12";
            this.COM12.Size = new System.Drawing.Size(52, 23);
            this.COM12.TabIndex = 179;
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(638, 527);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(40, 17);
            this.label131.TabIndex = 178;
            this.label131.Text = "COM:";
            // 
            // COM11
            // 
            this.COM11.FormattingEnabled = true;
            this.COM11.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM11.Location = new System.Drawing.Point(689, 490);
            this.COM11.Name = "COM11";
            this.COM11.Size = new System.Drawing.Size(52, 23);
            this.COM11.TabIndex = 177;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(638, 492);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(40, 17);
            this.label132.TabIndex = 176;
            this.label132.Text = "COM:";
            // 
            // feedback15
            // 
            this.feedback15.FormattingEnabled = true;
            this.feedback15.Items.AddRange(new object[] {
            ""});
            this.feedback15.Location = new System.Drawing.Point(842, 630);
            this.feedback15.Name = "feedback15";
            this.feedback15.Size = new System.Drawing.Size(167, 23);
            this.feedback15.TabIndex = 175;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(747, 632);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(79, 17);
            this.label133.TabIndex = 174;
            this.label133.Text = "Feedback15:";
            // 
            // feedback14
            // 
            this.feedback14.FormattingEnabled = true;
            this.feedback14.Location = new System.Drawing.Point(842, 595);
            this.feedback14.Name = "feedback14";
            this.feedback14.Size = new System.Drawing.Size(167, 23);
            this.feedback14.TabIndex = 173;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(747, 597);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(79, 17);
            this.label134.TabIndex = 172;
            this.label134.Text = "Feedback14:";
            // 
            // feedback13
            // 
            this.feedback13.FormattingEnabled = true;
            this.feedback13.Items.AddRange(new object[] {
            ""});
            this.feedback13.Location = new System.Drawing.Point(842, 560);
            this.feedback13.Name = "feedback13";
            this.feedback13.Size = new System.Drawing.Size(167, 23);
            this.feedback13.TabIndex = 171;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(747, 562);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(79, 17);
            this.label135.TabIndex = 170;
            this.label135.Text = "Feedback13:";
            // 
            // feedback12
            // 
            this.feedback12.FormattingEnabled = true;
            this.feedback12.Location = new System.Drawing.Point(842, 525);
            this.feedback12.Name = "feedback12";
            this.feedback12.Size = new System.Drawing.Size(167, 23);
            this.feedback12.TabIndex = 169;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(747, 527);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(79, 17);
            this.label136.TabIndex = 168;
            this.label136.Text = "Feedback12:";
            // 
            // feedback11
            // 
            this.feedback11.FormattingEnabled = true;
            this.feedback11.Location = new System.Drawing.Point(842, 490);
            this.feedback11.Name = "feedback11";
            this.feedback11.Size = new System.Drawing.Size(167, 23);
            this.feedback11.TabIndex = 167;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(747, 492);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(79, 17);
            this.label137.TabIndex = 166;
            this.label137.Text = "Feedback11:";
            // 
            // step15Job
            // 
            this.step15Job.FormattingEnabled = true;
            this.step15Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step15Job.Location = new System.Drawing.Point(78, 630);
            this.step15Job.Name = "step15Job";
            this.step15Job.Size = new System.Drawing.Size(58, 23);
            this.step15Job.TabIndex = 165;
            this.step15Job.SelectedIndexChanged += new System.EventHandler(this.step15Job_SelectedIndexChanged);
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(17, 632);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(51, 17);
            this.label138.TabIndex = 164;
            this.label138.Text = "Step15:";
            // 
            // step14Job
            // 
            this.step14Job.FormattingEnabled = true;
            this.step14Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step14Job.Location = new System.Drawing.Point(78, 595);
            this.step14Job.Name = "step14Job";
            this.step14Job.Size = new System.Drawing.Size(58, 23);
            this.step14Job.TabIndex = 163;
            this.step14Job.SelectedIndexChanged += new System.EventHandler(this.step14Job_SelectedIndexChanged);
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(17, 597);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(51, 17);
            this.label139.TabIndex = 162;
            this.label139.Text = "Step14:";
            // 
            // step13Job
            // 
            this.step13Job.FormattingEnabled = true;
            this.step13Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step13Job.Location = new System.Drawing.Point(78, 560);
            this.step13Job.Name = "step13Job";
            this.step13Job.Size = new System.Drawing.Size(58, 23);
            this.step13Job.TabIndex = 161;
            this.step13Job.SelectedIndexChanged += new System.EventHandler(this.step13Job_SelectedIndexChanged);
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(17, 562);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(51, 17);
            this.label140.TabIndex = 160;
            this.label140.Text = "Step13:";
            // 
            // step12Job
            // 
            this.step12Job.FormattingEnabled = true;
            this.step12Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step12Job.Location = new System.Drawing.Point(78, 525);
            this.step12Job.Name = "step12Job";
            this.step12Job.Size = new System.Drawing.Size(58, 23);
            this.step12Job.TabIndex = 159;
            this.step12Job.SelectedIndexChanged += new System.EventHandler(this.step12Job_SelectedIndexChanged);
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(17, 527);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(51, 17);
            this.label141.TabIndex = 158;
            this.label141.Text = "Step12:";
            // 
            // step11Job
            // 
            this.step11Job.FormattingEnabled = true;
            this.step11Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step11Job.Location = new System.Drawing.Point(78, 490);
            this.step11Job.Name = "step11Job";
            this.step11Job.Size = new System.Drawing.Size(58, 23);
            this.step11Job.TabIndex = 157;
            this.step11Job.SelectedIndexChanged += new System.EventHandler(this.step11Job_SelectedIndexChanged);
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(17, 492);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(51, 17);
            this.label142.TabIndex = 156;
            this.label142.Text = "Step11:";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(1562, 455);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(49, 17);
            this.label143.TabIndex = 435;
            this.label143.Text = "İsim30:";
            // 
            // isim30
            // 
            this.isim30.Location = new System.Drawing.Point(1621, 453);
            this.isim30.Name = "isim30";
            this.isim30.Size = new System.Drawing.Size(174, 24);
            this.isim30.TabIndex = 434;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(1562, 420);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(49, 17);
            this.label144.TabIndex = 433;
            this.label144.Text = "İsim29:";
            // 
            // isim29
            // 
            this.isim29.Location = new System.Drawing.Point(1621, 418);
            this.isim29.Name = "isim29";
            this.isim29.Size = new System.Drawing.Size(174, 24);
            this.isim29.TabIndex = 432;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(1562, 385);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(49, 17);
            this.label145.TabIndex = 431;
            this.label145.Text = "İsim28:";
            // 
            // isim28
            // 
            this.isim28.Location = new System.Drawing.Point(1621, 383);
            this.isim28.Name = "isim28";
            this.isim28.Size = new System.Drawing.Size(174, 24);
            this.isim28.TabIndex = 430;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(1562, 350);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(49, 17);
            this.label146.TabIndex = 429;
            this.label146.Text = "İsim27:";
            // 
            // isim27
            // 
            this.isim27.Location = new System.Drawing.Point(1621, 348);
            this.isim27.Name = "isim27";
            this.isim27.Size = new System.Drawing.Size(174, 24);
            this.isim27.TabIndex = 428;
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(1562, 315);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(49, 17);
            this.label147.TabIndex = 427;
            this.label147.Text = "İsim26:";
            // 
            // isim26
            // 
            this.isim26.Location = new System.Drawing.Point(1621, 313);
            this.isim26.Name = "isim26";
            this.isim26.Size = new System.Drawing.Size(174, 24);
            this.isim26.TabIndex = 426;
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(2620, 455);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(60, 17);
            this.label148.TabIndex = 425;
            this.label148.Text = "Görev30:";
            // 
            // gorev30
            // 
            this.gorev30.Location = new System.Drawing.Point(2692, 453);
            this.gorev30.Name = "gorev30";
            this.gorev30.Size = new System.Drawing.Size(100, 24);
            this.gorev30.TabIndex = 424;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(2620, 420);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(60, 17);
            this.label149.TabIndex = 423;
            this.label149.Text = "Görev29:";
            // 
            // gorev29
            // 
            this.gorev29.Location = new System.Drawing.Point(2692, 418);
            this.gorev29.Name = "gorev29";
            this.gorev29.Size = new System.Drawing.Size(100, 24);
            this.gorev29.TabIndex = 422;
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(2620, 385);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(60, 17);
            this.label150.TabIndex = 421;
            this.label150.Text = "Görev28:";
            // 
            // gorev28
            // 
            this.gorev28.Location = new System.Drawing.Point(2691, 383);
            this.gorev28.Name = "gorev28";
            this.gorev28.Size = new System.Drawing.Size(100, 24);
            this.gorev28.TabIndex = 420;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(2620, 350);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(60, 17);
            this.label151.TabIndex = 419;
            this.label151.Text = "Görev27:";
            // 
            // gorev27
            // 
            this.gorev27.Location = new System.Drawing.Point(2692, 348);
            this.gorev27.Name = "gorev27";
            this.gorev27.Size = new System.Drawing.Size(100, 24);
            this.gorev27.TabIndex = 418;
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(2620, 315);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(60, 17);
            this.label152.TabIndex = 417;
            this.label152.Text = "Görev26:";
            // 
            // gorev26
            // 
            this.gorev26.Location = new System.Drawing.Point(2692, 313);
            this.gorev26.Name = "gorev26";
            this.gorev26.Size = new System.Drawing.Size(100, 24);
            this.gorev26.TabIndex = 416;
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(2432, 455);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(67, 17);
            this.label153.TabIndex = 415;
            this.label153.Text = "Kontrol30:";
            // 
            // kontrol30
            // 
            this.kontrol30.Location = new System.Drawing.Point(2514, 453);
            this.kontrol30.Name = "kontrol30";
            this.kontrol30.Size = new System.Drawing.Size(100, 24);
            this.kontrol30.TabIndex = 414;
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(2432, 420);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(67, 17);
            this.label154.TabIndex = 413;
            this.label154.Text = "Kontrol29:";
            // 
            // kontrol29
            // 
            this.kontrol29.Location = new System.Drawing.Point(2514, 418);
            this.kontrol29.Name = "kontrol29";
            this.kontrol29.Size = new System.Drawing.Size(100, 24);
            this.kontrol29.TabIndex = 412;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(2432, 385);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(67, 17);
            this.label155.TabIndex = 411;
            this.label155.Text = "Kontrol28:";
            // 
            // kontrol28
            // 
            this.kontrol28.Location = new System.Drawing.Point(2514, 383);
            this.kontrol28.Name = "kontrol28";
            this.kontrol28.Size = new System.Drawing.Size(100, 24);
            this.kontrol28.TabIndex = 410;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(2432, 350);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(67, 17);
            this.label156.TabIndex = 409;
            this.label156.Text = "Kontrol27:";
            // 
            // kontrol27
            // 
            this.kontrol27.Location = new System.Drawing.Point(2514, 348);
            this.kontrol27.Name = "kontrol27";
            this.kontrol27.Size = new System.Drawing.Size(100, 24);
            this.kontrol27.TabIndex = 408;
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(2432, 315);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(67, 17);
            this.label157.TabIndex = 407;
            this.label157.Text = "Kontrol26:";
            // 
            // kontrol26
            // 
            this.kontrol26.Location = new System.Drawing.Point(2514, 313);
            this.kontrol26.Name = "kontrol26";
            this.kontrol26.Size = new System.Drawing.Size(100, 24);
            this.kontrol26.TabIndex = 406;
            // 
            // veri30
            // 
            this.veri30.FormattingEnabled = true;
            this.veri30.Items.AddRange(new object[] {
            ""});
            this.veri30.Location = new System.Drawing.Point(1858, 453);
            this.veri30.Name = "veri30";
            this.veri30.Size = new System.Drawing.Size(185, 23);
            this.veri30.TabIndex = 405;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(1801, 455);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(48, 17);
            this.label158.TabIndex = 404;
            this.label158.Text = "Veri30:";
            // 
            // veri29
            // 
            this.veri29.FormattingEnabled = true;
            this.veri29.Location = new System.Drawing.Point(1858, 418);
            this.veri29.Name = "veri29";
            this.veri29.Size = new System.Drawing.Size(185, 23);
            this.veri29.TabIndex = 403;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(1801, 420);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(48, 17);
            this.label159.TabIndex = 402;
            this.label159.Text = "Veri29:";
            // 
            // veri28
            // 
            this.veri28.FormattingEnabled = true;
            this.veri28.Items.AddRange(new object[] {
            ""});
            this.veri28.Location = new System.Drawing.Point(1858, 383);
            this.veri28.Name = "veri28";
            this.veri28.Size = new System.Drawing.Size(185, 23);
            this.veri28.TabIndex = 401;
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(1801, 385);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(48, 17);
            this.label160.TabIndex = 400;
            this.label160.Text = "Veri28:";
            // 
            // veri27
            // 
            this.veri27.FormattingEnabled = true;
            this.veri27.Location = new System.Drawing.Point(1858, 348);
            this.veri27.Name = "veri27";
            this.veri27.Size = new System.Drawing.Size(185, 23);
            this.veri27.TabIndex = 399;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(1801, 350);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(48, 17);
            this.label161.TabIndex = 398;
            this.label161.Text = "Veri27:";
            // 
            // veri26
            // 
            this.veri26.FormattingEnabled = true;
            this.veri26.Location = new System.Drawing.Point(1858, 313);
            this.veri26.Name = "veri26";
            this.veri26.Size = new System.Drawing.Size(185, 23);
            this.veri26.TabIndex = 397;
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(1801, 315);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(48, 17);
            this.label162.TabIndex = 396;
            this.label162.Text = "Veri26:";
            // 
            // COM30
            // 
            this.COM30.FormattingEnabled = true;
            this.COM30.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM30.Location = new System.Drawing.Point(2100, 453);
            this.COM30.Name = "COM30";
            this.COM30.Size = new System.Drawing.Size(52, 23);
            this.COM30.TabIndex = 395;
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(2049, 455);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(40, 17);
            this.label163.TabIndex = 394;
            this.label163.Text = "COM:";
            // 
            // COM29
            // 
            this.COM29.FormattingEnabled = true;
            this.COM29.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM29.Location = new System.Drawing.Point(2100, 418);
            this.COM29.Name = "COM29";
            this.COM29.Size = new System.Drawing.Size(52, 23);
            this.COM29.TabIndex = 393;
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(2049, 420);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(40, 17);
            this.label164.TabIndex = 392;
            this.label164.Text = "COM:";
            // 
            // COM28
            // 
            this.COM28.FormattingEnabled = true;
            this.COM28.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM28.Location = new System.Drawing.Point(2100, 383);
            this.COM28.Name = "COM28";
            this.COM28.Size = new System.Drawing.Size(52, 23);
            this.COM28.TabIndex = 391;
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(2049, 385);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(40, 17);
            this.label165.TabIndex = 390;
            this.label165.Text = "COM:";
            // 
            // COM27
            // 
            this.COM27.FormattingEnabled = true;
            this.COM27.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM27.Location = new System.Drawing.Point(2100, 348);
            this.COM27.Name = "COM27";
            this.COM27.Size = new System.Drawing.Size(52, 23);
            this.COM27.TabIndex = 389;
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(2049, 350);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(40, 17);
            this.label166.TabIndex = 388;
            this.label166.Text = "COM:";
            // 
            // COM26
            // 
            this.COM26.FormattingEnabled = true;
            this.COM26.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM26.Location = new System.Drawing.Point(2100, 313);
            this.COM26.Name = "COM26";
            this.COM26.Size = new System.Drawing.Size(52, 23);
            this.COM26.TabIndex = 387;
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(2049, 315);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(40, 17);
            this.label167.TabIndex = 386;
            this.label167.Text = "COM:";
            // 
            // feedback30
            // 
            this.feedback30.FormattingEnabled = true;
            this.feedback30.Items.AddRange(new object[] {
            ""});
            this.feedback30.Location = new System.Drawing.Point(2253, 453);
            this.feedback30.Name = "feedback30";
            this.feedback30.Size = new System.Drawing.Size(167, 23);
            this.feedback30.TabIndex = 385;
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(2158, 455);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(79, 17);
            this.label168.TabIndex = 384;
            this.label168.Text = "Feedback30:";
            // 
            // feedback29
            // 
            this.feedback29.FormattingEnabled = true;
            this.feedback29.Location = new System.Drawing.Point(2253, 418);
            this.feedback29.Name = "feedback29";
            this.feedback29.Size = new System.Drawing.Size(167, 23);
            this.feedback29.TabIndex = 383;
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(2158, 420);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(79, 17);
            this.label169.TabIndex = 382;
            this.label169.Text = "Feedback29:";
            // 
            // feedback28
            // 
            this.feedback28.FormattingEnabled = true;
            this.feedback28.Items.AddRange(new object[] {
            ""});
            this.feedback28.Location = new System.Drawing.Point(2253, 383);
            this.feedback28.Name = "feedback28";
            this.feedback28.Size = new System.Drawing.Size(167, 23);
            this.feedback28.TabIndex = 381;
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(2158, 385);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(79, 17);
            this.label170.TabIndex = 380;
            this.label170.Text = "Feedback28:";
            // 
            // feedback27
            // 
            this.feedback27.FormattingEnabled = true;
            this.feedback27.Location = new System.Drawing.Point(2253, 348);
            this.feedback27.Name = "feedback27";
            this.feedback27.Size = new System.Drawing.Size(167, 23);
            this.feedback27.TabIndex = 379;
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(2158, 350);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(79, 17);
            this.label171.TabIndex = 378;
            this.label171.Text = "Feedback27:";
            // 
            // feedback26
            // 
            this.feedback26.FormattingEnabled = true;
            this.feedback26.Location = new System.Drawing.Point(2253, 313);
            this.feedback26.Name = "feedback26";
            this.feedback26.Size = new System.Drawing.Size(167, 23);
            this.feedback26.TabIndex = 377;
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(2158, 315);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(79, 17);
            this.label172.TabIndex = 376;
            this.label172.Text = "Feedback26:";
            // 
            // step30Job
            // 
            this.step30Job.FormattingEnabled = true;
            this.step30Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step30Job.Location = new System.Drawing.Point(1489, 453);
            this.step30Job.Name = "step30Job";
            this.step30Job.Size = new System.Drawing.Size(58, 23);
            this.step30Job.TabIndex = 375;
            this.step30Job.SelectedIndexChanged += new System.EventHandler(this.step30Job_SelectedIndexChanged);
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(1428, 455);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(51, 17);
            this.label173.TabIndex = 374;
            this.label173.Text = "Step30:";
            // 
            // step29Job
            // 
            this.step29Job.FormattingEnabled = true;
            this.step29Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step29Job.Location = new System.Drawing.Point(1489, 418);
            this.step29Job.Name = "step29Job";
            this.step29Job.Size = new System.Drawing.Size(58, 23);
            this.step29Job.TabIndex = 373;
            this.step29Job.SelectedIndexChanged += new System.EventHandler(this.step29Job_SelectedIndexChanged);
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(1428, 420);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(51, 17);
            this.label174.TabIndex = 372;
            this.label174.Text = "Step29:";
            // 
            // step28Job
            // 
            this.step28Job.FormattingEnabled = true;
            this.step28Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step28Job.Location = new System.Drawing.Point(1489, 383);
            this.step28Job.Name = "step28Job";
            this.step28Job.Size = new System.Drawing.Size(58, 23);
            this.step28Job.TabIndex = 371;
            this.step28Job.SelectedIndexChanged += new System.EventHandler(this.step28Job_SelectedIndexChanged);
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(1428, 385);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(51, 17);
            this.label175.TabIndex = 370;
            this.label175.Text = "Step28:";
            // 
            // step27Job
            // 
            this.step27Job.FormattingEnabled = true;
            this.step27Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step27Job.Location = new System.Drawing.Point(1489, 348);
            this.step27Job.Name = "step27Job";
            this.step27Job.Size = new System.Drawing.Size(58, 23);
            this.step27Job.TabIndex = 369;
            this.step27Job.SelectedIndexChanged += new System.EventHandler(this.step27Job_SelectedIndexChanged);
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(1428, 350);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(51, 17);
            this.label176.TabIndex = 368;
            this.label176.Text = "Step27:";
            // 
            // step26Job
            // 
            this.step26Job.FormattingEnabled = true;
            this.step26Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step26Job.Location = new System.Drawing.Point(1489, 313);
            this.step26Job.Name = "step26Job";
            this.step26Job.Size = new System.Drawing.Size(58, 23);
            this.step26Job.TabIndex = 367;
            this.step26Job.SelectedIndexChanged += new System.EventHandler(this.step26Job_SelectedIndexChanged);
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(1428, 315);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(51, 17);
            this.label177.TabIndex = 366;
            this.label177.Text = "Step26:";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(1562, 280);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(49, 17);
            this.label178.TabIndex = 365;
            this.label178.Text = "İsim25:";
            // 
            // isim25
            // 
            this.isim25.Location = new System.Drawing.Point(1621, 278);
            this.isim25.Name = "isim25";
            this.isim25.Size = new System.Drawing.Size(174, 24);
            this.isim25.TabIndex = 364;
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(1562, 245);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(49, 17);
            this.label179.TabIndex = 363;
            this.label179.Text = "İsim24:";
            // 
            // isim24
            // 
            this.isim24.Location = new System.Drawing.Point(1621, 243);
            this.isim24.Name = "isim24";
            this.isim24.Size = new System.Drawing.Size(174, 24);
            this.isim24.TabIndex = 362;
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(1562, 210);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(49, 17);
            this.label180.TabIndex = 361;
            this.label180.Text = "İsim23:";
            // 
            // isim23
            // 
            this.isim23.Location = new System.Drawing.Point(1621, 208);
            this.isim23.Name = "isim23";
            this.isim23.Size = new System.Drawing.Size(174, 24);
            this.isim23.TabIndex = 360;
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(1562, 175);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(49, 17);
            this.label181.TabIndex = 359;
            this.label181.Text = "İsim22:";
            // 
            // isim22
            // 
            this.isim22.Location = new System.Drawing.Point(1621, 173);
            this.isim22.Name = "isim22";
            this.isim22.Size = new System.Drawing.Size(174, 24);
            this.isim22.TabIndex = 358;
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(1562, 140);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(49, 17);
            this.label182.TabIndex = 357;
            this.label182.Text = "İsim21:";
            // 
            // isim21
            // 
            this.isim21.Location = new System.Drawing.Point(1621, 138);
            this.isim21.Name = "isim21";
            this.isim21.Size = new System.Drawing.Size(174, 24);
            this.isim21.TabIndex = 356;
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(2620, 280);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(60, 17);
            this.label183.TabIndex = 355;
            this.label183.Text = "Görev25:";
            // 
            // gorev25
            // 
            this.gorev25.Location = new System.Drawing.Point(2692, 278);
            this.gorev25.Name = "gorev25";
            this.gorev25.Size = new System.Drawing.Size(100, 24);
            this.gorev25.TabIndex = 354;
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Location = new System.Drawing.Point(2620, 245);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(60, 17);
            this.label184.TabIndex = 353;
            this.label184.Text = "Görev24:";
            // 
            // gorev24
            // 
            this.gorev24.Location = new System.Drawing.Point(2692, 243);
            this.gorev24.Name = "gorev24";
            this.gorev24.Size = new System.Drawing.Size(100, 24);
            this.gorev24.TabIndex = 352;
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(2620, 210);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(60, 17);
            this.label185.TabIndex = 351;
            this.label185.Text = "Görev23:";
            // 
            // gorev23
            // 
            this.gorev23.Location = new System.Drawing.Point(2691, 208);
            this.gorev23.Name = "gorev23";
            this.gorev23.Size = new System.Drawing.Size(100, 24);
            this.gorev23.TabIndex = 350;
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(2620, 175);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(60, 17);
            this.label186.TabIndex = 349;
            this.label186.Text = "Görev22:";
            // 
            // gorev22
            // 
            this.gorev22.Location = new System.Drawing.Point(2692, 173);
            this.gorev22.Name = "gorev22";
            this.gorev22.Size = new System.Drawing.Size(100, 24);
            this.gorev22.TabIndex = 348;
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Location = new System.Drawing.Point(2620, 140);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(60, 17);
            this.label187.TabIndex = 347;
            this.label187.Text = "Görev21:";
            // 
            // gorev21
            // 
            this.gorev21.Location = new System.Drawing.Point(2692, 138);
            this.gorev21.Name = "gorev21";
            this.gorev21.Size = new System.Drawing.Size(100, 24);
            this.gorev21.TabIndex = 346;
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Location = new System.Drawing.Point(2432, 280);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(67, 17);
            this.label188.TabIndex = 345;
            this.label188.Text = "Kontrol25:";
            // 
            // kontrol25
            // 
            this.kontrol25.Location = new System.Drawing.Point(2514, 278);
            this.kontrol25.Name = "kontrol25";
            this.kontrol25.Size = new System.Drawing.Size(100, 24);
            this.kontrol25.TabIndex = 344;
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Location = new System.Drawing.Point(2432, 245);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(67, 17);
            this.label189.TabIndex = 343;
            this.label189.Text = "Kontrol24:";
            // 
            // kontrol24
            // 
            this.kontrol24.Location = new System.Drawing.Point(2514, 243);
            this.kontrol24.Name = "kontrol24";
            this.kontrol24.Size = new System.Drawing.Size(100, 24);
            this.kontrol24.TabIndex = 342;
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Location = new System.Drawing.Point(2432, 210);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(67, 17);
            this.label190.TabIndex = 341;
            this.label190.Text = "Kontrol23:";
            // 
            // kontrol23
            // 
            this.kontrol23.Location = new System.Drawing.Point(2514, 208);
            this.kontrol23.Name = "kontrol23";
            this.kontrol23.Size = new System.Drawing.Size(100, 24);
            this.kontrol23.TabIndex = 340;
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Location = new System.Drawing.Point(2432, 175);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(67, 17);
            this.label191.TabIndex = 339;
            this.label191.Text = "Kontrol22:";
            // 
            // kontrol22
            // 
            this.kontrol22.Location = new System.Drawing.Point(2514, 173);
            this.kontrol22.Name = "kontrol22";
            this.kontrol22.Size = new System.Drawing.Size(100, 24);
            this.kontrol22.TabIndex = 338;
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Location = new System.Drawing.Point(2432, 140);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(67, 17);
            this.label192.TabIndex = 337;
            this.label192.Text = "Kontrol21:";
            // 
            // kontrol21
            // 
            this.kontrol21.Location = new System.Drawing.Point(2514, 138);
            this.kontrol21.Name = "kontrol21";
            this.kontrol21.Size = new System.Drawing.Size(100, 24);
            this.kontrol21.TabIndex = 336;
            // 
            // veri25
            // 
            this.veri25.FormattingEnabled = true;
            this.veri25.Items.AddRange(new object[] {
            ""});
            this.veri25.Location = new System.Drawing.Point(1858, 278);
            this.veri25.Name = "veri25";
            this.veri25.Size = new System.Drawing.Size(185, 23);
            this.veri25.TabIndex = 335;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Location = new System.Drawing.Point(1801, 280);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(48, 17);
            this.label193.TabIndex = 334;
            this.label193.Text = "Veri25:";
            // 
            // veri24
            // 
            this.veri24.FormattingEnabled = true;
            this.veri24.Location = new System.Drawing.Point(1858, 243);
            this.veri24.Name = "veri24";
            this.veri24.Size = new System.Drawing.Size(185, 23);
            this.veri24.TabIndex = 333;
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Location = new System.Drawing.Point(1801, 245);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(48, 17);
            this.label194.TabIndex = 332;
            this.label194.Text = "Veri24:";
            // 
            // veri23
            // 
            this.veri23.FormattingEnabled = true;
            this.veri23.Items.AddRange(new object[] {
            ""});
            this.veri23.Location = new System.Drawing.Point(1858, 208);
            this.veri23.Name = "veri23";
            this.veri23.Size = new System.Drawing.Size(185, 23);
            this.veri23.TabIndex = 331;
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Location = new System.Drawing.Point(1801, 210);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(48, 17);
            this.label195.TabIndex = 330;
            this.label195.Text = "Veri23:";
            // 
            // veri22
            // 
            this.veri22.FormattingEnabled = true;
            this.veri22.Location = new System.Drawing.Point(1858, 173);
            this.veri22.Name = "veri22";
            this.veri22.Size = new System.Drawing.Size(185, 23);
            this.veri22.TabIndex = 329;
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Location = new System.Drawing.Point(1801, 175);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(48, 17);
            this.label196.TabIndex = 328;
            this.label196.Text = "Veri22:";
            // 
            // veri21
            // 
            this.veri21.FormattingEnabled = true;
            this.veri21.Location = new System.Drawing.Point(1858, 138);
            this.veri21.Name = "veri21";
            this.veri21.Size = new System.Drawing.Size(185, 23);
            this.veri21.TabIndex = 327;
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Location = new System.Drawing.Point(1801, 140);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(48, 17);
            this.label197.TabIndex = 326;
            this.label197.Text = "Veri21:";
            // 
            // COM25
            // 
            this.COM25.FormattingEnabled = true;
            this.COM25.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM25.Location = new System.Drawing.Point(2100, 278);
            this.COM25.Name = "COM25";
            this.COM25.Size = new System.Drawing.Size(52, 23);
            this.COM25.TabIndex = 325;
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(2049, 280);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(40, 17);
            this.label198.TabIndex = 324;
            this.label198.Text = "COM:";
            // 
            // COM24
            // 
            this.COM24.FormattingEnabled = true;
            this.COM24.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM24.Location = new System.Drawing.Point(2100, 243);
            this.COM24.Name = "COM24";
            this.COM24.Size = new System.Drawing.Size(52, 23);
            this.COM24.TabIndex = 323;
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(2049, 245);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(40, 17);
            this.label199.TabIndex = 322;
            this.label199.Text = "COM:";
            // 
            // COM23
            // 
            this.COM23.FormattingEnabled = true;
            this.COM23.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM23.Location = new System.Drawing.Point(2100, 208);
            this.COM23.Name = "COM23";
            this.COM23.Size = new System.Drawing.Size(52, 23);
            this.COM23.TabIndex = 321;
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(2049, 210);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(40, 17);
            this.label200.TabIndex = 320;
            this.label200.Text = "COM:";
            // 
            // COM22
            // 
            this.COM22.FormattingEnabled = true;
            this.COM22.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM22.Location = new System.Drawing.Point(2100, 173);
            this.COM22.Name = "COM22";
            this.COM22.Size = new System.Drawing.Size(52, 23);
            this.COM22.TabIndex = 319;
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(2049, 175);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(40, 17);
            this.label201.TabIndex = 318;
            this.label201.Text = "COM:";
            // 
            // COM21
            // 
            this.COM21.FormattingEnabled = true;
            this.COM21.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM21.Location = new System.Drawing.Point(2100, 138);
            this.COM21.Name = "COM21";
            this.COM21.Size = new System.Drawing.Size(52, 23);
            this.COM21.TabIndex = 317;
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Location = new System.Drawing.Point(2049, 140);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(40, 17);
            this.label202.TabIndex = 316;
            this.label202.Text = "COM:";
            // 
            // feedback25
            // 
            this.feedback25.FormattingEnabled = true;
            this.feedback25.Items.AddRange(new object[] {
            ""});
            this.feedback25.Location = new System.Drawing.Point(2253, 278);
            this.feedback25.Name = "feedback25";
            this.feedback25.Size = new System.Drawing.Size(167, 23);
            this.feedback25.TabIndex = 315;
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Location = new System.Drawing.Point(2158, 280);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(79, 17);
            this.label203.TabIndex = 314;
            this.label203.Text = "Feedback25:";
            // 
            // feedback24
            // 
            this.feedback24.FormattingEnabled = true;
            this.feedback24.Location = new System.Drawing.Point(2253, 243);
            this.feedback24.Name = "feedback24";
            this.feedback24.Size = new System.Drawing.Size(167, 23);
            this.feedback24.TabIndex = 313;
            // 
            // label204
            // 
            this.label204.AutoSize = true;
            this.label204.Location = new System.Drawing.Point(2158, 245);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(79, 17);
            this.label204.TabIndex = 312;
            this.label204.Text = "Feedback24:";
            // 
            // feedback23
            // 
            this.feedback23.FormattingEnabled = true;
            this.feedback23.Items.AddRange(new object[] {
            ""});
            this.feedback23.Location = new System.Drawing.Point(2253, 208);
            this.feedback23.Name = "feedback23";
            this.feedback23.Size = new System.Drawing.Size(167, 23);
            this.feedback23.TabIndex = 311;
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.Location = new System.Drawing.Point(2158, 210);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(79, 17);
            this.label205.TabIndex = 310;
            this.label205.Text = "Feedback23:";
            // 
            // feedback22
            // 
            this.feedback22.FormattingEnabled = true;
            this.feedback22.Location = new System.Drawing.Point(2253, 173);
            this.feedback22.Name = "feedback22";
            this.feedback22.Size = new System.Drawing.Size(167, 23);
            this.feedback22.TabIndex = 309;
            // 
            // label206
            // 
            this.label206.AutoSize = true;
            this.label206.Location = new System.Drawing.Point(2158, 175);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(79, 17);
            this.label206.TabIndex = 308;
            this.label206.Text = "Feedback22:";
            // 
            // feedback21
            // 
            this.feedback21.FormattingEnabled = true;
            this.feedback21.Location = new System.Drawing.Point(2253, 138);
            this.feedback21.Name = "feedback21";
            this.feedback21.Size = new System.Drawing.Size(167, 23);
            this.feedback21.TabIndex = 307;
            // 
            // label207
            // 
            this.label207.AutoSize = true;
            this.label207.Location = new System.Drawing.Point(2158, 140);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(79, 17);
            this.label207.TabIndex = 306;
            this.label207.Text = "Feedback21:";
            // 
            // step25Job
            // 
            this.step25Job.FormattingEnabled = true;
            this.step25Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step25Job.Location = new System.Drawing.Point(1489, 278);
            this.step25Job.Name = "step25Job";
            this.step25Job.Size = new System.Drawing.Size(58, 23);
            this.step25Job.TabIndex = 305;
            this.step25Job.SelectedIndexChanged += new System.EventHandler(this.step25Job_SelectedIndexChanged);
            // 
            // label208
            // 
            this.label208.AutoSize = true;
            this.label208.Location = new System.Drawing.Point(1428, 280);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(51, 17);
            this.label208.TabIndex = 304;
            this.label208.Text = "Step25:";
            // 
            // step24Job
            // 
            this.step24Job.FormattingEnabled = true;
            this.step24Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step24Job.Location = new System.Drawing.Point(1489, 243);
            this.step24Job.Name = "step24Job";
            this.step24Job.Size = new System.Drawing.Size(58, 23);
            this.step24Job.TabIndex = 303;
            this.step24Job.SelectedIndexChanged += new System.EventHandler(this.step24Job_SelectedIndexChanged);
            // 
            // label209
            // 
            this.label209.AutoSize = true;
            this.label209.Location = new System.Drawing.Point(1428, 245);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(51, 17);
            this.label209.TabIndex = 302;
            this.label209.Text = "Step24:";
            // 
            // step23Job
            // 
            this.step23Job.FormattingEnabled = true;
            this.step23Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step23Job.Location = new System.Drawing.Point(1489, 208);
            this.step23Job.Name = "step23Job";
            this.step23Job.Size = new System.Drawing.Size(58, 23);
            this.step23Job.TabIndex = 301;
            this.step23Job.SelectedIndexChanged += new System.EventHandler(this.step23Job_SelectedIndexChanged);
            // 
            // label210
            // 
            this.label210.AutoSize = true;
            this.label210.Location = new System.Drawing.Point(1428, 210);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(51, 17);
            this.label210.TabIndex = 300;
            this.label210.Text = "Step23:";
            // 
            // step22Job
            // 
            this.step22Job.FormattingEnabled = true;
            this.step22Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step22Job.Location = new System.Drawing.Point(1489, 173);
            this.step22Job.Name = "step22Job";
            this.step22Job.Size = new System.Drawing.Size(58, 23);
            this.step22Job.TabIndex = 299;
            this.step22Job.SelectedIndexChanged += new System.EventHandler(this.step22Job_SelectedIndexChanged);
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Location = new System.Drawing.Point(1428, 175);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(51, 17);
            this.label211.TabIndex = 298;
            this.label211.Text = "Step22:";
            // 
            // step21Job
            // 
            this.step21Job.FormattingEnabled = true;
            this.step21Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step21Job.Location = new System.Drawing.Point(1489, 138);
            this.step21Job.Name = "step21Job";
            this.step21Job.Size = new System.Drawing.Size(58, 23);
            this.step21Job.TabIndex = 297;
            this.step21Job.SelectedIndexChanged += new System.EventHandler(this.step21Job_SelectedIndexChanged);
            // 
            // label212
            // 
            this.label212.AutoSize = true;
            this.label212.Location = new System.Drawing.Point(1428, 140);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(51, 17);
            this.label212.TabIndex = 296;
            this.label212.Text = "Step21:";
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.Location = new System.Drawing.Point(1562, 492);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(49, 17);
            this.label213.TabIndex = 449;
            this.label213.Text = "İsim31:";
            // 
            // isim31
            // 
            this.isim31.Location = new System.Drawing.Point(1621, 490);
            this.isim31.Name = "isim31";
            this.isim31.Size = new System.Drawing.Size(174, 24);
            this.isim31.TabIndex = 448;
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Location = new System.Drawing.Point(2620, 492);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(60, 17);
            this.label214.TabIndex = 447;
            this.label214.Text = "Görev31:";
            // 
            // gorev31
            // 
            this.gorev31.Location = new System.Drawing.Point(2692, 490);
            this.gorev31.Name = "gorev31";
            this.gorev31.Size = new System.Drawing.Size(100, 24);
            this.gorev31.TabIndex = 446;
            // 
            // label215
            // 
            this.label215.AutoSize = true;
            this.label215.Location = new System.Drawing.Point(2432, 492);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(67, 17);
            this.label215.TabIndex = 445;
            this.label215.Text = "Kontrol31:";
            // 
            // kontrol31
            // 
            this.kontrol31.Location = new System.Drawing.Point(2514, 490);
            this.kontrol31.Name = "kontrol31";
            this.kontrol31.Size = new System.Drawing.Size(100, 24);
            this.kontrol31.TabIndex = 444;
            // 
            // veri31
            // 
            this.veri31.FormattingEnabled = true;
            this.veri31.Items.AddRange(new object[] {
            ""});
            this.veri31.Location = new System.Drawing.Point(1858, 490);
            this.veri31.Name = "veri31";
            this.veri31.Size = new System.Drawing.Size(185, 23);
            this.veri31.TabIndex = 443;
            // 
            // label216
            // 
            this.label216.AutoSize = true;
            this.label216.Location = new System.Drawing.Point(1801, 492);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(48, 17);
            this.label216.TabIndex = 442;
            this.label216.Text = "Veri31:";
            // 
            // COM31
            // 
            this.COM31.FormattingEnabled = true;
            this.COM31.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM31.Location = new System.Drawing.Point(2100, 490);
            this.COM31.Name = "COM31";
            this.COM31.Size = new System.Drawing.Size(52, 23);
            this.COM31.TabIndex = 441;
            // 
            // label217
            // 
            this.label217.AutoSize = true;
            this.label217.Location = new System.Drawing.Point(2049, 492);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(40, 17);
            this.label217.TabIndex = 440;
            this.label217.Text = "COM:";
            // 
            // feedback31
            // 
            this.feedback31.FormattingEnabled = true;
            this.feedback31.Items.AddRange(new object[] {
            ""});
            this.feedback31.Location = new System.Drawing.Point(2253, 490);
            this.feedback31.Name = "feedback31";
            this.feedback31.Size = new System.Drawing.Size(167, 23);
            this.feedback31.TabIndex = 439;
            // 
            // label218
            // 
            this.label218.AutoSize = true;
            this.label218.Location = new System.Drawing.Point(2158, 492);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(79, 17);
            this.label218.TabIndex = 438;
            this.label218.Text = "Feedback31:";
            // 
            // step31Job
            // 
            this.step31Job.FormattingEnabled = true;
            this.step31Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step31Job.Location = new System.Drawing.Point(1489, 490);
            this.step31Job.Name = "step31Job";
            this.step31Job.Size = new System.Drawing.Size(58, 23);
            this.step31Job.TabIndex = 437;
            this.step31Job.SelectedIndexChanged += new System.EventHandler(this.step31Job_SelectedIndexChanged);
            // 
            // label219
            // 
            this.label219.AutoSize = true;
            this.label219.Location = new System.Drawing.Point(1428, 492);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(51, 17);
            this.label219.TabIndex = 436;
            this.label219.Text = "Step31:";
            // 
            // label223
            // 
            this.label223.AutoSize = true;
            this.label223.Location = new System.Drawing.Point(1562, 700);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(49, 17);
            this.label223.TabIndex = 576;
            this.label223.Text = "İsim37:";
            // 
            // isim37
            // 
            this.isim37.Location = new System.Drawing.Point(1621, 698);
            this.isim37.Name = "isim37";
            this.isim37.Size = new System.Drawing.Size(174, 24);
            this.isim37.TabIndex = 575;
            // 
            // label224
            // 
            this.label224.AutoSize = true;
            this.label224.Location = new System.Drawing.Point(1562, 665);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(49, 17);
            this.label224.TabIndex = 574;
            this.label224.Text = "İsim36:";
            // 
            // isim36
            // 
            this.isim36.Location = new System.Drawing.Point(1621, 663);
            this.isim36.Name = "isim36";
            this.isim36.Size = new System.Drawing.Size(174, 24);
            this.isim36.TabIndex = 573;
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Location = new System.Drawing.Point(2620, 700);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(60, 17);
            this.label228.TabIndex = 566;
            this.label228.Text = "Görev37:";
            // 
            // gorev37
            // 
            this.gorev37.Location = new System.Drawing.Point(2692, 698);
            this.gorev37.Name = "gorev37";
            this.gorev37.Size = new System.Drawing.Size(100, 24);
            this.gorev37.TabIndex = 565;
            // 
            // label229
            // 
            this.label229.AutoSize = true;
            this.label229.Location = new System.Drawing.Point(2620, 665);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(60, 17);
            this.label229.TabIndex = 564;
            this.label229.Text = "Görev36:";
            // 
            // gorev36
            // 
            this.gorev36.Location = new System.Drawing.Point(2692, 663);
            this.gorev36.Name = "gorev36";
            this.gorev36.Size = new System.Drawing.Size(100, 24);
            this.gorev36.TabIndex = 563;
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Location = new System.Drawing.Point(2432, 700);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(67, 17);
            this.label233.TabIndex = 556;
            this.label233.Text = "Kontrol37:";
            // 
            // kontrol37
            // 
            this.kontrol37.Location = new System.Drawing.Point(2514, 698);
            this.kontrol37.Name = "kontrol37";
            this.kontrol37.Size = new System.Drawing.Size(100, 24);
            this.kontrol37.TabIndex = 555;
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Location = new System.Drawing.Point(2432, 665);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(67, 17);
            this.label234.TabIndex = 554;
            this.label234.Text = "Kontrol36:";
            // 
            // kontrol36
            // 
            this.kontrol36.Location = new System.Drawing.Point(2514, 663);
            this.kontrol36.Name = "kontrol36";
            this.kontrol36.Size = new System.Drawing.Size(100, 24);
            this.kontrol36.TabIndex = 553;
            // 
            // veri37
            // 
            this.veri37.FormattingEnabled = true;
            this.veri37.Location = new System.Drawing.Point(1858, 698);
            this.veri37.Name = "veri37";
            this.veri37.Size = new System.Drawing.Size(185, 23);
            this.veri37.TabIndex = 546;
            // 
            // label238
            // 
            this.label238.AutoSize = true;
            this.label238.Location = new System.Drawing.Point(1801, 700);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(48, 17);
            this.label238.TabIndex = 545;
            this.label238.Text = "Veri37:";
            // 
            // veri36
            // 
            this.veri36.FormattingEnabled = true;
            this.veri36.Location = new System.Drawing.Point(1858, 663);
            this.veri36.Name = "veri36";
            this.veri36.Size = new System.Drawing.Size(185, 23);
            this.veri36.TabIndex = 544;
            // 
            // label239
            // 
            this.label239.AutoSize = true;
            this.label239.Location = new System.Drawing.Point(1801, 665);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(48, 17);
            this.label239.TabIndex = 543;
            this.label239.Text = "Veri36:";
            // 
            // COM37
            // 
            this.COM37.FormattingEnabled = true;
            this.COM37.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM37.Location = new System.Drawing.Point(2100, 698);
            this.COM37.Name = "COM37";
            this.COM37.Size = new System.Drawing.Size(52, 23);
            this.COM37.TabIndex = 536;
            // 
            // label243
            // 
            this.label243.AutoSize = true;
            this.label243.Location = new System.Drawing.Point(2049, 700);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(40, 17);
            this.label243.TabIndex = 535;
            this.label243.Text = "COM:";
            // 
            // COM36
            // 
            this.COM36.FormattingEnabled = true;
            this.COM36.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM36.Location = new System.Drawing.Point(2100, 663);
            this.COM36.Name = "COM36";
            this.COM36.Size = new System.Drawing.Size(52, 23);
            this.COM36.TabIndex = 534;
            // 
            // label244
            // 
            this.label244.AutoSize = true;
            this.label244.Location = new System.Drawing.Point(2049, 665);
            this.label244.Name = "label244";
            this.label244.Size = new System.Drawing.Size(40, 17);
            this.label244.TabIndex = 533;
            this.label244.Text = "COM:";
            // 
            // feedback37
            // 
            this.feedback37.FormattingEnabled = true;
            this.feedback37.Location = new System.Drawing.Point(2253, 698);
            this.feedback37.Name = "feedback37";
            this.feedback37.Size = new System.Drawing.Size(167, 23);
            this.feedback37.TabIndex = 526;
            // 
            // label248
            // 
            this.label248.AutoSize = true;
            this.label248.Location = new System.Drawing.Point(2158, 700);
            this.label248.Name = "label248";
            this.label248.Size = new System.Drawing.Size(79, 17);
            this.label248.TabIndex = 525;
            this.label248.Text = "Feedback37:";
            // 
            // feedback36
            // 
            this.feedback36.FormattingEnabled = true;
            this.feedback36.Location = new System.Drawing.Point(2253, 663);
            this.feedback36.Name = "feedback36";
            this.feedback36.Size = new System.Drawing.Size(167, 23);
            this.feedback36.TabIndex = 524;
            // 
            // label249
            // 
            this.label249.AutoSize = true;
            this.label249.Location = new System.Drawing.Point(2158, 665);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(79, 17);
            this.label249.TabIndex = 523;
            this.label249.Text = "Feedback36:";
            // 
            // step37Job
            // 
            this.step37Job.FormattingEnabled = true;
            this.step37Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step37Job.Location = new System.Drawing.Point(1489, 698);
            this.step37Job.Name = "step37Job";
            this.step37Job.Size = new System.Drawing.Size(58, 23);
            this.step37Job.TabIndex = 516;
            this.step37Job.SelectedIndexChanged += new System.EventHandler(this.step37Job_SelectedIndexChanged);
            // 
            // label253
            // 
            this.label253.AutoSize = true;
            this.label253.Location = new System.Drawing.Point(1428, 700);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(51, 17);
            this.label253.TabIndex = 515;
            this.label253.Text = "Step37:";
            // 
            // step36Job
            // 
            this.step36Job.FormattingEnabled = true;
            this.step36Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step36Job.Location = new System.Drawing.Point(1489, 663);
            this.step36Job.Name = "step36Job";
            this.step36Job.Size = new System.Drawing.Size(58, 23);
            this.step36Job.TabIndex = 514;
            this.step36Job.SelectedIndexChanged += new System.EventHandler(this.step36Job_SelectedIndexChanged);
            // 
            // label254
            // 
            this.label254.AutoSize = true;
            this.label254.Location = new System.Drawing.Point(1428, 665);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(51, 17);
            this.label254.TabIndex = 513;
            this.label254.Text = "Step36:";
            // 
            // label255
            // 
            this.label255.AutoSize = true;
            this.label255.Location = new System.Drawing.Point(1562, 630);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(49, 17);
            this.label255.TabIndex = 512;
            this.label255.Text = "İsim35:";
            // 
            // isim35
            // 
            this.isim35.Location = new System.Drawing.Point(1621, 628);
            this.isim35.Name = "isim35";
            this.isim35.Size = new System.Drawing.Size(174, 24);
            this.isim35.TabIndex = 511;
            // 
            // label256
            // 
            this.label256.AutoSize = true;
            this.label256.Location = new System.Drawing.Point(1562, 595);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(49, 17);
            this.label256.TabIndex = 510;
            this.label256.Text = "İsim34:";
            // 
            // isim34
            // 
            this.isim34.Location = new System.Drawing.Point(1621, 593);
            this.isim34.Name = "isim34";
            this.isim34.Size = new System.Drawing.Size(174, 24);
            this.isim34.TabIndex = 509;
            // 
            // label257
            // 
            this.label257.AutoSize = true;
            this.label257.Location = new System.Drawing.Point(1562, 560);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(49, 17);
            this.label257.TabIndex = 508;
            this.label257.Text = "İsim33:";
            // 
            // isim33
            // 
            this.isim33.Location = new System.Drawing.Point(1621, 558);
            this.isim33.Name = "isim33";
            this.isim33.Size = new System.Drawing.Size(174, 24);
            this.isim33.TabIndex = 507;
            // 
            // label258
            // 
            this.label258.AutoSize = true;
            this.label258.Location = new System.Drawing.Point(1562, 525);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(49, 17);
            this.label258.TabIndex = 506;
            this.label258.Text = "İsim32:";
            // 
            // isim32
            // 
            this.isim32.Location = new System.Drawing.Point(1621, 523);
            this.isim32.Name = "isim32";
            this.isim32.Size = new System.Drawing.Size(174, 24);
            this.isim32.TabIndex = 505;
            // 
            // label259
            // 
            this.label259.AutoSize = true;
            this.label259.Location = new System.Drawing.Point(2620, 630);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(60, 17);
            this.label259.TabIndex = 504;
            this.label259.Text = "Görev35:";
            // 
            // gorev35
            // 
            this.gorev35.Location = new System.Drawing.Point(2692, 628);
            this.gorev35.Name = "gorev35";
            this.gorev35.Size = new System.Drawing.Size(100, 24);
            this.gorev35.TabIndex = 503;
            // 
            // label260
            // 
            this.label260.AutoSize = true;
            this.label260.Location = new System.Drawing.Point(2620, 595);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(60, 17);
            this.label260.TabIndex = 502;
            this.label260.Text = "Görev34:";
            // 
            // gorev34
            // 
            this.gorev34.Location = new System.Drawing.Point(2692, 593);
            this.gorev34.Name = "gorev34";
            this.gorev34.Size = new System.Drawing.Size(100, 24);
            this.gorev34.TabIndex = 501;
            // 
            // label261
            // 
            this.label261.AutoSize = true;
            this.label261.Location = new System.Drawing.Point(2620, 560);
            this.label261.Name = "label261";
            this.label261.Size = new System.Drawing.Size(60, 17);
            this.label261.TabIndex = 500;
            this.label261.Text = "Görev33:";
            // 
            // gorev33
            // 
            this.gorev33.Location = new System.Drawing.Point(2691, 558);
            this.gorev33.Name = "gorev33";
            this.gorev33.Size = new System.Drawing.Size(100, 24);
            this.gorev33.TabIndex = 499;
            // 
            // label262
            // 
            this.label262.AutoSize = true;
            this.label262.Location = new System.Drawing.Point(2620, 525);
            this.label262.Name = "label262";
            this.label262.Size = new System.Drawing.Size(60, 17);
            this.label262.TabIndex = 498;
            this.label262.Text = "Görev32:";
            // 
            // gorev32
            // 
            this.gorev32.Location = new System.Drawing.Point(2692, 523);
            this.gorev32.Name = "gorev32";
            this.gorev32.Size = new System.Drawing.Size(100, 24);
            this.gorev32.TabIndex = 497;
            // 
            // label263
            // 
            this.label263.AutoSize = true;
            this.label263.Location = new System.Drawing.Point(2432, 630);
            this.label263.Name = "label263";
            this.label263.Size = new System.Drawing.Size(67, 17);
            this.label263.TabIndex = 496;
            this.label263.Text = "Kontrol35:";
            // 
            // kontrol35
            // 
            this.kontrol35.Location = new System.Drawing.Point(2514, 628);
            this.kontrol35.Name = "kontrol35";
            this.kontrol35.Size = new System.Drawing.Size(100, 24);
            this.kontrol35.TabIndex = 495;
            // 
            // label264
            // 
            this.label264.AutoSize = true;
            this.label264.Location = new System.Drawing.Point(2432, 595);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(67, 17);
            this.label264.TabIndex = 494;
            this.label264.Text = "Kontrol34:";
            // 
            // kontrol34
            // 
            this.kontrol34.Location = new System.Drawing.Point(2514, 593);
            this.kontrol34.Name = "kontrol34";
            this.kontrol34.Size = new System.Drawing.Size(100, 24);
            this.kontrol34.TabIndex = 493;
            // 
            // label265
            // 
            this.label265.AutoSize = true;
            this.label265.Location = new System.Drawing.Point(2432, 560);
            this.label265.Name = "label265";
            this.label265.Size = new System.Drawing.Size(67, 17);
            this.label265.TabIndex = 492;
            this.label265.Text = "Kontrol33:";
            // 
            // kontrol33
            // 
            this.kontrol33.Location = new System.Drawing.Point(2514, 558);
            this.kontrol33.Name = "kontrol33";
            this.kontrol33.Size = new System.Drawing.Size(100, 24);
            this.kontrol33.TabIndex = 491;
            // 
            // label266
            // 
            this.label266.AutoSize = true;
            this.label266.Location = new System.Drawing.Point(2432, 525);
            this.label266.Name = "label266";
            this.label266.Size = new System.Drawing.Size(67, 17);
            this.label266.TabIndex = 490;
            this.label266.Text = "Kontrol32:";
            // 
            // kontrol32
            // 
            this.kontrol32.Location = new System.Drawing.Point(2514, 523);
            this.kontrol32.Name = "kontrol32";
            this.kontrol32.Size = new System.Drawing.Size(100, 24);
            this.kontrol32.TabIndex = 489;
            // 
            // veri35
            // 
            this.veri35.FormattingEnabled = true;
            this.veri35.Items.AddRange(new object[] {
            ""});
            this.veri35.Location = new System.Drawing.Point(1858, 628);
            this.veri35.Name = "veri35";
            this.veri35.Size = new System.Drawing.Size(185, 23);
            this.veri35.TabIndex = 488;
            // 
            // label267
            // 
            this.label267.AutoSize = true;
            this.label267.Location = new System.Drawing.Point(1801, 630);
            this.label267.Name = "label267";
            this.label267.Size = new System.Drawing.Size(48, 17);
            this.label267.TabIndex = 487;
            this.label267.Text = "Veri35:";
            // 
            // veri34
            // 
            this.veri34.FormattingEnabled = true;
            this.veri34.Location = new System.Drawing.Point(1858, 593);
            this.veri34.Name = "veri34";
            this.veri34.Size = new System.Drawing.Size(185, 23);
            this.veri34.TabIndex = 486;
            // 
            // label268
            // 
            this.label268.AutoSize = true;
            this.label268.Location = new System.Drawing.Point(1801, 595);
            this.label268.Name = "label268";
            this.label268.Size = new System.Drawing.Size(48, 17);
            this.label268.TabIndex = 485;
            this.label268.Text = "Veri34:";
            // 
            // veri33
            // 
            this.veri33.FormattingEnabled = true;
            this.veri33.Items.AddRange(new object[] {
            ""});
            this.veri33.Location = new System.Drawing.Point(1858, 558);
            this.veri33.Name = "veri33";
            this.veri33.Size = new System.Drawing.Size(185, 23);
            this.veri33.TabIndex = 484;
            // 
            // label269
            // 
            this.label269.AutoSize = true;
            this.label269.Location = new System.Drawing.Point(1801, 560);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(48, 17);
            this.label269.TabIndex = 483;
            this.label269.Text = "Veri33:";
            // 
            // veri32
            // 
            this.veri32.FormattingEnabled = true;
            this.veri32.Location = new System.Drawing.Point(1858, 523);
            this.veri32.Name = "veri32";
            this.veri32.Size = new System.Drawing.Size(185, 23);
            this.veri32.TabIndex = 482;
            // 
            // label270
            // 
            this.label270.AutoSize = true;
            this.label270.Location = new System.Drawing.Point(1801, 525);
            this.label270.Name = "label270";
            this.label270.Size = new System.Drawing.Size(48, 17);
            this.label270.TabIndex = 481;
            this.label270.Text = "Veri32:";
            // 
            // COM35
            // 
            this.COM35.FormattingEnabled = true;
            this.COM35.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM35.Location = new System.Drawing.Point(2100, 628);
            this.COM35.Name = "COM35";
            this.COM35.Size = new System.Drawing.Size(52, 23);
            this.COM35.TabIndex = 480;
            // 
            // label271
            // 
            this.label271.AutoSize = true;
            this.label271.Location = new System.Drawing.Point(2049, 630);
            this.label271.Name = "label271";
            this.label271.Size = new System.Drawing.Size(40, 17);
            this.label271.TabIndex = 479;
            this.label271.Text = "COM:";
            // 
            // COM34
            // 
            this.COM34.FormattingEnabled = true;
            this.COM34.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM34.Location = new System.Drawing.Point(2100, 593);
            this.COM34.Name = "COM34";
            this.COM34.Size = new System.Drawing.Size(52, 23);
            this.COM34.TabIndex = 478;
            // 
            // label272
            // 
            this.label272.AutoSize = true;
            this.label272.Location = new System.Drawing.Point(2049, 595);
            this.label272.Name = "label272";
            this.label272.Size = new System.Drawing.Size(40, 17);
            this.label272.TabIndex = 477;
            this.label272.Text = "COM:";
            // 
            // COM33
            // 
            this.COM33.FormattingEnabled = true;
            this.COM33.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM33.Location = new System.Drawing.Point(2100, 558);
            this.COM33.Name = "COM33";
            this.COM33.Size = new System.Drawing.Size(52, 23);
            this.COM33.TabIndex = 476;
            // 
            // label273
            // 
            this.label273.AutoSize = true;
            this.label273.Location = new System.Drawing.Point(2049, 560);
            this.label273.Name = "label273";
            this.label273.Size = new System.Drawing.Size(40, 17);
            this.label273.TabIndex = 475;
            this.label273.Text = "COM:";
            // 
            // COM32
            // 
            this.COM32.FormattingEnabled = true;
            this.COM32.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM32.Location = new System.Drawing.Point(2100, 523);
            this.COM32.Name = "COM32";
            this.COM32.Size = new System.Drawing.Size(52, 23);
            this.COM32.TabIndex = 474;
            // 
            // label274
            // 
            this.label274.AutoSize = true;
            this.label274.Location = new System.Drawing.Point(2049, 525);
            this.label274.Name = "label274";
            this.label274.Size = new System.Drawing.Size(40, 17);
            this.label274.TabIndex = 473;
            this.label274.Text = "COM:";
            // 
            // feedback35
            // 
            this.feedback35.FormattingEnabled = true;
            this.feedback35.Items.AddRange(new object[] {
            ""});
            this.feedback35.Location = new System.Drawing.Point(2253, 628);
            this.feedback35.Name = "feedback35";
            this.feedback35.Size = new System.Drawing.Size(167, 23);
            this.feedback35.TabIndex = 472;
            // 
            // label275
            // 
            this.label275.AutoSize = true;
            this.label275.Location = new System.Drawing.Point(2158, 630);
            this.label275.Name = "label275";
            this.label275.Size = new System.Drawing.Size(79, 17);
            this.label275.TabIndex = 471;
            this.label275.Text = "Feedback35:";
            // 
            // feedback34
            // 
            this.feedback34.FormattingEnabled = true;
            this.feedback34.Location = new System.Drawing.Point(2253, 593);
            this.feedback34.Name = "feedback34";
            this.feedback34.Size = new System.Drawing.Size(167, 23);
            this.feedback34.TabIndex = 470;
            // 
            // label276
            // 
            this.label276.AutoSize = true;
            this.label276.Location = new System.Drawing.Point(2158, 595);
            this.label276.Name = "label276";
            this.label276.Size = new System.Drawing.Size(79, 17);
            this.label276.TabIndex = 469;
            this.label276.Text = "Feedback34:";
            // 
            // feedback33
            // 
            this.feedback33.FormattingEnabled = true;
            this.feedback33.Items.AddRange(new object[] {
            ""});
            this.feedback33.Location = new System.Drawing.Point(2253, 558);
            this.feedback33.Name = "feedback33";
            this.feedback33.Size = new System.Drawing.Size(167, 23);
            this.feedback33.TabIndex = 468;
            // 
            // label277
            // 
            this.label277.AutoSize = true;
            this.label277.Location = new System.Drawing.Point(2158, 560);
            this.label277.Name = "label277";
            this.label277.Size = new System.Drawing.Size(79, 17);
            this.label277.TabIndex = 467;
            this.label277.Text = "Feedback33:";
            // 
            // feedback32
            // 
            this.feedback32.FormattingEnabled = true;
            this.feedback32.Location = new System.Drawing.Point(2253, 523);
            this.feedback32.Name = "feedback32";
            this.feedback32.Size = new System.Drawing.Size(167, 23);
            this.feedback32.TabIndex = 466;
            // 
            // label278
            // 
            this.label278.AutoSize = true;
            this.label278.Location = new System.Drawing.Point(2158, 525);
            this.label278.Name = "label278";
            this.label278.Size = new System.Drawing.Size(79, 17);
            this.label278.TabIndex = 465;
            this.label278.Text = "Feedback32:";
            // 
            // step35Job
            // 
            this.step35Job.FormattingEnabled = true;
            this.step35Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step35Job.Location = new System.Drawing.Point(1489, 628);
            this.step35Job.Name = "step35Job";
            this.step35Job.Size = new System.Drawing.Size(58, 23);
            this.step35Job.TabIndex = 464;
            this.step35Job.SelectedIndexChanged += new System.EventHandler(this.step35Job_SelectedIndexChanged);
            // 
            // label279
            // 
            this.label279.AutoSize = true;
            this.label279.Location = new System.Drawing.Point(1428, 630);
            this.label279.Name = "label279";
            this.label279.Size = new System.Drawing.Size(51, 17);
            this.label279.TabIndex = 463;
            this.label279.Text = "Step35:";
            // 
            // step34Job
            // 
            this.step34Job.FormattingEnabled = true;
            this.step34Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step34Job.Location = new System.Drawing.Point(1489, 593);
            this.step34Job.Name = "step34Job";
            this.step34Job.Size = new System.Drawing.Size(58, 23);
            this.step34Job.TabIndex = 462;
            this.step34Job.SelectedIndexChanged += new System.EventHandler(this.step34Job_SelectedIndexChanged);
            // 
            // label280
            // 
            this.label280.AutoSize = true;
            this.label280.Location = new System.Drawing.Point(1428, 595);
            this.label280.Name = "label280";
            this.label280.Size = new System.Drawing.Size(51, 17);
            this.label280.TabIndex = 461;
            this.label280.Text = "Step34:";
            // 
            // step33Job
            // 
            this.step33Job.FormattingEnabled = true;
            this.step33Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step33Job.Location = new System.Drawing.Point(1489, 558);
            this.step33Job.Name = "step33Job";
            this.step33Job.Size = new System.Drawing.Size(58, 23);
            this.step33Job.TabIndex = 460;
            this.step33Job.SelectedIndexChanged += new System.EventHandler(this.step33Job_SelectedIndexChanged);
            // 
            // label281
            // 
            this.label281.AutoSize = true;
            this.label281.Location = new System.Drawing.Point(1428, 560);
            this.label281.Name = "label281";
            this.label281.Size = new System.Drawing.Size(51, 17);
            this.label281.TabIndex = 459;
            this.label281.Text = "Step33:";
            // 
            // step32Job
            // 
            this.step32Job.FormattingEnabled = true;
            this.step32Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step32Job.Location = new System.Drawing.Point(1489, 523);
            this.step32Job.Name = "step32Job";
            this.step32Job.Size = new System.Drawing.Size(58, 23);
            this.step32Job.TabIndex = 458;
            this.step32Job.SelectedIndexChanged += new System.EventHandler(this.step32Job_SelectedIndexChanged);
            // 
            // label282
            // 
            this.label282.AutoSize = true;
            this.label282.Location = new System.Drawing.Point(1428, 525);
            this.label282.Name = "label282";
            this.label282.Size = new System.Drawing.Size(51, 17);
            this.label282.TabIndex = 457;
            this.label282.Text = "Step32:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1397, 140);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 689);
            this.vScrollBar1.TabIndex = 577;
            // 
            // infoPicture7
            // 
            this.infoPicture7.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture7.Image")));
            this.infoPicture7.Location = new System.Drawing.Point(1319, 120);
            this.infoPicture7.Name = "infoPicture7";
            this.infoPicture7.Size = new System.Drawing.Size(20, 20);
            this.infoPicture7.TabIndex = 456;
            this.infoPicture7.TabStop = false;
            // 
            // infoPicture6
            // 
            this.infoPicture6.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture6.Image")));
            this.infoPicture6.Location = new System.Drawing.Point(1141, 120);
            this.infoPicture6.Name = "infoPicture6";
            this.infoPicture6.Size = new System.Drawing.Size(20, 20);
            this.infoPicture6.TabIndex = 455;
            this.infoPicture6.TabStop = false;
            // 
            // infoPicture5
            // 
            this.infoPicture5.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture5.Image")));
            this.infoPicture5.Location = new System.Drawing.Point(913, 120);
            this.infoPicture5.Name = "infoPicture5";
            this.infoPicture5.Size = new System.Drawing.Size(20, 20);
            this.infoPicture5.TabIndex = 454;
            this.infoPicture5.TabStop = false;
            // 
            // infoPicture4
            // 
            this.infoPicture4.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture4.Image")));
            this.infoPicture4.Location = new System.Drawing.Point(704, 120);
            this.infoPicture4.Name = "infoPicture4";
            this.infoPicture4.Size = new System.Drawing.Size(20, 20);
            this.infoPicture4.TabIndex = 453;
            this.infoPicture4.TabStop = false;
            // 
            // infoPicture3
            // 
            this.infoPicture3.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture3.Image")));
            this.infoPicture3.Location = new System.Drawing.Point(530, 120);
            this.infoPicture3.Name = "infoPicture3";
            this.infoPicture3.Size = new System.Drawing.Size(20, 20);
            this.infoPicture3.TabIndex = 452;
            this.infoPicture3.TabStop = false;
            // 
            // infoPicture2
            // 
            this.infoPicture2.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture2.Image")));
            this.infoPicture2.Location = new System.Drawing.Point(284, 120);
            this.infoPicture2.Name = "infoPicture2";
            this.infoPicture2.Size = new System.Drawing.Size(20, 20);
            this.infoPicture2.TabIndex = 451;
            this.infoPicture2.TabStop = false;
            // 
            // infoPicture1
            // 
            this.infoPicture1.Image = ((System.Drawing.Image)(resources.GetObject("infoPicture1.Image")));
            this.infoPicture1.Location = new System.Drawing.Point(96, 120);
            this.infoPicture1.Name = "infoPicture1";
            this.infoPicture1.Size = new System.Drawing.Size(20, 20);
            this.infoPicture1.TabIndex = 450;
            this.infoPicture1.TabStop = false;
            // 
            // btnKaydetIni
            // 
            this.btnKaydetIni.BackColor = System.Drawing.Color.Aqua;
            this.btnKaydetIni.Location = new System.Drawing.Point(128, 50);
            this.btnKaydetIni.Name = "btnKaydetIni";
            this.btnKaydetIni.Size = new System.Drawing.Size(80, 30);
            this.btnKaydetIni.TabIndex = 578;
            this.btnKaydetIni.Text = "Kaydet";
            this.btnKaydetIni.UseVisualStyleBackColor = false;
            this.btnKaydetIni.Click += new System.EventHandler(this.btnKaydetIni_Click);
            // 
            // btnOkuIni
            // 
            this.btnOkuIni.BackColor = System.Drawing.Color.Aqua;
            this.btnOkuIni.Location = new System.Drawing.Point(214, 50);
            this.btnOkuIni.Name = "btnOkuIni";
            this.btnOkuIni.Size = new System.Drawing.Size(80, 30);
            this.btnOkuIni.TabIndex = 579;
            this.btnOkuIni.Text = "Oku";
            this.btnOkuIni.UseVisualStyleBackColor = false;
            this.btnOkuIni.Click += new System.EventHandler(this.btnOkuIni_Click);
            // 
            // btnINIsec
            // 
            this.btnINIsec.BackColor = System.Drawing.Color.Aqua;
            this.btnINIsec.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnINIsec.Location = new System.Drawing.Point(303, 20);
            this.btnINIsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINIsec.Name = "btnINIsec";
            this.btnINIsec.Size = new System.Drawing.Size(64, 23);
            this.btnINIsec.TabIndex = 582;
            this.btnINIsec.Text = "Seç";
            this.btnINIsec.UseVisualStyleBackColor = false;
            this.btnINIsec.Click += new System.EventHandler(this.btnIDsec_Click);
            // 
            // txtINIdosya
            // 
            this.txtINIdosya.Location = new System.Drawing.Point(128, 19);
            this.txtINIdosya.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtINIdosya.Name = "txtINIdosya";
            this.txtINIdosya.Size = new System.Drawing.Size(167, 24);
            this.txtINIdosya.TabIndex = 581;
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Location = new System.Drawing.Point(6, 19);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(116, 17);
            this.label220.TabIndex = 580;
            this.label220.Text = "Ayarlar Dosya Yolu:";
            // 
            // chBoxProgramlama
            // 
            this.chBoxProgramlama.AutoSize = true;
            this.chBoxProgramlama.Location = new System.Drawing.Point(11, 76);
            this.chBoxProgramlama.Name = "chBoxProgramlama";
            this.chBoxProgramlama.Size = new System.Drawing.Size(160, 21);
            this.chBoxProgramlama.TabIndex = 583;
            this.chBoxProgramlama.Text = "Programlama Otomatik";
            this.chBoxProgramlama.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtINIdosya);
            this.groupBox1.Controls.Add(this.btnKaydetIni);
            this.groupBox1.Controls.Add(this.btnINIsec);
            this.groupBox1.Controls.Add(this.btnOkuIni);
            this.groupBox1.Controls.Add(this.label220);
            this.groupBox1.Location = new System.Drawing.Point(451, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 85);
            this.groupBox1.TabIndex = 584;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ini Dosyası Ayarları:";
            // 
            // label221
            // 
            this.label221.AutoSize = true;
            this.label221.Location = new System.Drawing.Point(1562, 736);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(49, 17);
            this.label221.TabIndex = 598;
            this.label221.Text = "İsim38:";
            // 
            // isim38
            // 
            this.isim38.Location = new System.Drawing.Point(1621, 734);
            this.isim38.Name = "isim38";
            this.isim38.Size = new System.Drawing.Size(174, 24);
            this.isim38.TabIndex = 597;
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Location = new System.Drawing.Point(2620, 736);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(60, 17);
            this.label222.TabIndex = 596;
            this.label222.Text = "Görev38:";
            // 
            // gorev38
            // 
            this.gorev38.Location = new System.Drawing.Point(2692, 734);
            this.gorev38.Name = "gorev38";
            this.gorev38.Size = new System.Drawing.Size(100, 24);
            this.gorev38.TabIndex = 595;
            // 
            // label225
            // 
            this.label225.AutoSize = true;
            this.label225.Location = new System.Drawing.Point(2432, 736);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(67, 17);
            this.label225.TabIndex = 594;
            this.label225.Text = "Kontrol38:";
            // 
            // kontrol38
            // 
            this.kontrol38.Location = new System.Drawing.Point(2514, 734);
            this.kontrol38.Name = "kontrol38";
            this.kontrol38.Size = new System.Drawing.Size(100, 24);
            this.kontrol38.TabIndex = 593;
            // 
            // veri38
            // 
            this.veri38.FormattingEnabled = true;
            this.veri38.Location = new System.Drawing.Point(1858, 734);
            this.veri38.Name = "veri38";
            this.veri38.Size = new System.Drawing.Size(185, 23);
            this.veri38.TabIndex = 592;
            // 
            // label226
            // 
            this.label226.AutoSize = true;
            this.label226.Location = new System.Drawing.Point(1801, 736);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(48, 17);
            this.label226.TabIndex = 591;
            this.label226.Text = "Veri38:";
            // 
            // COM38
            // 
            this.COM38.FormattingEnabled = true;
            this.COM38.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM38.Location = new System.Drawing.Point(2100, 734);
            this.COM38.Name = "COM38";
            this.COM38.Size = new System.Drawing.Size(52, 23);
            this.COM38.TabIndex = 590;
            // 
            // label227
            // 
            this.label227.AutoSize = true;
            this.label227.Location = new System.Drawing.Point(2049, 736);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(40, 17);
            this.label227.TabIndex = 589;
            this.label227.Text = "COM:";
            // 
            // feedback38
            // 
            this.feedback38.FormattingEnabled = true;
            this.feedback38.Location = new System.Drawing.Point(2253, 734);
            this.feedback38.Name = "feedback38";
            this.feedback38.Size = new System.Drawing.Size(167, 23);
            this.feedback38.TabIndex = 588;
            // 
            // label230
            // 
            this.label230.AutoSize = true;
            this.label230.Location = new System.Drawing.Point(2158, 736);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(79, 17);
            this.label230.TabIndex = 587;
            this.label230.Text = "Feedback38:";
            // 
            // step38Job
            // 
            this.step38Job.FormattingEnabled = true;
            this.step38Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step38Job.Location = new System.Drawing.Point(1489, 734);
            this.step38Job.Name = "step38Job";
            this.step38Job.Size = new System.Drawing.Size(58, 23);
            this.step38Job.TabIndex = 586;
            this.step38Job.SelectedIndexChanged += new System.EventHandler(this.step38Job_SelectedIndexChanged);
            // 
            // label231
            // 
            this.label231.AutoSize = true;
            this.label231.Location = new System.Drawing.Point(1428, 736);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(51, 17);
            this.label231.TabIndex = 585;
            this.label231.Text = "Step38:";
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(1562, 771);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(49, 17);
            this.label232.TabIndex = 611;
            this.label232.Text = "İsim39:";
            // 
            // isim39
            // 
            this.isim39.Location = new System.Drawing.Point(1621, 769);
            this.isim39.Name = "isim39";
            this.isim39.Size = new System.Drawing.Size(174, 24);
            this.isim39.TabIndex = 610;
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Location = new System.Drawing.Point(2620, 771);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(60, 17);
            this.label235.TabIndex = 609;
            this.label235.Text = "Görev39:";
            // 
            // gorev39
            // 
            this.gorev39.Location = new System.Drawing.Point(2692, 769);
            this.gorev39.Name = "gorev39";
            this.gorev39.Size = new System.Drawing.Size(100, 24);
            this.gorev39.TabIndex = 608;
            // 
            // label236
            // 
            this.label236.AutoSize = true;
            this.label236.Location = new System.Drawing.Point(2432, 771);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(67, 17);
            this.label236.TabIndex = 607;
            this.label236.Text = "Kontrol39:";
            // 
            // kontrol39
            // 
            this.kontrol39.Location = new System.Drawing.Point(2514, 769);
            this.kontrol39.Name = "kontrol39";
            this.kontrol39.Size = new System.Drawing.Size(100, 24);
            this.kontrol39.TabIndex = 606;
            // 
            // veri39
            // 
            this.veri39.FormattingEnabled = true;
            this.veri39.Location = new System.Drawing.Point(1858, 769);
            this.veri39.Name = "veri39";
            this.veri39.Size = new System.Drawing.Size(185, 23);
            this.veri39.TabIndex = 605;
            // 
            // COM39
            // 
            this.COM39.FormattingEnabled = true;
            this.COM39.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM39.Location = new System.Drawing.Point(2100, 769);
            this.COM39.Name = "COM39";
            this.COM39.Size = new System.Drawing.Size(52, 23);
            this.COM39.TabIndex = 604;
            // 
            // label237
            // 
            this.label237.AutoSize = true;
            this.label237.Location = new System.Drawing.Point(2049, 771);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(40, 17);
            this.label237.TabIndex = 603;
            this.label237.Text = "COM:";
            // 
            // feedback39
            // 
            this.feedback39.FormattingEnabled = true;
            this.feedback39.Location = new System.Drawing.Point(2253, 769);
            this.feedback39.Name = "feedback39";
            this.feedback39.Size = new System.Drawing.Size(167, 23);
            this.feedback39.TabIndex = 602;
            // 
            // label240
            // 
            this.label240.AutoSize = true;
            this.label240.Location = new System.Drawing.Point(2158, 771);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(79, 17);
            this.label240.TabIndex = 601;
            this.label240.Text = "Feedback39:";
            // 
            // step39Job
            // 
            this.step39Job.FormattingEnabled = true;
            this.step39Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step39Job.Location = new System.Drawing.Point(1489, 769);
            this.step39Job.Name = "step39Job";
            this.step39Job.Size = new System.Drawing.Size(58, 23);
            this.step39Job.TabIndex = 600;
            this.step39Job.SelectedIndexChanged += new System.EventHandler(this.step39Job_SelectedIndexChanged);
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Location = new System.Drawing.Point(1428, 771);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(51, 17);
            this.label241.TabIndex = 599;
            this.label241.Text = "Step39:";
            // 
            // label242
            // 
            this.label242.AutoSize = true;
            this.label242.Location = new System.Drawing.Point(1562, 806);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(49, 17);
            this.label242.TabIndex = 624;
            this.label242.Text = "İsim40:";
            // 
            // isim40
            // 
            this.isim40.Location = new System.Drawing.Point(1621, 804);
            this.isim40.Name = "isim40";
            this.isim40.Size = new System.Drawing.Size(174, 24);
            this.isim40.TabIndex = 623;
            // 
            // label245
            // 
            this.label245.AutoSize = true;
            this.label245.Location = new System.Drawing.Point(2620, 806);
            this.label245.Name = "label245";
            this.label245.Size = new System.Drawing.Size(60, 17);
            this.label245.TabIndex = 622;
            this.label245.Text = "Görev40:";
            // 
            // gorev40
            // 
            this.gorev40.Location = new System.Drawing.Point(2692, 804);
            this.gorev40.Name = "gorev40";
            this.gorev40.Size = new System.Drawing.Size(100, 24);
            this.gorev40.TabIndex = 621;
            // 
            // label246
            // 
            this.label246.AutoSize = true;
            this.label246.Location = new System.Drawing.Point(2432, 806);
            this.label246.Name = "label246";
            this.label246.Size = new System.Drawing.Size(67, 17);
            this.label246.TabIndex = 620;
            this.label246.Text = "Kontrol40:";
            // 
            // kontrol40
            // 
            this.kontrol40.Location = new System.Drawing.Point(2514, 804);
            this.kontrol40.Name = "kontrol40";
            this.kontrol40.Size = new System.Drawing.Size(100, 24);
            this.kontrol40.TabIndex = 619;
            // 
            // veri40
            // 
            this.veri40.FormattingEnabled = true;
            this.veri40.Location = new System.Drawing.Point(1858, 804);
            this.veri40.Name = "veri40";
            this.veri40.Size = new System.Drawing.Size(185, 23);
            this.veri40.TabIndex = 618;
            // 
            // COM40
            // 
            this.COM40.FormattingEnabled = true;
            this.COM40.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.COM40.Location = new System.Drawing.Point(2100, 804);
            this.COM40.Name = "COM40";
            this.COM40.Size = new System.Drawing.Size(52, 23);
            this.COM40.TabIndex = 617;
            // 
            // label247
            // 
            this.label247.AutoSize = true;
            this.label247.Location = new System.Drawing.Point(2049, 806);
            this.label247.Name = "label247";
            this.label247.Size = new System.Drawing.Size(40, 17);
            this.label247.TabIndex = 616;
            this.label247.Text = "COM:";
            // 
            // feedback40
            // 
            this.feedback40.FormattingEnabled = true;
            this.feedback40.Location = new System.Drawing.Point(2253, 804);
            this.feedback40.Name = "feedback40";
            this.feedback40.Size = new System.Drawing.Size(167, 23);
            this.feedback40.TabIndex = 615;
            // 
            // label250
            // 
            this.label250.AutoSize = true;
            this.label250.Location = new System.Drawing.Point(2158, 806);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(79, 17);
            this.label250.TabIndex = 614;
            this.label250.Text = "Feedback40:";
            // 
            // step40Job
            // 
            this.step40Job.FormattingEnabled = true;
            this.step40Job.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.step40Job.Location = new System.Drawing.Point(1489, 804);
            this.step40Job.Name = "step40Job";
            this.step40Job.Size = new System.Drawing.Size(58, 23);
            this.step40Job.TabIndex = 613;
            this.step40Job.SelectedIndexChanged += new System.EventHandler(this.step40Job_SelectedIndexChanged);
            // 
            // label251
            // 
            this.label251.AutoSize = true;
            this.label251.Location = new System.Drawing.Point(1428, 806);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(51, 17);
            this.label251.TabIndex = 612;
            this.label251.Text = "Step40:";
            // 
            // label252
            // 
            this.label252.AutoSize = true;
            this.label252.Location = new System.Drawing.Point(1801, 772);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(48, 17);
            this.label252.TabIndex = 625;
            this.label252.Text = "Veri39:";
            // 
            // label283
            // 
            this.label283.AutoSize = true;
            this.label283.Location = new System.Drawing.Point(1801, 808);
            this.label283.Name = "label283";
            this.label283.Size = new System.Drawing.Size(48, 17);
            this.label283.TabIndex = 626;
            this.label283.Text = "Veri40:";
            // 
            // KurulumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2811, 916);
            this.Controls.Add(this.label283);
            this.Controls.Add(this.label252);
            this.Controls.Add(this.label242);
            this.Controls.Add(this.isim40);
            this.Controls.Add(this.label245);
            this.Controls.Add(this.gorev40);
            this.Controls.Add(this.label246);
            this.Controls.Add(this.kontrol40);
            this.Controls.Add(this.veri40);
            this.Controls.Add(this.COM40);
            this.Controls.Add(this.label247);
            this.Controls.Add(this.feedback40);
            this.Controls.Add(this.label250);
            this.Controls.Add(this.step40Job);
            this.Controls.Add(this.label251);
            this.Controls.Add(this.label232);
            this.Controls.Add(this.isim39);
            this.Controls.Add(this.label235);
            this.Controls.Add(this.gorev39);
            this.Controls.Add(this.label236);
            this.Controls.Add(this.kontrol39);
            this.Controls.Add(this.veri39);
            this.Controls.Add(this.COM39);
            this.Controls.Add(this.label237);
            this.Controls.Add(this.feedback39);
            this.Controls.Add(this.label240);
            this.Controls.Add(this.step39Job);
            this.Controls.Add(this.label241);
            this.Controls.Add(this.label221);
            this.Controls.Add(this.isim38);
            this.Controls.Add(this.label222);
            this.Controls.Add(this.gorev38);
            this.Controls.Add(this.label225);
            this.Controls.Add(this.kontrol38);
            this.Controls.Add(this.veri38);
            this.Controls.Add(this.label226);
            this.Controls.Add(this.COM38);
            this.Controls.Add(this.label227);
            this.Controls.Add(this.feedback38);
            this.Controls.Add(this.label230);
            this.Controls.Add(this.step38Job);
            this.Controls.Add(this.label231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chBoxProgramlama);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label223);
            this.Controls.Add(this.isim37);
            this.Controls.Add(this.label224);
            this.Controls.Add(this.isim36);
            this.Controls.Add(this.label228);
            this.Controls.Add(this.gorev37);
            this.Controls.Add(this.label229);
            this.Controls.Add(this.gorev36);
            this.Controls.Add(this.label233);
            this.Controls.Add(this.kontrol37);
            this.Controls.Add(this.label234);
            this.Controls.Add(this.kontrol36);
            this.Controls.Add(this.veri37);
            this.Controls.Add(this.label238);
            this.Controls.Add(this.veri36);
            this.Controls.Add(this.label239);
            this.Controls.Add(this.COM37);
            this.Controls.Add(this.label243);
            this.Controls.Add(this.COM36);
            this.Controls.Add(this.label244);
            this.Controls.Add(this.feedback37);
            this.Controls.Add(this.label248);
            this.Controls.Add(this.feedback36);
            this.Controls.Add(this.label249);
            this.Controls.Add(this.step37Job);
            this.Controls.Add(this.label253);
            this.Controls.Add(this.step36Job);
            this.Controls.Add(this.label254);
            this.Controls.Add(this.label255);
            this.Controls.Add(this.isim35);
            this.Controls.Add(this.label256);
            this.Controls.Add(this.isim34);
            this.Controls.Add(this.label257);
            this.Controls.Add(this.isim33);
            this.Controls.Add(this.label258);
            this.Controls.Add(this.isim32);
            this.Controls.Add(this.label259);
            this.Controls.Add(this.gorev35);
            this.Controls.Add(this.label260);
            this.Controls.Add(this.gorev34);
            this.Controls.Add(this.label261);
            this.Controls.Add(this.gorev33);
            this.Controls.Add(this.label262);
            this.Controls.Add(this.gorev32);
            this.Controls.Add(this.label263);
            this.Controls.Add(this.kontrol35);
            this.Controls.Add(this.label264);
            this.Controls.Add(this.kontrol34);
            this.Controls.Add(this.label265);
            this.Controls.Add(this.kontrol33);
            this.Controls.Add(this.label266);
            this.Controls.Add(this.kontrol32);
            this.Controls.Add(this.veri35);
            this.Controls.Add(this.label267);
            this.Controls.Add(this.veri34);
            this.Controls.Add(this.label268);
            this.Controls.Add(this.veri33);
            this.Controls.Add(this.label269);
            this.Controls.Add(this.veri32);
            this.Controls.Add(this.label270);
            this.Controls.Add(this.COM35);
            this.Controls.Add(this.label271);
            this.Controls.Add(this.COM34);
            this.Controls.Add(this.label272);
            this.Controls.Add(this.COM33);
            this.Controls.Add(this.label273);
            this.Controls.Add(this.COM32);
            this.Controls.Add(this.label274);
            this.Controls.Add(this.feedback35);
            this.Controls.Add(this.label275);
            this.Controls.Add(this.feedback34);
            this.Controls.Add(this.label276);
            this.Controls.Add(this.feedback33);
            this.Controls.Add(this.label277);
            this.Controls.Add(this.feedback32);
            this.Controls.Add(this.label278);
            this.Controls.Add(this.step35Job);
            this.Controls.Add(this.label279);
            this.Controls.Add(this.step34Job);
            this.Controls.Add(this.label280);
            this.Controls.Add(this.step33Job);
            this.Controls.Add(this.label281);
            this.Controls.Add(this.step32Job);
            this.Controls.Add(this.label282);
            this.Controls.Add(this.infoPicture7);
            this.Controls.Add(this.infoPicture6);
            this.Controls.Add(this.infoPicture5);
            this.Controls.Add(this.infoPicture4);
            this.Controls.Add(this.infoPicture3);
            this.Controls.Add(this.infoPicture2);
            this.Controls.Add(this.infoPicture1);
            this.Controls.Add(this.label213);
            this.Controls.Add(this.isim31);
            this.Controls.Add(this.label214);
            this.Controls.Add(this.gorev31);
            this.Controls.Add(this.label215);
            this.Controls.Add(this.kontrol31);
            this.Controls.Add(this.veri31);
            this.Controls.Add(this.label216);
            this.Controls.Add(this.COM31);
            this.Controls.Add(this.label217);
            this.Controls.Add(this.feedback31);
            this.Controls.Add(this.label218);
            this.Controls.Add(this.step31Job);
            this.Controls.Add(this.label219);
            this.Controls.Add(this.label143);
            this.Controls.Add(this.isim30);
            this.Controls.Add(this.label144);
            this.Controls.Add(this.isim29);
            this.Controls.Add(this.label145);
            this.Controls.Add(this.isim28);
            this.Controls.Add(this.label146);
            this.Controls.Add(this.isim27);
            this.Controls.Add(this.label147);
            this.Controls.Add(this.isim26);
            this.Controls.Add(this.label148);
            this.Controls.Add(this.gorev30);
            this.Controls.Add(this.label149);
            this.Controls.Add(this.gorev29);
            this.Controls.Add(this.label150);
            this.Controls.Add(this.gorev28);
            this.Controls.Add(this.label151);
            this.Controls.Add(this.gorev27);
            this.Controls.Add(this.label152);
            this.Controls.Add(this.gorev26);
            this.Controls.Add(this.label153);
            this.Controls.Add(this.kontrol30);
            this.Controls.Add(this.label154);
            this.Controls.Add(this.kontrol29);
            this.Controls.Add(this.label155);
            this.Controls.Add(this.kontrol28);
            this.Controls.Add(this.label156);
            this.Controls.Add(this.kontrol27);
            this.Controls.Add(this.label157);
            this.Controls.Add(this.kontrol26);
            this.Controls.Add(this.veri30);
            this.Controls.Add(this.label158);
            this.Controls.Add(this.veri29);
            this.Controls.Add(this.label159);
            this.Controls.Add(this.veri28);
            this.Controls.Add(this.label160);
            this.Controls.Add(this.veri27);
            this.Controls.Add(this.label161);
            this.Controls.Add(this.veri26);
            this.Controls.Add(this.label162);
            this.Controls.Add(this.COM30);
            this.Controls.Add(this.label163);
            this.Controls.Add(this.COM29);
            this.Controls.Add(this.label164);
            this.Controls.Add(this.COM28);
            this.Controls.Add(this.label165);
            this.Controls.Add(this.COM27);
            this.Controls.Add(this.label166);
            this.Controls.Add(this.COM26);
            this.Controls.Add(this.label167);
            this.Controls.Add(this.feedback30);
            this.Controls.Add(this.label168);
            this.Controls.Add(this.feedback29);
            this.Controls.Add(this.label169);
            this.Controls.Add(this.feedback28);
            this.Controls.Add(this.label170);
            this.Controls.Add(this.feedback27);
            this.Controls.Add(this.label171);
            this.Controls.Add(this.feedback26);
            this.Controls.Add(this.label172);
            this.Controls.Add(this.step30Job);
            this.Controls.Add(this.label173);
            this.Controls.Add(this.step29Job);
            this.Controls.Add(this.label174);
            this.Controls.Add(this.step28Job);
            this.Controls.Add(this.label175);
            this.Controls.Add(this.step27Job);
            this.Controls.Add(this.label176);
            this.Controls.Add(this.step26Job);
            this.Controls.Add(this.label177);
            this.Controls.Add(this.label178);
            this.Controls.Add(this.isim25);
            this.Controls.Add(this.label179);
            this.Controls.Add(this.isim24);
            this.Controls.Add(this.label180);
            this.Controls.Add(this.isim23);
            this.Controls.Add(this.label181);
            this.Controls.Add(this.isim22);
            this.Controls.Add(this.label182);
            this.Controls.Add(this.isim21);
            this.Controls.Add(this.label183);
            this.Controls.Add(this.gorev25);
            this.Controls.Add(this.label184);
            this.Controls.Add(this.gorev24);
            this.Controls.Add(this.label185);
            this.Controls.Add(this.gorev23);
            this.Controls.Add(this.label186);
            this.Controls.Add(this.gorev22);
            this.Controls.Add(this.label187);
            this.Controls.Add(this.gorev21);
            this.Controls.Add(this.label188);
            this.Controls.Add(this.kontrol25);
            this.Controls.Add(this.label189);
            this.Controls.Add(this.kontrol24);
            this.Controls.Add(this.label190);
            this.Controls.Add(this.kontrol23);
            this.Controls.Add(this.label191);
            this.Controls.Add(this.kontrol22);
            this.Controls.Add(this.label192);
            this.Controls.Add(this.kontrol21);
            this.Controls.Add(this.veri25);
            this.Controls.Add(this.label193);
            this.Controls.Add(this.veri24);
            this.Controls.Add(this.label194);
            this.Controls.Add(this.veri23);
            this.Controls.Add(this.label195);
            this.Controls.Add(this.veri22);
            this.Controls.Add(this.label196);
            this.Controls.Add(this.veri21);
            this.Controls.Add(this.label197);
            this.Controls.Add(this.COM25);
            this.Controls.Add(this.label198);
            this.Controls.Add(this.COM24);
            this.Controls.Add(this.label199);
            this.Controls.Add(this.COM23);
            this.Controls.Add(this.label200);
            this.Controls.Add(this.COM22);
            this.Controls.Add(this.label201);
            this.Controls.Add(this.COM21);
            this.Controls.Add(this.label202);
            this.Controls.Add(this.feedback25);
            this.Controls.Add(this.label203);
            this.Controls.Add(this.feedback24);
            this.Controls.Add(this.label204);
            this.Controls.Add(this.feedback23);
            this.Controls.Add(this.label205);
            this.Controls.Add(this.feedback22);
            this.Controls.Add(this.label206);
            this.Controls.Add(this.feedback21);
            this.Controls.Add(this.label207);
            this.Controls.Add(this.step25Job);
            this.Controls.Add(this.label208);
            this.Controls.Add(this.step24Job);
            this.Controls.Add(this.label209);
            this.Controls.Add(this.step23Job);
            this.Controls.Add(this.label210);
            this.Controls.Add(this.step22Job);
            this.Controls.Add(this.label211);
            this.Controls.Add(this.step21Job);
            this.Controls.Add(this.label212);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.isim20);
            this.Controls.Add(this.label74);
            this.Controls.Add(this.isim19);
            this.Controls.Add(this.label75);
            this.Controls.Add(this.isim18);
            this.Controls.Add(this.label76);
            this.Controls.Add(this.isim17);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.isim16);
            this.Controls.Add(this.label78);
            this.Controls.Add(this.gorev20);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.gorev19);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.gorev18);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.gorev17);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.gorev16);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.kontrol20);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.kontrol19);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.kontrol18);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.kontrol17);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.kontrol16);
            this.Controls.Add(this.veri20);
            this.Controls.Add(this.label88);
            this.Controls.Add(this.veri19);
            this.Controls.Add(this.label89);
            this.Controls.Add(this.veri18);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.veri17);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.veri16);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.COM20);
            this.Controls.Add(this.label93);
            this.Controls.Add(this.COM19);
            this.Controls.Add(this.label94);
            this.Controls.Add(this.COM18);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.COM17);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.COM16);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.feedback20);
            this.Controls.Add(this.label98);
            this.Controls.Add(this.feedback19);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.feedback18);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.feedback17);
            this.Controls.Add(this.label101);
            this.Controls.Add(this.feedback16);
            this.Controls.Add(this.label102);
            this.Controls.Add(this.step20Job);
            this.Controls.Add(this.label103);
            this.Controls.Add(this.step19Job);
            this.Controls.Add(this.label104);
            this.Controls.Add(this.step18Job);
            this.Controls.Add(this.label105);
            this.Controls.Add(this.step17Job);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.step16Job);
            this.Controls.Add(this.label107);
            this.Controls.Add(this.label108);
            this.Controls.Add(this.isim15);
            this.Controls.Add(this.label109);
            this.Controls.Add(this.isim14);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.isim13);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.isim12);
            this.Controls.Add(this.label112);
            this.Controls.Add(this.isim11);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.gorev15);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.gorev14);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.gorev13);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.gorev12);
            this.Controls.Add(this.label117);
            this.Controls.Add(this.gorev11);
            this.Controls.Add(this.label118);
            this.Controls.Add(this.kontrol15);
            this.Controls.Add(this.label119);
            this.Controls.Add(this.kontrol14);
            this.Controls.Add(this.label120);
            this.Controls.Add(this.kontrol13);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.kontrol12);
            this.Controls.Add(this.label122);
            this.Controls.Add(this.kontrol11);
            this.Controls.Add(this.veri15);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.veri14);
            this.Controls.Add(this.label124);
            this.Controls.Add(this.veri13);
            this.Controls.Add(this.label125);
            this.Controls.Add(this.veri12);
            this.Controls.Add(this.label126);
            this.Controls.Add(this.veri11);
            this.Controls.Add(this.label127);
            this.Controls.Add(this.COM15);
            this.Controls.Add(this.label128);
            this.Controls.Add(this.COM14);
            this.Controls.Add(this.label129);
            this.Controls.Add(this.COM13);
            this.Controls.Add(this.label130);
            this.Controls.Add(this.COM12);
            this.Controls.Add(this.label131);
            this.Controls.Add(this.COM11);
            this.Controls.Add(this.label132);
            this.Controls.Add(this.feedback15);
            this.Controls.Add(this.label133);
            this.Controls.Add(this.feedback14);
            this.Controls.Add(this.label134);
            this.Controls.Add(this.feedback13);
            this.Controls.Add(this.label135);
            this.Controls.Add(this.feedback12);
            this.Controls.Add(this.label136);
            this.Controls.Add(this.feedback11);
            this.Controls.Add(this.label137);
            this.Controls.Add(this.step15Job);
            this.Controls.Add(this.label138);
            this.Controls.Add(this.step14Job);
            this.Controls.Add(this.label139);
            this.Controls.Add(this.step13Job);
            this.Controls.Add(this.label140);
            this.Controls.Add(this.step12Job);
            this.Controls.Add(this.label141);
            this.Controls.Add(this.step11Job);
            this.Controls.Add(this.label142);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.isim10);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.isim9);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.isim8);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.isim7);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.isim6);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.gorev10);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.gorev9);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.gorev8);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.gorev7);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.gorev6);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.kontrol10);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.kontrol9);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.kontrol8);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.kontrol7);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.kontrol6);
            this.Controls.Add(this.veri10);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.veri9);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.veri8);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.veri7);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.veri6);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.COM10);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.COM9);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.COM8);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.COM7);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.COM6);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.feedback10);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.feedback9);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.feedback8);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.feedback7);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.feedback6);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.step10Job);
            this.Controls.Add(this.label68);
            this.Controls.Add(this.step9Job);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.step8Job);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.step7Job);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.step6Job);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.isim5);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.isim4);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.isim3);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.isim2);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.isim1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.gorev5);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.gorev4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.gorev3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.gorev2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.gorev1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.kontrol5);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.kontrol4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.kontrol3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.kontrol2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kontrol1);
            this.Controls.Add(this.veri5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.veri4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.veri3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.veri2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.veri1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.COM5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COM4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.COM3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COM2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COM1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.feedback5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.feedback4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.feedback3);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.feedback2);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.feedback1);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.step5Job);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.step4Job);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.step3Job);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.step2Job);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.step1Job);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.stepNum);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnKaydet);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KurulumForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kurulum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AyarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnKaydetIni_Click(object sender, EventArgs e)
        {
            if (txtINIdosya.Text != "")
            {
                INIKaydet ini = new INIKaydet(txtINIdosya.Text);  // @"\Ayarlar.ini"
                ini.Yaz("programlamaChecked", "Metin Kutusu", Convert.ToString(chBoxProgramlama.Checked));

                ini.Yaz("stepNum", "Metin Kutusu", Convert.ToString(stepNum.Text));

                ini.Yaz("step1job", "Metin Kutusu", Convert.ToString(step1Job.Text));
                ini.Yaz("step2job", "Metin Kutusu", Convert.ToString(step2Job.Text));
                ini.Yaz("step3job", "Metin Kutusu", Convert.ToString(step3Job.Text));
                ini.Yaz("step4job", "Metin Kutusu", Convert.ToString(step4Job.Text));
                ini.Yaz("step5job", "Metin Kutusu", Convert.ToString(step5Job.Text));
                ini.Yaz("step6job", "Metin Kutusu", Convert.ToString(step6Job.Text));
                ini.Yaz("step7job", "Metin Kutusu", Convert.ToString(step7Job.Text));
                ini.Yaz("step8job", "Metin Kutusu", Convert.ToString(step8Job.Text));
                ini.Yaz("step9job", "Metin Kutusu", Convert.ToString(step9Job.Text));
                ini.Yaz("step10job", "Metin Kutusu", Convert.ToString(step10Job.Text));
                ini.Yaz("step11job", "Metin Kutusu", Convert.ToString(step11Job.Text));
                ini.Yaz("step12job", "Metin Kutusu", Convert.ToString(step12Job.Text));
                ini.Yaz("step13job", "Metin Kutusu", Convert.ToString(step13Job.Text));
                ini.Yaz("step14job", "Metin Kutusu", Convert.ToString(step14Job.Text));
                ini.Yaz("step15job", "Metin Kutusu", Convert.ToString(step15Job.Text));
                ini.Yaz("step16job", "Metin Kutusu", Convert.ToString(step16Job.Text));
                ini.Yaz("step17job", "Metin Kutusu", Convert.ToString(step17Job.Text));
                ini.Yaz("step18job", "Metin Kutusu", Convert.ToString(step18Job.Text));
                ini.Yaz("step19job", "Metin Kutusu", Convert.ToString(step19Job.Text));
                ini.Yaz("step20job", "Metin Kutusu", Convert.ToString(step20Job.Text));
                ini.Yaz("step21job", "Metin Kutusu", Convert.ToString(step21Job.Text));
                ini.Yaz("step22job", "Metin Kutusu", Convert.ToString(step22Job.Text));
                ini.Yaz("step23job", "Metin Kutusu", Convert.ToString(step23Job.Text));
                ini.Yaz("step24job", "Metin Kutusu", Convert.ToString(step24Job.Text));
                ini.Yaz("step25job", "Metin Kutusu", Convert.ToString(step25Job.Text));
                ini.Yaz("step26job", "Metin Kutusu", Convert.ToString(step26Job.Text));
                ini.Yaz("step27job", "Metin Kutusu", Convert.ToString(step27Job.Text));
                ini.Yaz("step28job", "Metin Kutusu", Convert.ToString(step28Job.Text));
                ini.Yaz("step29job", "Metin Kutusu", Convert.ToString(step29Job.Text));
                ini.Yaz("step30job", "Metin Kutusu", Convert.ToString(step30Job.Text));
                ini.Yaz("step31job", "Metin Kutusu", Convert.ToString(step31Job.Text));
                ini.Yaz("step32job", "Metin Kutusu", Convert.ToString(step32Job.Text));
                ini.Yaz("step33job", "Metin Kutusu", Convert.ToString(step33Job.Text));
                ini.Yaz("step34job", "Metin Kutusu", Convert.ToString(step34Job.Text));
                ini.Yaz("step35job", "Metin Kutusu", Convert.ToString(step35Job.Text));
                ini.Yaz("step36job", "Metin Kutusu", Convert.ToString(step36Job.Text));
                ini.Yaz("step37job", "Metin Kutusu", Convert.ToString(step37Job.Text));
                ini.Yaz("step38job", "Metin Kutusu", Convert.ToString(step38Job.Text));
                ini.Yaz("step39job", "Metin Kutusu", Convert.ToString(step39Job.Text));
                ini.Yaz("step40job", "Metin Kutusu", Convert.ToString(step40Job.Text));

                ini.Yaz("isim1", "Metin Kutusu", Convert.ToString(isim1.Text));
                ini.Yaz("isim2", "Metin Kutusu", Convert.ToString(isim2.Text));
                ini.Yaz("isim3", "Metin Kutusu", Convert.ToString(isim3.Text));
                ini.Yaz("isim4", "Metin Kutusu", Convert.ToString(isim4.Text));
                ini.Yaz("isim5", "Metin Kutusu", Convert.ToString(isim5.Text));
                ini.Yaz("isim6", "Metin Kutusu", Convert.ToString(isim6.Text));
                ini.Yaz("isim7", "Metin Kutusu", Convert.ToString(isim7.Text));
                ini.Yaz("isim8", "Metin Kutusu", Convert.ToString(isim8.Text));
                ini.Yaz("isim9", "Metin Kutusu", Convert.ToString(isim9.Text));
                ini.Yaz("isim10", "Metin Kutusu", Convert.ToString(isim10.Text));
                ini.Yaz("isim11", "Metin Kutusu", Convert.ToString(isim11.Text));
                ini.Yaz("isim12", "Metin Kutusu", Convert.ToString(isim12.Text));
                ini.Yaz("isim13", "Metin Kutusu", Convert.ToString(isim13.Text));
                ini.Yaz("isim14", "Metin Kutusu", Convert.ToString(isim14.Text));
                ini.Yaz("isim15", "Metin Kutusu", Convert.ToString(isim15.Text));
                ini.Yaz("isim16", "Metin Kutusu", Convert.ToString(isim16.Text));
                ini.Yaz("isim17", "Metin Kutusu", Convert.ToString(isim17.Text));
                ini.Yaz("isim18", "Metin Kutusu", Convert.ToString(isim18.Text));
                ini.Yaz("isim19", "Metin Kutusu", Convert.ToString(isim19.Text));
                ini.Yaz("isim20", "Metin Kutusu", Convert.ToString(isim20.Text));
                ini.Yaz("isim21", "Metin Kutusu", Convert.ToString(isim21.Text));
                ini.Yaz("isim22", "Metin Kutusu", Convert.ToString(isim22.Text));
                ini.Yaz("isim23", "Metin Kutusu", Convert.ToString(isim23.Text));
                ini.Yaz("isim24", "Metin Kutusu", Convert.ToString(isim24.Text));
                ini.Yaz("isim25", "Metin Kutusu", Convert.ToString(isim25.Text));
                ini.Yaz("isim26", "Metin Kutusu", Convert.ToString(isim26.Text));
                ini.Yaz("isim27", "Metin Kutusu", Convert.ToString(isim27.Text));
                ini.Yaz("isim28", "Metin Kutusu", Convert.ToString(isim28.Text));
                ini.Yaz("isim29", "Metin Kutusu", Convert.ToString(isim29.Text));
                ini.Yaz("isim30", "Metin Kutusu", Convert.ToString(isim30.Text));
                ini.Yaz("isim31", "Metin Kutusu", Convert.ToString(isim31.Text));
                ini.Yaz("isim32", "Metin Kutusu", Convert.ToString(isim32.Text));
                ini.Yaz("isim33", "Metin Kutusu", Convert.ToString(isim33.Text));
                ini.Yaz("isim34", "Metin Kutusu", Convert.ToString(isim34.Text));
                ini.Yaz("isim35", "Metin Kutusu", Convert.ToString(isim35.Text));
                ini.Yaz("isim36", "Metin Kutusu", Convert.ToString(isim36.Text));
                ini.Yaz("isim37", "Metin Kutusu", Convert.ToString(isim37.Text));
                ini.Yaz("isim38", "Metin Kutusu", Convert.ToString(isim38.Text));
                ini.Yaz("isim39", "Metin Kutusu", Convert.ToString(isim39.Text));
                ini.Yaz("isim40", "Metin Kutusu", Convert.ToString(isim40.Text));

                ini.Yaz("veri1", "Metin Kutusu", Convert.ToString(veri1.Text));
                ini.Yaz("veri2", "Metin Kutusu", Convert.ToString(veri2.Text));
                ini.Yaz("veri3", "Metin Kutusu", Convert.ToString(veri3.Text));
                ini.Yaz("veri4", "Metin Kutusu", Convert.ToString(veri4.Text));
                ini.Yaz("veri5", "Metin Kutusu", Convert.ToString(veri5.Text));
                ini.Yaz("veri6", "Metin Kutusu", Convert.ToString(veri6.Text));
                ini.Yaz("veri7", "Metin Kutusu", Convert.ToString(veri7.Text));
                ini.Yaz("veri8", "Metin Kutusu", Convert.ToString(veri8.Text));
                ini.Yaz("veri9", "Metin Kutusu", Convert.ToString(veri9.Text));
                ini.Yaz("veri10", "Metin Kutusu", Convert.ToString(veri10.Text));
                ini.Yaz("veri11", "Metin Kutusu", Convert.ToString(veri11.Text));
                ini.Yaz("veri12", "Metin Kutusu", Convert.ToString(veri12.Text));
                ini.Yaz("veri13", "Metin Kutusu", Convert.ToString(veri13.Text));
                ini.Yaz("veri14", "Metin Kutusu", Convert.ToString(veri14.Text));
                ini.Yaz("veri15", "Metin Kutusu", Convert.ToString(veri15.Text));
                ini.Yaz("veri16", "Metin Kutusu", Convert.ToString(veri16.Text));
                ini.Yaz("veri17", "Metin Kutusu", Convert.ToString(veri17.Text));
                ini.Yaz("veri18", "Metin Kutusu", Convert.ToString(veri18.Text));
                ini.Yaz("veri19", "Metin Kutusu", Convert.ToString(veri19.Text));
                ini.Yaz("veri20", "Metin Kutusu", Convert.ToString(veri20.Text));
                ini.Yaz("veri21", "Metin Kutusu", Convert.ToString(veri21.Text));
                ini.Yaz("veri22", "Metin Kutusu", Convert.ToString(veri22.Text));
                ini.Yaz("veri23", "Metin Kutusu", Convert.ToString(veri23.Text));
                ini.Yaz("veri24", "Metin Kutusu", Convert.ToString(veri24.Text));
                ini.Yaz("veri25", "Metin Kutusu", Convert.ToString(veri25.Text));
                ini.Yaz("veri26", "Metin Kutusu", Convert.ToString(veri26.Text));
                ini.Yaz("veri27", "Metin Kutusu", Convert.ToString(veri27.Text));
                ini.Yaz("veri28", "Metin Kutusu", Convert.ToString(veri28.Text));
                ini.Yaz("veri29", "Metin Kutusu", Convert.ToString(veri29.Text));
                ini.Yaz("veri30", "Metin Kutusu", Convert.ToString(veri30.Text));
                ini.Yaz("veri31", "Metin Kutusu", Convert.ToString(veri31.Text));
                ini.Yaz("veri32", "Metin Kutusu", Convert.ToString(veri32.Text));
                ini.Yaz("veri33", "Metin Kutusu", Convert.ToString(veri33.Text));
                ini.Yaz("veri34", "Metin Kutusu", Convert.ToString(veri34.Text));
                ini.Yaz("veri35", "Metin Kutusu", Convert.ToString(veri35.Text));
                ini.Yaz("veri36", "Metin Kutusu", Convert.ToString(veri36.Text));
                ini.Yaz("veri37", "Metin Kutusu", Convert.ToString(veri37.Text));
                ini.Yaz("veri38", "Metin Kutusu", Convert.ToString(veri38.Text));
                ini.Yaz("veri39", "Metin Kutusu", Convert.ToString(veri39.Text));
                ini.Yaz("veri40", "Metin Kutusu", Convert.ToString(veri40.Text));

                ini.Yaz("COM1", "Metin Kutusu", Convert.ToString(COM1.Text));
                ini.Yaz("COM2", "Metin Kutusu", Convert.ToString(COM2.Text));
                ini.Yaz("COM3", "Metin Kutusu", Convert.ToString(COM3.Text));
                ini.Yaz("COM4", "Metin Kutusu", Convert.ToString(COM4.Text));
                ini.Yaz("COM5", "Metin Kutusu", Convert.ToString(COM5.Text));
                ini.Yaz("COM6", "Metin Kutusu", Convert.ToString(COM6.Text));
                ini.Yaz("COM7", "Metin Kutusu", Convert.ToString(COM7.Text));
                ini.Yaz("COM8", "Metin Kutusu", Convert.ToString(COM8.Text));
                ini.Yaz("COM9", "Metin Kutusu", Convert.ToString(COM9.Text));
                ini.Yaz("COM10", "Metin Kutusu", Convert.ToString(COM10.Text));
                ini.Yaz("COM11", "Metin Kutusu", Convert.ToString(COM11.Text));
                ini.Yaz("COM12", "Metin Kutusu", Convert.ToString(COM12.Text));
                ini.Yaz("COM13", "Metin Kutusu", Convert.ToString(COM13.Text));
                ini.Yaz("COM14", "Metin Kutusu", Convert.ToString(COM14.Text));
                ini.Yaz("COM15", "Metin Kutusu", Convert.ToString(COM15.Text));
                ini.Yaz("COM16", "Metin Kutusu", Convert.ToString(COM16.Text));
                ini.Yaz("COM17", "Metin Kutusu", Convert.ToString(COM17.Text));
                ini.Yaz("COM18", "Metin Kutusu", Convert.ToString(COM18.Text));
                ini.Yaz("COM19", "Metin Kutusu", Convert.ToString(COM19.Text));
                ini.Yaz("COM20", "Metin Kutusu", Convert.ToString(COM20.Text));
                ini.Yaz("COM21", "Metin Kutusu", Convert.ToString(COM21.Text));
                ini.Yaz("COM22", "Metin Kutusu", Convert.ToString(COM22.Text));
                ini.Yaz("COM23", "Metin Kutusu", Convert.ToString(COM23.Text));
                ini.Yaz("COM24", "Metin Kutusu", Convert.ToString(COM24.Text));
                ini.Yaz("COM25", "Metin Kutusu", Convert.ToString(COM25.Text));
                ini.Yaz("COM26", "Metin Kutusu", Convert.ToString(COM26.Text));
                ini.Yaz("COM27", "Metin Kutusu", Convert.ToString(COM27.Text));
                ini.Yaz("COM28", "Metin Kutusu", Convert.ToString(COM28.Text));
                ini.Yaz("COM29", "Metin Kutusu", Convert.ToString(COM29.Text));
                ini.Yaz("COM30", "Metin Kutusu", Convert.ToString(COM30.Text));
                ini.Yaz("COM31", "Metin Kutusu", Convert.ToString(COM31.Text));
                ini.Yaz("COM32", "Metin Kutusu", Convert.ToString(COM32.Text));
                ini.Yaz("COM33", "Metin Kutusu", Convert.ToString(COM33.Text));
                ini.Yaz("COM34", "Metin Kutusu", Convert.ToString(COM34.Text));
                ini.Yaz("COM35", "Metin Kutusu", Convert.ToString(COM35.Text));
                ini.Yaz("COM36", "Metin Kutusu", Convert.ToString(COM36.Text));
                ini.Yaz("COM37", "Metin Kutusu", Convert.ToString(COM37.Text));
                ini.Yaz("COM38", "Metin Kutusu", Convert.ToString(COM38.Text));
                ini.Yaz("COM39", "Metin Kutusu", Convert.ToString(COM39.Text));
                ini.Yaz("COM40", "Metin Kutusu", Convert.ToString(COM40.Text));

                ini.Yaz("feedback1", "Metin Kutusu", Convert.ToString(feedback1.Text));
                ini.Yaz("feedback2", "Metin Kutusu", Convert.ToString(feedback2.Text));
                ini.Yaz("feedback3", "Metin Kutusu", Convert.ToString(feedback3.Text));
                ini.Yaz("feedback4", "Metin Kutusu", Convert.ToString(feedback4.Text));
                ini.Yaz("feedback5", "Metin Kutusu", Convert.ToString(feedback5.Text));
                ini.Yaz("feedback6", "Metin Kutusu", Convert.ToString(feedback6.Text));
                ini.Yaz("feedback7", "Metin Kutusu", Convert.ToString(feedback7.Text));
                ini.Yaz("feedback8", "Metin Kutusu", Convert.ToString(feedback8.Text));
                ini.Yaz("feedback9", "Metin Kutusu", Convert.ToString(feedback9.Text));
                ini.Yaz("feedback10", "Metin Kutusu", Convert.ToString(feedback10.Text));
                ini.Yaz("feedback11", "Metin Kutusu", Convert.ToString(feedback11.Text));
                ini.Yaz("feedback12", "Metin Kutusu", Convert.ToString(feedback12.Text));
                ini.Yaz("feedback13", "Metin Kutusu", Convert.ToString(feedback13.Text));
                ini.Yaz("feedback14", "Metin Kutusu", Convert.ToString(feedback14.Text));
                ini.Yaz("feedback15", "Metin Kutusu", Convert.ToString(feedback15.Text));
                ini.Yaz("feedback16", "Metin Kutusu", Convert.ToString(feedback16.Text));
                ini.Yaz("feedback17", "Metin Kutusu", Convert.ToString(feedback17.Text));
                ini.Yaz("feedback18", "Metin Kutusu", Convert.ToString(feedback18.Text));
                ini.Yaz("feedback19", "Metin Kutusu", Convert.ToString(feedback19.Text));
                ini.Yaz("feedback20", "Metin Kutusu", Convert.ToString(feedback20.Text));
                ini.Yaz("feedback21", "Metin Kutusu", Convert.ToString(feedback21.Text));
                ini.Yaz("feedback22", "Metin Kutusu", Convert.ToString(feedback22.Text));
                ini.Yaz("feedback23", "Metin Kutusu", Convert.ToString(feedback23.Text));
                ini.Yaz("feedback24", "Metin Kutusu", Convert.ToString(feedback24.Text));
                ini.Yaz("feedback25", "Metin Kutusu", Convert.ToString(feedback25.Text));
                ini.Yaz("feedback26", "Metin Kutusu", Convert.ToString(feedback26.Text));
                ini.Yaz("feedback27", "Metin Kutusu", Convert.ToString(feedback27.Text));
                ini.Yaz("feedback28", "Metin Kutusu", Convert.ToString(feedback28.Text));
                ini.Yaz("feedback29", "Metin Kutusu", Convert.ToString(feedback29.Text));
                ini.Yaz("feedback30", "Metin Kutusu", Convert.ToString(feedback30.Text));
                ini.Yaz("feedback31", "Metin Kutusu", Convert.ToString(feedback31.Text));
                ini.Yaz("feedback32", "Metin Kutusu", Convert.ToString(feedback32.Text));
                ini.Yaz("feedback33", "Metin Kutusu", Convert.ToString(feedback33.Text));
                ini.Yaz("feedback34", "Metin Kutusu", Convert.ToString(feedback34.Text));
                ini.Yaz("feedback35", "Metin Kutusu", Convert.ToString(feedback35.Text));
                ini.Yaz("feedback36", "Metin Kutusu", Convert.ToString(feedback36.Text));
                ini.Yaz("feedback37", "Metin Kutusu", Convert.ToString(feedback37.Text));
                ini.Yaz("feedback38", "Metin Kutusu", Convert.ToString(feedback38.Text));
                ini.Yaz("feedback39", "Metin Kutusu", Convert.ToString(feedback39.Text));
                ini.Yaz("feedback40", "Metin Kutusu", Convert.ToString(feedback40.Text));

                ini.Yaz("kontrol1", "Metin Kutusu", Convert.ToString(kontrol1.Text));
                ini.Yaz("kontrol2", "Metin Kutusu", Convert.ToString(kontrol2.Text));
                ini.Yaz("kontrol3", "Metin Kutusu", Convert.ToString(kontrol3.Text));
                ini.Yaz("kontrol4", "Metin Kutusu", Convert.ToString(kontrol4.Text));
                ini.Yaz("kontrol5", "Metin Kutusu", Convert.ToString(kontrol5.Text));
                ini.Yaz("kontrol6", "Metin Kutusu", Convert.ToString(kontrol6.Text));
                ini.Yaz("kontrol7", "Metin Kutusu", Convert.ToString(kontrol7.Text));
                ini.Yaz("kontrol8", "Metin Kutusu", Convert.ToString(kontrol8.Text));
                ini.Yaz("kontrol9", "Metin Kutusu", Convert.ToString(kontrol9.Text));
                ini.Yaz("kontrol10", "Metin Kutusu", Convert.ToString(kontrol10.Text));
                ini.Yaz("kontrol11", "Metin Kutusu", Convert.ToString(kontrol11.Text));
                ini.Yaz("kontrol12", "Metin Kutusu", Convert.ToString(kontrol12.Text));
                ini.Yaz("kontrol13", "Metin Kutusu", Convert.ToString(kontrol13.Text));
                ini.Yaz("kontrol14", "Metin Kutusu", Convert.ToString(kontrol14.Text));
                ini.Yaz("kontrol15", "Metin Kutusu", Convert.ToString(kontrol15.Text));
                ini.Yaz("kontrol16", "Metin Kutusu", Convert.ToString(kontrol16.Text));
                ini.Yaz("kontrol17", "Metin Kutusu", Convert.ToString(kontrol17.Text));
                ini.Yaz("kontrol18", "Metin Kutusu", Convert.ToString(kontrol18.Text));
                ini.Yaz("kontrol19", "Metin Kutusu", Convert.ToString(kontrol19.Text));
                ini.Yaz("kontrol20", "Metin Kutusu", Convert.ToString(kontrol20.Text));
                ini.Yaz("kontrol21", "Metin Kutusu", Convert.ToString(kontrol21.Text));
                ini.Yaz("kontrol22", "Metin Kutusu", Convert.ToString(kontrol22.Text));
                ini.Yaz("kontrol23", "Metin Kutusu", Convert.ToString(kontrol23.Text));
                ini.Yaz("kontrol24", "Metin Kutusu", Convert.ToString(kontrol24.Text));
                ini.Yaz("kontrol25", "Metin Kutusu", Convert.ToString(kontrol25.Text));
                ini.Yaz("kontrol26", "Metin Kutusu", Convert.ToString(kontrol26.Text));
                ini.Yaz("kontrol27", "Metin Kutusu", Convert.ToString(kontrol27.Text));
                ini.Yaz("kontrol28", "Metin Kutusu", Convert.ToString(kontrol28.Text));
                ini.Yaz("kontrol29", "Metin Kutusu", Convert.ToString(kontrol29.Text));
                ini.Yaz("kontrol30", "Metin Kutusu", Convert.ToString(kontrol30.Text));
                ini.Yaz("kontrol31", "Metin Kutusu", Convert.ToString(kontrol31.Text));
                ini.Yaz("kontrol32", "Metin Kutusu", Convert.ToString(kontrol32.Text));
                ini.Yaz("kontrol33", "Metin Kutusu", Convert.ToString(kontrol33.Text));
                ini.Yaz("kontrol34", "Metin Kutusu", Convert.ToString(kontrol34.Text));
                ini.Yaz("kontrol35", "Metin Kutusu", Convert.ToString(kontrol35.Text));
                ini.Yaz("kontrol36", "Metin Kutusu", Convert.ToString(kontrol36.Text));
                ini.Yaz("kontrol37", "Metin Kutusu", Convert.ToString(kontrol37.Text));
                ini.Yaz("kontrol38", "Metin Kutusu", Convert.ToString(kontrol38.Text));
                ini.Yaz("kontrol39", "Metin Kutusu", Convert.ToString(kontrol39.Text));
                ini.Yaz("kontrol40", "Metin Kutusu", Convert.ToString(kontrol40.Text));

                ini.Yaz("gorev1", "Metin Kutusu", Convert.ToString(gorev1.Text));
                ini.Yaz("gorev2", "Metin Kutusu", Convert.ToString(gorev2.Text));
                ini.Yaz("gorev3", "Metin Kutusu", Convert.ToString(gorev3.Text));
                ini.Yaz("gorev4", "Metin Kutusu", Convert.ToString(gorev4.Text));
                ini.Yaz("gorev5", "Metin Kutusu", Convert.ToString(gorev5.Text));
                ini.Yaz("gorev6", "Metin Kutusu", Convert.ToString(gorev6.Text));
                ini.Yaz("gorev7", "Metin Kutusu", Convert.ToString(gorev7.Text));
                ini.Yaz("gorev8", "Metin Kutusu", Convert.ToString(gorev8.Text));
                ini.Yaz("gorev9", "Metin Kutusu", Convert.ToString(gorev9.Text));
                ini.Yaz("gorev10", "Metin Kutusu", Convert.ToString(gorev10.Text));
                ini.Yaz("gorev11", "Metin Kutusu", Convert.ToString(gorev11.Text));
                ini.Yaz("gorev12", "Metin Kutusu", Convert.ToString(gorev12.Text));
                ini.Yaz("gorev13", "Metin Kutusu", Convert.ToString(gorev13.Text));
                ini.Yaz("gorev14", "Metin Kutusu", Convert.ToString(gorev14.Text));
                ini.Yaz("gorev15", "Metin Kutusu", Convert.ToString(gorev15.Text));
                ini.Yaz("gorev16", "Metin Kutusu", Convert.ToString(gorev16.Text));
                ini.Yaz("gorev17", "Metin Kutusu", Convert.ToString(gorev17.Text));
                ini.Yaz("gorev18", "Metin Kutusu", Convert.ToString(gorev18.Text));
                ini.Yaz("gorev19", "Metin Kutusu", Convert.ToString(gorev19.Text));
                ini.Yaz("gorev20", "Metin Kutusu", Convert.ToString(gorev20.Text));
                ini.Yaz("gorev21", "Metin Kutusu", Convert.ToString(gorev21.Text));
                ini.Yaz("gorev22", "Metin Kutusu", Convert.ToString(gorev22.Text));
                ini.Yaz("gorev23", "Metin Kutusu", Convert.ToString(gorev23.Text));
                ini.Yaz("gorev24", "Metin Kutusu", Convert.ToString(gorev24.Text));
                ini.Yaz("gorev25", "Metin Kutusu", Convert.ToString(gorev25.Text));
                ini.Yaz("gorev26", "Metin Kutusu", Convert.ToString(gorev26.Text));
                ini.Yaz("gorev27", "Metin Kutusu", Convert.ToString(gorev27.Text));
                ini.Yaz("gorev28", "Metin Kutusu", Convert.ToString(gorev28.Text));
                ini.Yaz("gorev29", "Metin Kutusu", Convert.ToString(gorev29.Text));
                ini.Yaz("gorev30", "Metin Kutusu", Convert.ToString(gorev30.Text));
                ini.Yaz("gorev31", "Metin Kutusu", Convert.ToString(gorev31.Text));
                ini.Yaz("gorev32", "Metin Kutusu", Convert.ToString(gorev32.Text));
                ini.Yaz("gorev33", "Metin Kutusu", Convert.ToString(gorev33.Text));
                ini.Yaz("gorev34", "Metin Kutusu", Convert.ToString(gorev34.Text));
                ini.Yaz("gorev35", "Metin Kutusu", Convert.ToString(gorev35.Text));
                ini.Yaz("gorev36", "Metin Kutusu", Convert.ToString(gorev36.Text));
                ini.Yaz("gorev37", "Metin Kutusu", Convert.ToString(gorev37.Text));
                ini.Yaz("gorev38", "Metin Kutusu", Convert.ToString(gorev38.Text));
                ini.Yaz("gorev39", "Metin Kutusu", Convert.ToString(gorev39.Text));
                ini.Yaz("gorev40", "Metin Kutusu", Convert.ToString(gorev40.Text));

                CustomMessageBox.ShowMessage("Bütün Ayarlar Dosyaya Başarıyla Kaydedildi.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
            }
            else
            {
                CustomMessageBox.ShowMessage("Dosya Yolu Boş Kalamaz", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void btnOkuIni_Click(object sender, EventArgs e)
        {
            if (txtINIdosya.Text != "")
            {
                try
                {
                    if (File.Exists(txtINIdosya.Text))
                    {
                        INIKaydet ini = new INIKaydet(txtINIdosya.Text);

                        if (ini.Oku("programlamaChecked", "Metin Kutusu") == "True")
                            chBoxProgramlama.Checked = true;
                        else if (ini.Oku("programlamaChecked", "Metin Kutusu") == "False")
                            chBoxProgramlama.Checked = false;

                        stepNum.Text = ini.Oku("stepNum", "Metin Kutusu");

                        step1Job.Text = ini.Oku("step1job", "Metin Kutusu");
                        step2Job.Text = ini.Oku("step2job", "Metin Kutusu");
                        step3Job.Text = ini.Oku("step3job", "Metin Kutusu");
                        step4Job.Text = ini.Oku("step4job", "Metin Kutusu");
                        step5Job.Text = ini.Oku("step5job", "Metin Kutusu");
                        step6Job.Text = ini.Oku("step6job", "Metin Kutusu");
                        step7Job.Text = ini.Oku("step7job", "Metin Kutusu");
                        step8Job.Text = ini.Oku("step8job", "Metin Kutusu");
                        step9Job.Text = ini.Oku("step9job", "Metin Kutusu");
                        step10Job.Text = ini.Oku("step10job", "Metin Kutusu");
                        step11Job.Text = ini.Oku("step11job", "Metin Kutusu");
                        step12Job.Text = ini.Oku("step12job", "Metin Kutusu");
                        step13Job.Text = ini.Oku("step13job", "Metin Kutusu");
                        step14Job.Text = ini.Oku("step14job", "Metin Kutusu");
                        step15Job.Text = ini.Oku("step15job", "Metin Kutusu");
                        step16Job.Text = ini.Oku("step16job", "Metin Kutusu");
                        step17Job.Text = ini.Oku("step17job", "Metin Kutusu");
                        step18Job.Text = ini.Oku("step18job", "Metin Kutusu");
                        step19Job.Text = ini.Oku("step19job", "Metin Kutusu");
                        step20Job.Text = ini.Oku("step20job", "Metin Kutusu");
                        step21Job.Text = ini.Oku("step21job", "Metin Kutusu");
                        step22Job.Text = ini.Oku("step22job", "Metin Kutusu");
                        step23Job.Text = ini.Oku("step23job", "Metin Kutusu");
                        step24Job.Text = ini.Oku("step24job", "Metin Kutusu");
                        step25Job.Text = ini.Oku("step25job", "Metin Kutusu");
                        step26Job.Text = ini.Oku("step26job", "Metin Kutusu");
                        step27Job.Text = ini.Oku("step27job", "Metin Kutusu");
                        step28Job.Text = ini.Oku("step28job", "Metin Kutusu");
                        step29Job.Text = ini.Oku("step29job", "Metin Kutusu");
                        step30Job.Text = ini.Oku("step30job", "Metin Kutusu");
                        step31Job.Text = ini.Oku("step31job", "Metin Kutusu");
                        step32Job.Text = ini.Oku("step32job", "Metin Kutusu");
                        step33Job.Text = ini.Oku("step33job", "Metin Kutusu");
                        step34Job.Text = ini.Oku("step34job", "Metin Kutusu");
                        step35Job.Text = ini.Oku("step35job", "Metin Kutusu");
                        step36Job.Text = ini.Oku("step36job", "Metin Kutusu");
                        step37Job.Text = ini.Oku("step37job", "Metin Kutusu");
                        step38Job.Text = ini.Oku("step38job", "Metin Kutusu");
                        step39Job.Text = ini.Oku("step39job", "Metin Kutusu");
                        step40Job.Text = ini.Oku("step40job", "Metin Kutusu");

                        isim1.Text = ini.Oku("isim1", "Metin Kutusu");
                        isim2.Text = ini.Oku("isim2", "Metin Kutusu");
                        isim3.Text = ini.Oku("isim3", "Metin Kutusu");
                        isim4.Text = ini.Oku("isim4", "Metin Kutusu");
                        isim5.Text = ini.Oku("isim5", "Metin Kutusu");
                        isim6.Text = ini.Oku("isim6", "Metin Kutusu");
                        isim7.Text = ini.Oku("isim7", "Metin Kutusu");
                        isim8.Text = ini.Oku("isim8", "Metin Kutusu");
                        isim9.Text = ini.Oku("isim9", "Metin Kutusu");
                        isim10.Text = ini.Oku("isim10", "Metin Kutusu");
                        isim11.Text = ini.Oku("isim11", "Metin Kutusu");
                        isim12.Text = ini.Oku("isim12", "Metin Kutusu");
                        isim13.Text = ini.Oku("isim13", "Metin Kutusu");
                        isim14.Text = ini.Oku("isim14", "Metin Kutusu");
                        isim15.Text = ini.Oku("isim15", "Metin Kutusu");
                        isim16.Text = ini.Oku("isim16", "Metin Kutusu");
                        isim17.Text = ini.Oku("isim17", "Metin Kutusu");
                        isim18.Text = ini.Oku("isim18", "Metin Kutusu");
                        isim19.Text = ini.Oku("isim19", "Metin Kutusu");
                        isim20.Text = ini.Oku("isim20", "Metin Kutusu");
                        isim21.Text = ini.Oku("isim21", "Metin Kutusu");
                        isim22.Text = ini.Oku("isim22", "Metin Kutusu");
                        isim23.Text = ini.Oku("isim23", "Metin Kutusu");
                        isim24.Text = ini.Oku("isim24", "Metin Kutusu");
                        isim25.Text = ini.Oku("isim25", "Metin Kutusu");
                        isim26.Text = ini.Oku("isim26", "Metin Kutusu");
                        isim27.Text = ini.Oku("isim27", "Metin Kutusu");
                        isim28.Text = ini.Oku("isim28", "Metin Kutusu");
                        isim29.Text = ini.Oku("isim29", "Metin Kutusu");
                        isim30.Text = ini.Oku("isim30", "Metin Kutusu");
                        isim31.Text = ini.Oku("isim31", "Metin Kutusu");
                        isim32.Text = ini.Oku("isim32", "Metin Kutusu");
                        isim33.Text = ini.Oku("isim33", "Metin Kutusu");
                        isim34.Text = ini.Oku("isim34", "Metin Kutusu");
                        isim35.Text = ini.Oku("isim35", "Metin Kutusu");
                        isim36.Text = ini.Oku("isim36", "Metin Kutusu");
                        isim37.Text = ini.Oku("isim37", "Metin Kutusu");
                        isim38.Text = ini.Oku("isim38", "Metin Kutusu");
                        isim39.Text = ini.Oku("isim39", "Metin Kutusu");
                        isim40.Text = ini.Oku("isim40", "Metin Kutusu");

                        veri1.Text = ini.Oku("veri1", "Metin Kutusu");
                        veri2.Text = ini.Oku("veri2", "Metin Kutusu");
                        veri3.Text = ini.Oku("veri3", "Metin Kutusu");
                        veri4.Text = ini.Oku("veri4", "Metin Kutusu");
                        veri5.Text = ini.Oku("veri5", "Metin Kutusu");
                        veri6.Text = ini.Oku("veri6", "Metin Kutusu");
                        veri7.Text = ini.Oku("veri7", "Metin Kutusu");
                        veri8.Text = ini.Oku("veri8", "Metin Kutusu");
                        veri9.Text = ini.Oku("veri9", "Metin Kutusu");
                        veri10.Text = ini.Oku("veri10", "Metin Kutusu");
                        veri11.Text = ini.Oku("veri11", "Metin Kutusu");
                        veri12.Text = ini.Oku("veri12", "Metin Kutusu");
                        veri13.Text = ini.Oku("veri13", "Metin Kutusu");
                        veri14.Text = ini.Oku("veri14", "Metin Kutusu");
                        veri15.Text = ini.Oku("veri15", "Metin Kutusu");
                        veri16.Text = ini.Oku("veri16", "Metin Kutusu");
                        veri17.Text = ini.Oku("veri17", "Metin Kutusu");
                        veri18.Text = ini.Oku("veri18", "Metin Kutusu");
                        veri19.Text = ini.Oku("veri19", "Metin Kutusu");
                        veri20.Text = ini.Oku("veri20", "Metin Kutusu");
                        veri21.Text = ini.Oku("veri21", "Metin Kutusu");
                        veri22.Text = ini.Oku("veri22", "Metin Kutusu");
                        veri23.Text = ini.Oku("veri23", "Metin Kutusu");
                        veri24.Text = ini.Oku("veri24", "Metin Kutusu");
                        veri25.Text = ini.Oku("veri25", "Metin Kutusu");
                        veri26.Text = ini.Oku("veri26", "Metin Kutusu");
                        veri27.Text = ini.Oku("veri27", "Metin Kutusu");
                        veri28.Text = ini.Oku("veri28", "Metin Kutusu");
                        veri29.Text = ini.Oku("veri29", "Metin Kutusu");
                        veri30.Text = ini.Oku("veri30", "Metin Kutusu");
                        veri31.Text = ini.Oku("veri31", "Metin Kutusu");
                        veri32.Text = ini.Oku("veri32", "Metin Kutusu");
                        veri33.Text = ini.Oku("veri33", "Metin Kutusu");
                        veri34.Text = ini.Oku("veri34", "Metin Kutusu");
                        veri35.Text = ini.Oku("veri35", "Metin Kutusu");
                        veri36.Text = ini.Oku("veri36", "Metin Kutusu");
                        veri37.Text = ini.Oku("veri37", "Metin Kutusu");
                        veri38.Text = ini.Oku("veri38", "Metin Kutusu");
                        veri39.Text = ini.Oku("veri39", "Metin Kutusu");
                        veri40.Text = ini.Oku("veri40", "Metin Kutusu");

                        COM1.Text = ini.Oku("COM1", "Metin Kutusu");
                        COM2.Text = ini.Oku("COM2", "Metin Kutusu");
                        COM3.Text = ini.Oku("COM3", "Metin Kutusu");
                        COM4.Text = ini.Oku("COM4", "Metin Kutusu");
                        COM5.Text = ini.Oku("COM5", "Metin Kutusu");
                        COM6.Text = ini.Oku("COM6", "Metin Kutusu");
                        COM7.Text = ini.Oku("COM7", "Metin Kutusu");
                        COM8.Text = ini.Oku("COM8", "Metin Kutusu");
                        COM9.Text = ini.Oku("COM9", "Metin Kutusu");
                        COM10.Text = ini.Oku("COM10", "Metin Kutusu");
                        COM11.Text = ini.Oku("COM11", "Metin Kutusu");
                        COM12.Text = ini.Oku("COM12", "Metin Kutusu");
                        COM13.Text = ini.Oku("COM13", "Metin Kutusu");
                        COM14.Text = ini.Oku("COM14", "Metin Kutusu");
                        COM15.Text = ini.Oku("COM15", "Metin Kutusu");
                        COM16.Text = ini.Oku("COM16", "Metin Kutusu");
                        COM17.Text = ini.Oku("COM17", "Metin Kutusu");
                        COM18.Text = ini.Oku("COM18", "Metin Kutusu");
                        COM19.Text = ini.Oku("COM19", "Metin Kutusu");
                        COM20.Text = ini.Oku("COM20", "Metin Kutusu");
                        COM21.Text = ini.Oku("COM21", "Metin Kutusu");
                        COM22.Text = ini.Oku("COM22", "Metin Kutusu");
                        COM23.Text = ini.Oku("COM23", "Metin Kutusu");
                        COM24.Text = ini.Oku("COM24", "Metin Kutusu");
                        COM25.Text = ini.Oku("COM25", "Metin Kutusu");
                        COM26.Text = ini.Oku("COM26", "Metin Kutusu");
                        COM27.Text = ini.Oku("COM27", "Metin Kutusu");
                        COM28.Text = ini.Oku("COM28", "Metin Kutusu");
                        COM29.Text = ini.Oku("COM29", "Metin Kutusu");
                        COM30.Text = ini.Oku("COM30", "Metin Kutusu");
                        COM31.Text = ini.Oku("COM31", "Metin Kutusu");
                        COM32.Text = ini.Oku("COM32", "Metin Kutusu");
                        COM33.Text = ini.Oku("COM33", "Metin Kutusu");
                        COM34.Text = ini.Oku("COM34", "Metin Kutusu");
                        COM35.Text = ini.Oku("COM35", "Metin Kutusu");
                        COM36.Text = ini.Oku("COM36", "Metin Kutusu");
                        COM37.Text = ini.Oku("COM37", "Metin Kutusu");
                        COM38.Text = ini.Oku("COM38", "Metin Kutusu");
                        COM39.Text = ini.Oku("COM39", "Metin Kutusu");
                        COM40.Text = ini.Oku("COM40", "Metin Kutusu");

                        feedback1.Text = ini.Oku("feedback1", "Metin Kutusu");
                        feedback2.Text = ini.Oku("feedback2", "Metin Kutusu");
                        feedback3.Text = ini.Oku("feedback3", "Metin Kutusu");
                        feedback4.Text = ini.Oku("feedback4", "Metin Kutusu");
                        feedback5.Text = ini.Oku("feedback5", "Metin Kutusu");
                        feedback6.Text = ini.Oku("feedback6", "Metin Kutusu");
                        feedback7.Text = ini.Oku("feedback7", "Metin Kutusu");
                        feedback8.Text = ini.Oku("feedback8", "Metin Kutusu");
                        feedback9.Text = ini.Oku("feedback9", "Metin Kutusu");
                        feedback10.Text = ini.Oku("feedback10", "Metin Kutusu");
                        feedback11.Text = ini.Oku("feedback11", "Metin Kutusu");
                        feedback12.Text = ini.Oku("feedback12", "Metin Kutusu");
                        feedback13.Text = ini.Oku("feedback13", "Metin Kutusu");
                        feedback14.Text = ini.Oku("feedback14", "Metin Kutusu");
                        feedback15.Text = ini.Oku("feedback15", "Metin Kutusu");
                        feedback16.Text = ini.Oku("feedback16", "Metin Kutusu");
                        feedback17.Text = ini.Oku("feedback17", "Metin Kutusu");
                        feedback18.Text = ini.Oku("feedback18", "Metin Kutusu");
                        feedback19.Text = ini.Oku("feedback19", "Metin Kutusu");
                        feedback20.Text = ini.Oku("feedback20", "Metin Kutusu");
                        feedback21.Text = ini.Oku("feedback21", "Metin Kutusu");
                        feedback22.Text = ini.Oku("feedback22", "Metin Kutusu");
                        feedback23.Text = ini.Oku("feedback23", "Metin Kutusu");
                        feedback24.Text = ini.Oku("feedback24", "Metin Kutusu");
                        feedback25.Text = ini.Oku("feedback25", "Metin Kutusu");
                        feedback26.Text = ini.Oku("feedback26", "Metin Kutusu");
                        feedback27.Text = ini.Oku("feedback27", "Metin Kutusu");
                        feedback28.Text = ini.Oku("feedback28", "Metin Kutusu");
                        feedback29.Text = ini.Oku("feedback29", "Metin Kutusu");
                        feedback30.Text = ini.Oku("feedback30", "Metin Kutusu");
                        feedback31.Text = ini.Oku("feedback31", "Metin Kutusu");
                        feedback32.Text = ini.Oku("feedback32", "Metin Kutusu");
                        feedback33.Text = ini.Oku("feedback33", "Metin Kutusu");
                        feedback34.Text = ini.Oku("feedback34", "Metin Kutusu");
                        feedback35.Text = ini.Oku("feedback35", "Metin Kutusu");
                        feedback36.Text = ini.Oku("feedback36", "Metin Kutusu");
                        feedback37.Text = ini.Oku("feedback37", "Metin Kutusu");
                        feedback38.Text = ini.Oku("feedback38", "Metin Kutusu");
                        feedback39.Text = ini.Oku("feedback39", "Metin Kutusu");
                        feedback40.Text = ini.Oku("feedback40", "Metin Kutusu");

                        kontrol1.Text = ini.Oku("kontrol1", "Metin Kutusu");
                        kontrol2.Text = ini.Oku("kontrol2", "Metin Kutusu");
                        kontrol3.Text = ini.Oku("kontrol3", "Metin Kutusu");
                        kontrol4.Text = ini.Oku("kontrol4", "Metin Kutusu");
                        kontrol5.Text = ini.Oku("kontrol5", "Metin Kutusu");
                        kontrol6.Text = ini.Oku("kontrol6", "Metin Kutusu");
                        kontrol7.Text = ini.Oku("kontrol7", "Metin Kutusu");
                        kontrol8.Text = ini.Oku("kontrol8", "Metin Kutusu");
                        kontrol9.Text = ini.Oku("kontrol9", "Metin Kutusu");
                        kontrol10.Text = ini.Oku("kontrol10", "Metin Kutusu");
                        kontrol11.Text = ini.Oku("kontrol11", "Metin Kutusu");
                        kontrol12.Text = ini.Oku("kontrol12", "Metin Kutusu");
                        kontrol13.Text = ini.Oku("kontrol13", "Metin Kutusu");
                        kontrol14.Text = ini.Oku("kontrol14", "Metin Kutusu");
                        kontrol15.Text = ini.Oku("kontrol15", "Metin Kutusu");
                        kontrol16.Text = ini.Oku("kontrol16", "Metin Kutusu");
                        kontrol17.Text = ini.Oku("kontrol17", "Metin Kutusu");
                        kontrol18.Text = ini.Oku("kontrol18", "Metin Kutusu");
                        kontrol19.Text = ini.Oku("kontrol19", "Metin Kutusu");
                        kontrol20.Text = ini.Oku("kontrol20", "Metin Kutusu");
                        kontrol21.Text = ini.Oku("kontrol21", "Metin Kutusu");
                        kontrol22.Text = ini.Oku("kontrol22", "Metin Kutusu");
                        kontrol23.Text = ini.Oku("kontrol23", "Metin Kutusu");
                        kontrol24.Text = ini.Oku("kontrol24", "Metin Kutusu");
                        kontrol25.Text = ini.Oku("kontrol25", "Metin Kutusu");
                        kontrol26.Text = ini.Oku("kontrol26", "Metin Kutusu");
                        kontrol27.Text = ini.Oku("kontrol27", "Metin Kutusu");
                        kontrol28.Text = ini.Oku("kontrol28", "Metin Kutusu");
                        kontrol29.Text = ini.Oku("kontrol29", "Metin Kutusu");
                        kontrol30.Text = ini.Oku("kontrol30", "Metin Kutusu");
                        kontrol31.Text = ini.Oku("kontrol31", "Metin Kutusu");
                        kontrol32.Text = ini.Oku("kontrol32", "Metin Kutusu");
                        kontrol33.Text = ini.Oku("kontrol33", "Metin Kutusu");
                        kontrol34.Text = ini.Oku("kontrol34", "Metin Kutusu");
                        kontrol35.Text = ini.Oku("kontrol35", "Metin Kutusu");
                        kontrol36.Text = ini.Oku("kontrol36", "Metin Kutusu");
                        kontrol37.Text = ini.Oku("kontrol37", "Metin Kutusu");
                        kontrol38.Text = ini.Oku("kontrol38", "Metin Kutusu");
                        kontrol39.Text = ini.Oku("kontrol39", "Metin Kutusu");
                        kontrol40.Text = ini.Oku("kontrol40", "Metin Kutusu");

                        gorev1.Text = ini.Oku("gorev1", "Metin Kutusu");
                        gorev2.Text = ini.Oku("gorev2", "Metin Kutusu");
                        gorev3.Text = ini.Oku("gorev3", "Metin Kutusu");
                        gorev4.Text = ini.Oku("gorev4", "Metin Kutusu");
                        gorev5.Text = ini.Oku("gorev5", "Metin Kutusu");
                        gorev6.Text = ini.Oku("gorev6", "Metin Kutusu");
                        gorev7.Text = ini.Oku("gorev7", "Metin Kutusu");
                        gorev8.Text = ini.Oku("gorev8", "Metin Kutusu");
                        gorev9.Text = ini.Oku("gorev9", "Metin Kutusu");
                        gorev10.Text = ini.Oku("gorev10", "Metin Kutusu");
                        gorev11.Text = ini.Oku("gorev11", "Metin Kutusu");
                        gorev12.Text = ini.Oku("gorev12", "Metin Kutusu");
                        gorev13.Text = ini.Oku("gorev13", "Metin Kutusu");
                        gorev14.Text = ini.Oku("gorev14", "Metin Kutusu");
                        gorev15.Text = ini.Oku("gorev15", "Metin Kutusu");
                        gorev16.Text = ini.Oku("gorev16", "Metin Kutusu");
                        gorev17.Text = ini.Oku("gorev17", "Metin Kutusu");
                        gorev18.Text = ini.Oku("gorev18", "Metin Kutusu");
                        gorev19.Text = ini.Oku("gorev19", "Metin Kutusu");
                        gorev20.Text = ini.Oku("gorev20", "Metin Kutusu");
                        gorev21.Text = ini.Oku("gorev21", "Metin Kutusu");
                        gorev22.Text = ini.Oku("gorev22", "Metin Kutusu");
                        gorev23.Text = ini.Oku("gorev23", "Metin Kutusu");
                        gorev24.Text = ini.Oku("gorev24", "Metin Kutusu");
                        gorev25.Text = ini.Oku("gorev25", "Metin Kutusu");
                        gorev26.Text = ini.Oku("gorev26", "Metin Kutusu");
                        gorev27.Text = ini.Oku("gorev27", "Metin Kutusu");
                        gorev28.Text = ini.Oku("gorev28", "Metin Kutusu");
                        gorev29.Text = ini.Oku("gorev29", "Metin Kutusu");
                        gorev30.Text = ini.Oku("gorev30", "Metin Kutusu");
                        gorev31.Text = ini.Oku("gorev31", "Metin Kutusu");
                        gorev32.Text = ini.Oku("gorev32", "Metin Kutusu");
                        gorev33.Text = ini.Oku("gorev33", "Metin Kutusu");
                        gorev34.Text = ini.Oku("gorev34", "Metin Kutusu");
                        gorev35.Text = ini.Oku("gorev35", "Metin Kutusu");
                        gorev36.Text = ini.Oku("gorev36", "Metin Kutusu");
                        gorev37.Text = ini.Oku("gorev37", "Metin Kutusu");
                        gorev38.Text = ini.Oku("gorev38", "Metin Kutusu");
                        gorev39.Text = ini.Oku("gorev39", "Metin Kutusu");
                        gorev40.Text = ini.Oku("gorev40", "Metin Kutusu");

                        CustomMessageBox.ShowMessage("Bütün Ayarlar Dosyadan Başarıyla Okundu.", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Information, Color.Yellow);
                    }
                }
                catch (Exception hata)
                {
                    CustomMessageBox.ShowMessage("ini Dosyası Hasarlı", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
                }
            }
            else
            {
                CustomMessageBox.ShowMessage("Dosya Yolu Boş Kalamaz", Ayarlar.Default.projectName, MessageBoxButtons.OK, CustomMessageBoxIcon.Error, Color.Red);
            }
        }

        private void btnIDsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.ini";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.txtINIdosya.Text = openFileDialog.FileName;
        }


    }
}
