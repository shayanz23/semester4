namespace MDI
{
    partial class NewImageDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewImageChoice3 = new System.Windows.Forms.RadioButton();
            this.NewImageChoice2 = new System.Windows.Forms.RadioButton();
            this.NewImageChoice1 = new System.Windows.Forms.RadioButton();
            this.newImageOKButton = new System.Windows.Forms.Button();
            this.newImageCancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewImageChoice3);
            this.groupBox1.Controls.Add(this.NewImageChoice2);
            this.groupBox1.Controls.Add(this.NewImageChoice1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NewImageChoice3
            // 
            this.NewImageChoice3.AutoSize = true;
            this.NewImageChoice3.Location = new System.Drawing.Point(6, 97);
            this.NewImageChoice3.Name = "NewImageChoice3";
            this.NewImageChoice3.Size = new System.Drawing.Size(79, 19);
            this.NewImageChoice3.TabIndex = 2;
            this.NewImageChoice3.TabStop = true;
            this.NewImageChoice3.Text = "1024 x 768";
            this.NewImageChoice3.UseVisualStyleBackColor = true;
            this.NewImageChoice3.CheckedChanged += new System.EventHandler(this.NewImageChoice3_CheckedChanged);
            // 
            // NewImageChoice2
            // 
            this.NewImageChoice2.AutoSize = true;
            this.NewImageChoice2.Location = new System.Drawing.Point(6, 59);
            this.NewImageChoice2.Name = "NewImageChoice2";
            this.NewImageChoice2.Size = new System.Drawing.Size(73, 19);
            this.NewImageChoice2.TabIndex = 1;
            this.NewImageChoice2.TabStop = true;
            this.NewImageChoice2.Text = "800 x 600";
            this.NewImageChoice2.UseVisualStyleBackColor = true;
            this.NewImageChoice2.CheckedChanged += new System.EventHandler(this.NewImageChoice2_CheckedChanged);
            // 
            // NewImageChoice1
            // 
            this.NewImageChoice1.AutoSize = true;
            this.NewImageChoice1.Location = new System.Drawing.Point(6, 22);
            this.NewImageChoice1.Name = "NewImageChoice1";
            this.NewImageChoice1.Size = new System.Drawing.Size(73, 19);
            this.NewImageChoice1.TabIndex = 0;
            this.NewImageChoice1.TabStop = true;
            this.NewImageChoice1.Text = "640 x 480";
            this.NewImageChoice1.UseVisualStyleBackColor = true;
            this.NewImageChoice1.CheckedChanged += new System.EventHandler(this.NewImageChoice1_CheckedChanged);
            // 
            // newImageOKButton
            // 
            this.newImageOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newImageOKButton.Location = new System.Drawing.Point(299, 33);
            this.newImageOKButton.Name = "newImageOKButton";
            this.newImageOKButton.Size = new System.Drawing.Size(75, 23);
            this.newImageOKButton.TabIndex = 1;
            this.newImageOKButton.Text = "OK";
            this.newImageOKButton.UseVisualStyleBackColor = true;
            // 
            // newImageCancelButton
            // 
            this.newImageCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newImageCancelButton.Location = new System.Drawing.Point(299, 104);
            this.newImageCancelButton.Name = "newImageCancelButton";
            this.newImageCancelButton.Size = new System.Drawing.Size(75, 23);
            this.newImageCancelButton.TabIndex = 2;
            this.newImageCancelButton.Text = "Cancel";
            this.newImageCancelButton.UseVisualStyleBackColor = true;
            // 
            // NewImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 151);
            this.Controls.Add(this.newImageCancelButton);
            this.Controls.Add(this.newImageOKButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewImageDialog";
            this.Text = "New Image Dialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton NewImageChoice3;
        private RadioButton NewImageChoice2;
        private RadioButton NewImageChoice1;
        private Button newImageOKButton;
        private Button newImageCancelButton;
    }
}