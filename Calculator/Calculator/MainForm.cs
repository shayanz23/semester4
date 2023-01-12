/// <summary>
/// Lab 1 Calculator Application 
/// Author: Shayan Zahedanaraki
/// Date: January 11, 2023; Revision: -
/// Source: Code based on the Intro to Windows Forms (WinForms) in .NET 6 tutorial at: https://www.youtube.com/watch?v=0zLZQesgV5o&t=4100s
/// EXternal Libraries: https://matheval.org/
/// </summary>

using org.matheval;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += ".";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length-1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            mainTextBox.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Expression expression = new Expression(mainTextBox.Text.ToString());
            try
            {
                var v = expression.Eval();
                mainTextBox.Text = v.ToString();
                // Items Are added to list, but just not scrolled to bottom automatically.
                listBox1.Items.Add(v.ToString());
            }
            catch (Exception b)
            {
                MessageBox.Show("Please check your format and try again.", "Incorect format.",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "^";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator\nVersion: 2\nBy: Shayan Zahedanaraki");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "0";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "6";
        }

        private void button_subtraction_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "-";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "7";
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += "*";
        }

        private void button_bracket_Click(object sender, EventArgs e)
        {
            if ((mainTextBox.Text.ToString().Count(t => t == '(') + mainTextBox.Text.ToString().Count(t => t == ')')) % 2 == 0)
            {
                mainTextBox.Text += "(";
            } else
            {
                mainTextBox.Text += ")";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}