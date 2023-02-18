namespace MDI
{
    partial class ImageFromWebDialog
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
            this.newImageOKButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newImageOKButton
            // 
            this.newImageOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newImageOKButton.Location = new System.Drawing.Point(307, 64);
            this.newImageOKButton.Name = "newImageOKButton";
            this.newImageOKButton.Size = new System.Drawing.Size(75, 23);
            this.newImageOKButton.TabIndex = 2;
            this.newImageOKButton.Text = "OK";
            this.newImageOKButton.UseVisualStyleBackColor = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 65);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(289, 23);
            this.urlTextBox.TabIndex = 3;
            // 
            // ImageFromWebDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 151);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.newImageOKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ImageFromWebDialog";
            this.Text = "Choose Image From Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button newImageOKButton;
        private TextBox urlTextBox;
    }
}