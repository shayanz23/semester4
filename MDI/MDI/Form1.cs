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
                if (newImageDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Text = newImageDialog.SelectedRes.ToString();
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}