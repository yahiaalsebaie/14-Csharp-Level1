namespace WindowsFormsApp1
{
    partial class frmDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnChangeForeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnOpenFileDialogMultiSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.textBox1.Location = new System.Drawing.Point(82, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(579, 41);
            this.textBox1.TabIndex = 0;
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(82, 148);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(179, 58);
            this.btnChangeBackColor.TabIndex = 1;
            this.btnChangeBackColor.Text = "Change Back Color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // btnChangeForeColor
            // 
            this.btnChangeForeColor.Location = new System.Drawing.Point(282, 148);
            this.btnChangeForeColor.Name = "btnChangeForeColor";
            this.btnChangeForeColor.Size = new System.Drawing.Size(179, 58);
            this.btnChangeForeColor.TabIndex = 2;
            this.btnChangeForeColor.Text = "Change Fore Color";
            this.btnChangeForeColor.UseVisualStyleBackColor = true;
            this.btnChangeForeColor.Click += new System.EventHandler(this.btnChangeForeColor_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(482, 148);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(179, 58);
            this.btnChangeFont.TabIndex = 3;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(82, 276);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(179, 58);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(282, 276);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(179, 58);
            this.btnOpenFileDialog.TabIndex = 5;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnOpenFileDialogMultiSelect
            // 
            this.btnOpenFileDialogMultiSelect.Location = new System.Drawing.Point(482, 276);
            this.btnOpenFileDialogMultiSelect.Name = "btnOpenFileDialogMultiSelect";
            this.btnOpenFileDialogMultiSelect.Size = new System.Drawing.Size(179, 58);
            this.btnOpenFileDialogMultiSelect.TabIndex = 6;
            this.btnOpenFileDialogMultiSelect.Text = "Open File Dialog Multi Select";
            this.btnOpenFileDialogMultiSelect.UseVisualStyleBackColor = true;
            this.btnOpenFileDialogMultiSelect.Click += new System.EventHandler(this.btnOpenFileDialogMultiSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFolderBrowserDialog
            // 
            this.btnFolderBrowserDialog.Location = new System.Drawing.Point(282, 212);
            this.btnFolderBrowserDialog.Name = "btnFolderBrowserDialog";
            this.btnFolderBrowserDialog.Size = new System.Drawing.Size(179, 58);
            this.btnFolderBrowserDialog.TabIndex = 7;
            this.btnFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.btnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDialog.Click += new System.EventHandler(this.btnFolderBrowserDialog_Click);
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFolderBrowserDialog);
            this.Controls.Add(this.btnOpenFileDialogMultiSelect);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnChangeForeColor);
            this.Controls.Add(this.btnChangeBackColor);
            this.Controls.Add(this.textBox1);
            this.Name = "frmDialog";
            this.Text = "frmColorDialog";
            this.Load += new System.EventHandler(this.frmDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.Button btnChangeForeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnOpenFileDialogMultiSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}