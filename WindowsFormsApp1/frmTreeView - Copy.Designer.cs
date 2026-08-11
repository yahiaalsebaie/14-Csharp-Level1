namespace WindowsFormsApp1
{
    partial class frmTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Season 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Season 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("First 2 Seasons Checked List", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Season 3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Season 4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Season 3 & 4 ImageIndex Only", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("S 5", 5, 5);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("S 6", 6, 6);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Season 5 & 6 Both of ImageIndex & Selected Same Image", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("S 7");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("S 8");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Season 7 & 9", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Prequal Season");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Season 9", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Last Season", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "The Office (US).png");
            this.imageList1.Images.SetKeyName(1, "The Office (US) Season 1.png");
            this.imageList1.Images.SetKeyName(2, "The Office (US) Season 2.png");
            this.imageList1.Images.SetKeyName(3, "The Office (US) Season 3.png");
            this.imageList1.Images.SetKeyName(4, "The Office (US) Season 4.png");
            this.imageList1.Images.SetKeyName(5, "The Office (US) Season 5.png");
            this.imageList1.Images.SetKeyName(6, "The Office (US) Season 6.png");
            this.imageList1.Images.SetKeyName(7, "The Office (US) Season 7.png");
            this.imageList1.Images.SetKeyName(8, "The Office (US) Season 8.png");
            this.imageList1.Images.SetKeyName(9, "The Office (US) Season 9.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(139, 36);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Season 1";
            treeNode2.Name = "Node5";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Season 2";
            treeNode3.Checked = true;
            treeNode3.Name = "First2Seasons";
            treeNode3.Text = "First 2 Seasons Checked List";
            treeNode3.ToolTipText = "The Office";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "Node6";
            treeNode4.Text = "Season 3";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "Node7";
            treeNode5.Text = "Season 4";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Season 3 & 4 ImageIndex Only";
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "Node8";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Text = "S 5";
            treeNode8.ImageIndex = 6;
            treeNode8.Name = "Node9";
            treeNode8.SelectedImageIndex = 6;
            treeNode8.Text = "S 6";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Season 5 & 6 Both of ImageIndex & Selected Same Image";
            treeNode10.Name = "Node10";
            treeNode10.SelectedImageIndex = 7;
            treeNode10.Text = "S 7";
            treeNode11.Name = "Node11";
            treeNode11.SelectedImageIndex = 8;
            treeNode11.Text = "S 8";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Season 7 & 9";
            treeNode13.Name = "Node14";
            treeNode13.Text = "Prequal Season";
            treeNode14.ImageIndex = 9;
            treeNode14.Name = "Node13";
            treeNode14.SelectedImageIndex = 9;
            treeNode14.Text = "Season 9";
            treeNode15.ImageIndex = 0;
            treeNode15.Name = "Node12";
            treeNode15.SelectedImageKey = "The Office (US) Season 9.png";
            treeNode15.Text = "Last Season";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12,
            treeNode15});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(712, 596);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 677);
            this.Controls.Add(this.treeView1);
            this.Name = "frmTreeView";
            this.Text = "frmTreeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}