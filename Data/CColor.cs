namespace DatabaseWndMySQL.Data {
    public class CColor {
        public CColor() {
            try {
                if (!DatabaseWnd.Theme) {
                    //
                }
                else {
                    DatabaseWnd.Drawing.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                    DatabaseWnd.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);

                    Controls.CStatusStrip.PStatusStrip.Drawing.BackColor = System.Drawing.Color.FromArgb(0x00, 0x2D, 0x4F);
                    Controls.CStatusStrip.PBorder.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);

                    Controls.CMainPanel.PMainPanel.Drawing.BackColor = System.Drawing.Color.FromArgb(0x2D, 0x2D, 0x30);
                    Controls.CMainPanel.PBorder.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);

                    Controls.CLeftPanel.PLeftPanel.Drawing.BackColor = System.Drawing.Color.FromArgb(0x2D, 0x2D, 0x30);
                    Controls.CLeftPanel.PBorder.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);

                    Controls.CDataTable.PDataBase.Drawing.BackgroundColor = System.Drawing.Color.FromArgb(0x25, 0x25, 0x26);
                    Controls.CDataTable.PDataBase.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.CDataTable.PBorder.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);

                    Controls.FMainPanel.CLogInPanel.PLogInPanel.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);
                    Controls.FMainPanel.CLogInPanel.PCaption.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);
                    Controls.FMainPanel.CLogInPanel.PCaption.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);

                    LogInForm.Drawing.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                    LogInForm.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);

                    Controls.FMainPanel.CLogInForm.PCaption.Drawing.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                    Controls.FMainPanel.CLogInForm.PCaption.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FMainPanel.CLogInForm.PCaptionLogin.Drawing.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                    Controls.FMainPanel.CLogInForm.PCaptionLogin.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FMainPanel.CLogInForm.PTextBoxLogin.Drawing.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                    Controls.FMainPanel.CLogInForm.PTextBoxLogin.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FMainPanel.CLogInForm.PLineLogin.Drawing.BackColor = System.Drawing.Color.FromArgb(0x00, 0x7A, 0xCC);
                    Controls.FMainPanel.CLogInForm.PCaptionPass.Drawing.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                    Controls.FMainPanel.CLogInForm.PCaptionPass.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FMainPanel.CLogInForm.PTextBoxPass.Drawing.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                    Controls.FMainPanel.CLogInForm.PTextBoxPass.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FMainPanel.CLogInForm.PLinePass.Drawing.BackColor = System.Drawing.Color.FromArgb(0x00, 0x7A, 0xCC);

                    Controls.FMainPanel.CLogInButton.PLogInButton.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);
                    Controls.FMainPanel.CLogInButton.PCaption.Drawing.BackColor = System.Drawing.Color.FromArgb(0x2D, 0x2D, 0x30);
                    Controls.FMainPanel.CLogInButton.PCaption.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);

                    Controls.FLeftPanel.CListTables.PBorder.Drawing.BackColor = System.Drawing.Color.FromArgb(0x3F, 0x3F, 0x46);
                    Controls.FLeftPanel.CListTables.PCaption.Drawing.BackColor = System.Drawing.Color.FromArgb(0x2D, 0x2D, 0x30);
                    Controls.FLeftPanel.CListTables.PCaption.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FLeftPanel.CListTables.PTriangle.Drawing.BackColor = System.Drawing.Color.FromArgb(0x2D, 0x2D, 0x30);
                    Controls.FLeftPanel.CListTables.PTriangle.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FLeftPanel.CListTables.PBorderEvents.Drawing.BackColor = System.Drawing.Color.FromArgb(0x1B, 0x1B, 0x1C);
                    Controls.FLeftPanel.CListTables.PBorderEvents.Drawing.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                    Controls.FLeftPanel.CListTables.PListTables.Drawing.BackColor = System.Drawing.Color.FromArgb(0x1B, 0x1B, 0x1C);
                }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
    }
}
