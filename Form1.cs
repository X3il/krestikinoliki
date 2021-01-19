using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krestikinoliki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool FirstMove;

        public void CheckWinX()
        {
            if (((button4.Text=="x")&&(button5.Text=="x")&&(button6.Text=="x"))||((button2.Text=="x")&&(button5.Text=="x")&&(button8.Text=="x"))||((button1.Text=="x")&&(button4.Text=="x")&&(button7.Text=="x"))||((button1.Text=="x")&&(button2.Text=="x")&&(button3.Text=="x"))||((button1.Text=="x")&&(button5.Text=="x")&&(button9.Text=="x"))||((button3.Text=="x")&&(button5.Text=="x")&&(button7.Text=="x"))||((button3.Text=="x")&&(button6.Text=="x")&&(button9.Text=="x"))||((button7.Text=="x")&&(button8.Text=="x")&&(button9.Text=="x")))
            {
                MessageBox.Show("Крестики выйграли");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                

            }
        }
        public void CheckWinO()
        {
            if (((button4.Text == "0") && (button5.Text == "0") && (button6.Text == "0")) || ((button2.Text == "0") && (button5.Text == "0") && (button8.Text == "0"))||((button1.Text == "0") && (button4.Text == "0") && (button7.Text == "0")) || ((button1.Text == "0") && (button2.Text == "0") && (button3.Text == "0")) || ((button1.Text == "0") && (button5.Text == "0") && (button9.Text == "0")) || ((button3.Text == "0") && (button5.Text == "0") && (button7.Text == "0")) || ((button3.Text == "0") && (button6.Text == "0") && (button9.Text == "0")) || ((button7.Text == "0") && (button8.Text == "0") && (button9.Text == "0")))
            {
                MessageBox.Show("Нолики выйграли");
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!FirstMove&&button1.Text=="")
            {
                button1.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();
            }
            else if (button1.Text == "")
            {
                button1.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button2.Text == "")
            {
                button2.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button2.Text == "")
            {
                button2.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button3.Text == "")
            {
                button3.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button3.Text == "")
            {
                button3.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button4.Text == "")
            {
                button4.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button4.Text == "")
            {
                button4.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button5.Text == "")
            {
                button5.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button5.Text == "")
            {
                button5.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button6.Text == "")
            {
                button6.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button6.Text == "")
            {
                button6.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button7.Text == "")
            {
                button7.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button7.Text == "")
            {
                button7.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button8.Text == "")
            {
                button8.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button8.Text == "")
            {
                button8.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!FirstMove && button9.Text == "")
            {
                button9.Text = "x";
                FirstMove = true;
                CheckWinX();
                CheckWinO();

            }
            else if (button9.Text == "")
            {
                button9.Text = "0";
                FirstMove = false;
                CheckWinX();
                CheckWinO();
            }
        }
    }
}