﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//this was very tough to code purely on c# witohu the use of any other software like unity so please consider voting!


namespace BRICK_BREAKER
{
    public partial class Form1 : Form
    {




        bool goLeft;

        bool goRight;

        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random rnd = new Random();


        PictureBox[] blockArray;


        public Form1()
        {
            InitializeComponent();
            
            PlaceBlocks();
        }

        private void setupGame()

        {

            isGameOver = false;

            score = 0;

            ballx = 5;

            bally = 5;
            playerSpeed = 12;
            txtScore.Text = "Score: " + score;

            ball.Left = 376;
            ball.Top = 328;

            player.Left = 347;


            gameTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }



                
                   

                

            }
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();

            
        }

        private void PlaceBlocks()
        {
            blockArray = new PictureBox[15];

            int a = 0;

            int top = 50;
            int left = 100;


            for(int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i]= new PictureBox();
                blockArray[i].Height = 32;
                blockArray[i].Width = 100;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White; 

                if(a == 5)
                {
                    top = top + 50;
                    left = 100;
                    a = 0; 

                }

                if(a < 5)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 130;
                }
            }

            setupGame();
        }

        private void removeBlocks()
        {
            foreach(PictureBox x in blockArray)
            {
                this.Controls.Remove(x);


            }
        }



        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;

            if(goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed; 
            }




            if(goRight == true && player.Left < 700)
            {

                player.Left += playerSpeed;

            }


            ball.Left += ballx;

            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 775)
            {

                ballx = -ballx;

            }
            if(ball.Top < 0)
            {

                bally = -bally;


            }
            
            if (ball.Bounds.IntersectsWith(player.Bounds))
            
            {


                bally = rnd.Next(5, 12) * -1;


                if(ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1; 
                        
                    

                }
                else
                {

                    ballx = rnd.Next(5, 12);

                }

            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "blocks")
                {

                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;

                      
                        if (ball.Right >= x.Left && ball.Left < x.Left) 
                        {
                            ballx = -Math.Abs(ballx);
                        }

                        else if (ball.Left <= x.Right && ball.Right > x.Right) 
                        {

                            ballx = Math.Abs(ballx);
                        
                        }

                        if (ball.Bottom >= x.Top && ball.Top < x.Top)
                        {
                            bally = -Math.Abs(bally);
                        }
                        else if (ball.Top <= x.Bottom && ball.Bottom > x.Bottom) 
                        {

                            bally = Math.Abs(bally);
                        }

                       
                        this.Controls.Remove(x);
                    }
                }

            }

            if(score == 15)
            {
                gameOver();

                LOSSSCREEN.Visible = true;
                WINSCREEN.Visible = true;
            }
            if(ball.Top > 530
                )
            {
                gameOver();

                LOSSSCREEN.Visible = true;

            }
            
            

            




        }




        private void keyisdown(object sender, KeyEventArgs e)
        {


            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            { 
                removeBlocks();
                 
                PlaceBlocks();

                LOSSSCREEN.Visible = false;

                
                WINSCREEN.Visible = false;


            }







        }
    }
} 

