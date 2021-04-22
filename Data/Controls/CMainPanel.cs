namespace DatabaseWndMySQL.Data.Controls {
    public class CMainPanel {
        #region Поля

        #endregion

        #region Методы
        private static void SetMainPanel() {
            try {
                MainPanel.Size = new System.Drawing.Size(1000, 44);
                MainPanel.Location = new System.Drawing.Point();
                MainPanel.BackColor = System.Drawing.Color.FromArgb(0xCC, 0xD5, 0xF0);
                MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Свойства
        public struct Location {
            public static int X { get => MainPanel.Location.X; }
            public static int Y { get => MainPanel.Location.Y; }
        }
        public static int Width { get => MainPanel.Width; }
        public static int Height { get => MainPanel.Height; }
        public static System.Drawing.Color BackColor { get => MainPanel.BackColor; set { MainPanel.BackColor = value; } }
        #endregion

        #region Конструкторы
        public CMainPanel() {
            try {
                DatabaseWnd.MainForm.Controls.Add(MainPanel);
                SetMainPanel();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Экземпляры
        private static readonly System.Windows.Forms.Panel MainPanel = new System.Windows.Forms.Panel();
        #endregion
    }
}
