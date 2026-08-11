using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void CheckTreeViewNode(TreeNode node, bool isChecked) 
        {
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = isChecked; 
                if (childNode.Nodes.Count > 0)
                {
                    this.CheckTreeViewNode(childNode, isChecked); //Recursive func.
                }

            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {//Check All Node Members
            CheckTreeViewNode(e.Node, e.Node.Checked); //Hard coded func.    
        }


         /* تحديث يجعل الابن لو اتلغى تحديده يتم إلغاء تحديد الأب
          * private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
         {
             // نفّذ فقط لو المستخدم هو اللي غير الحالة
             if (e.Action != TreeViewAction.Unknown)
             {
                 // 1. عدّل كل الفروع (الأبناء)
                 CheckTreeViewNode(e.Node, e.Node.Checked);

                 // 2. حسِّن حالة العقدة الأم
                 UpdateParentNodes(e.Node);
             }
         }
        private void UpdateParentNodes(TreeNode node)
        {
            TreeNode parent = node.Parent;
            while (parent != null)
            {
                bool anyChecked = false;

                foreach (TreeNode sibling in parent.Nodes)
                {
                    if (sibling.Checked)
                    {
                        anyChecked = true;
                        break;
                    }
                }

                parent.Checked = anyChecked;

                parent = parent.Parent; // كرر العملية على الأب الأكبر
            }
        }*/
 



    }
}
