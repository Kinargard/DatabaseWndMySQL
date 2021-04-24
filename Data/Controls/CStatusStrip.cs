namespace DatabaseWndMySQL.Data.Controls {
    public class CStatusStrip {
        public CStatusStrip() {
            try {
                DatabaseWnd.MainForm.Controls.Add(Border);
                Border.Controls.Add(StatusStrip);
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

        private static readonly System.Windows.Forms.Panel StatusStrip = new System.Windows.Forms.Panel() {
            Size = new System.Drawing.Size(1000, 24),
            Location = new System.Drawing.Point(0, 1),
            BackColor = PStatusStrip.BackColor,
            Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left
        };

        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel() {
            Size = new System.Drawing.Size(1000, 25),
            Location = new System.Drawing.Point(0, 575),
            BackColor = PBorder.BackColor,
            Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left
        };
    }
}
