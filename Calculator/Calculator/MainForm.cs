/// <summary>
/// Lab 1 Calculator Application 
/// Author: Shayan Zahedanaraki
/// Date: January 11, 2023; Revision: -
/// Source: Code based on the Intro to Windows Forms (WinForms) in .NET 6 tutorial at: https://www.youtube.com/watch?v=0zLZQesgV5o&t=4100s
/// EXternal Libraries: https://matheval.org/
/// </summary>

using org.matheval;
using org.matheval.Node;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            try
            {
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/img.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } 
            catch (Exception b) 
            {
                MessageBox.Show("Please put an image here: " + Directory.GetCurrentDirectory() + ", with the name img.jpg", "No image found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "=")
            {
                Expression expression = new Expression(mainTextBox.Text.ToString());
                try
                {
                    var v = expression.Eval();
                    mainTextBox.Text = v.ToString();
                }
                catch (Exception b)
                {
                    MessageBox.Show("Please check your format and try again.", "Incorect format.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else if(((Button)sender).Text == "C")
            {
                mainTextBox.Clear();
                memoryTxtBx.Text = "";
            } 
            else if(((Button)sender).Text == "CE")
            {
                mainTextBox.Clear();
            } 
            else if (((Button)sender).Text == "<-")
            {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
            }
            else if (((Button)sender).Text == "1/x")
            {
                mainTextBox.Text += "1/";
            }
            else if (((Button)sender).Text == "x^2")
            {
                mainTextBox.Text += "^2";
            }
            else if (((Button)sender).Text == "MC")
            {
                memoryTxtBx.Text = "";
            }
            else if (((Button)sender).Text == "MR")
            {
                mainTextBox.Text += memoryTxtBx.Text;
            }
            else if (((Button)sender).Text == "M+")
            {
                memoryTxtBx.Text = mainTextBox.Text;
            }
            else if (((Button)sender).Text == "()")
            {
                if ((mainTextBox.Text.ToString().Count(t => t == '(') + mainTextBox.Text.ToString().Count(t => t == ')')) % 2 == 0)
                {
                    mainTextBox.Text += "(";
                }
                else
                {
                    mainTextBox.Text += ")";
                }
            } 
            else
            {
                mainTextBox.Text += ((Button)sender).Text.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator\nVersion: 2\nBy: Shayan Zahedanaraki");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}