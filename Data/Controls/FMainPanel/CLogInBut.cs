namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    public class CLogInBut {
        public CLogInBut() {
            try {
                LogInForm.LInForm.Controls.Add(LogInBut);
                LogInBut.Controls.Add(Caption);
                SetCaption();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static void SetCaption() {
            try {
                Caption.MouseEnter += (s, e) => {
                    try {
                        Caption.BackColor = System.Drawing.Color.FromArgb(0xE3, 0xEC, 0xFA);
                        LogInBut.BackColor = System.Drawing.Color.FromArgb(0x4A, 0x78, 0xB0);
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                Caption.MouseLeave += (s, e) => {
                    try {
                        Caption.BackColor = System.Drawing.SystemColors.Control;
                        LogInBut.BackColor = System.Drawing.Color.FromArgb(0xAB, 0xAB, 0xAB);
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                Caption.Click += (s, e) => {
                    try {
                        string login = CLogIn.PTextBoxLogin.Text;
                        string pass = CLogIn.PTextBoxPass.Text;
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
                            CAuthorization.Text = table.Rows[0].ItemArray[1].ToString();
                            CLogIn.PTextBoxLogin.Text = "";
                            CLogIn.PTextBoxPass.Text = "";
                            LogInForm.LInForm.Close();
                        }
                        else { System.Windows.Forms.MessageBox.Show("Логин или пароль введены неверно", "Ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PLogInBut {
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct PCaption {
            public static System.Drawing.Color BackColor { get; set; }
        }

        private static readonly System.Windows.Forms.Panel LogInBut = new System.Windows.Forms.Panel() {
            Size = new System.Drawing.Size(200, 25),
            Location = new System.Drawing.Point(CLogIn.PCaption.Location.X, 210),
            BackColor = PLogInBut.BackColor
        };

        private static readonly System.Windows.Forms.Label Caption = new System.Windows.Forms.Label() {
            Size = new System.Drawing.Size(198, 23),
            Location = new System.Drawing.Point(1, 1),
            BackColor = PCaption.BackColor,
            TextAlign = System.Drawing.ContentAlignment.TopCenter,
            Text = "ВХОД"
        };
    }
}
