using System;
using System.Windows.Forms;
using Counter;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public partial class CC : Form
    {

        Point lastPoint;
        
        public CC()
        {
            InitializeComponent();
           
        }

        private void СС_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && SS1.Text != "" && SS2.Text != "")
                {
                    int i = Convert.ToInt32(textBox1.Text, Convert.ToInt32(SS1.Text));
                    textBox2.Text = Convert.ToString(i, Convert.ToInt32(SS2.Text));
                }
                else
                {
                    label1.Text = "Ошибка! Введите данные!";
                }
            }
            catch
            {
                label1.Text = "Ошибка! Неверно введены дынные!";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            SS1.Text = "";
            SS2.Text = "";
            C1.Text = "";
            C2.Text = "";
            SS3.Text = "";
            SS4.Text = "";
            SS5.Text = "";
            Total.Text = "";
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Variables.CountWindow_3 == false)
            {
                Variables.CountWindow_3 = true;
                this.Close();
            }
        }

        private void Plus(object sender, EventArgs e)
        {
            try
            {
                if (C1.Text != "" && C2.Text != "" && SS3.Text != "" && SS4.Text != "" && SS5.Text != "")
                {
                    int a = Convert.ToInt32(C1.Text, Convert.ToInt32(SS3.Text));
                    int b = Convert.ToInt32(C2.Text, Convert.ToInt32(SS4.Text));
                    Total.Text = Convert.ToString(a + b, Convert.ToInt32(SS5.Text));
                }
                else
                {
                    label1.Text = "Ошибка! Введите данные!";
                }
            }
            catch
            {
                label1.Text = "Ошибка. Недопустимое значение СС.";
            }
        }

        private void Minus(object sender, EventArgs e)
        {
            try
            {
                if (C1.Text != "" && C2.Text != "" && SS3.Text != "" && SS4.Text != "" && SS5.Text != "")
                {
                    int a = Convert.ToInt32(C1.Text, Convert.ToInt32(SS3.Text));
                    int b = Convert.ToInt32(C2.Text, Convert.ToInt32(SS4.Text));
                    Total.Text = Convert.ToString(a - b, Convert.ToInt32(SS5.Text));
                }
                else
                {
                    label1.Text = "Ошибка! Введите данные!";
                }
            }
            catch
            {
                label1.Text = "Ошибка. Недопустимое значение СС.";
            }
        }

        private void Multiply(object sender, EventArgs e)
        {
            try
            {
                if (C1.Text != "" && C2.Text != "" && SS3.Text != "" && SS4.Text != "" && SS5.Text != "")
                {
                    int a = Convert.ToInt32(C1.Text, Convert.ToInt32(SS3.Text));
                    int b = Convert.ToInt32(C2.Text, Convert.ToInt32(SS4.Text));
                    Total.Text = Convert.ToString(a * b, Convert.ToInt32(SS5.Text));
                }
                else
                {
                    label1.Text = "Ошибка! Введите данные!";
                }
            }
            catch
            {
                label1.Text = "Ошибка. Недопустимое значение СС.";
            }
        }

        private void Division(object sender, EventArgs e)
        {
            try
            {
                if (C1.Text != "" && C2.Text != "" && SS3.Text != "" && SS4.Text != "" && SS5.Text != "")
                {
                    int a = Convert.ToInt32(C1.Text, Convert.ToInt32(SS3.Text));
                    int b = Convert.ToInt32(C2.Text, Convert.ToInt32(SS4.Text));
                    Total.Text = Convert.ToString(a / b, Convert.ToInt32(SS5.Text));
                }
                else
                {
                    label1.Text = "Ошибка! Введите данные!";
                }
            }
            catch
            {
                label1.Text = "Ошибка. Недопустимое значение СС.";
            }
        }

        private void CC_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CC_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
