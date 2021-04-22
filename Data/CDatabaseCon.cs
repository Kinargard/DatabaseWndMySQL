namespace DatabaseWndMySQL.Data {
    public class CDatabaseCon {
        #region Поля
        private static string Connect = "server=localhost;port=3306;username=root;password=123Pjkjnj123pJKJNJ;database=appliances;";
        #endregion

        #region Методы
        public void OpenConnection() {
            try {
                if (Connection.State == System.Data.ConnectionState.Closed) { Connection.Open(); }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        public void CloseConnection() {
            try {
                if (Connection.State == System.Data.ConnectionState.Open) { Connection.Close(); }
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        public MySql.Data.MySqlClient.MySqlConnection GetConnection() => Connection;
        #endregion

        #region Свойства

        #endregion

        #region Конструкторы

        #endregion

        #region Экземпляры
        private static MySql.Data.MySqlClient.MySqlConnection Connection = new MySql.Data.MySqlClient.MySqlConnection(Connect);
        #endregion
    }
}
