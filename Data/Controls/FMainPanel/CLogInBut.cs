﻿namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    class CLogInBut {
        #region Экземпляры
        private static readonly System.Windows.Forms.Panel LogInBut = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Label CCaption = new System.Windows.Forms.Label();
        #endregion

        #region Поля

        #endregion

        #region Методы
        private static void SetLogInBut() {
            try {
                LogInBut.Size = new System.Drawing.Size(200, 25);
                LogInBut.Location = new System.Drawing.Point(CLogIn.Caption.Location.X, 210);
                LogInBut.BackColor = System.Drawing.Color.FromArgb(0xAB, 0xAB, 0xAB);
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetCCaption() {
            try {
                CCaption.Size = new System.Drawing.Size(198, 23);
                CCaption.Location = new System.Drawing.Point(1, 1);
                CCaption.BackColor = System.Drawing.SystemColors.Control;
                CCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                CCaption.Text = "ВХОД";
                CCaption.MouseEnter += (s, e) => {
                    try {
                        CCaption.BackColor = System.Drawing.Color.FromArgb(0xE3, 0xEC, 0xFA);
                        LogInBut.BackColor = System.Drawing.Color.FromArgb(0x4A, 0x78, 0xB0);
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                CCaption.MouseLeave += (s, e) => {
                    try {
                        CCaption.BackColor = System.Drawing.SystemColors.Control;
                        LogInBut.BackColor = System.Drawing.Color.FromArgb(0xAB, 0xAB, 0xAB);
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                CCaption.Click += (s, e) => {
                    try {
                        string login = CLogIn.TextBoxLogin.Text;
                        string pass = CLogIn.TextBoxPass.Text;
                        CDatabaseCon DataConn = new CDatabaseCon();
                        System.Data.DataTable table = new System.Data.DataTable();
                        MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                        string com = "SELECT * FROM `Права` WHERE `Логин` = @UsLogin AND `Пароль` = @UsPass;";
                        MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(com, DataConn.GetConnection());
                        command.Parameters.Add("@UsLogin", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@UsPass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = pass;
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        if (table.Rows.Count > 0) { System.Windows.Forms.MessageBox.Show("Yes"); }
                        else { System.Windows.Forms.MessageBox.Show("No"); }
                        CLogIn.TextBoxLogin.Text = null;
                        CLogIn.TextBoxPass.Text = null;
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region События
        
        #endregion

        #region Свойства

        #endregion

        #region Конструкторы
        public CLogInBut() {
            try {
                LogInForm.LInForm.Controls.Add(LogInBut);
                LogInBut.Controls.Add(CCaption);
                SetLogInBut();
                SetCCaption();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion
    }
}
