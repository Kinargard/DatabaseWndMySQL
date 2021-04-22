namespace DatabaseWndMySQL.Data.Controls {
    public class CStatusStrip {
        #region Поля

        #endregion

        #region Методы
        private static void SetStatusStrip() {
            try {
                StatusStrip.Size = new System.Drawing.Size(1000, 24);
                StatusStrip.Location = new System.Drawing.Point(0, 576);
                StatusStrip.BackColor = BackColor;
                StatusStrip.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Свойства
        public struct Location {
            public static int X { get => StatusStrip.Location.X; }
            public static int Y { get => StatusStrip.Location.Y; }
        }
        public static int Width { get => StatusStrip.Width; }
        public static int Height { get => StatusStrip.Height; }
        public static System.Drawing.Color BackColor { get; set; }
        #endregion

        #region Конструкторы
        public CStatusStrip() {
            try {
                DatabaseWnd.MainForm.Controls.Add(StatusStrip);

                SetStatusStrip();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Экземпляры
        private static readonly System.Windows.Forms.Panel StatusStrip = new System.Windows.Forms.Panel();
        #endregion
    }
}
