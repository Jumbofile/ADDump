namespace ActiveDirectoryDump
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
            this.runButton = new System.Windows.Forms.Button();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.folderButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runtimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGregPlachnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v110ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(97, 68);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(109, 56);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBox
            // 
            this.folderBox.Location = new System.Drawing.Point(11, 42);
            this.folderBox.Name = "folderBox";
            this.folderBox.ReadOnly = true;
            this.folderBox.Size = new System.Drawing.Size(228, 20);
            this.folderBox.TabIndex = 1;
            this.folderBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(245, 42);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(48, 21);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "Save";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 130);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(281, 119);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Save Location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptLocationToolStripMenuItem,
            this.runtimeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // scriptLocationToolStripMenuItem
            // 
            this.scriptLocationToolStripMenuItem.Name = "scriptLocationToolStripMenuItem";
            this.scriptLocationToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.scriptLocationToolStripMenuItem.Text = "Script";
            this.scriptLocationToolStripMenuItem.Click += new System.EventHandler(this.scriptLocationToolStripMenuItem_Click);
            // 
            // runtimeToolStripMenuItem
            // 
            this.runtimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToolStripMenuItem});
            this.runtimeToolStripMenuItem.Name = "runtimeToolStripMenuItem";
            this.runtimeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.runtimeToolStripMenuItem.Text = "Runtime";
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.installToolStripMenuItem.Text = "Install";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byGregPlachnoToolStripMenuItem,
            this.v110ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // byGregPlachnoToolStripMenuItem
            // 
            this.byGregPlachnoToolStripMenuItem.Name = "byGregPlachnoToolStripMenuItem";
            this.byGregPlachnoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.byGregPlachnoToolStripMenuItem.Text = "By: Greg Plachno";
            // 
            // v110ToolStripMenuItem
            // 
            this.v110ToolStripMenuItem.Name = "v110ToolStripMenuItem";
            this.v110ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.v110ToolStripMenuItem.Text = "v1.2.0";
            this.v110ToolStripMenuItem.Click += new System.EventHandler(this.v110ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Active Directory Dump";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGregPlachnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v110ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runtimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
    }
}

