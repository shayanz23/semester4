using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Lab 7 Control Library. 
/// Author: Shayan Zahedanaraki
/// Date: March 20, 2023; Revision: -
/// Source:
/// EXternal Libraries:
/// </summary>
namespace ControlLibraryShayan
{
    /// <summary>
    /// Custom UserControl to select and display RGB colors.
    /// </summary>
    public partial class UserControlRGBShayan : UserControl
    {
        /// <summary>
        /// Property to get or set the selected color.
        /// </summary>
        public Color ColorProperty { get; set; }

        /// <summary>
        /// Event raised when the selected color changes.
        /// </summary>
        public event EventHandler ColorChanged;

        /// <summary>
        /// Method invoked when the ColorChanged event is fired off.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Initializes a new instance of the UserControlRGBShayan.
        /// </summary>
        public UserControlRGBShayan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for trackbar scroll events. Updates the mixed color based on trackbar values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBarScroll(object sender, EventArgs e)
        {
            Color mixedColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            try
            {
                colorPanel.BackColor = mixedColor;
                ColorProperty = mixedColor;
                OnColorChanged(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}