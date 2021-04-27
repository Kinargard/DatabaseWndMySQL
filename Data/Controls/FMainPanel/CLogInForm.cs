namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    public class CLogInForm {
        private void InitializeComponent() {
            try {
                
                // Caption (Label) ////////////////////////////////////////////
                
                Caption.Size = new System.Drawing.Size(200, 25);
                Caption.Location = new System.Drawing.Point((LogInForm.LInForm.ClientSize.Width / 2) - (Caption.Width / 2), 40);
                Caption.AutoSize = false;
                Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Caption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 14.0f, System.Drawing.FontStyle.Bold);
                Caption.Text = "АВТОРИЗАЦИЯ";
                Caption.BackColor = PCaption.Drawing.BackColor;
                Caption.ForeColor = PCaption.Drawing.ForeColor;
                
                // LoginTBox (TextBox) ////////////////////////////////////////
                
                LoginTBox.Width = 200;
                LoginTBox.Location = new System.Drawing.Point(Caption.Location.X, 125);
                LoginTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                LoginTBox.BackColor = PTextBoxLogin.Drawing.BackColor;
                LoginTBox.ForeColor = PTextBoxLogin.Drawing.ForeColor;
                
                // LoginCaption (Label) ///////////////////////////////////////
                
                LoginCaption.Location = new System.Drawing.Point(LoginTBox.Location.X, 102);
                LoginCaption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 11.0f, System.Drawing.FontStyle.Regular);
                LoginCaption.Text = "Логин:";
                LoginCaption.BackColor = PCaptionLogin.Drawing.BackColor;
                LoginCaption.ForeColor = PCaptionLogin.Drawing.ForeColor;
                
                // LoginLine (Panel) //////////////////////////////////////////
                
                LoginLine.Size = new System.Drawing.Size(200, 2);
                LoginLine.Location = new System.Drawing.Point(LoginTBox.Location.X, 146);
                LoginLine.BackColor = PLineLogin.Drawing.BackColor;
                
                // PassTBox (TextBox) /////////////////////////////////////////
                
                PassTBox.Width = 200;
                PassTBox.Location = new System.Drawing.Point(Caption.Location.X, 195);
                PassTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                PassTBox.BackColor = PTextBoxPass.Drawing.BackColor;
                PassTBox.PasswordChar = '*';
                PassTBox.ForeColor = PTextBoxPass.Drawing.ForeColor;
                
                // PassCaption (Label) ////////////////////////////////////////
                
                PassCaption.Location = new System.Drawing.Point(PassTBox.Location.X, 172);
                PassCaption.Font = new System.Drawing.Font(LogInForm.LInForm.Font.Name, 11.0f, System.Drawing.FontStyle.Regular);
                PassCaption.Text = "Пароль:";
                PassCaption.BackColor = PCaptionPass.Drawing.BackColor;
                PassCaption.ForeColor = PCaptionPass.Drawing.ForeColor;
                
                // PassLine (Panel) ///////////////////////////////////////////
                
                PassLine.Size = new System.Drawing.Size(200, 2);
                PassLine.Location = new System.Drawing.Point(PassTBox.Location.X, 216);
                PassLine.BackColor = PLinePass.Drawing.BackColor;

                ///////////////////////////////////////////////////////////////

            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PCaption {
            public struct Location {
                public static int X { get => Caption.Location.X; }
                public static int Y { get => Caption.Location.Y; }
            }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }
        public struct PTextBoxLogin {
            public static string Text { get => LoginTBox.Text; set { LoginTBox.Text = value; } }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }
        public struct PTextBoxPass {
            public static string Text { get => PassTBox.Text; set { PassTBox.Text = value; } }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }
        public struct PCaptionLogin {
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }
        public struct PLineLogin {
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
            }
        }
        public struct PCaptionPass {
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }
        public struct PLinePass {
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
            }
        }

        public CLogInForm() {
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
