﻿namespace DatabaseWndMySQL.Data {
    public class CColor {
        public CColor() {
            try {
                if (!DatabaseWnd.Theme) {
                    DatabaseWnd.Drawing.BackColor = System.Drawing.Color.FromArgb(0x5D, 0x6B, 0x99);                    //+
                    Controls.CDataTable.PDataBase.BackgroundColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);              //+
                    Controls.CLeftPanel.PLeftPanel.BackColor = System.Drawing.Color.FromArgb(0xCC, 0xD5, 0xF0);         //+
                    Controls.CLeftPanel.PBorder.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);            //+
                    Controls.CMainPanel.PMainPanel.BackColor = System.Drawing.Color.FromArgb(0xCC, 0xD5, 0xF0);         //+
                    Controls.CMainPanel.PBorder.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);            //+
                    Controls.CStatusStrip.PStatusStrip.BackColor = System.Drawing.Color.FromArgb(0x40, 0x50, 0x8D);     //+
                    Controls.FMainPanel.CAuthorization.LBackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);    //+
                    Controls.FMainPanel.CAuthorization.CBackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);    //+
                    Controls.FMainPanel.CAuthorization.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);     //+
                    Controls.FMainPanel.CLogIn.PTextBoxLogin.BackColor = LogInForm.LInForm.BackColor;                    //+
                    Controls.FMainPanel.CLogIn.PCaptionLogin.BackColor = LogInForm.LInForm.BackColor;                    //+
                    Controls.FMainPanel.CLogIn.PLineLogin.BackColor = System.Drawing.Color.FromArgb(0x00, 0x63, 0xB1);   //+
                    Controls.FMainPanel.CLogIn.PTextBoxPass.BackColor = System.Drawing.SystemColors.Control;             //+
                    Controls.FMainPanel.CLogIn.PCaptionPass.BackColor = System.Drawing.SystemColors.Control;             //+
                    Controls.FMainPanel.CLogIn.PLinePass.BackColor = System.Drawing.Color.FromArgb(0x00, 0x63, 0xB1);    //+
                    Controls.FMainPanel.CLogInBut.PLogInBut.BackColor = System.Drawing.Color.FromArgb(0xAB, 0xAB, 0xAB); //+
                    Controls.FMainPanel.CLogInBut.PCaption.BackColor = System.Drawing.SystemColors.Control;              //+
                }
                else {
                    //
                }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
    }
}
