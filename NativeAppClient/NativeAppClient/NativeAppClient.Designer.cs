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
            this.newFileBtn = new System.Windows.Forms.Button();
            this.showFilesBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newFileBtn
            // 
            this.newFileBtn.Location = new System.Drawing.Point(28, 35);
            this.newFileBtn.Name = "newFileBtn";
            this.newFileBtn.Size = new System.Drawing.Size(123, 44);
            this.newFileBtn.TabIndex = 1;
            this.newFileBtn.Text = "New File";
            this.newFileBtn.UseVisualStyleBackColor = true;
            // 
            // showFilesBtn
            // 
            this.showFilesBtn.Location = new System.Drawing.Point(28, 85);
            this.showFilesBtn.Name = "showFilesBtn";
            this.showFilesBtn.Size = new System.Drawing.Size(123, 44);
            this.showFilesBtn.TabIndex = 2;
            this.showFilesBtn.Text = "Show Files";
            this.showFilesBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newFileBtn);
            this.groupBox1.Controls.Add(this.showFilesBtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // NativeAppClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 514);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NativeAppClient";
            this.Text = "NativeAppClient";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newFileBtn;
        private System.Windows.Forms.Button showFilesBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

