namespace NativeAppClient
{
    partial class NativeAppClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NativeAppClient));
            this.downloadFilesBtn = new System.Windows.Forms.Button();
            this.showFilesBtn = new System.Windows.Forms.Button();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.groupBoxNewFile = new System.Windows.Forms.GroupBox();
            this.richTextBoxNewFile = new System.Windows.Forms.RichTextBox();
            this.sendFilesBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewYourFiles = new System.Windows.Forms.DataGridView();
            this.groupBoxYourFiles = new System.Windows.Forms.GroupBox();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeFilesBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxNewFile.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourFiles)).BeginInit();
            this.groupBoxYourFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadFilesBtn
            // 
            this.downloadFilesBtn.Location = new System.Drawing.Point(28, 169);
            this.downloadFilesBtn.Name = "downloadFilesBtn";
            this.downloadFilesBtn.Size = new System.Drawing.Size(123, 44);
            this.downloadFilesBtn.TabIndex = 1;
            this.downloadFilesBtn.Text = "Download Files";
            this.downloadFilesBtn.UseVisualStyleBackColor = true;
            // 
            // showFilesBtn
            // 
            this.showFilesBtn.Location = new System.Drawing.Point(28, 19);
            this.showFilesBtn.Name = "showFilesBtn";
            this.showFilesBtn.Size = new System.Drawing.Size(123, 44);
            this.showFilesBtn.TabIndex = 2;
            this.showFilesBtn.Text = "Show Files";
            this.showFilesBtn.UseVisualStyleBackColor = true;
            this.showFilesBtn.Click += new System.EventHandler(this.showFilesBtn_Click);
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.closeFilesBtn);
            this.groupBoxMenu.Controls.Add(this.sendFilesBtn);
            this.groupBoxMenu.Controls.Add(this.downloadFilesBtn);
            this.groupBoxMenu.Controls.Add(this.showFilesBtn);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 38);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(178, 229);
            this.groupBoxMenu.TabIndex = 3;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // groupBoxNewFile
            // 
            this.groupBoxNewFile.Controls.Add(this.richTextBoxNewFile);
            this.groupBoxNewFile.Location = new System.Drawing.Point(214, 38);
            this.groupBoxNewFile.Name = "groupBoxNewFile";
            this.groupBoxNewFile.Size = new System.Drawing.Size(407, 369);
            this.groupBoxNewFile.TabIndex = 6;
            this.groupBoxNewFile.TabStop = false;
            this.groupBoxNewFile.Text = "New File";
            this.groupBoxNewFile.Visible = false;
            // 
            // richTextBoxNewFile
            // 
            this.richTextBoxNewFile.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxNewFile.Name = "richTextBoxNewFile";
            this.richTextBoxNewFile.Size = new System.Drawing.Size(395, 344);
            this.richTextBoxNewFile.TabIndex = 6;
            this.richTextBoxNewFile.Text = "";
            this.richTextBoxNewFile.Visible = false;
            // 
            // sendFilesBtn
            // 
            this.sendFilesBtn.Location = new System.Drawing.Point(28, 119);
            this.sendFilesBtn.Name = "sendFilesBtn";
            this.sendFilesBtn.Size = new System.Drawing.Size(123, 44);
            this.sendFilesBtn.TabIndex = 7;
            this.sendFilesBtn.Text = "Send Files";
            this.sendFilesBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // dataGridViewYourFiles
            // 
            this.dataGridViewYourFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYourFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.modifyDate,
            this.lastModifyDate});
            this.dataGridViewYourFiles.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewYourFiles.Name = "dataGridViewYourFiles";
            this.dataGridViewYourFiles.Size = new System.Drawing.Size(417, 345);
            this.dataGridViewYourFiles.TabIndex = 9;
            this.dataGridViewYourFiles.Visible = false;
            // 
            // groupBoxYourFiles
            // 
            this.groupBoxYourFiles.Controls.Add(this.dataGridViewYourFiles);
            this.groupBoxYourFiles.Location = new System.Drawing.Point(627, 38);
            this.groupBoxYourFiles.Name = "groupBoxYourFiles";
            this.groupBoxYourFiles.Size = new System.Drawing.Size(434, 369);
            this.groupBoxYourFiles.TabIndex = 10;
            this.groupBoxYourFiles.TabStop = false;
            this.groupBoxYourFiles.Text = "Your Files";
            this.groupBoxYourFiles.Visible = false;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "File Name";
            this.fileName.Name = "fileName";
            this.fileName.Width = 150;
            // 
            // modifyDate
            // 
            this.modifyDate.HeaderText = "Modify Date";
            this.modifyDate.Name = "modifyDate";
            this.modifyDate.Width = 150;
            // 
            // lastModifyDate
            // 
            this.lastModifyDate.HeaderText = "Last Modify Date";
            this.lastModifyDate.Name = "lastModifyDate";
            this.lastModifyDate.Width = 150;
            // 
            // closeFilesBtn
            // 
            this.closeFilesBtn.Location = new System.Drawing.Point(28, 69);
            this.closeFilesBtn.Name = "closeFilesBtn";
            this.closeFilesBtn.Size = new System.Drawing.Size(123, 44);
            this.closeFilesBtn.TabIndex = 11;
            this.closeFilesBtn.Text = "Close Files";
            this.closeFilesBtn.UseVisualStyleBackColor = true;
            this.closeFilesBtn.Click += new System.EventHandler(this.closeFilesBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // NativeAppClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxNewFile);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxYourFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "NativeAppClient";
            this.Text = "NativeAppClient";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxNewFile.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYourFiles)).EndInit();
            this.groupBoxYourFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadFilesBtn;
        private System.Windows.Forms.Button showFilesBtn;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxNewFile;
        private System.Windows.Forms.Button sendFilesBtn;
        private System.Windows.Forms.RichTextBox richTextBoxNewFile;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridViewYourFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifyDate;
        private System.Windows.Forms.GroupBox groupBoxYourFiles;
        private System.Windows.Forms.Button closeFilesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

