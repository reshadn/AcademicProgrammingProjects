using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewDragDrop
{
    public partial class DisplayData : Form
    {
        public DisplayData()
        {
            InitializeComponent();
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode newNode;
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt;
                TreeNode destinationNode;

                pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                destinationNode = ((TreeView)sender).GetNodeAt(pt);
                newNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (!(destinationNode.TreeView == newNode.TreeView))
                {
                    destinationNode.Nodes.Add((TreeNode)newNode.Clone());
                    destinationNode.Expand();

                    //remove orginal node
                    newNode.Remove();
                }
            }
        }
    }
}
