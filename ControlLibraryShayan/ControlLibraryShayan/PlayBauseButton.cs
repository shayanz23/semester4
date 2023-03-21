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
    /// Custom PlayPauseButton control that toggles between play and pause states and displays corresponding images.
    /// </summary>
    public partial class PlayPauseButton : Button
    {
        /// <summary>
        /// Delegate for the PlayingChanged event.
        /// </summary>
        public delegate void PlayingChangedEventHandler(object sender, EventArgs e);

        /// <summary>
        /// Event raised when the playing state changes.
        /// </summary>
        public event PlayingChangedEventHandler PlayingChanged;

        // Internal variable to store the playing state
        private bool _playing;

        /// <summary>
        /// Property to get or set the playing state of the button.
        /// </summary>
        public bool playing
        {
            get { return _playing; }
            set
            {
                if (_playing != value)
                {
                    _playing = value;
                    OnPlayingChanged(EventArgs.Empty);
                }
            }
        }

        // Internal variables to store the background images
        private Image _playingBackgroundImage = null;
        private Image _pausedBackgroundImage = null;

        /// <summary>
        /// Property to get or set the background image when the button is in playing state.
        /// </summary>
        public Image PlayingBackgroundImage
        {
            get { return _playingBackgroundImage; }
            set { _playingBackgroundImage = value; }
        }

        /// <summary>
        /// Property to get or set the background image when the button is in paused state.
        /// </summary>
        public Image PausedBackgroundImage
        {
            get { return _pausedBackgroundImage; }
            set { _pausedBackgroundImage = value; }
        }

        /// <summary>
        /// Initializes a new instance of the PlayPauseButton control.
        /// </summary>
        public PlayPauseButton()
        {
            InitializeComponent();
            playing = false;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;

            // Enable double buffering for smoother graphics rendering
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        /// <summary>
        /// Overrides the OnPaint event to display the corresponding background image based on the playing state.
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            Image backgroundImage;

            if (playing)
            {
                backgroundImage = PlayingBackgroundImage;
            }
            else
            {
                backgroundImage = PausedBackgroundImage;
            }

            if (backgroundImage != null)
            {
                Text = "";

                // Clear the previous graphics with the BackColor
                pe.Graphics.Clear(BackColor);

                // Draw the new image
                pe.Graphics.DrawImage(backgroundImage, 0, 0, this.Width, this.Height);

                // Remove the border
                ControlPaint.DrawBorder(pe.Graphics, ClientRectangle, BackColor, ButtonBorderStyle.Solid);
            }
            else
            {
                base.OnPaint(pe);
                Text = "No Image";
                ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Raises the PlayingChanged event and invalidates the control to update the visual appearance.
        /// </summary>
        protected virtual void OnPlayingChanged(EventArgs e)
        {
            PlayingChanged?.Invoke(this, e);
            Invalidate();
        }
    }
}