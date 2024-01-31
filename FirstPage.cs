using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace neopixel_arduino
{
    public partial class FirstPage : Form
    {
        private Hashtable h = new Hashtable();
        Form1 f = new Form1();

        public FirstPage()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private string t4
        {
            get { return textBox4.Text; }
        }
        
        private void new_pattern()
        {

          
            string c = comboBox1.SelectedItem.ToString();
            string[] s = c.Split('-');
            string mesaj = "."+textBox2.Text;
            mesaj += "." + textBox5.Text;
            if (checkBox1.Checked)
                mesaj += ".1.";
            else
                mesaj += ".0.";
            mesaj += s[0];  
            textBox4.Text = mesaj;
        }
  

        private void FirstPage_Load(object sender, EventArgs e)
        {
            textBox5.Text = "100";
            textBox2.Text = "8";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text + "-" + textBox3.Text);
            if (h[textBox1.Text] != null)
            MessageBox.Show("There is already a pattern of this kind initialized" ,"BipBop", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
           else
            h[textBox1.Text] = textBox3.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            new_pattern();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            new_pattern();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            new_pattern();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new_pattern();
            this.DialogResult = DialogResult.OK;
        }
    }
}
