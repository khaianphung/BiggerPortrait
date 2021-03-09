using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace BiggerPortrait
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rectangle desktopRect0 = GetDesktopBounds();
            this.Size= new Size(desktopRect0.Width, desktopRect0.Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Opacity = 0.99;
            this.TopMost = true;

            Bitmap b = CaptureApplication();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.BackgroundImageLayout = ImageLayout.Center;

            pictureBox1.BackColor = Color.LimeGreen;
            //pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(this.Bounds.Right * 545 / 1000, this.Bounds.Bottom * 390 / 1000);
            pictureBox1.Size = new Size(this.Bounds.Right * 115 / 1000*3, this.Bounds.Bottom * 21 / 100*3);
            pictureBox1.Image= (Image)b;
           
            //pictureBox1.Size = new Rectangle(this.Bounds.Right * 115 / 1000, this.Bounds.Bottom * 21 / 100);
            //this.BackgroundImage = (Image)b;


        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }





        private static void CaptureDesktop()
        {
            Rectangle desktopRect = GetDesktopBounds();

            Bitmap bitmap = new Bitmap(desktopRect.Width, desktopRect.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(desktopRect.Location, Point.Empty, bitmap.Size);
            }
            bitmap.Save("nice.png", ImageFormat.Png);
        }

        private static Rectangle GetDesktopBounds()
        {
            Rectangle result = new Rectangle();
            foreach (Screen screen in Screen.AllScreens)
            {
                result = Rectangle.Union(result, screen.Bounds);

            }

            return result;
        }

        public Bitmap CaptureApplication()
        {

            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    //g.CopyFromScreen(new Point(bounds.Right*595/1000, bounds.Bottom*727/1000), Point.Empty, bounds.Size);
                    g.CopyFromScreen(new Point(bounds.Right*595/1000, bounds.Bottom*727/1000), Point.Empty, bounds.Size);
                }


                Bitmap bmp1 = bitmap.Clone(new Rectangle(bounds.Left, bounds.Top, bounds.Right*115/1000, bounds.Bottom*21/100), bitmap.PixelFormat);

                int zoomFactor = 3;
                Size newSize = new Size((int)(bmp1.Width * zoomFactor), (int)(bmp1.Height * zoomFactor));
                Bitmap bmp2 = new Bitmap(bmp1, newSize);


                return bmp2;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }


        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString()=="H")
            {
                this.Close();
                this.Dispose();
            }
            // the user pressed the F1 key


        }
    }
}