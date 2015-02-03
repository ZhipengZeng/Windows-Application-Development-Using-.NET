using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3Lab
{
    public partial class MainForm : Form
    {
        public bool isNewChild = true;
        public int newChildNumber = 1;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNewChild = true;
            ChildForm myChild = new ChildForm();
            myChild.MdiParent = this;
            if (isNewChild)
            {
                myChild.Text = "rtf doc" + newChildNumber;
            }
            myChild.Show();
            newChildNumber++;
            
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeCtrlF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void closeAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ChildForm window in MdiChildren)
                window.Close();
        }

        private void openToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
            if (openFile1.ShowDialog() == DialogResult.OK && openFile1.FileName.Length > 0)
            {
                ChildForm newChild = new ChildForm(openFile1.FileName);
                newChild.MdiParent = this;
                newChild.Text = openFile1.FileName;
                newChild.Show();
                isNewChild = false;
                newChild.isNotChanged = false;
                newChild.isNotOpened = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                ChildForm myChild = (ChildForm)this.ActiveMdiChild;
                myChild.richTextBox1.SaveFile(saveFile1.FileName);
                myChild.Text = saveFile1.FileName;
                myChild.isSaved = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm myChild = (ChildForm)this.ActiveMdiChild;

            if (isNewChild == true)
            {
                if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
                {
                    myChild.richTextBox1.SaveFile(saveFile1.FileName);
                    myChild.Text = saveFile1.FileName;
                    myChild.isSaved = true;
                    myChild.isNotChanged = true;
                }
            }
            else
            {
                myChild.richTextBox1.SaveFile(openFile1.FileName);
                myChild.Text = openFile1.FileName;
                myChild.isSaved = true;
                myChild.isNotChanged = true;
            }
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutMe = new AboutForm();
            aboutMe.Show();
        }
    }
}
