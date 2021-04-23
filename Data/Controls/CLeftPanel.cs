namespace DatabaseWndMySQL.Data.Controls {
    public class CLeftPanel {
        public CLeftPanel() {
            try {
                DatabaseWnd.MainForm.Controls.Add(Border);
                Border.Controls.Add(LeftPanel);
            }
            catch (System.Exception Ex) { System.Windows.Forms.MessageBox.Show(Ex.Message); }
        }

        public struct PLeftPanel {
            public struct Location {
                public static int X { get => LeftPanel.Location.X; }
                public static int Y { get => LeftPanel.Location.Y; }
            }

            public static int Width { get => LeftPanel.Width; }
            public static int Height { get => LeftPanel.Height; }
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

        private static readonly System.Windows.Forms.Panel LeftPanel = new System.Windows.Forms.Panel() {
            Size = new System.Drawing.Size(250, 508),
            Location = new System.Drawing.Point(1, 1),
            BackColor = PLeftPanel.BackColor,
            Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
        };

        private static readonly System.Windows.Forms.Panel Border = new System.Windows.Forms.Panel() {
            Size = new System.Drawing.Size(252, 510),
            Location = new System.Drawing.Point(10, 55),
            BackColor = PBorder.BackColor,
            Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
        };
    }
}
