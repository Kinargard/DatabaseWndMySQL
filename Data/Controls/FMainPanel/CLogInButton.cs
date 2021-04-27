namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    public class CLogInButton {
        private void InitializeComponent() {
            try {
                
                // LogInBut (Panel) ///////////////////////////////////////////
                
                LogInButton.Size = new System.Drawing.Size(200, 25);
                LogInButton.Location = new System.Drawing.Point(CLogInForm.PCaption.Location.X, 240);
                LogInButton.BackColor = PLogInButton.Drawing.BackColor;
                
                // Caption (Label) ////////////////////////////////////////////
                
                Caption.Size = new System.Drawing.Size(198, 23);
                Caption.Location = new System.Drawing.Point(1, 1);
                Caption.BackColor = PCaption.Drawing.BackColor;
                Caption.ForeColor = PCaption.Drawing.ForeColor;
                Caption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                Caption.Text = "ВХОД";
                CaptionEvents();

                ///////////////////////////////////////////////////////////////
                
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private void CaptionEvents() {
            try {
                Caption.MouseEnter += (s, e) => {
                    try {
                        Caption.BackColor = System.Drawing.Color.FromArgb(0x33, 0x33, 0x33);
                        LogInButton.BackColor = System.Drawing.Color.FromArgb(0x00, 0x7A, 0xCC);
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                Caption.MouseLeave += (s, e) => {
                    try {
                        Caption.BackColor = PCaption.Drawing.BackColor;
                        LogInButton.BackColor = PLogInButton.Drawing.BackColor;
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                Caption.Click += (s, e) => {
                    try {
                        string login = CLogInForm.PTextBoxLogin.Text;
                        string pass = CLogInForm.PTextBoxPass.Text;
                        CDatabaseCon DataConn = new CDatabaseCon();
                        System.Data.DataTable table = new System.Data.DataTable();
                        MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                        string com = "SELECT * FROM Права WHERE Логин = @UsLogin AND Пароль = @UsPass;";
                        MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(com, DataConn.GetConnection());
                        command.Parameters.Add("@UsLogin", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@UsPass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass;
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        if (table.Rows.Count > 0) {
                            CLogInPanel.PCaption.Text = table.Rows[0].ItemArray[1].ToString();
                            CLogInForm.PTextBoxLogin.Text = "";
                            CLogInForm.PTextBoxPass.Text = "";
                            LogInForm.LInForm.Close();
                        }
                        else { System.Windows.Forms.MessageBox.Show("Логин или пароль введены неверно", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PLogInButton {
            public struct Location {
                public static int X { get => LogInButton.Location.X; }
                public static int Y { get => LogInButton.Location.Y; }
            }
            public static int Width { get => LogInButton.Width; }
            public static int Height { get => LogInButton.Height; }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
            }
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
        }

        public CLogInButton() {
            try {
                LogInForm.LInForm.Controls.Add(LogInButton);
                LogInButton.Controls.Add(Caption);
                InitializeComponent();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.Panel LogInButton = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Label Caption = new System.Windows.Forms.Label();
    }
}
