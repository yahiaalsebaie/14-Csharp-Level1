namespace WindowsFormsApp1
{
    partial class frmComboBoxPictures
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPictures = new System.Windows.Forms.ComboBox();
            this.lblTiltle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApp1.Properties.Resources.Breaking_Bad_S3;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Boy;
            this.pictureBox1.InitialImage = global::WindowsFormsApp1.Properties.Resources.Breaking_Bad_S3;
            this.pictureBox1.Location = new System.Drawing.Point(158, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Picture:";
            // 
            // cmbPictures
            // 
            this.cmbPictures.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPictures.FormattingEnabled = true;
            this.cmbPictures.Items.AddRange(new object[] {
            "Boy",
            "Book",
            "Girl",
            "Pen"});
            this.cmbPictures.Location = new System.Drawing.Point(283, 403);
            this.cmbPictures.Name = "cmbPictures";
            this.cmbPictures.Size = new System.Drawing.Size(274, 23);
            this.cmbPictures.TabIndex = 2;
            this.cmbPictures.SelectedIndexChanged += new System.EventHandler(this.cmbPictures_SelectedIndexChanged);
            // 
            // lblTiltle
            // 
            this.lblTiltle.AutoSize = true;
            this.lblTiltle.Font = new System.Drawing.Font("Snap ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTiltle.Location = new System.Drawing.Point(332, 3);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(174, 64);
            this.lblTiltle.TabIndex = 3;
            this.lblTiltle.Text = "Title";
            this.lblTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmComboBoxPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTiltle);
            this.Controls.Add(this.cmbPictures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmComboBoxPictures";
            this.Text = "frmComboBoxPictures";
            this.Load += new System.EventHandler(this.frmComboBoxPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPictures;
        private System.Windows.Forms.Label lblTiltle;
    }
}