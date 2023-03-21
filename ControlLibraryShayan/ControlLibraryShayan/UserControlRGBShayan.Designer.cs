
/// <summary>
/// Lab 7 Control Library. 
/// Author: Shayan Zahedanaraki
/// Date: March 20, 2023; Revision: -
/// Source:
/// EXternal Libraries:
/// </summary>
namespace ControlLibraryShayan
{
    partial class UserControlRGBShayan
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.redSliderLbl = new System.Windows.Forms.Label();
            this.greenSliderLbl = new System.Windows.Forms.Label();
            this.blueSliderLbl = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(29, 47);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(218, 45);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.TickFrequency = 4;
            this.redTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(29, 121);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(218, 45);
            this.greenTrackBar.TabIndex = 1;
            this.greenTrackBar.TickFrequency = 4;
            this.greenTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(29, 195);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(218, 45);
            this.blueTrackBar.TabIndex = 2;
            this.blueTrackBar.TickFrequency = 4;
            this.blueTrackBar.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // redSliderLbl
            // 
            this.redSliderLbl.AutoSize = true;
            this.redSliderLbl.Location = new System.Drawing.Point(26, 31);
            this.redSliderLbl.Name = "redSliderLbl";
            this.redSliderLbl.Size = new System.Drawing.Size(27, 13);
            this.redSliderLbl.TabIndex = 3;
            this.redSliderLbl.Text = "Red";
            // 
            // greenSliderLbl
            // 
            this.greenSliderLbl.AutoSize = true;
            this.greenSliderLbl.Location = new System.Drawing.Point(26, 105);
            this.greenSliderLbl.Name = "greenSliderLbl";
            this.greenSliderLbl.Size = new System.Drawing.Size(36, 13);
            this.greenSliderLbl.TabIndex = 4;
            this.greenSliderLbl.Text = "Green";
            // 
            // blueSliderLbl
            // 
            this.blueSliderLbl.AutoSize = true;
            this.blueSliderLbl.Location = new System.Drawing.Point(26, 179);
            this.blueSliderLbl.Name = "blueSliderLbl";
            this.blueSliderLbl.Size = new System.Drawing.Size(28, 13);
            this.blueSliderLbl.TabIndex = 5;
            this.blueSliderLbl.Text = "Blue";
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(267, 31);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(228, 209);
            this.colorPanel.TabIndex = 7;
            // 
            // UserControlRGBShayan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.blueSliderLbl);
            this.Controls.Add(this.greenSliderLbl);
            this.Controls.Add(this.redSliderLbl);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.redTrackBar);
            this.Name = "UserControlRGBShayan";
            this.Size = new System.Drawing.Size(523, 272);
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label redSliderLbl;
        private System.Windows.Forms.Label greenSliderLbl;
        private System.Windows.Forms.Label blueSliderLbl;
        private System.Windows.Forms.Panel colorPanel;
    }
}
