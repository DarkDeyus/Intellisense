namespace WindowsFormsIntellisense
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addNew = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTextBox1_PreviewKeyDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(512, 354);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.addNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sort, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 56);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // addNew
            // 
            this.addNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNew.AutoSize = true;
            this.addNew.Font = new System.Drawing.Font("Calibri", 7F);
            this.addNew.Location = new System.Drawing.Point(5, 16);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(74, 23);
            this.addNew.TabIndex = 6;
            this.addNew.TabStop = false;
            this.addNew.Text = "Add new word";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // sort
            // 
            this.sort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sort.AutoSize = true;
            this.sort.Font = new System.Drawing.Font("Calibri", 7F);
            this.sort.Location = new System.Drawing.Point(89, 16);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(73, 23);
            this.sort.TabIndex = 7;
            this.sort.TabStop = false;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(169, 289);
            this.listBox2.TabIndex = 5;
            this.listBox2.TabStop = false;
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listBox2_PreviewKeyDown);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(302, 329);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(2, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(302, 354);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 80);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(-3, -3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 329);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.richTextBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTextBox1_PreviewKeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBold,
            this.toolStripItalic,
            this.toolStripUnderline,
            this.toolStripTextColor,
            this.toolStripBackgroundColor,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(250, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // toolStripBold
            // 
            this.toolStripBold.CheckOnClick = true;
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.Image = global::WindowsFormsIntellisense.Properties.Resources.Bold1;
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripBold.Text = "toolStripBold";
            this.toolStripBold.Click += new System.EventHandler(this.toolStripBold_Click);
            // 
            // toolStripItalic
            // 
            this.toolStripItalic.CheckOnClick = true;
            this.toolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalic.Image = global::WindowsFormsIntellisense.Properties.Resources.Italic;
            this.toolStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalic.Name = "toolStripItalic";
            this.toolStripItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripItalic.Text = "toolStripButton2";
            this.toolStripItalic.Click += new System.EventHandler(this.toolStripItalic_Click);
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.CheckOnClick = true;
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.Image = global::WindowsFormsIntellisense.Properties.Resources.Underline;
            this.toolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripUnderline.Text = "toolStripButton3";
            this.toolStripUnderline.Click += new System.EventHandler(this.toolStripUnderline_Click);
            // 
            // toolStripTextColor
            // 
            this.toolStripTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTextColor.Image = global::WindowsFormsIntellisense.Properties.Resources.FontColor;
            this.toolStripTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTextColor.Name = "toolStripTextColor";
            this.toolStripTextColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripTextColor.Text = "toolStripButton4";
            this.toolStripTextColor.Click += new System.EventHandler(this.toolStripTextColor_Click);
            // 
            // toolStripBackgroundColor
            // 
            this.toolStripBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackgroundColor.Image = global::WindowsFormsIntellisense.Properties.Resources.BackColor;
            this.toolStripBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackgroundColor.Name = "toolStripBackgroundColor";
            this.toolStripBackgroundColor.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackgroundColor.Text = "toolStripButton5";
            this.toolStripBackgroundColor.Click += new System.EventHandler(this.toolStripBackgroundColor_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 383);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(528, 421);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intellisense";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItalic;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
        private System.Windows.Forms.ToolStripButton toolStripTextColor;
        private System.Windows.Forms.ToolStripButton toolStripBackgroundColor;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.Button sort;
    }
}

