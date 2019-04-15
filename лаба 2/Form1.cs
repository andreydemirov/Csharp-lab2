using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_2
{
    public partial class Form1 : Form
    {
        Circle circle;
        Conus conus;
        public Form1()
        {
            circle = new Circle();
            conus = new Conus();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            conus.R = Convert.ToDouble(textBox2.Text);
            conus.H = Convert.ToDouble(textBox3.Text);
            richTextBox2.Text = conus.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            circle.R = Convert.ToDouble(textBox1.Text);
            richTextBox1.Text = circle.ToString();
            
        }

      
    }
}
