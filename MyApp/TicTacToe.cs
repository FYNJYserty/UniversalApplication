using System;
using System.Drawing;
using System.Windows.Forms;
using Counter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        int CheckBox = 2;
        private Button[,] buttons = new Button[3, 3];
        int Total1 = 0;
        int Total2 = 0;
        int Player = 0;
        int total_moves;
        Point lastPoint;

        public TicTacToe()
        {
            InitializeComponent();

            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(100, 100);
                    buttons[i, j].BackColor = Color.FromArgb(63, 146, 210);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].FlatAppearance.BorderSize = 0;
                }
            }

            label3.Text = "Выберите сторону!";

            SetBTN();
        }

        public void buttonMenu_Click(object sender, EventArgs e)
        {
            if (Variables.CountWindow_1 == false)
            {
                Variables.CountWindow_1 = true;
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Player = 2;
                label3.Text = "Сейчас ходят крестики!";
                CheckBox = 1;
                checkBox2.Enabled = false;
            }
            if (checkBox2.Checked == true)
            {
                Player = 1;
                label3.Text = "Сейчас ходят нолики!";
                CheckBox = 0;
                checkBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckBox == 1)
            {
                total_moves++;
                sender.GetType().GetProperty("Text").SetValue(sender, "X");
                label3.Text = "Сейчас ходят нолики!";
                sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            }
            else if (CheckBox == 0)
            {
                total_moves++;
                sender.GetType().GetProperty("Text").SetValue(sender, "O");
                label3.Text = "Сейчас ходят крестики!";
                sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            }

            RandomChoice();
            Check();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void SetBTN()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Location = new Point(12 + 106 * j, 87 + 106 * i);
                    buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 48);
                    buttons[i, j].Click += button1_Click;
                    this.Controls.Add(buttons[i, j]);
                }
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Total1 = 0);
            label2.Text = Convert.ToString(Total2 = 0);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Text = "";
                }
            }

            Player = 0;
            total_moves = 0;
            CheckBox = 2;
            label3.Text = "Выберите сторону!";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void Check()
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if(buttons[0, 0].Text == "X" && buttons[0, 1].Text == "X" && buttons[0, 2].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[0, 0].Text == "O" && buttons[0, 1].Text == "O" && buttons[0, 2].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    if (buttons[1, 0].Text == "X" && buttons[1, 1].Text == "X" && buttons[1, 2].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[1, 0].Text == "O" && buttons[1, 1].Text == "O" && buttons[1, 2].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    if (buttons[2, 0].Text == "X" && buttons[2, 1].Text == "X" && buttons[2, 2].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[2, 0].Text == "O" && buttons[2, 1].Text == "O" && buttons[2, 2].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (buttons[0, 0].Text == "X" && buttons[1, 0].Text == "X" && buttons[2, 0].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[0, 0].Text == "O" && buttons[1, 0].Text == "O" && buttons[2, 0].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    if (buttons[0, 1].Text == "X" && buttons[1, 1].Text == "X" && buttons[2, 1].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[0, 1].Text == "O" && buttons[1, 1].Text == "O" && buttons[2, 1].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    if (buttons[0, 2].Text == "X" && buttons[1, 2].Text == "X" && buttons[2, 2].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[0, 2].Text == "O" && buttons[1, 2].Text == "O" && buttons[2, 2].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    if (buttons[0, 0].Text == "X" && buttons[1, 1].Text == "X" && buttons[2, 2].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[0, 0].Text == "O" && buttons[1, 1].Text == "O" && buttons[2, 2].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    if (buttons[2, 0].Text == "X" && buttons[1, 1].Text == "X" && buttons[0, 2].Text == "X")
                    {
                        CheckBox = 2;
                        label2.Text = Convert.ToString(Total2 += 1);
                        MessageBox.Show("Крестики выиграли!!!");
                        return;
                    }
                    if (buttons[2, 0].Text == "O" && buttons[1, 1].Text == "O" && buttons[0, 2].Text == "O")
                    {
                        CheckBox = 2;
                        label1.Text = Convert.ToString(Total1 += 1);
                        MessageBox.Show("Нолики выиграли!!!");
                        return;
                    }
                }                
            }
            if (total_moves == 9)
            {
                Player = 0;
                MessageBox.Show("Ничья!");
            }
        }

        private void RandomChoice()
        {
            Random rnd = new Random();
            int ph = rnd.Next(0,8);

            if(Player == 1 && total_moves != 9)
            {
                switch (ph)
                {
                    case 0:
                        if (buttons[0, 0].Text == "")
                        {
                            buttons[0, 0].Text = "X";
                            buttons[0, 0].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[0, 0].Text != "")
                        {
                            goto case 1;
                        }
                        break;
                    case 1:
                        if (buttons[0, 1].Text == "")
                        {
                            buttons[0, 1].Text = "X";
                            buttons[0, 1].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[0, 1].Text != "")
                        {
                            goto case 2;
                        }
                        break;
                    case 2:
                        if (buttons[0, 2].Text == "")
                        {
                            buttons[0, 2].Text = "X";
                            buttons[0, 2].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[0, 2].Text != "")
                        {
                            goto case 3;
                        }
                        break;
                    case 3:
                        if (buttons[1, 0].Text == "")
                        {
                            buttons[1, 0].Text = "X";
                            buttons[1, 0].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[1, 0].Text != "")
                        {
                            goto case 4;
                        }
                        break;
                    case 4:
                        if (buttons[1, 1].Text == "")
                        {
                            buttons[1, 1].Text = "X";
                            buttons[1, 1].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[1, 1].Text != "")
                        {
                            goto case 5;
                        }
                        break;
                    case 5:
                        if (buttons[1, 2].Text == "")
                        {
                            buttons[1, 2].Text = "X";
                            buttons[1, 2].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[1, 2].Text != "")
                        {
                            goto case 6;
                        }
                        break;
                    case 6:
                        if (buttons[2, 0].Text == "")
                        {
                            buttons[2, 0].Text = "X";
                            buttons[2, 0].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[2, 0].Text != "")
                        {
                            goto case 7;
                        }
                        break;
                    case 7:
                        if (buttons[2, 1].Text == "")
                        {
                            buttons[2, 1].Text = "X";
                            buttons[2, 1].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[2, 1].Text != "")
                        {
                            goto case 8;
                        }
                        break;
                    case 8:
                        if (buttons[2, 2].Text == "")
                        {
                            buttons[2, 2].Text = "X";
                            buttons[2, 2].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[2, 2].Text != "")
                        {
                            goto case 0;
                        }
                        break;
                }
            }
            if (Player == 2 && total_moves != 9)
            {
                switch (ph)
                {
                    case 0:
                        if(buttons[0, 0].Text == "")
                        {
                            buttons[0, 0].Text = "O";
                            buttons[0, 0].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[0, 0].Text != "")
                        {
                            goto case 1;
                        }
                        break;
                    case 1:
                        if (buttons[0, 1].Text == "")
                        {
                            buttons[0, 1].Text = "O";
                            buttons[0, 1].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[0, 1].Text != "")
                        {
                            goto case 2;
                        }
                        break;
                    case 2:
                        if (buttons[0, 2].Text == "")
                        {
                            buttons[0, 2].Text = "O";
                            buttons[0, 2].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[0, 2].Text != "")
                        {
                            goto case 3;
                        }
                        break;
                    case 3:
                        if (buttons[1, 0].Text == "")
                        {
                            buttons[1, 0].Text = "O";
                            buttons[1, 0].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[1, 0].Text != "")
                        {
                            goto case 4;
                        }
                        break;
                    case 4:
                        if (buttons[1, 1].Text == "")
                        {
                            buttons[1, 1].Text = "O";
                            buttons[1, 1].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[1, 1].Text != "")
                        {
                            goto case 5;
                        }
                        break;
                    case 5:
                        if (buttons[1, 2].Text == "")
                        {
                            buttons[1, 2].Text = "O";
                            buttons[1, 2].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[1, 2].Text != "")
                        {
                            goto case 6;
                        }
                        break;
                    case 6:
                        if (buttons[2, 0].Text == "")
                        {
                            buttons[2, 0].Text = "O";
                            buttons[2, 0].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[2, 0].Text != "")
                        {
                            goto case 7;
                        }
                        break;
                    case 7:
                        if (buttons[2, 1].Text == "")
                        {
                            buttons[2, 1].Text = "O";
                            buttons[2, 1].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[2, 1].Text != "")
                        {
                            goto case 8;
                        }
                        break;
                    case 8:
                        if (buttons[2, 2].Text == "")
                        {
                            buttons[2, 2].Text = "O";
                            buttons[2, 2].Enabled = false;
                            total_moves++;
                        }
                        else if (buttons[2, 2].Text != "")
                        {
                            goto case 0;
                        }
                        break;
                }
            }
        }

        private void TicTacToe_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

    }
}