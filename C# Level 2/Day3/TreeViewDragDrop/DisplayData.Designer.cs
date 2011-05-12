namespace TreeViewDragDrop
{
    partial class DisplayData
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
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Hitch Hiker\'s Guide to the Universe");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Life, The Universe and Everything");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("A Tale of Two Cities");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Fiction", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("C# Fundamentals");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("How to Wreck Cars");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("On Photography");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Inside C#");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Non-Fiction", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("100 Ways to Get Rich");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Books Read", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Workaholic Programmers");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("How to Meet Woman");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Immediately", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Insomnia");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Later", new System.Windows.Forms.TreeNode[] {
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Books To Read", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Books to Forget");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Drag Drop here with a node.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drop node here...";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(48, 85);
            this.treeView1.Name = "treeView1";
            treeNode37.Name = "Node1";
            treeNode37.Text = "Hitch Hiker\'s Guide to the Universe";
            treeNode38.Name = "Node3";
            treeNode38.Text = "Life, The Universe and Everything";
            treeNode39.Name = "Node4";
            treeNode39.Text = "A Tale of Two Cities";
            treeNode40.Name = "Node0";
            treeNode40.Text = "Fiction";
            treeNode41.Name = "Node5";
            treeNode41.Text = "C# Fundamentals";
            treeNode42.Name = "Node6";
            treeNode42.Text = "How to Wreck Cars";
            treeNode43.Name = "Node7";
            treeNode43.Text = "On Photography";
            treeNode44.Name = "Node8";
            treeNode44.Text = "Inside C#";
            treeNode45.Name = "Node2";
            treeNode45.Text = "Non-Fiction";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode45});
            this.treeView1.Size = new System.Drawing.Size(206, 218);
            this.treeView1.TabIndex = 2;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.Location = new System.Drawing.Point(277, 85);
            this.treeView2.Name = "treeView2";
            treeNode46.Name = "Node3";
            treeNode46.Text = "100 Ways to Get Rich";
            treeNode47.Name = "Node0";
            treeNode47.Text = "Books Read";
            treeNode48.Name = "Node6";
            treeNode48.Text = "Workaholic Programmers";
            treeNode49.Name = "Node7";
            treeNode49.Text = "How to Meet Woman";
            treeNode50.Name = "Node4";
            treeNode50.Text = "Immediately";
            treeNode51.Name = "Node8";
            treeNode51.Text = "Insomnia";
            treeNode52.Name = "Node5";
            treeNode52.Text = "Later";
            treeNode53.Name = "Node1";
            treeNode53.Text = "Books To Read";
            treeNode54.Name = "Node2";
            treeNode54.Text = "Books to Forget";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode53,
            treeNode54});
            this.treeView2.Size = new System.Drawing.Size(209, 218);
            this.treeView2.TabIndex = 3;
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            // 
            // DisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 409);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayData";
            this.Text = "TreeView Drag and Drop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
    }
}

