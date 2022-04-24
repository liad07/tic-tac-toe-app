using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        int turn = 0;
        char tur;
        char[,] board = new char[3, 3];


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button1.Text = tur.ToString();
                board[0, 0] = tur;
                //label2.Text = board[0, 0].ToString()
                wino();
                winx();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button2.Text = tur.ToString();
                board[0, 1] = tur;
                wino();
                winx();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button3.Text = tur.ToString();
                board[0, 2] = tur;
                wino();
                winx();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button4.Text = tur.ToString();
                board[1, 0] = tur;
                wino();
                winx();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button5.Text = tur.ToString();
                board[1, 1] = tur;
                wino();
                winx();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button6.Text = tur.ToString();
                board[1, 2] = tur;
                wino();
                winx();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button7.Text = tur.ToString();
                board[2, 0] = tur;
                wino();
                winx();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button8.Text = tur.ToString();
                board[2, 1] = tur;
                wino();
                winx();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "")
            {

            }
            else
            {
                turn++;
                if (turn % 2 == 1)
                {
                    tur = 'x';
                    label1.Text = "o" + " תור";

                }
                else
                {
                    tur = 'o';
                    label1.Text = "x" + " תור";


                }
                button9.Text = tur.ToString();
                board[2, 2] = tur;
                wino();
                winx();
            }
        }
    
        private int wino()
        {
            int counter = 0;
            //line 1 all o
            if (board[0, 0] == 'o' && board[0, 1] == 'o' && board[0, 2] == 'o')
            {
                counter++;
            }
            //line 2 all o
            if (board[1, 0] == 'o' && board[1, 1] == 'o' && board[1, 2] == 'o')
            {
                counter++;
            }
            // line 3 all o
            if (board[2, 0] == 'o' && board[2, 1] == 'o' && board[2, 2] == 'o')
            {
                counter++;
            }
            //alcson rtl
            if (board[0, 0] == 'o' && board[1, 1] == 'o' && board[2, 2] == 'o')
            {
                counter++;
            }
            //alcson ltr

            if (board[2, 0] == 'o' && board[1, 1] == 'o' && board[0, 2] == 'o')
            {
                counter++;
            }
            //row 1 all o
            if (board[0, 0] == 'o' && board[1, 0] == 'o' && board[2, 0] == 'o')
            {
                counter++;
            }
            //row 2 all o
            if (board[0, 1] == 'o' && board[1, 1] == 'o' && board[2, 1] == 'o')
            {
                counter++;
            }
            //row 3 all o
            if (board[0, 2] == 'o' && board[1, 2] == 'o' && board[2, 2] == 'o')
            {
                counter++;
            }
            if (counter == 1)
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "o ניצח";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;


            }
            if (counter == 2)
            {
                label2.ForeColor = System.Drawing.Color.Blue;
                label2.Text = "o win in godmode";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (turn == 9 && counter == 0)
            {
                label2.ForeColor = System.Drawing.Color.BurlyWood;
                label2.Text = "draw";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            return counter;
        }
        private int winx()
        {
            int counter = 0;
            //line 1 all x
            if (board[0, 0] == 'x' && board[0, 1] == 'x' && board[0, 2] == 'x')
            {
                counter++;
            }
            //line 2 all x
            if (board[1, 0] == 'x' && board[1, 1] == 'x' && board[1, 2] == 'x')
            {
                counter++;
            }
            // line 3 all x
            if (board[2, 0] == 'x' && board[2, 1] == 'x' && board[2, 2] == 'x')
            {
                counter++;
            }
            //alcson rtl
            if (board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x')
            {
                counter++;
            }
            //alcson ltr

            if (board[2, 0] == 'x' && board[1, 1] == 'x' && board[0, 2] == 'x')
            {
                counter++;
            }
            //row 1 all o
            if (board[0, 0] == 'x' && board[1, 0] == 'x' && board[2, 0] == 'x')
            {
                counter++;
            }
            //row 2 all o
            if (board[0, 1] == 'x' && board[1, 1] == 'x' && board[2, 1] == 'x')
            {
                counter++;
            }
            //row 3 all o
            if (board[0, 2] == 'x' && board[1, 2] == 'x' && board[2, 2] == 'x')
            {
                counter++;
            }
            if (counter == 1)
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "x ניצח";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (counter == 2)
            {
                label2.ForeColor = System.Drawing.Color.Blue;
                label2.Text = "x win in godmode";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            if (turn == 9 && counter == 0)
            {
                label2.ForeColor = System.Drawing.Color.BurlyWood;
                label2.Text = "draw";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            
            return counter;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            Array.Clear(board, 0, board.Length);
            turn = 0;
            label1.Text = "" + " תור";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}
