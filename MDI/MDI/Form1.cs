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
            int option;
            using (NewImageDialog newImageDialog = new NewImageDialog())
            {
                if (newImageDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    option = newImageDialog.SelectedRes;
                        MDIChild mDIChild = new MDIChild(option);
                        mDIChild.MdiParent = this;
                        mDIChild.Show();
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}