namespace DatabaseWndMySQL {
    public partial class DatabaseWnd : System.Windows.Forms.Form {
        public static DatabaseWnd MainForm = null;
        public DatabaseWnd() {
            InitializeComponent();
            MainForm = this;
            _ = new Data.CColor();
            _ = new Data.Controls.FMainPanel.CAuthorization();
            _ = new Data.Controls.CDataTable();
            _ = new Data.Controls.CLeftPanel();
            _ = new Data.Controls.CMainPanel();
            _ = new Data.Controls.CStatusStrip();
            MainForm.Text = $"{MainForm.ClientSize.Width} x {MainForm.ClientSize.Height}";
        }
    }
}
