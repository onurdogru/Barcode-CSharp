﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGFCTBarkod
{
    class CustomMessageBox
    {
        public static DialogResult ShowMessage(string message, string caption, MessageBoxButtons button, CustomMessageBoxIcon icon, Color bgcolor)
        {
            DialogResult dlgResult = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (FormMessageOK msgOK = new FormMessageOK())
                    {
                        msgOK.Title = caption;
                        msgOK.Message = message;
                        msgOK.BackColor = bgcolor;
                        msgOK.ButtonOK.BackColor = bgcolor;
                        switch (icon)
                        {
                            case CustomMessageBoxIcon.Information:
                                msgOK.MessageIcon = YGFCTBarkod.Properties.Resources.info_128x128;
                                break;
                            case CustomMessageBoxIcon.Question:
                                msgOK.MessageIcon = YGFCTBarkod.Properties.Resources.info_128x128;
                                break;
                            case CustomMessageBoxIcon.Error:
                                msgOK.MessageIcon = YGFCTBarkod.Properties.Resources.error_128x128;
                                break;
                            case CustomMessageBoxIcon.Pass:
                                msgOK.MessageIcon = YGFCTBarkod.Properties.Resources.ok_128x128;
                                break;
                            case CustomMessageBoxIcon.Fail:
                                msgOK.MessageIcon = YGFCTBarkod.Properties.Resources.cross_128x128;
                                break;
                            case CustomMessageBoxIcon.Warning:
                                msgOK.MessageIcon = YGFCTBarkod.Properties.Resources.error_128x128;
                                break;
                        }
                        dlgResult = msgOK.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.YesNo:
                    using (FormMessageYesNo msgYesNo = new FormMessageYesNo())
                    {
                        msgYesNo.Title = caption;
                        msgYesNo.Message = message;
                        msgYesNo.BackColor = bgcolor;
                        msgYesNo.ButtonYes.BackColor = bgcolor;
                        msgYesNo.ButtonNo.BackColor = bgcolor;
                        switch (icon)
                        {
                            case CustomMessageBoxIcon.Information:
                                msgYesNo.MessageIcon = YGFCTBarkod.Properties.Resources.info_128x128;
                                break;
                            case CustomMessageBoxIcon.Question:
                                msgYesNo.MessageIcon = YGFCTBarkod.Properties.Resources.info_128x128;
                                break;
                            case CustomMessageBoxIcon.Error:
                                msgYesNo.MessageIcon = YGFCTBarkod.Properties.Resources.error_128x128;
                                break;
                            case CustomMessageBoxIcon.Pass:
                                msgYesNo.MessageIcon = YGFCTBarkod.Properties.Resources.ok_128x128;
                                break;
                            case CustomMessageBoxIcon.Fail:
                                msgYesNo.MessageIcon = YGFCTBarkod.Properties.Resources.cross_128x128;
                                break;
                            case CustomMessageBoxIcon.Warning:
                                msgYesNo.MessageIcon = YGFCTBarkod.Properties.Resources.error_128x128;
                                break;
                        }
                        dlgResult = msgYesNo.ShowDialog();
                    }
                    break;
                case MessageBoxButtons.OKCancel:
                    using (FormMessageOKCancel msgOKCancel = new FormMessageOKCancel())
                    {
                        msgOKCancel.Title = caption;
                        msgOKCancel.Message = message;
                        msgOKCancel.BackColor = bgcolor;
                        msgOKCancel.ButtonOK.BackColor = bgcolor;
                        msgOKCancel.ButtonCancel.BackColor = bgcolor;
                        switch (icon)
                        {
                            case CustomMessageBoxIcon.Information:
                                msgOKCancel.MessageIcon = YGFCTBarkod.Properties.Resources.info_128x128;
                                break;
                            case CustomMessageBoxIcon.Question:
                                msgOKCancel.MessageIcon = YGFCTBarkod.Properties.Resources.info_128x128;
                                break;
                            case CustomMessageBoxIcon.Error:
                                msgOKCancel.MessageIcon = YGFCTBarkod.Properties.Resources.error_128x128;
                                break;
                            case CustomMessageBoxIcon.Pass:
                                msgOKCancel.MessageIcon = YGFCTBarkod.Properties.Resources.ok_128x128;
                                break;
                            case CustomMessageBoxIcon.Fail:
                                msgOKCancel.MessageIcon = YGFCTBarkod.Properties.Resources.cross_128x128;
                                break;
                            case CustomMessageBoxIcon.Warning:
                                msgOKCancel.MessageIcon = YGFCTBarkod.Properties.Resources.error_128x128;
                                break;
                        }
                        dlgResult = msgOKCancel.ShowDialog();
                    }
                    break;
            }
            return dlgResult;
        }
    }

    public enum CustomMessageBoxIcon
    {
        None = 0,
        Hand = 1,
        Stop = 1,
        Error = 1,
        Question = 2,
        Exclamation = 3,
        Warning = 3,
        Asterisk = 4,
        Information = 4,
        Pass = 5,
        Fail = 6
    }
}
