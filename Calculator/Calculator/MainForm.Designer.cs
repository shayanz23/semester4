namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_addition = new System.Windows.Forms.Button();
            this.button_answer = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.button_division = new System.Windows.Forms.Button();
            this.button_power = new System.Windows.Forms.Button();
            this.button_bracket = new System.Windows.Forms.Button();
            this.button_AC = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_1.Location = new System.Drawing.Point(8, 393);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(77, 71);
            this.button_1.TabIndex = 2;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_2.Location = new System.Drawing.Point(95, 393);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(77, 71);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_3.Location = new System.Drawing.Point(178, 393);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(77, 71);
            this.button_3.TabIndex = 8;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_addition
            // 
            this.button_addition.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_addition.Location = new System.Drawing.Point(265, 393);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(77, 71);
            this.button_addition.TabIndex = 11;
            this.button_addition.Text = "+";
            this.button_addition.UseVisualStyleBackColor = true;
            this.button_addition.Click += new System.EventHandler(this.button10_Click);
            // 
            // button_answer
            // 
            this.button_answer.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_answer.Location = new System.Drawing.Point(265, 471);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(77, 71);
            this.button_answer.TabIndex = 15;
            this.button_answer.Text = "=";
            this.button_answer.UseVisualStyleBackColor = true;
            this.button_answer.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(178, 471);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(77, 71);
            this.button_back.TabIndex = 14;
            this.button_back.Text = "<-";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_0.Location = new System.Drawing.Point(95, 471);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(77, 71);
            this.button_0.TabIndex = 13;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_dot
            // 
            this.button_dot.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dot.Location = new System.Drawing.Point(8, 471);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(77, 71);
            this.button_dot.TabIndex = 12;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_subtraction
            // 
            this.button_subtraction.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_subtraction.Location = new System.Drawing.Point(265, 316);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(77, 71);
            this.button_subtraction.TabIndex = 19;
            this.button_subtraction.Text = "-";
            this.button_subtraction.UseVisualStyleBackColor = true;
            this.button_subtraction.Click += new System.EventHandler(this.button_subtraction_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_6.Location = new System.Drawing.Point(178, 316);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(77, 71);
            this.button_6.TabIndex = 18;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_5.Location = new System.Drawing.Point(95, 316);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(77, 71);
            this.button_5.TabIndex = 17;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_4.Location = new System.Drawing.Point(8, 316);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(77, 71);
            this.button_4.TabIndex = 16;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_multiplication.Location = new System.Drawing.Point(265, 239);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(77, 71);
            this.button_multiplication.TabIndex = 23;
            this.button_multiplication.Text = "x";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_9.Location = new System.Drawing.Point(178, 239);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(77, 71);
            this.button_9.TabIndex = 22;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_8.Location = new System.Drawing.Point(95, 239);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(77, 71);
            this.button_8.TabIndex = 21;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button15_Click);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_7.Location = new System.Drawing.Point(8, 239);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(77, 71);
            this.button_7.TabIndex = 20;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTextBox.Location = new System.Drawing.Point(7, 50);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(335, 70);
            this.mainTextBox.TabIndex = 24;
            this.mainTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_division
            // 
            this.button_division.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_division.Location = new System.Drawing.Point(265, 162);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(77, 71);
            this.button_division.TabIndex = 28;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button17_Click);
            // 
            // button_power
            // 
            this.button_power.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_power.Location = new System.Drawing.Point(178, 162);
            this.button_power.Name = "button_power";
            this.button_power.Size = new System.Drawing.Size(77, 71);
            this.button_power.TabIndex = 27;
            this.button_power.Text = "^";
            this.button_power.UseVisualStyleBackColor = true;
            this.button_power.Click += new System.EventHandler(this.button18_Click);
            // 
            // button_bracket
            // 
            this.button_bracket.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_bracket.Location = new System.Drawing.Point(95, 162);
            this.button_bracket.Name = "button_bracket";
            this.button_bracket.Size = new System.Drawing.Size(77, 71);
            this.button_bracket.TabIndex = 26;
            this.button_bracket.Text = "()";
            this.button_bracket.UseVisualStyleBackColor = true;
            this.button_bracket.Click += new System.EventHandler(this.button_bracket_Click);
            // 
            // button_AC
            // 
            this.button_AC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_AC.Location = new System.Drawing.Point(8, 162);
            this.button_AC.Name = "button_AC";
            this.button_AC.Size = new System.Drawing.Size(77, 71);
            this.button_AC.TabIndex = 25;
            this.button_AC.Text = "AC";
            this.button_AC.UseVisualStyleBackColor = true;
            this.button_AC.Click += new System.EventHandler(this.button20_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(8, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 36);
            this.listBox1.TabIndex = 31;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 548);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_power);
            this.Controls.Add(this.button_bracket);
            this.Controls.Add(this.button_AC);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_subtraction);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_answer);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_addition);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_addition;
        private Button button_answer;
        private Button button_back;
        private Button button_0;
        private Button button_dot;
        private Button button_subtraction;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_multiplication;
        private Button button_9;
        private Button button_8;
        private Button button_7;
        private TextBox mainTextBox;
        private Button button_division;
        private Button button_power;
        private Button button_bracket;
        private Button button_AC;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox listBox1;
    }
}