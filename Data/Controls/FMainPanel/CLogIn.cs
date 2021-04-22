﻿namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    public class CLogIn {
        #region Поля

        #endregion

        #region Методы
        private static void SetCCaption() {
            try {
                CCaption.Size = new System.Drawing.Size(200, 25);
                CCaption.Location = new System.Drawing.Point((LogInForm.LInForm.ClientSize.Width / 2) - (CCaption.Width / 2), 25);
                CCaption.AutoSize = false;
                CCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                CCaption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 14.0f, System.Drawing.FontStyle.Bold);
                CCaption.Text = "АВТОРИЗАЦИЯ";
                CCaption.BackColor = Caption.BackColor;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetLoginTBox() {
            try {
                LoginTBox.Width = 200;
                LoginTBox.Location = new System.Drawing.Point(CCaption.Location.X, 95);
                LoginTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                LoginTBox.BackColor = TextBoxLogin.BackColor;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetLoginCaption() {
            try {
                LoginCaption.Location = new System.Drawing.Point(LoginTBox.Location.X, 72);
                LoginCaption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 11.0f, System.Drawing.FontStyle.Regular);
                LoginCaption.Text = "Логин:";
                LoginCaption.BackColor = CaptionLogin.BackColor;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetLoginLine() {
            try {
                LoginLine.Size = new System.Drawing.Size(200, 2);
                LoginLine.Location = new System.Drawing.Point(LoginTBox.Location.X, 116);
                LoginLine.BackColor = LineLogin.BackColor;
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetPassTBox() {
            try {
                PassTBox.Width = 200;
                PassTBox.Location = new System.Drawing.Point(CCaption.Location.X, 165);
                PassTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                PassTBox.BackColor = TextBoxPass.BackColor;
                PassTBox.PasswordChar = '*';
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetPassCaption() {
            try {
                PassCaption.Location = new System.Drawing.Point(PassTBox.Location.X, 142);
                PassCaption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 11.0f, System.Drawing.FontStyle.Regular);
                PassCaption.Text = "Пароль:";
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        private static void SetPassLine() {
            try {
                PassLine.Size = new System.Drawing.Size(200, 2);
                PassLine.Location = new System.Drawing.Point(PassTBox.Location.X, 186);
                PassLine.BackColor = System.Drawing.Color.FromArgb(0x00, 0x63, 0xB1);
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Свойства
        public struct Caption {
            public struct Location {
                public static int X { get => CCaption.Location.X; }
                public static int Y { get => CCaption.Location.Y; }
            }
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct TextBoxLogin {
            public static string Text { get => LoginTBox.Text; set { LoginTBox.Text = value; } }
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct TextBoxPass {
            public static string Text { get => PassTBox.Text; set { PassTBox.Text = value; } }
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct CaptionLogin {
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct LineLogin {
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct CaptionPass {
            public static System.Drawing.Color BackColor { get; set; }
        }
        #endregion

        #region Конструкторы
        public CLogIn() {
            try {
                LogInForm.LInForm.Controls.Add(CCaption);
                LogInForm.LInForm.Controls.Add(LoginLine);
                LogInForm.LInForm.Controls.Add(LoginTBox);
                LogInForm.LInForm.Controls.Add(LoginCaption);
                LogInForm.LInForm.Controls.Add(PassLine);
                LogInForm.LInForm.Controls.Add(PassTBox);
                LogInForm.LInForm.Controls.Add(PassCaption);
                SetCCaption();
                SetLoginTBox();
                SetLoginCaption();
                SetLoginLine();
                SetPassTBox();
                SetPassCaption();
                SetPassLine();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }
        #endregion

        #region Экземпляры
        private static readonly System.Windows.Forms.Label CCaption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Label LoginCaption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Label PassCaption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.TextBox LoginTBox = new System.Windows.Forms.TextBox();
        private static readonly System.Windows.Forms.TextBox PassTBox = new System.Windows.Forms.TextBox();
        private static readonly System.Windows.Forms.Panel LoginLine = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Panel PassLine = new System.Windows.Forms.Panel();
        #endregion
    }
}
