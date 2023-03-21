namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playPauseButton1 = new ControlLibraryShayan.PlayPauseButton();
            this.buttonShayan1 = new ControlLibraryShayan.ButtonShayan();
            this.userControlRGB = new ControlLibraryShayan.UserControlRGBShayan();
            this.buttonShayan2 = new ControlLibraryShayan.ButtonShayan();
            this.playbackButtonLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playPauseButton1
            // 
            this.playPauseButton1.FlatAppearance.BorderSize = 0;
            this.playPauseButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playPauseButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playPauseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPauseButton1.ForeColor = System.Drawing.Color.Black;
            this.playPauseButton1.Location = new System.Drawing.Point(208, 110);
            this.playPauseButton1.Name = "playPauseButton1";
            this.playPauseButton1.PausedBackgroundImage = null;
            this.playPauseButton1.playing = false;
            this.playPauseButton1.PlayingBackgroundImage = null;
            this.playPauseButton1.Size = new System.Drawing.Size(34, 32);
            this.playPauseButton1.TabIndex = 0;
            this.playPauseButton1.Text = "No Image";
            this.playPauseButton1.UseVisualStyleBackColor = true;
            this.playPauseButton1.Click += new System.EventHandler(this.playPauseButton1_Click);
            // 
            // buttonShayan1
            // 
            this.buttonShayan1.ColorBack = System.Drawing.Color.DarkBlue;
            this.buttonShayan1.ColorFore = System.Drawing.Color.Aqua;
            this.buttonShayan1.CustomStyle = System.Drawing.Drawing2D.HatchStyle.DashedVertical;
            this.buttonShayan1.Location = new System.Drawing.Point(208, 164);
            this.buttonShayan1.Name = "buttonShayan1";
            this.buttonShayan1.Size = new System.Drawing.Size(86, 27);
            this.buttonShayan1.TabIndex = 1;
            this.buttonShayan1.Text = "buttonShayan1";
            this.buttonShayan1.TransparencyBackground = 64;
            this.buttonShayan1.TransparencyForeground = 64;
            this.buttonShayan1.UseVisualStyleBackColor = true;
            // 
            // userControlRGB
            // 
            this.userControlRGB.ColorProperty = System.Drawing.Color.Empty;
            this.userControlRGB.Location = new System.Drawing.Point(208, 267);
            this.userControlRGB.Name = "userControlRGB";
            this.userControlRGB.Size = new System.Drawing.Size(523, 272);
            this.userControlRGB.TabIndex = 2;
            this.userControlRGB.ColorChanged += new System.EventHandler(this.ColorChanged);
            // 
            // buttonShayan2
            // 
            this.buttonShayan2.ColorBack = System.Drawing.Color.DimGray;
            this.buttonShayan2.ColorFore = System.Drawing.Color.Aqua;
            this.buttonShayan2.CustomStyle = System.Drawing.Drawing2D.HatchStyle.DashedVertical;
            this.buttonShayan2.Location = new System.Drawing.Point(208, 216);
            this.buttonShayan2.Name = "buttonShayan2";
            this.buttonShayan2.Size = new System.Drawing.Size(86, 27);
            this.buttonShayan2.TabIndex = 3;
            this.buttonShayan2.Text = "buttonShayan2";
            this.buttonShayan2.TransparencyBackground = 64;
            this.buttonShayan2.TransparencyForeground = 64;
            this.buttonShayan2.UseVisualStyleBackColor = true;
            // 
            // playbackButtonLabel
            // 
            this.playbackButtonLabel.AutoSize = true;
            this.playbackButtonLabel.Location = new System.Drawing.Point(205, 79);
            this.playbackButtonLabel.Name = "playbackButtonLabel";
            this.playbackButtonLabel.Size = new System.Drawing.Size(89, 13);
            this.playbackButtonLabel.TabIndex = 4;
            this.playbackButtonLabel.Text = "Playpause button";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(737, 319);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(30, 13);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "Red:";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(737, 395);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(39, 13);
            this.greenLabel.TabIndex = 6;
            this.greenLabel.Text = "Green:";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(737, 468);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(31, 13);
            this.blueLabel.TabIndex = 7;
            this.blueLabel.Text = "Blue:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 551);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.playbackButtonLabel);
            this.Controls.Add(this.buttonShayan2);
            this.Controls.Add(this.userControlRGB);
            this.Controls.Add(this.buttonShayan1);
            this.Controls.Add(this.playPauseButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibraryShayan.PlayPauseButton playPauseButton1;
        private ControlLibraryShayan.ButtonShayan buttonShayan1;
        private ControlLibraryShayan.UserControlRGBShayan userControlRGB;
        private ControlLibraryShayan.ButtonShayan buttonShayan2;
        private System.Windows.Forms.Label playbackButtonLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
    }
}

