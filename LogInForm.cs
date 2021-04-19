namespace DatabaseWndMySQL {
    public partial class LogInForm : System.Windows.Forms.Form {
        public static LogInForm LInForm = null;
        public LogInForm() {
            InitializeComponent();
            LInForm = this;
        }
    }
}
