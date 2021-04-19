namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    class CLogIn {
        #region Экземпляры
        private static readonly System.Windows.Forms.Label Caption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Label LoginCaption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Label PassCaption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.TextBox LoginTBox = new System.Windows.Forms.TextBox();
        private static readonly System.Windows.Forms.TextBox PassTBox = new System.Windows.Forms.TextBox();
        #endregion

        #region Поля

        #endregion

        #region Методы
        private static void SetCaption() {
            try {
                Caption.Size = new System.Drawing.Size(150, 23);
                Caption.Location = new System.Drawing.Point((LogInForm.LInForm.ClientSize.Width / 2) - (Caption.Width / 2), 30);
                Caption.AutoSize = false;
                Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Caption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 12.0f, LogInForm.LInForm.Font.Style);
                Caption.Text = "АВТОРИЗАЦИЯ";
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region События

        #endregion

        #region Свойства

        #endregion

        #region Конструкторы
        public CLogIn() {
            try {
                LogInForm.LInForm.Controls.Add(Caption);
                SetCaption();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion
    }
}
