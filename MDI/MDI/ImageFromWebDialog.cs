using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MDI
{
    public partial class ImageFromWebDialog : Form
    {
        public string Url { 
            get {
                return urlTextBox.Text;
            } 
            set { 
                urlTextBox.Text = value;
            } 
        }

        public ImageFromWebDialog()
        {
            InitializeComponent();
            urlTextBox.Text = "https://t4.ftcdn.net/jpg/03/18/62/73/360_F_318627348_Uj5VtxZe8mOdGE5IDEw4SK7FL6IuWQPr.jpg";
        }
    }
}
