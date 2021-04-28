namespace DatabaseWndMySQL.Data.Controls.FLeftPanel {
    public class CListTables {
        private static bool BTriangle = false;
        private static readonly System.Collections.Generic.List<System.Windows.Forms.Label> labels = new System.Collections.Generic.List<System.Windows.Forms.Label>();

        private void InitializeComponent() {
            try {

                // Border (Panel) /////////////////////////////////////////////

                Border.Size = new System.Drawing.Size(250, 24);
                Border.Location = new System.Drawing.Point(0, 0);
                Border.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
                Border.BackColor = PBorder.Drawing.BackColor;
                BorderEventrs();

                // Caprion (Label) ////////////////////////////////////////////

                Caption.Size = new System.Drawing.Size(226, 23);
                Caption.Location = new System.Drawing.Point(0, 0);
                Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                Caption.AutoSize = false;
                Caption.BackColor = PCaption.Drawing.BackColor;
                Caption.ForeColor = PCaption.Drawing.ForeColor;
                Caption.Text = "Таблицы";

                // Triangle (Label) ///////////////////////////////////////////

                Triangle.Size = new System.Drawing.Size(23, 23);
                Triangle.Location = new System.Drawing.Point(227, 0);
                Triangle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                Triangle.AutoSize = false;
                Triangle.BackColor = PTriangle.Drawing.BackColor;
                Triangle.ForeColor = PTriangle.Drawing.ForeColor;
                Triangle.Text = "▼";
                TriangleEventrs();

                // ListTables (Panel) /////////////////////////////////////////

                ListTables.Size = new System.Drawing.Size(250, 184);
                ListTables.Location = new System.Drawing.Point(0, 24);
                ListTables.BackColor = PListTables.Drawing.BackColor;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private void TriangleEventrs() {
            try {
                Triangle.Click += (s, e) => {
                    try {
                        if (!BTriangle) { Triangle.Text = "▲"; BTriangle = true; Border.Height = 209; }
                        else { Triangle.Text = "▼"; BTriangle = false; Border.Height = 24; }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private void BorderEventrs() {
            try {
                CDatabaseCon DataConn = new CDatabaseCon();
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                System.Data.DataTable table = new System.Data.DataTable();
                string com = "SHOW TABLES;";
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(com, DataConn.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0) {
                    for (int i = 0; i < table.Rows.Count; i++) {
                        labels.Add(new System.Windows.Forms.Label() {
                            AutoSize = false,
                            Size = new System.Drawing.Size(250, 23),
                            Location = new System.Drawing.Point(0, i * 23),
                            TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                            BackColor = PBorderEvents.Drawing.BackColor,
                            ForeColor = PBorderEvents.Drawing.ForeColor,
                            Text = table.Rows[i].ItemArray[0].ToString()
                        });
                    }
                    foreach (System.Windows.Forms.Label label in labels) {
                        ListTables.Controls.Add(label);
                    }
                    foreach (System.Windows.Forms.Label label in labels) {
                        label.MouseEnter += (s, e) => {
                            try {
                                label.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x34);
                            }
                            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                        };
                        label.MouseLeave += (s, e) => {
                            try {
                                label.BackColor = PBorderEvents.Drawing.BackColor;
                            }
                            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                        };
                        label.Click += (s, e) => {
                            try {
                                CDatabaseCon DataConn1 = new CDatabaseCon();
                                MySql.Data.MySqlClient.MySqlDataAdapter adapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
                                System.Data.DataTable table1 = new System.Data.DataTable();
                                string com1 = $"SELECT * FROM {label.Text};";
                                MySql.Data.MySqlClient.MySqlCommand command1 = new MySql.Data.MySqlClient.MySqlCommand(com1, DataConn1.GetConnection());
                                adapter.SelectCommand = command1;
                                adapter.Fill(table1);
                                CDataTable.PDataBase.DataGridView.DataSource = table1;
                            }
                            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                        };
                    }
                }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
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
            public static System.Windows.Forms.Panel AListTables { get => Border; }
        }

        public struct PCaption {
            public struct Location {
                public static int X { get => Caption.Location.X; }
                public static int Y { get => Caption.Location.Y; }
            }
            public static int Width { get => Caption.Width; }
            public static int Height { get => Caption.Height; }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
            public static string Text { get; set; }
        }

        public struct PTriangle {
            public struct Location {
                public static int X { get => Triangle.Location.X; }
                public static int Y { get => Triangle.Location.Y; }
            }
            public static int Width { get => Triangle.Width; }
            public static int Height { get => Triangle.Height; }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }

        public struct PBorderEvents {
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }

        public struct PListTables {
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
            }
        }

        public CListTables() {
            try {
                Border.Controls.Add(Caption);
                Border.Controls.Add(Triangle);
                Border.Controls.Add(ListTables);
                InitializeComponent();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Panel ListTables = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Label Caption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Label Triangle = new System.Windows.Forms.Label();

    }
}
