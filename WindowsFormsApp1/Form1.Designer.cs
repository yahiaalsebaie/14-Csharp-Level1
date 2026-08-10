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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnChangeFormTitle = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 76);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(466, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 76);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy On Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 77);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Copy On Mouse Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 51);
            this.button4.TabIndex = 1;
            this.button4.TabStop = false;
            this.button4.Text = "Clear Text Box 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_textBox1_ClearClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 51);
            this.button5.TabIndex = 11;
            this.button5.TabStop = false;
            this.button5.Text = "Clear Text Box 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_textBox2_ClearClick);
            // 
            // btnClearAll
            // 
            this.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClearAll.FlatAppearance.BorderSize = 5;
            this.btnClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Location = new System.Drawing.Point(330, 86);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(127, 51);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Clear All Text";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btn_ClearClick);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(63, 331);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 76);
            this.textBox3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 42);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "Disable text box 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn3_textBox1_Disabled_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(117, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 42);
            this.button7.TabIndex = 1;
            this.button7.TabStop = false;
            this.button7.Text = "Enable text box 3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn4_textBox1_Enabled_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(542, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 42);
            this.button8.TabIndex = 4;
            this.button8.TabStop = false;
            this.button8.Text = "Show text box 2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(542, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(132, 42);
            this.button9.TabIndex = 5;
            this.button9.TabStop = false;
            this.button9.Text = "Hide text box 2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(334, 326);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 42);
            this.button11.TabIndex = 2;
            this.button11.Text = "Change Form Color Mode";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnFrmColor_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(201, 418);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 42);
            this.button10.TabIndex = 7;
            this.button10.Text = "Back to Defult Mode";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.Location = new System.Drawing.Point(467, 331);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(258, 76);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.btn4_textBox1_Enabled_Click);
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // btnChangeFormTitle
            // 
            this.btnChangeFormTitle.Location = new System.Drawing.Point(542, 413);
            this.btnChangeFormTitle.Name = "btnChangeFormTitle";
            this.btnChangeFormTitle.Size = new System.Drawing.Size(132, 42);
            this.btnChangeFormTitle.TabIndex = 6;
            this.btnChangeFormTitle.Text = "Change Form Title ↑";
            this.btnChangeFormTitle.UseVisualStyleBackColor = true;
            this.btnChangeFormTitle.Click += new System.EventHandler(this.btnChangeFormTitle_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(63, 418);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 42);
            this.button13.TabIndex = 7;
            this.button13.Text = "Change TextBox Color Mode";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button11_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(334, 374);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 42);
            this.button14.TabIndex = 3;
            this.button14.Text = "Back to Defult Mode";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Papyrus", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(241, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "Practice project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WindowsFormsApp1.Properties.Resources.Close_Window2;
            this.btnClose.Location = new System.Drawing.Point(735, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 51);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 472);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeFormTitle);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnChangeFormTitle;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}

