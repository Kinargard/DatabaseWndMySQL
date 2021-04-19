namespace DatabaseWndMySQL.Data.Controls {
    class CLeftPanel {
        #region Экземпляры
        private static readonly System.Windows.Forms.Panel LeftPanel = new System.Windows.Forms.Panel();
        #endregion

        #region Поля

        #endregion

        #region Методы
        private static void SetLeftPanel() {
            try {
                LeftPanel.Size = new System.Drawing.Size(250, 512);
                LeftPanel.Location = new System.Drawing.Point(10, 54);
                LeftPanel.BackColor = System.Drawing.Color.FromArgb(0xCC, 0xD5, 0xF0);
                LeftPanel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region События

        #endregion

        #region Свойства
        public struct Location {
            public static int X { get { return LeftPanel.Location.X; } }
            public static int Y { get { return LeftPanel.Location.Y; } }
        }
        public static int Width { get { return LeftPanel.Width; } }
        public static int Height { get { return LeftPanel.Height; } }
        public static System.Drawing.Color BackColor { get { return LeftPanel.BackColor; } set { LeftPanel.BackColor = value; } }
        #endregion

        #region Конструкторы
        public CLeftPanel() {
            try {
                DatabaseWnd.MainForm.Controls.Add(LeftPanel);
                SetLeftPanel();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion
    }
}
