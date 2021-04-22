namespace DatabaseWndMySQL.Data.Controls {
    public class CLeftPanel {
        #region Поля

        #endregion

        #region Методы
        private static void SetLeftPanel() {
            try {
                LeftPanel.Size = new System.Drawing.Size(250, 512);
                LeftPanel.Location = new System.Drawing.Point(10, 54);
                LeftPanel.BackColor = BackColor;
                LeftPanel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Свойства
        public struct Location {
            public static int X { get => LeftPanel.Location.X; }
            public static int Y { get => LeftPanel.Location.Y; }
        }
        public static int Width { get => LeftPanel.Width; }
        public static int Height { get => LeftPanel.Height; }
        public static System.Drawing.Color BackColor { get; set; }
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

        #region Экземпляры
        private static readonly System.Windows.Forms.Panel LeftPanel = new System.Windows.Forms.Panel();
        #endregion
    }
}
