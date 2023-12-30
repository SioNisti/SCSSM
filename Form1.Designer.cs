namespace cspracSaveloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            saveList = new ListBox();
            savelistMenu = new ContextMenuStrip(components);
            renameToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnLoad = new Button();
            btnSave = new Button();
            nameBox = new TextBox();
            refreshListToolStripMenuItem = new ToolStripMenuItem();
            savelistMenu.SuspendLayout();
            SuspendLayout();
            // 
            // saveList
            // 
            saveList.BackColor = Color.FromArgb(64, 64, 64);
            saveList.ContextMenuStrip = savelistMenu;
            saveList.ForeColor = Color.White;
            saveList.FormattingEnabled = true;
            saveList.ItemHeight = 15;
            saveList.Location = new Point(12, 12);
            saveList.Name = "saveList";
            saveList.Size = new Size(235, 229);
            saveList.TabIndex = 0;
            // 
            // savelistMenu
            // 
            savelistMenu.Items.AddRange(new ToolStripItem[] { renameToolStripMenuItem, deleteToolStripMenuItem, refreshListToolStripMenuItem });
            savelistMenu.Name = "contextMenuStrip1";
            savelistMenu.Size = new Size(181, 92);
            savelistMenu.Opening += savelistMenu_Opening;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.Size = new Size(180, 22);
            renameToolStripMenuItem.Text = "Rename";
            renameToolStripMenuItem.Click += renameToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(64, 64, 64);
            btnLoad.BackgroundImageLayout = ImageLayout.None;
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(12, 247);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(235, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(12, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(59, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save As";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.FromArgb(64, 64, 64);
            nameBox.ForeColor = Color.White;
            nameBox.Location = new Point(76, 276);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(171, 23);
            nameBox.TabIndex = 3;
            // 
            // refreshListToolStripMenuItem
            // 
            refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            refreshListToolStripMenuItem.Size = new Size(180, 22);
            refreshListToolStripMenuItem.Text = "Refresh list";
            refreshListToolStripMenuItem.Click += refreshListToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(259, 308);
            Controls.Add(nameBox);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(saveList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "SCSSM";
            Load += Form1_Load;
            savelistMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox saveList;
        private Button btnLoad;
        private Button btnSave;
        private TextBox nameBox;
        private ContextMenuStrip savelistMenu;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem refreshListToolStripMenuItem;
    }
}