using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problemləmi qarşılaşdınız? O zaman bizimle email vasitəsiylə əlaqə saxlayın qnicat.p102@code.edu.az","Dəstək",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextRichBox.Text.Length>0)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;

            }
            else
            {
                selectAllToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.Text = " ";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextRichBox.SelectionFont = new Font(TextRichBox.Font, FontStyle.Underline);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.SelectAll();
        }

        private void dataTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.Text = TextRichBox.Text + DateTime.Now;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.SelectionFont = new Font(TextRichBox.Font, FontStyle.Bold);
        }

        private void ıtalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.SelectionFont = new Font(TextRichBox.Font, FontStyle.Italic);
        }

        private void strikeThroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextRichBox.SelectionFont = new Font(TextRichBox.Font, FontStyle.Strikeout);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fayliac2 = new OpenFileDialog();
            if (Fayliac2.ShowDialog() == DialogResult.OK)
            {
                //eger deyisenimizin showdialog - u Dialogresult - un OK -sine beraberdise asagdaki emeliyatlari 
                TextRichBox.LoadFile(Fayliac2.FileName, RichTextBoxStreamType.PlainText);
                this.Text = Fayliac2.FileName;
            }
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();
            if (cr.ShowDialog() == DialogResult.OK)
            {
                TextRichBox.BackColor = cr.Color;
            }
          
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog rengimiz = new ColorDialog();
            rengimiz.Color = TextRichBox.SelectionColor;
            if (rengimiz.ShowDialog() == DialogResult.OK)
            {
                TextRichBox.SelectionColor = rengimiz.Color;
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problemləmi qarşılaşdınız? O zaman bizimle email vasitəsiylə əlaqə saxlayın qnicat.p102@code.edu.az", "Dəstək", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fayliSaxla = new SaveFileDialog();
            fayliSaxla.Title = "Save File as .....";

            if (fayliSaxla.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(fayliSaxla.FileName);
                txtoutput.Write(TextRichBox.Text);
                txtoutput.Close();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click_1(object sender, EventArgs e)
        {
            TextRichBox.Clear();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.PerformClick();
        }

        private void openToolStripButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Fayliac2 = new OpenFileDialog();
            if (Fayliac2.ShowDialog() == DialogResult.OK)
            {
               
                TextRichBox.LoadFile(Fayliac2.FileName, RichTextBoxStreamType.PlainText);
                this.Text = Fayliac2.FileName;

                
            }
        }

        private void helpToolStripButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Problemləmi qarşılaşdınız? O zaman bizimle email vasitəsiylə əlaqə saxlayın qnicat.p102@code.edu.az", "Dəstək", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void newToolStripButton_Click_2(object sender, EventArgs e)
        {
            TextRichBox.Text = " ";
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muveqqeti Narahatciliga Gore Uzr isteyirik", "Diqqet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muveqqeti Narahatciliga Gore Uzr isteyirik", "Diqqet", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextRichBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void textSizeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog fontumuz = new FontDialog();
            fontumuz.Font = TextRichBox.SelectionFont;
            if (fontumuz.ShowDialog() == DialogResult.OK)
            {
                TextRichBox.SelectionFont = fontumuz.Font;
            }
        }
    }
}
