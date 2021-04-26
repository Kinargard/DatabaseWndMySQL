namespace DatabaseWndMySQL.Data.Controls {
    public class CStatusStrip {
        private void InitializeComponent() {
            try {
                
                // StatusStrip (Panel) ////////////////////////////////////////
                
                StatusStrip.Size = new System.Drawing.Size(1000, 24);
                StatusStrip.Location = new System.Drawing.Point(0, 1);
                StatusStrip.BackColor = PStatusStrip.BackColor;
                StatusStrip.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
                
                // Border (Panel) /////////////////////////////////////////////
                
                Border.Size = new System.Drawing.Size(1000, 25);
                Border.Location = new System.Drawing.Point(0, 575);
                Border.BackColor = PBorder.BackColor;
                Border.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
                
                ///////////////////////////////////////////////////////////////
                
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PStatusStrip {
            public struct Location {
                public static int X { get => StatusStrip.Location.X; }
                public static int Y { get => StatusStrip.Location.Y; }
            }
            public static int Width { get => StatusStrip.Width; }
            public static int Height { get => StatusStrip.Height; }
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

        public CStatusStrip() {
            try {
                DatabaseWnd.MainForm.Controls.Add(Border);
                Border.Controls.Add(StatusStrip);
                InitializeComponent();
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        private static readonly System.Windows.Forms.Panel StatusStrip = new System.Windows.Forms.Panel();
        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel();
    }
}
