namespace WindowsFormsApp1
{
    partial class frmChkRadioGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChkRadioGroup));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnchkReceveEmails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.gbPizzaCrust = new System.Windows.Forms.GroupBox();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbPizzaSize.SuspendLayout();
            this.gbPizzaCrust.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(211, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Do you want to receve emails?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnchkReceveEmails
            // 
            this.btnchkReceveEmails.Enabled = false;
            this.btnchkReceveEmails.Location = new System.Drawing.Point(34, 73);
            this.btnchkReceveEmails.Name = "btnchkReceveEmails";
            this.btnchkReceveEmails.Size = new System.Drawing.Size(237, 72);
            this.btnchkReceveEmails.TabIndex = 1;
            this.btnchkReceveEmails.Text = "Receve Email";
            this.btnchkReceveEmails.UseVisualStyleBackColor = true;
            this.btnchkReceveEmails.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnchkReceveEmails);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receve Email";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(22, 30);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(97, 37);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Jokerman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(22, 67);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(137, 41);
            this.rbMedium.TabIndex = 4;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Font = new System.Drawing.Font("Jokerman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.Location = new System.Drawing.Point(22, 106);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(143, 53);
            this.rbLarge.TabIndex = 5;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.Controls.Add(this.rbLarge);
            this.gbPizzaSize.Controls.Add(this.rbSmall);
            this.gbPizzaSize.Controls.Add(this.rbMedium);
            this.gbPizzaSize.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaSize.Location = new System.Drawing.Point(359, 12);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(198, 176);
            this.gbPizzaSize.TabIndex = 6;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Pizza Size";
            this.gbPizzaSize.Enter += new System.EventHandler(this.gbPizzaSize_Enter);
            // 
            // gbPizzaCrust
            // 
            this.gbPizzaCrust.BackColor = System.Drawing.SystemColors.Control;
            this.gbPizzaCrust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbPizzaCrust.Controls.Add(this.rbThinCrust);
            this.gbPizzaCrust.Controls.Add(this.rbThickCrust);
            this.gbPizzaCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbPizzaCrust.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPizzaCrust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbPizzaCrust.Location = new System.Drawing.Point(615, 12);
            this.gbPizzaCrust.Name = "gbPizzaCrust";
            this.gbPizzaCrust.Size = new System.Drawing.Size(198, 176);
            this.gbPizzaCrust.TabIndex = 7;
            this.gbPizzaCrust.TabStop = false;
            this.gbPizzaCrust.Text = "Crust";
            this.gbPizzaCrust.Enter += new System.EventHandler(this.gbPizzaCrust_Enter);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(22, 30);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(85, 34);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Kristen ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(22, 104);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(111, 39);
            this.rbThickCrust.TabIndex = 4;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Location = new System.Drawing.Point(13, 373);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(185, 66);
            this.btnTakeOrder.TabIndex = 8;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            this.btnTakeOrder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.txtPrice);
            this.gbPrice.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrice.Location = new System.Drawing.Point(615, 263);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(198, 176);
            this.gbPrice.TabIndex = 8;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Price";
            this.gbPrice.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrice.Font = new System.Drawing.Font("Vivaldi", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPrice.Location = new System.Drawing.Point(22, 44);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 110);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(216, 373);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(185, 66);
            this.btnNewOrder.TabIndex = 9;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmChkRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 531);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.gbPizzaCrust);
            this.Controls.Add(this.gbPizzaSize);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChkRadioGroup";
            this.Text = "TMNT Pizza Time ";
            this.Load += new System.EventHandler(this.frmChkRadioGroup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbPizzaCrust.ResumeLayout(false);
            this.gbPizzaCrust.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnchkReceveEmails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.GroupBox gbPizzaCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnNewOrder;
    }
}