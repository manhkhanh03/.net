using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPadApp
{
    public partial class WordPad : Form
    {
        public WordPad()
        {
            InitializeComponent();
        }

        private void changeFont()
        {
            if (tsFontFamily.Text == "")
                tsFontFamily.Text = "Arial";
            if (tsFontSize.Text == "")
                tsFontSize.Text = "14";

            rtbContent.SelectionFont = new Font(tsFontFamily.Text, float.Parse(tsFontSize.Text));
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void WordPad_Load(object sender, EventArgs e)
        {
            FontFamily[] ff = FontFamily.Families;
            for (int i = 0; i < ff.Length; i++)
            {
                tsFontFamily.Items.Add(ff[i].Name);
            }

            for (int i = 0; i < 72; i += 2)
            {
                tsFontSize.Items.Add(i);
            }

            tsFontFamily.Text = "Arial";
            tsFontSize.Text = "14";
        }

        private void tsFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void tsFontSize_Click(object sender, EventArgs e)
        {

        }

        private void tsFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        private void tsBold_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, rtbContent.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, rtbContent.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void tsU_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionFont = new Font(rtbContent.SelectionFont, rtbContent.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dr = new SaveFileDialog();
            dr.Filter = "Doc File|*.doc";

            if(dr.ShowDialog() == DialogResult.OK)
            {
                rtbContent.SaveFile(dr.FileName);
                MessageBox.Show("Save successfully", "Address File: " + dr.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void tsOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "DOC File|*.doc";

            if(file.ShowDialog() == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0) 
            {
                rtbContent.LoadFile(file.FileName);
            }
        }
    }
}
