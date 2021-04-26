namespace DatabaseWndMySQL.Data.Controls {
    public class CMainPanel {
        private void InitializeComponent() {
            try {
                
                // MainPanel (Panel) //////////////////////////////////////////
                
                MainPanel.Size = new System.Drawing.Size(1000, 44);
                MainPanel.Location = new System.Drawing.Point(0, 0);
                MainPanel.BackColor = PMainPanel.BackColor;
                MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
                
                // Border (Panel) /////////////////////////////////////////////
                
                Border.Size = new System.Drawing.Size(1000, 45);
                Border.Location = new System.Drawing.Point(0, 0);
                Border.BackColor = PBorder.BackColor;
                Border.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

                ///////////////////////////////////////////////////////////////
                
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PMainPanel {
            public struct Location {
                public static int X { get => MainPanel.Location.X; }
                public static int Y { get => MainPanel.Location.Y; }
            }

            public static int Width { get => MainPanel.Width; }
            public static int Height { get => MainPanel.Height; }
            public static System.Drawing.Color BackColor { get; set; }
        }

        public struct PBorder {
            public struct Location {
                public static int X { get => Border.Location.X; }
                public static int Y { get => Border.Location.Y; }
            }

            public static int Width { get => Border.Width; }
            public static int Height { get => Border.Height; }
            public static System.Drawing.Color BackColor { get; set; }
        }

        public CMainPanel() {
            try {
                DatabaseWnd.MainForm.Controls.Add(Border);
                Border.Controls.Add(MainPanel);
                InitializeComponent();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.Panel MainPanel = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel();
    }
}
