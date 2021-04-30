namespace DatabaseWndMySQL.Data.Controls {
    public class CDataTable {
        private void InitializeComponent() {
            try {
                
                // Border (Panel) /////////////////////////////////////////////
                
                Border.Size = new System.Drawing.Size(718, 510);
                Border.Location = new System.Drawing.Point(272, 55);
                Border.BackColor = PBorder.Drawing.BackColor;
                Border.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
                Border.BorderStyle = System.Windows.Forms.BorderStyle.None;

                // DataTable (DataGridView) ///////////////////////////////////
                
                DataTable.Size = new System.Drawing.Size(716, 508);
                DataTable.Location = new System.Drawing.Point(1, 1);
                DataTable.BackgroundColor = PDataBase.Drawing.BackgroundColor;
                DataTable.ForeColor = PDataBase.Drawing.ForeColor;
                DataTable.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
                DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
                DataTable.AdvancedCellBorderStyle.All = System.Windows.Forms.DataGridViewAdvancedCellBorderStyle.Single;
                DataTable.AdvancedColumnHeadersBorderStyle.All = System.Windows.Forms.DataGridViewAdvancedCellBorderStyle.Single;
                DataTable.AdvancedRowHeadersBorderStyle.All = System.Windows.Forms.DataGridViewAdvancedCellBorderStyle.Single;
                DataTable.AllowUserToOrderColumns = false;
                DataTable.AllowUserToResizeColumns = false;
                DataTable.AllowUserToResizeRows = false;
                DataTable.EnableHeadersVisualStyles = false;
                DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
                DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                DataTable.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                DataTable.ColumnHeadersDefaultCellStyle.BackColor = PDataBase.Drawing.BackgroundColor;
                DataTable.ColumnHeadersDefaultCellStyle.ForeColor = PDataBase.Drawing.ForeColor;
                DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                DataTable.DefaultCellStyle.BackColor = PDataBase.Drawing.BackgroundColor;
                DataTable.DefaultCellStyle.ForeColor = PDataBase.Drawing.ForeColor;
                DataTable.GridColor = PBorder.Drawing.BackColor;
                DataTable.ReadOnly = true;
                DataTable.RowHeadersVisible = false;
                DataTable.ColumnHeadersDefaultCellStyle.SelectionBackColor = PDataBase.Drawing.BackgroundColor;
                DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

                ///////////////////////////////////////////////////////////////

            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PDataBase {
            public struct Location {
                public static int X { get => DataTable.Location.X; }
                public static int Y { get => DataTable.Location.Y; }
            }
            public static int Width { get => DataTable.Width; }
            public static int Height { get => DataTable.Height; }
            public struct Drawing {
                public static System.Drawing.Color BackgroundColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
            public static System.Windows.Forms.DataGridView DataGridView { get => DataTable; }
        }

        public struct PBorder {
            public struct Location {
                public static int X { get => Border.Location.X; }
                public static int Y { get => Border.Location.Y; }
            }
            public static int Width { get => Border.Width; }
            public static int Height { get => Border.Height; }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
            }
        }

        public CDataTable() {
            try {
                DatabaseWnd.MainForm.Controls.Add(Border);
                Border.Controls.Add(DataTable);
                InitializeComponent();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.DataGridView DataTable = new System.Windows.Forms.DataGridView();
        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel();
    }
}
