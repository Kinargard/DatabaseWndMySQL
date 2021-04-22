namespace DatabaseWndMySQL.Data.Controls {
    public class CDataTable {
        #region Поля

        #endregion

        #region Методы
        private static void SetDataTable() {
            try {
                DataTable.Size = new System.Drawing.Size(720, 512);
                DataTable.Location = new System.Drawing.Point(270, 54);
                DataTable.BackgroundColor = BackgroundColor;
                DataTable.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
                DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Свойства
        public struct Location {
            public static int X { get => DataTable.Location.X; }
            public static int Y { get => DataTable.Location.Y; }
        }
        public static int Width { get => DataTable.Width; }
        public static int Height { get => DataTable.Height; }
        public static System.Drawing.Color BackgroundColor { get; set; }
        #endregion

        #region Конструкторы
        public CDataTable() {
            try {
                DatabaseWnd.MainForm.Controls.Add(DataTable);
                SetDataTable();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Экземпляры
        private static readonly System.Windows.Forms.DataGridView DataTable = new System.Windows.Forms.DataGridView();
        #endregion
    }
}
