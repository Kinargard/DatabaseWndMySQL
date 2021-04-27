namespace DatabaseWndMySQL {
    public partial class LogInForm : System.Windows.Forms.Form {
        public static LogInForm LInForm = null;

        public struct Drawing {
            public static System.Drawing.Color BackColor { get; set; }
            public static System.Drawing.Color ForeColor { get; set; }
        }

        public LogInForm() {
            InitializeComponent();
            LInForm = this;
            _ = new Data.CColor();
            _ = new Data.Controls.FMainPanel.CLogInForm();
            _ = new Data.Controls.FMainPanel.CLogInButton();
            LInForm.BackColor = Drawing.BackColor;
            LInForm.ForeColor = Drawing.ForeColor;
            LInForm.Text = $"{LInForm.ClientSize.Width} x {LInForm.ClientSize.Height}";
        }
    }
}
