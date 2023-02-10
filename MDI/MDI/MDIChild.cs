using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MDI
{
    public partial class MDIChild : Form
    {
        public MDIChild()
        {
            InitializeComponent();
        }

        public MDIChild(int resChoice)
        {
            InitializeComponent();
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            if (resChoice == 1)
            {
                this.Size = new Size(640, 480);
                Bitmap bitmap = new Bitmap(640, 480, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

                Graphics graphics = Graphics.FromImage(bitmap);
                Rectangle rectangle = new Rectangle(0, 0, 640, 480);
                graphics.FillRectangle(blueBrush, rectangle);
            } 
            else if (resChoice == 2)
            {
                this.Size = new Size(800, 600);
            }
            else if (resChoice == 3)
            {
                this.Size = new Size(1024, 768);
            } else
            {
                this.Size = new Size(640, 480);
            }
        }
    }
}
