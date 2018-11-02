using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.KeyDown += new KeyEventHandler(richKeyDown);
            foreach (var b  in this.tableLayoutPanel1.Controls)
            {
                ((Button)b).Click += new EventHandler(  ButtonClick);
            }
        }

        private Font numfont = new Font("微软雅黑", 12, FontStyle.Regular);
        private Font opfont = new Font("微软雅黑", 12, FontStyle.Regular);
        private Font keyfont = new Font("微软雅黑", 12, FontStyle.Bold);
        private void richKeyDown(object sender ,KeyEventArgs e )
        {
            for (int i =0;i< richTextBox1.TextLength; i++)
            {
                richTextBox1.Select(i, 1);
                if (Char.IsLetter(richTextBox1.SelectedText.ElementAt(0)))
                {
                    richTextBox1.SelectionFont = keyfont;
                    richTextBox1.SelectionColor = Color.Blue;
                }
                else
                {
                    richTextBox1.SelectionFont = numfont;
                    richTextBox1.SelectionColor = Color.Brown;
                }
            }
            richTextBox1.Select(richTextBox1.TextLength, 0);
        }

        private void ButtonClick(object sender ,EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }
    }
}
