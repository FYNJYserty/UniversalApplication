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
    public partial class Calc : Form
    {
        string sign;
        double firstNumber;
        double secondNumber;
        double Total;
        double OpNumber;
        Point lastPoint;

        public Calc()
        {
            InitializeComponent();

        }

        private void buttonMenu(object sender, EventArgs e)
        {
            if (Variables.CountWindow_2 == false)
            {
                Variables.CountWindow_2 = true;
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBox1.Text += B.Text;

        }

        private void ButtonSign(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            sign = B.Text;
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            catch
            {
                textBox1.Text = "Ошибка";
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            Total = 0;
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (sign)
                {
                    case "/":
                        secondNumber = Convert.ToDouble(textBox1.Text);
                        Total = firstNumber / secondNumber;
                        textBox1.Text = Convert.ToString(Total);
                        break;
                    case "X":
                        secondNumber = Convert.ToDouble(textBox1.Text);
                        Total = firstNumber * secondNumber;
                        textBox1.Text = Convert.ToString(Total);
                        break;
                    case "-":
                        secondNumber = Convert.ToDouble(textBox1.Text);
                        Total = firstNumber - secondNumber;
                        textBox1.Text = Convert.ToString(Total);
                        break;
                    case "+":
                        secondNumber = Convert.ToDouble(textBox1.Text);
                        Total = firstNumber + secondNumber;
                        textBox1.Text = Convert.ToString(Total);
                        break;
                    case "%":
                        secondNumber = Convert.ToDouble(textBox1.Text);
                        Total = (firstNumber / 100) * secondNumber;
                        textBox1.Text = Convert.ToString(Total);
                        break;
                    default:
                        textBox1.Text = "Ошибка";
                        break;
                }
            }
            catch
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void buttonDel(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                string s = textBox1.Text;

                s = s.Substring(0, s.Length - 1);

                textBox1.Text = s;
            }
            
        }

        private void Operations(object sender, EventArgs e)
        {
            Button ClickedOperations = (Button)sender;
            try
            {
                switch (ClickedOperations.Text)
                {
                    case " ":
                        OpNumber = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(Math.Sqrt(OpNumber));
                        break;
                    case "sin":
                        OpNumber = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(Math.Sin(OpNumber));
                        break;
                    case "cos":
                        OpNumber = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(Math.Cos(OpNumber));
                        break;
                    case "tan":
                        OpNumber = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = Convert.ToString(Math.Tan(OpNumber));
                        break;
                    case "Pi":
                        textBox1.Text = Convert.ToString(Math.PI);
                        break;
                    default:
                        textBox1.Text = "Ошибка";
                        break;

                }
            }
            catch
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void Calc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Calc_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
