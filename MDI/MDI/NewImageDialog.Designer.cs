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
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(492, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // NewImageChoice3
            // 
            this.NewImageChoice3.AutoSize = true;
            this.NewImageChoice3.Location = new System.Drawing.Point(11, 207);
            this.NewImageChoice3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewImageChoice3.Name = "NewImageChoice3";
            this.NewImageChoice3.Size = new System.Drawing.Size(161, 36);
            this.NewImageChoice3.TabIndex = 2;
            this.NewImageChoice3.TabStop = true;
            this.NewImageChoice3.Text = "1024 x 768";
            this.NewImageChoice3.UseVisualStyleBackColor = true;
            this.NewImageChoice3.CheckedChanged += new System.EventHandler(this.NewImageChoice3_CheckedChanged);
            // 
            // NewImageChoice2
            // 
            this.NewImageChoice2.AutoSize = true;
            this.NewImageChoice2.Location = new System.Drawing.Point(11, 126);
            this.NewImageChoice2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewImageChoice2.Name = "NewImageChoice2";
            this.NewImageChoice2.Size = new System.Drawing.Size(148, 36);
            this.NewImageChoice2.TabIndex = 1;
            this.NewImageChoice2.TabStop = true;
            this.NewImageChoice2.Text = "800 x 600";
            this.NewImageChoice2.UseVisualStyleBackColor = true;
            this.NewImageChoice2.CheckedChanged += new System.EventHandler(this.NewImageChoice2_CheckedChanged);
            // 
            // NewImageChoice1
            // 
            this.NewImageChoice1.AutoSize = true;
            this.NewImageChoice1.Location = new System.Drawing.Point(11, 47);
            this.NewImageChoice1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewImageChoice1.Name = "NewImageChoice1";
            this.NewImageChoice1.Size = new System.Drawing.Size(148, 36);
            this.NewImageChoice1.TabIndex = 0;
            this.NewImageChoice1.TabStop = true;
            this.NewImageChoice1.Text = "640 x 480";
            this.NewImageChoice1.UseVisualStyleBackColor = true;
            this.NewImageChoice1.CheckedChanged += new System.EventHandler(this.NewImageChoice1_CheckedChanged);
            // 
            // newImageOKButton
            // 
            this.newImageOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newImageOKButton.Location = new System.Drawing.Point(555, 70);
            this.newImageOKButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.newImageOKButton.Name = "newImageOKButton";
            this.newImageOKButton.Size = new System.Drawing.Size(139, 49);
            this.newImageOKButton.TabIndex = 1;
            this.newImageOKButton.Text = "OK";
            this.newImageOKButton.UseVisualStyleBackColor = true;
            // 
            // newImageCancelButton
            // 
            this.newImageCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newImageCancelButton.Location = new System.Drawing.Point(555, 222);
            this.newImageCancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.newImageCancelButton.Name = "newImageCancelButton";
            this.newImageCancelButton.Size = new System.Drawing.Size(139, 49);
            this.newImageCancelButton.TabIndex = 2;
            this.newImageCancelButton.Text = "Cancel";
            this.newImageCancelButton.UseVisualStyleBackColor = true;
            // 
            // NewImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 322);
            this.Controls.Add(this.newImageCancelButton);
            this.Controls.Add(this.newImageOKButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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