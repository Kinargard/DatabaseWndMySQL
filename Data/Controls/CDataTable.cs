namespace DatabaseWndMySQL.Data.Controls {
    public class CDataTable {
        public struct PDataBase {
            public struct Location {
                public static int X { get => DataTable.Location.X; }
                public static int Y { get => DataTable.Location.Y; }
            }
            public static int Width { get => DataTable.Width; }
            public static int Height { get => DataTable.Height; }
            public static System.Drawing.Color BackgroundColor { get; set; }
        }

        public struct PBorder {
            public struct Location {
                public static int X { get => Border.Location.X; }
                public static int Y { get => Border.Location.Y; }
            }
            public static int Width { get => Border.Width; }
            public static int Height { get => Border.Height; }
            public static System.Drawing.Color BackColor { get; set; }
        }

        public CDataTable() {
            try {
                DatabaseWnd.MainForm.Controls.Add(Border);
                Border.Controls.Add(DataTable);
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.DataGridView DataTable = new System.Windows.Forms.DataGridView() {
            Size = new System.Drawing.Size(716, 508),
            Location = new System.Drawing.Point(1, 1),
            BackgroundColor = PDataBase.BackgroundColor,
            Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom,
            BorderStyle = System.Windows.Forms.BorderStyle.None
        };

        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel() {
            Size = new System.Drawing.Size(718, 510),
            Location = new System.Drawing.Point(272, 55),
            BackColor = PBorder.BackColor,
            Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom,
            BorderStyle = System.Windows.Forms.BorderStyle.None
        };
    }
}
