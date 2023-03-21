using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 7 Tester App. 
/// Author: Shayan Zahedanaraki
/// Date: March 20, 2023; Revision: -
/// Source:
/// EXternal Libraries:
/// </summary>
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool playing;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            playing = false;
            string playImageLocation = Environment.CurrentDirectory + "/pause.png";
            string pausedImageLocation = Environment.CurrentDirectory + "/play.png";
            playPauseButton1.PlayingBackgroundImage = Image.FromFile(playImageLocation);
            playPauseButton1.PausedBackgroundImage = Image.FromFile(pausedImageLocation);
        }

        /// <summary>
        /// Event listener for if the play pause button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playPauseButton1_Click(object sender, EventArgs e)
        {
            playing = !playing;
            playPauseButton1.playing = playing;
        }

        /// <summary>
        /// This is the Color changed event handeler for the RGB user control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorChanged(object sender, EventArgs e)
        {
            redLabel.Text = "Red: " + userControlRGB.ColorProperty.R.ToString();
            greenLabel.Text = "Green: " + userControlRGB.ColorProperty.G.ToString();
            blueLabel.Text = "Blue: " + userControlRGB.ColorProperty.B.ToString();
        }
    }
}
