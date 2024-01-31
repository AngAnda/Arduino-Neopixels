using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace neopixel_arduino
{
    public partial class Form1 : Form
    {

        public int n = 1;

        public void culoare()
        {
            System.Drawing.Color c = System.Drawing.Color.FromArgb(255, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            panel4.BackColor = c;
        }

        public void mesaj(int m)
        {
            string mes = "";
            mes = (Int32.Parse(textBox2.Text)/m).ToString() + "." + (Int32.Parse(textBox3.Text)/m).ToString() + "." + (Int32.Parse(textBox4.Text)/m).ToString();
           
            tb.Text = mes+"\n";
            mes += tb2.Text.ToString();
            textBox1.Text = mes+"\n";
            culoare();
        }

        public Form1()
        {
            InitializeComponent();
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            tb.Text = "0.0.0";
            tb2.Text = ".8.100.0.1";
            mesaj(n);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mesaj(n);
            try
            {
                port.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj(n);
            port.Write(textBox1.Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            if(cd.ShowDialog()== DialogResult.OK)
            {
                byte red = cd.Color.R;
                byte green = cd.Color.G;
                byte blue = cd.Color.B;
                //System.Drawing.Color cl = new System.Drawing.Color();
                panel4.BackColor = cd.Color;
                textBox2.Text = red.ToString();
                textBox3.Text = green.ToString();
                textBox4.Text = blue.ToString();
                string mes = "";
                mesaj(n);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mesaj(n);
            culoare();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstPage f = new FirstPage();
            f.ShowDialog();
            tb2.Text = f.textBox4.Text;
            string s = textBox1.Text.ToString();
            mesaj(n);
            //s += tb2.Text.ToString();
            textBox1.Text = s;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = comboBox1.SelectedItem.ToString();
            if (s == "full light")
                n = 1;
            else
            {
                String[] l = s.Split('/');
                n = Int32.Parse(l[1]);
            }
            mesaj(n);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
