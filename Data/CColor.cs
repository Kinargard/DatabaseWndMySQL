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

                }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
    }
}
