using System;
using System.Net;
using System.Security.Policy;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            using (NewImageDialog newImageDialog = new NewImageDialog())
            {
                if (newImageDialog.ShowDialog() == DialogResult.OK)
                {
                    int option = newImageDialog.SelectedRes;
                    int width;
                    int height;
                    if (option == 2)
                    {
                        height = 600;
                        width = 800;
                    }
                    else if (option == 3)
                    {
                        height = 768;
                        width = 1024;
                    }
                    else
                    {
                        height = 480;
                        width = 640;
                    }
                    Image image = new Bitmap(width, height);
                    Graphics g = Graphics.FromImage(image);
                    MDIChild mDIChild = new MDIChild();
                    mDIChild.MdiParent = this;
                    SolidBrush blueBrush = new SolidBrush(Color.Blue);
                    mDIChild.Size = new Size(width, height);
                    Rectangle rect = new Rectangle(0, 0, width, height);
                    g.FillRectangle(blueBrush, rect);
                    mDIChild.image = image;
                    mDIChild.Show();
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFromFileMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif";
                
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    Image image = new Bitmap(openFileDialog.FileName);
                    MDIChild mDIChild = new MDIChild();
                    mDIChild.image = image;
                    mDIChild.MdiParent = this;
                    mDIChild.Show();
                }
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "JPEG Image|*.jpg;*.png;*.gif";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.DefaultExt = ".jpg";
                saveFileDialog1.FileName = "New Image";
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK && ActiveMdiChild != null)
                {
                    MDIChild mDIChild = (MDIChild)ActiveMdiChild;
                    mDIChild.image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                } 
                else if (result == DialogResult.OK && ActiveMdiChild == null)
                {
                    MessageBox.Show("No Image open.","Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void openFromWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ImageFromWebDialog openFileDialog = new ImageFromWebDialog())
            {

                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    try 
                    {
                        WebClient client = new WebClient();
                        byte[] data = client.DownloadData(openFileDialog.Url);
                        MemoryStream ms = new MemoryStream(data);
                        Image image = Image.FromStream(ms);
                        MDIChild mDIChild = new MDIChild();
                        mDIChild.image = image;
                        mDIChild.MdiParent = this;
                        mDIChild.Show();
                    } 
                    catch (WebException exception) 
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren != null && MdiChildren.Length != 0)
            {
                saveAsMenuItem.Enabled = true;
                saveMenuItem.Enabled = true;
            }
            else
            {
                saveAsMenuItem.Enabled = false;
                saveMenuItem.Enabled = false;
            }
        }
    }
}