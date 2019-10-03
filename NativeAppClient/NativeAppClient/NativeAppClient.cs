using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NativeAppClientLibrary;

namespace NativeAppClient
{
    public partial class NativeAppClient : Form
    {
        public NativeAppClient()
        {
            InitializeComponent();
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxNewFile.Visible = true;
            richTextBoxNewFile.Visible = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)| *.txt| Any file (*.*)|*.*";
            if(save.ShowDialog() == DialogResult.OK)
            {
                richTextBoxNewFile.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                this.Text = save.FileName;
                Document ob = new Document();
                ob.documentName = saveFileDialog.FileName;
               
                
                
            }
            MessageBox.Show("The .txt file was saved successfully!", "Information", 0, MessageBoxIcon.Information);

           // groupBoxNewFile.Visible = false;
           // richTextBoxNewFile.Visible = false;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)| *.txt| Any file (*.*)|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                richTextBoxNewFile.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open.FileName;
                Document ob = new Document();
                ob.documentName = openFileDialog.FileName;
                 groupBoxNewFile.Visible = true;
                 richTextBoxNewFile.Visible = true;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save button not work
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)| *.txt| Any file (*.*)|*.*";
            richTextBoxNewFile.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            this.Text = save.FileName;
            
            Document ob = new Document();
            ob.documentName = saveFileDialog.FileName;   
        }

        private void showFilesBtn_Click(object sender, EventArgs e)
        {
            groupBoxYourFiles.Visible = true;
            dataGridViewYourFiles.Visible = true;
        }

        private void closeFilesBtn_Click(object sender, EventArgs e)
        {
            groupBoxYourFiles.Visible = false;
            dataGridViewYourFiles.Visible = false;
        }
    }
}