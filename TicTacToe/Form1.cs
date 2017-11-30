using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player1;
        bool player2;
        bool AI;
        bool pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9;
        int moveCounter;
        Random rngeesus;
        Image[] XOImages;
            
        public Form1()
        {
            InitializeComponent();
            rngeesus = new Random();
            player1 = true;
            player2 = false; // 2player not implemented yet.
            AI = false;
            moveCounter = 0;
            XOImages = new Image[2];
            XOImages[0] = Properties.Resources.X;
            XOImages[1] = Properties.Resources.O;
            

        }

        private void EndTurn()
        {
            moveCounter++;
        }
                // Checks if theres 3 in a row
        private void WinCheck()
        {
            //if
        }

                // randomly decides who gets to start
        private void WhoStarts()
        {
           int i = rngeesus.Next(1, 3);
            if (i == 1)
            {
                player1 = true;
            }
            if (i == 2)
            {
                AI = true;
            }
        }
                // AI logic
    /*    private void AITurn()
        {
            if (AI == true && moveCounter == 0)
            { // If AI has first move, randomly put a O in one of the pictureBoxes.
                if (pictureBox1.Image == null && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox5.Image == null && pictureBox6.Image == null && pictureBox7.Image == null && pictureBox8.Image == null && pictureBox9.Image == null)
                {
                    int i = rngeesus.Next(1, 10);
                    if (i == 1)
                    {
                        pictureBox1.Image = XOImages[1];
                    }
                    if (i == 2)
                    {
                        pictureBox2.Image = XOImages[1];
                    }
                    if (i == 3)
                    {
                        pictureBox3.Image = XOImages[1];
                    }
                    if (i == 4)
                    {
                        pictureBox4.Image = XOImages[1];
                    }
                    if (i == 5)
                    {
                        pictureBox5.Image = XOImages[1];
                    }
                    if (i == 6)
                    {
                        pictureBox6.Image = XOImages[1];
                    }
                    if (i == 7)
                    {
                        pictureBox7.Image = XOImages[1];
                    }
                    if (i == 8)
                    {
                        pictureBox8.Image = XOImages[1];
                    }
                    if (i == 9)
                    {
                        pictureBox9.Image = XOImages[1];
                    }
                }
            }


            if (AI == true && moveCounter == 2)
            {
                int i = rngeesus.Next(1, 8);
                if (i == 1)
                {
                    if(pictureBox1.Image == )
                }
            }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == XOImages[0] && pictureBox3.Image == null && pictureBox4.Image == null && pictureBox5.Image == null && pictureBox6.Image == null && pictureBox7.Image == null && pictureBox8.Image == null && pictureBox9.Image == null)
                {
                    int i = rngeesus.Next(1, 8);
                    if(i == 1)
                    {

                    }
                }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == null && pictureBox3.Image == XOImages[0] && pictureBox4.Image == null && pictureBox5.Image == null && pictureBox6.Image == null && pictureBox7.Image == null && pictureBox8.Image == null && pictureBox9.Image == null)
                {

                }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox4.Image == XOImages[0] && pictureBox5.Image == null && pictureBox6.Image == null && pictureBox7.Image == null && pictureBox8.Image == null && pictureBox9.Image == null)
                {

                }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox4.Image == null && pictureBox5.Image == XOImages[0] && pictureBox6.Image == null && pictureBox7.Image == null && pictureBox8.Image == null && pictureBox9.Image == null)
                {

                }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox4.Image == null && pictureBox5.Image == null && pictureBox6.Image == XOImages[0] && pictureBox7.Image == null && pictureBox8.Image == null && pictureBox9.Image == null)
                {

                }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox4.Image == null && pictureBox5.Image == null && pictureBox6.Image == null && pictureBox7.Image == XOImages[0] && pictureBox8.Image == null && pictureBox9.Image == null)
                {

                }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox4.Image == null && pictureBox5.Image == null && pictureBox6.Image == null && pictureBox7.Image == null && pictureBox8.Image == XOImages[0] && pictureBox9.Image == null)
                {

                }
                if (pictureBox1.Image == XOImages[1] && pictureBox2.Image == null && pictureBox3.Image == null && pictureBox4.Image == null && pictureBox5.Image == null && pictureBox6.Image == null && pictureBox7.Image == null && pictureBox8.Image == null && pictureBox9.Image == XOImages[0])
                {

                }




            }*/


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox1.Image = XOImages[0];
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox2.Image = XOImages[0];
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox3.Image = XOImages[0];
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox4.Image = XOImages[0];
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox5.Image = XOImages[0];
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox6.Image = XOImages[0];
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox7.Image = XOImages[0];
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox8.Image = XOImages[0];
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (player1 == true)
            {
                pictureBox9.Image = XOImages[0];
            }
        }
    }
}
