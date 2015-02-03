using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3Lab
{
    public partial class ChildForm : Form
    {
        public bool isNotChanged = true;
        public bool isSaved = false;
        public bool isNotOpened = true;

        public ChildForm()
        {
            InitializeComponent();
        }

        public ChildForm(string fileName)
        {
            InitializeComponent();
            richTextBox1.LoadFile(fileName);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            isNotChanged = false;
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!isSaved && !isNotChanged)
            {
                string message = "Do you want to save changes to \n" + this.Text + " ?";
                DialogResult button = MessageBox.Show(message, this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (button == DialogResult.Yes)
                {
                    if (isNotOpened)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
                        {
                            this.richTextBox1.SaveFile(saveFileDialog1.FileName);
                            this.Text = saveFileDialog1.FileName;
                            this.isSaved = true;
                            this.isNotChanged = true;
                        }
                    }
                    else
                    {
                        this.richTextBox1.SaveFile(this.Text);
                        this.isSaved = true;
                        this.isNotChanged = true;
                    }
                }
                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;

                }
            }
            
        }
    }
}
