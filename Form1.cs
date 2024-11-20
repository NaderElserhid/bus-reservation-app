using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilit_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text);
            listView1.Items.Add(textBox2.Text);
            listView1.Items.Add(comboBox1.Text);
            listView1.Items.Add(comboBox2.Text);
            listView1.Items.Add(maskedTextBox1.Text);
            listView1.Items.Add(maskedTextBox2.Text);
            listView1.Items.Add(maskedTextBox3.Text);
            listView1.Items.Add(male.Text);
            listView1.Items.Add(famale.Text);
        }
    }
}
