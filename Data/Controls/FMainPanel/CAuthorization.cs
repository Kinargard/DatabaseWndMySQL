namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    public class CAuthorization {
        #region Поля
        private static readonly bool OnActiveMenu = false;
        #endregion

        #region Методы
        private static void SetLogInPanel() {
            try {
                LogInPanel.Size = new System.Drawing.Size(150, 24);
                LogInPanel.Location = new System.Drawing.Point(840, 10);
                LogInPanel.BackColor = LBackColor;
                LogInPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetCaption() {
            try {
                LogInPanel.Controls.Add(CCaption);
                CCaption.Size = new System.Drawing.Size(148, 22);
                CCaption.Location = new System.Drawing.Point(1, 1);
                CCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                CCaption.BackColor = CBackColor;
                CCaption.ForeColor = ForeColor;
                CCaption.Text = "АВТОРИЗАЦИЯ";
                CCaption.MouseEnter += (s, e) => {
                    try {
                        if (!OnActiveMenu) {
                            LogInPanel.BackColor = System.Drawing.Color.FromArgb(0x40, 0x50, 0x8D);
                            CCaption.BackColor = System.Drawing.Color.FromArgb(0x40, 0x50, 0x8D);
                        }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                CCaption.MouseLeave += (s, e) => {
                    try {
                        if (!OnActiveMenu) {
                            LogInPanel.BackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);
                            CCaption.BackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);
                        }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                CCaption.Click += (s, e) => {
                    try {
                        if (CCaption.Text == "АВТОРИЗАЦИЯ") { LInForm.ShowDialog(); }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Свойства
        public struct Location {
            public static int X { get => LogInPanel.Location.X; }
            public static int Y { get => LogInPanel.Location.Y; }
        }
        public static int Width { get => LogInPanel.Width; }
        public static int Height { get => LogInPanel.Height; }
        public static string Text { get => CCaption.Text; set { CCaption.Text = value; } }
        public static System.Drawing.Color LBackColor { get; set; }
        public static System.Drawing.Color CBackColor { get; set; }
        public static System.Drawing.Color ForeColor { get; set; }
        #endregion

        #region Конструкторы
        public CAuthorization() {
            try {
                DatabaseWnd.MainForm.Controls.Add(LogInPanel);
                SetLogInPanel();
                SetCaption();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Экземпляры
        private static readonly System.Windows.Forms.Panel LogInPanel = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Label CCaption = new System.Windows.Forms.Label();
        private static readonly LogInForm LInForm = new LogInForm();
        #endregion
    }
}
