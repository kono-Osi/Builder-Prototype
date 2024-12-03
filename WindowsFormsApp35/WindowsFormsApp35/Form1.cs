using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Builder builder;
        Product p;
        Product clone;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void on_product_btns()
        { 
            button4.Enabled = true;
            button5.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            builder = new BuilderHP();
            on_product_btns();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("телефон має " + p.battery);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new BuilderLenovo();
            on_product_btns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            builder = new BuilderDell();
            on_product_btns();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p = builder.getResult();
            listBox1.Items.Add("product: "+p.Tostring());//
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            clone = p.clone();
            listBox1.Items.Add("clone: " + p.Tostring());//
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p.VideoCard = "CHANGED VIDEO CARD";
            listBox1.Items.Add("------------------------------");
            listBox1.Items.Add("product: " + p.Tostring());//
            listBox1.Items.Add("clone: " + clone.Tostring());//
        }
    }
}
