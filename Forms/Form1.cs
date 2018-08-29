using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Enter += new EventHandler(textBox2_Enter);
            textBox2.Leave += new EventHandler(textBox2_Leave);
            textBox3.Enter += new EventHandler(textBox3_Enter);
            textBox3.Leave += new EventHandler(textBox3_Leave);
            textBox4.Enter += new EventHandler(textBox4_Enter);
            textBox4.Leave += new EventHandler(textBox4_Leave);
            richTextBox1.Enter += new EventHandler(richTextBox1_Enter);
            richTextBox1.Leave += new EventHandler(richTextBox1_Leave);
            textBox3.Text = DateTime.Now.Year.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ohjelman teki Arttu Höylä","Info");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "") textBox2.Text = "[Syötä elokuvan nimi]";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "") textBox3.Text = DateTime.Now.Year.ToString();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "") textBox4.Text = "0";
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "") richTextBox1.Text = "[Kirjoita Arvostelu Tähän]";
        }
    }
}
