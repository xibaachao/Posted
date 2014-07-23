using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Posted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Replace(" ", "");
            richTextBox1.Text = Regex.Replace(this.richTextBox1.Text, @"(?s)\n\s*\n", "\n");
            Clipboard.SetDataObject(richTextBox1.Text);
            richTextBox1.Text = "";
            label2.Text = "好的处理完成，粘贴就好！";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                label2.Text = "";
            }
          
        }
    }
}
