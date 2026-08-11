namespace WindowsFormsApp1
{
    partial class frmBetterCallSaul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBetterCallSaul));
            this.pbBetterCallSaul = new System.Windows.Forms.PictureBox();
            this.rbS1 = new System.Windows.Forms.RadioButton();
            this.rbS2 = new System.Windows.Forms.RadioButton();
            this.rbS3 = new System.Windows.Forms.RadioButton();
            this.rbS4 = new System.Windows.Forms.RadioButton();
            this.rbS5 = new System.Windows.Forms.RadioButton();
            this.lblSeason = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBetterCallSaul)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBetterCallSaul
            // 
            this.pbBetterCallSaul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBetterCallSaul.Image = ((System.Drawing.Image)(resources.GetObject("pbBetterCallSaul.Image")));
            this.pbBetterCallSaul.Location = new System.Drawing.Point(145, 63);
            this.pbBetterCallSaul.Name = "pbBetterCallSaul";
            this.pbBetterCallSaul.Size = new System.Drawing.Size(509, 291);
            this.pbBetterCallSaul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBetterCallSaul.TabIndex = 0;
            this.pbBetterCallSaul.TabStop = false;
            this.pbBetterCallSaul.Click += new System.EventHandler(this.pbBetterCallSaul_Click);
            // 
            // rbS1
            // 
            this.rbS1.AutoSize = true;
            this.rbS1.Location = new System.Drawing.Point(170, 360);
            this.rbS1.Name = "rbS1";
            this.rbS1.Size = new System.Drawing.Size(82, 20);
            this.rbS1.TabIndex = 1;
            this.rbS1.TabStop = true;
            this.rbS1.Text = "Season1";
            this.rbS1.UseVisualStyleBackColor = true;
            this.rbS1.CheckedChanged += new System.EventHandler(this.rbS1_CheckedChanged);
            // 
            // rbS2
            // 
            this.rbS2.AutoSize = true;
            this.rbS2.Location = new System.Drawing.Point(261, 360);
            this.rbS2.Name = "rbS2";
            this.rbS2.Size = new System.Drawing.Size(82, 20);
            this.rbS2.TabIndex = 2;
            this.rbS2.TabStop = true;
            this.rbS2.Tag = "Season 2";
            this.rbS2.Text = "Season2";
            this.rbS2.UseVisualStyleBackColor = true;
            this.rbS2.CheckedChanged += new System.EventHandler(this.rbS2_CheckedChanged);
            // 
            // rbS3
            // 
            this.rbS3.AutoSize = true;
            this.rbS3.Location = new System.Drawing.Point(352, 360);
            this.rbS3.Name = "rbS3";
            this.rbS3.Size = new System.Drawing.Size(82, 20);
            this.rbS3.TabIndex = 3;
            this.rbS3.TabStop = true;
            this.rbS3.Tag = "Season 3";
            this.rbS3.Text = "Season3";
            this.rbS3.UseVisualStyleBackColor = true;
            this.rbS3.CheckedChanged += new System.EventHandler(this.rbS3_CheckedChanged);
            // 
            // rbS4
            // 
            this.rbS4.AutoSize = true;
            this.rbS4.Location = new System.Drawing.Point(443, 360);
            this.rbS4.Name = "rbS4";
            this.rbS4.Size = new System.Drawing.Size(82, 20);
            this.rbS4.TabIndex = 4;
            this.rbS4.TabStop = true;
            this.rbS4.Text = "Season4";
            this.rbS4.UseVisualStyleBackColor = true;
            this.rbS4.CheckedChanged += new System.EventHandler(this.rbS4_CheckedChanged);
            // 
            // rbS5
            // 
            this.rbS5.AutoSize = true;
            this.rbS5.Location = new System.Drawing.Point(534, 360);
            this.rbS5.Name = "rbS5";
            this.rbS5.Size = new System.Drawing.Size(82, 20);
            this.rbS5.TabIndex = 5;
            this.rbS5.TabStop = true;
            this.rbS5.Text = "Season5";
            this.rbS5.UseVisualStyleBackColor = true;
            this.rbS5.CheckedChanged += new System.EventHandler(this.rbS5_CheckedChanged);
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeason.ForeColor = System.Drawing.Color.Brown;
            this.lblSeason.Location = new System.Drawing.Point(329, 15);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(131, 45);
            this.lblSeason.TabIndex = 6;
            this.lblSeason.Text = "Season";
            this.lblSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeason.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBetterCallSaul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.rbS5);
            this.Controls.Add(this.rbS4);
            this.Controls.Add(this.rbS3);
            this.Controls.Add(this.rbS2);
            this.Controls.Add(this.rbS1);
            this.Controls.Add(this.pbBetterCallSaul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBetterCallSaul";
            this.Text = "Better Call Saul";
            ((System.ComponentModel.ISupportInitialize)(this.pbBetterCallSaul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBetterCallSaul;
        private System.Windows.Forms.RadioButton rbS1;
        private System.Windows.Forms.RadioButton rbS2;
        private System.Windows.Forms.RadioButton rbS3;
        private System.Windows.Forms.RadioButton rbS4;
        private System.Windows.Forms.RadioButton rbS5;
        private System.Windows.Forms.Label lblSeason;
    }
}