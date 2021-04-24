namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    public class CLogIn {
        private void InitializeComponent() {
            //
            // Caption (Label)
            //
            Caption.Size = new System.Drawing.Size(200, 25);
            Caption.Location = new System.Drawing.Point((LogInForm.LInForm.ClientSize.Width / 2) - (Caption.Width / 2), 25);
            Caption.AutoSize = false;
            Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Caption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 14.0f, System.Drawing.FontStyle.Bold);
            Caption.Text = "АВТОРИЗАЦИЯ";
            Caption.BackColor = PCaption.BackColor;
            //
            // LoginTBox (TextBox)
            //
            LoginTBox.Width = 200;
            LoginTBox.Location = new System.Drawing.Point(Caption.Location.X, 95);
            LoginTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LoginTBox.BackColor = PTextBoxLogin.BackColor;
            //
            // LoginCaption (Label)
            //
            LoginCaption.Location = new System.Drawing.Point(LoginTBox.Location.X, 72);
            LoginCaption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 11.0f, System.Drawing.FontStyle.Regular);
            LoginCaption.Text = "Логин:";
            LoginCaption.BackColor = PCaptionLogin.BackColor;
            //
            // LoginLine (Panel)
            //
            LoginLine.Size = new System.Drawing.Size(200, 2);
            LoginLine.Location = new System.Drawing.Point(LoginTBox.Location.X, 116);
            LoginLine.BackColor = PLineLogin.BackColor;
            //
            // PassTBox (TextBox)
            //
            PassTBox.Width = 200;
            PassTBox.Location = new System.Drawing.Point(Caption.Location.X, 165);
            PassTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PassTBox.BackColor = PTextBoxPass.BackColor;
            PassTBox.PasswordChar = '*';
            //
            // PassCaption (Label)
            //
            PassCaption.Location = new System.Drawing.Point(PassTBox.Location.X, 142);
            PassCaption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 11.0f, System.Drawing.FontStyle.Regular);
            PassCaption.Text = "Пароль:";
            PassCaption.BackColor = PCaptionPass.BackColor;
            //
            // PassLine (Panel)
            //
            PassLine.Size = new System.Drawing.Size(200, 2);
            PassLine.Location = new System.Drawing.Point(PassTBox.Location.X, 186);
            PassLine.BackColor = PLinePass.BackColor;
        }

        public struct PCaption {
            public struct Location {
                public static int X { get => Caption.Location.X; }
                public static int Y { get => Caption.Location.Y; }
            }
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct PTextBoxLogin {
            public static string Text { get => LoginTBox.Text; set { LoginTBox.Text = value; } }
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct PTextBoxPass {
            public static string Text { get => PassTBox.Text; set { PassTBox.Text = value; } }
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct PCaptionLogin {
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct PLineLogin {
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct PCaptionPass {
            public static System.Drawing.Color BackColor { get; set; }
        }
        public struct PLinePass {
            public static System.Drawing.Color BackColor { get; set; }
        }

        public CLogIn() {
            try {
                LogInForm.LInForm.Controls.Add(Caption);
                LogInForm.LInForm.Controls.Add(LoginLine);
                LogInForm.LInForm.Controls.Add(LoginTBox);
                LogInForm.LInForm.Controls.Add(LoginCaption);
                LogInForm.LInForm.Controls.Add(PassLine);
                LogInForm.LInForm.Controls.Add(PassTBox);
                LogInForm.LInForm.Controls.Add(PassCaption);

                InitializeComponent();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.Label Caption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Label LoginCaption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Label PassCaption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.TextBox LoginTBox = new System.Windows.Forms.TextBox();
        private static readonly System.Windows.Forms.TextBox PassTBox = new System.Windows.Forms.TextBox();
        private static readonly System.Windows.Forms.Panel LoginLine = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Panel PassLine = new System.Windows.Forms.Panel();
    }
}
