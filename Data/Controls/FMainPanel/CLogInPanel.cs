namespace DatabaseWndMySQL.Data.Controls.FMainPanel {
    public class CLogInPanel {
        private static readonly bool OnActiveMenu = false;

        private void InitializeComponent() {
            try {

                // Border (Panel) /////////////////////////////////////////////

                //Border.Size

                // LogInPanel (Panel) /////////////////////////////////////////

                LogInPanel.Size = new System.Drawing.Size(150, 24);
                LogInPanel.Location = new System.Drawing.Point(840, 10);
                LogInPanel.BackColor = PLogInPanel.Drawing.BackColor;
                LogInPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
                
                // Caption (Label) ////////////////////////////////////////////
                
                Caption.Size = new System.Drawing.Size(148, 22);
                Caption.Location = new System.Drawing.Point(1, 1);
                Caption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                Caption.BackColor = PCaption.Drawing.BackColor;
                Caption.ForeColor = PCaption.Drawing.ForeColor;
                Caption.Text = "АВТОРИЗАЦИЯ";
                CaptionEvents();

                ///////////////////////////////////////////////////////////////

            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private void CaptionEvents() {
            try {
                Caption.MouseEnter += (s, e) => {
                    try {
                        if (!OnActiveMenu) {
                            LogInPanel.BackColor = System.Drawing.Color.FromArgb(0x40, 0x50, 0x8D);
                            Caption.BackColor = System.Drawing.Color.FromArgb(0x40, 0x50, 0x8D);
                        }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                Caption.MouseLeave += (s, e) => {
                    try {
                        if (!OnActiveMenu) {
                            LogInPanel.BackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);
                            Caption.BackColor = System.Drawing.Color.FromArgb(0x5F, 0x6F, 0xA4);
                        }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
                Caption.Click += (s, e) => {
                    try {
                        if (Caption.Text == "АВТОРИЗАЦИЯ") { LInForm.ShowDialog(); }
                    }
                    catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
                };
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PLogInPanel {
            public struct Location {
                public static int X { get => LogInPanel.Location.X; }
                public static int Y { get => LogInPanel.Location.Y; }
            }
            public static int Width { get => LogInPanel.Width; }
            public static int Height { get => LogInPanel.Height; }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
            }
        }

        public struct PCaption {
            public struct Location {
                public static int X { get => Caption.Location.X; }
                public static int Y { get => Caption.Location.Y; }
            }
            public static int Width { get => Caption.Width; }
            public static int Height { get => Caption.Height; }
            public static string Text { get => Caption.Text; set { Caption.Text = value; } }
            public struct Drawing {
                public static System.Drawing.Color BackColor { get; set; }
                public static System.Drawing.Color ForeColor { get; set; }
            }
        }

        public CLogInPanel() {
            try {
                DatabaseWnd.MainForm.Controls.Add(LogInPanel);
                LogInPanel.Controls.Add(Caption);
                InitializeComponent();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.Panel LogInPanel = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Label Caption = new System.Windows.Forms.Label();
        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel();
        private static readonly LogInForm LInForm = new LogInForm();
    }
}
