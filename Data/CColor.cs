namespace DatabaseWndMySQL.Data {
    public class CColor {
        public CColor() {
            try {
                Controls.CStatusStrip.BackColor = System.Drawing.Color.FromArgb(0x40, 0x50, 0x8D);
                Controls.FMainPanel.CAuthorization.LBackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);
                Controls.FMainPanel.CAuthorization.CBackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);
                Controls.FMainPanel.CAuthorization.ForeColor = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0xFF);
                Controls.FMainPanel.CLogIn.TextBoxLogin.BackColor = LogInForm.LInForm.BackColor;
                Controls.FMainPanel.CLogIn.CaptionLogin.BackColor = LogInForm.LInForm.BackColor;
                Controls.FMainPanel.CLogIn.LineLogin.BackColor = System.Drawing.Color.FromArgb(0x00, 0x63, 0xB1);
                Controls.FMainPanel.CLogIn.TextBoxPass.BackColor = System.Drawing.SystemColors.Control;

            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
    }
}
