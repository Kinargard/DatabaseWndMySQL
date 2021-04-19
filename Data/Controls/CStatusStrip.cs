namespace DatabaseWndMySQL.Data.Controls {
    class CStatusStrip {
        #region Экземпляры
        private static readonly System.Windows.Forms.Panel StatusStrip = new System.Windows.Forms.Panel();
        #endregion

        #region Поля

        #endregion

        #region Методы
        private static void SetStatusStrip() {
            try {
                StatusStrip.Size = new System.Drawing.Size(1000, 24);
                StatusStrip.Location = new System.Drawing.Point(0, 576);
                StatusStrip.BackColor = System.Drawing.Color.FromArgb(0x40, 0x50, 0x8D);
                StatusStrip.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region События

        #endregion

        #region Свойства
        public struct Location {
            public static int X { get { return StatusStrip.Location.X; } }
            public static int Y { get { return StatusStrip.Location.Y; } }
        }
        public static int Width { get { return StatusStrip.Width; } }
        public static int Height { get { return StatusStrip.Height; } }
        public static System.Drawing.Color BackColor { get { return StatusStrip.BackColor; } set { StatusStrip.BackColor = value; } }
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
    }
}
