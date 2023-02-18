

namespace MDI
{
    public partial class MDIChild : Form
    {

        public Image image { get; set; }

        public MDIChild()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        private void MDIChild_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, new Point(0, 0));
        }
    }
}
