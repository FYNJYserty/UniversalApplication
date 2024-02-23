using System;
using System.Windows.Forms;
using Counter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();

            this.Width = 349;
            this.Height = 502;

        }

        private void buttonPlay(object sender, EventArgs e)
        { 
            if (Variables.CountWindow_1 == true)
            {
                Variables.CountWindow_1 = false;
                TicTacToe newForm = new TicTacToe();
                newForm.Show();
            }
        }

        private void buttonCalc(object sender, EventArgs e)
        {
            if (Variables.CountWindow_2 == true)
            {
                Variables.CountWindow_2 = false;
                Calc newCalc = new Calc();
                newCalc.Show();
            }
        }

        private void buttonСС(object sender, EventArgs e)
        {
            if (Variables.CountWindow_3 == true)
            {
                Variables.CountWindow_3 = false;
                CC newCC = new CC();
                newCC.Show();
            }
        }
    }
}
