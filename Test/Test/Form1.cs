using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;
            label2.Text = " Hello, "+name+" !~";
        }
        //Площадь прямойгольника
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double a, b;
            a = rnd.NextDouble()*10;
            b = rnd.NextDouble()*10;
            double S = a * b;
            label3.Text = "Площадь прямойгольника со сторонами " + a.ToString("F1") + " и "+ b.ToString("F1");
            textBox2.Text = S.ToString("F2");
        }

        //количество нажатий
        int count = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            count++;
            label5.Text = $"Кнопка была нажата {count} раз";
            if (count % 2 == 0)
            {
                label5.ForeColor = Color.Red;
            } else
            {
                label5.ForeColor = Color.Blue;
                label5.Top += 5;
            }
        }
        //две кноспки
        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "Сработала левая кнопка";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.ForeColor = Color.Blue;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = "Сработала правая кнопка";
            label6.TextAlign = ContentAlignment.MiddleRight;
            label6.ForeColor = Color.Red;
        }

        //степень
        int b = 0;
        int TextSize = 8;
        private void button6_Click(object sender, EventArgs e)
        {
            int a;
            a = 2;
            label7.Text = a.ToString() ;
            label8.Text = b.ToString();
            label9.Text = "= "+ Math.Pow(a,b);
            label9.Font = new Font(label9.Font.Name, TextSize, label9.Font.Style);
            if(TextSize <25)
            {
                TextSize += 2;
            }
            b++;
        }
        //Окружность
        private void button7_Click(object sender, EventArgs e)
        {
            double x, r;
            try{
                r = Convert.ToDouble(textBox3.Text);
                x = 2 * Math.PI * r;
                label11.Text = "Длина окружности =" + x.ToString("F2");
            }
            catch { }  
        }
        //лампочка
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Включить")
            {
                pictureBox1.Image = Properties.Resources.Лампочка2;
                button8.Text = "Выключить";
                button8.ForeColor=Color.Red;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Лампочка1;
                button8.Text = "Включить";
                button8.ForeColor = Color.Blue;
            }
        }
        //лампочка таймер
        int sec;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label13.Text = $"Лампочка горит {sec} сек";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "Включить")
            {
                pictureBox2.Image = Properties.Resources.Лампочка2;
                button9.Text = "Выключить";
                button9.ForeColor = Color.Red;
                sec = 0;
                label13.ForeColor = Color.Red;
                label13.Text = $"Лампочка горит {sec} сек";
                timer1.Start();
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Лампочка1;
                button9.Text = "Включить";
                button9.ForeColor = Color.Blue;
                timer1.Stop();
                label13.ForeColor = Color.Green;
                label13.Text = $"Лампочка горела {sec} сек";
            }
        }
    }
}
