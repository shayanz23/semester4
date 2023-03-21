using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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
    /// Custom button control providing advanced styling options for colors, transparency, and hatch patterns.
    /// </summary>
    public partial class ButtonShayan : Button
    {
        public ButtonShayan()
        {
            InitializeComponent();
        }
        private Color firstColor = Color.Aqua;
        private Color secondColor = Color.DarkBlue;
        private int firstTransparency = 64;
        private int secondTransparency = 64;
        private HatchStyle customHatchStyle = HatchStyle.DashedVertical;

        /// <summary>
        /// Delegate for handling custom button events.
        /// </summary>
        public delegate void CustomButtonEventHandle(object sender, EventArgs e);

        /// <summary>
        /// Gets or sets the hatch pattern's style.
        /// </summary>
        [
        Category("Custom Design"),
        Description("Set the pattern's style")
        ]

        public HatchStyle CustomStyle
        {
            get
            {
                return customHatchStyle;
            }
            set
            {
                customHatchStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the foreground color of the button.
        /// </summary>
        [
        Category("Custom Design"),
        Description("Set the foreground color")
        ]
        public Color ColorFore
        {
            get
            {
                return firstColor;
            }
            set
            {
                firstColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the background color of the button.
        /// </summary>
        [
        Category("Custom Design"),
        Description("Set the background color")
        ]
        public Color ColorBack
        {
            get
            {
                return secondColor;
            }
            set
            {
                secondColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the transparency value for the foreground color.
        /// </summary>
        [
        Category("Custom Design"),
        Description("Set the trnsparency value for the foreground color")
        ]
        public int TransparencyForeground
        {
            get
            {
                return firstTransparency;
            }
            set
            {
                firstTransparency = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the transparency value for the background color.
        /// </summary>
        [
        Category("Custom Design"),
        Description("Set the trnsparency value for the background color")
        ]
        public int TransparencyBackground
        {
            get
            {
                return secondTransparency;
            }
            set
            {
                secondTransparency = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text that appears on the custom button.
        /// </summary>
        [
        Category("Custom Design"),
        Browsable(true),
        Description("Text that appear on the custom button"),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        /// <summary>
        /// Event for handling custom button clicks.
        /// </summary>
        [Category("Action"),
        Description("My Custom Event Click")
        ]
        public event CustomButtonEventHandle ShayanEvent;

        protected virtual void OnShayanEvent(EventArgs e)
        {
            if (ShayanEvent != null)
            {
                ShayanEvent(this, e);
            }
        }

        /// <summary>
        /// Overrides the OnMouseClick event to trigger the custom button click event.
        /// </summary>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            this.OnShayanEvent(e);
            this.Invalidate();
        }

        /// <summary>
        /// Overrides the OnPaint event to apply custom styling to the button.
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Call the base class OnPaint event
            base.OnPaint(pe);

            try
            {
                // Create the colors and the brush
                Color color1 = Color.FromArgb(firstTransparency, firstColor);
                Color color2 = Color.FromArgb(secondTransparency, secondColor);
                HatchBrush hatchBrush = new HatchBrush(customHatchStyle, color1, color2);

                // Paint the button rectangle
                pe.Graphics.FillRectangle(hatchBrush, ClientRectangle);

                // Dispose of the brush
                hatchBrush.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
