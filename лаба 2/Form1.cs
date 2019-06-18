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

namespace лаба_2
{
    public partial class Form1 : Form
    {

        OpenFileDialog openFileDialog1;
        SaveFileDialog saveFileDialog1;

        Circle[] circle;
        Circle[] circleleFromFile;
        Conus[] conus;
        Conus[] conusFromFile;

        public Form1()
        {
            circle = new Circle[2];
            conus = new Conus[2];
            InitializeComponent();

                
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            conus[0].R = Convert.ToDouble(textBox2.Text);
            conus[0].H = Convert.ToDouble(textBox3.Text);
            richTextBox2.Text = conus.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            circle[0].R = Convert.ToDouble(textBox1.Text);
            richTextBox1.Text = circle.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
            if ()
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;

                string path = Path.GetDirectoryName(Application.ExecutablePath);

                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);

                int length = circle.Length;
                bw.Write(length);

                // Пишем данные
                for (int i = 0; i < circle.Length; i++)
                {
                    circle[i].Write(bw);
                }

                // Закрываем потоки
                bw.Close();
                fs.Close();
                MessageBox.Show("Файл сохранен");
                // выходим из приложения 
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
