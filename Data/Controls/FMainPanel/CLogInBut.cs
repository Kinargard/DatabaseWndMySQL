namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    class CLogInBut {
        #region Экземпляры
        private static readonly System.Windows.Forms.Panel LogInBut = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Label CCaption = new System.Windows.Forms.Label();
        #endregion

        #region Поля

        #endregion

        #region Методы
        private static void SetLogInBut() {
            try {
                LogInBut.Size = new System.Drawing.Size(200, 25);
                LogInBut.Location = new System.Drawing.Point(CLogIn.Caption.Location.X, 210);
                LogInBut.BackColor = System.Drawing.Color.FromArgb(0xAB, 0xAB, 0xAB);
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetCCaption() {
            try {
                CCaption.Size = new System.Drawing.Size(198, 23);
                CCaption.Location = new System.Drawing.Point(1, 1);
                CCaption.BackColor = System.Drawing.SystemColors.Control;
                CCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                CCaption.Text = "ВХОД";
                CCaption.MouseEnter += CMouseEnter;
                CCaption.MouseLeave += CMouseLeave;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region События
        private static void CMouseEnter(object sender, System.EventArgs e) {
            try {
                if (sender == CCaption) {
                    CCaption.BackColor = System.Drawing.Color.FromArgb(0xE3, 0xEC, 0xFA);
                    LogInBut.BackColor = System.Drawing.Color.FromArgb(0x4A, 0x78, 0xB0);
                }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void CMouseLeave(object sender, System.EventArgs e) {
            try {
                if (sender == CCaption) {
                    CCaption.BackColor = System.Drawing.SystemColors.Control;
                    LogInBut.BackColor = System.Drawing.Color.FromArgb(0xAB, 0xAB, 0xAB);
                }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Свойства

        #endregion

        #region Конструкторы
        public CLogInBut() {
            try {
                LogInForm.LInForm.Controls.Add(LogInBut);
                LogInBut.Controls.Add(CCaption);
                SetLogInBut();
                SetCCaption();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion
    }
}
