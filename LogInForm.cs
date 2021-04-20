namespace DatabaseWndMySQL {
    public partial class LogInForm : System.Windows.Forms.Form {
        public static LogInForm LInForm = null;
        public LogInForm() {
            InitializeComponent();
            LInForm = this;
            _ = new Data.Controls.FMainPanel.CLogIn();
            _ = new Data.Controls.FMainPanel.CLogInBut();
        }
    }
}
