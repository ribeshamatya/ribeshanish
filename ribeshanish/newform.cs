using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ribeshanish
{
    public partial class newform : Form
    {

        
        int playerchoice;
        public newform()
        {
            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerchoice<1|| playerchoice>3)
            {
                MessageBox.Show("you havent chosen any options");
                return;
            }
            SoundPlayer sndplayr = new  SoundPlayer("spr.wav");
            //sndplayr.Play();
            System.Threading.Thread.Sleep(2500);
            Random r = new Random();
            int computerchoice = r.Next(1, 3);
            if(computerchoice==1)
            {
               pictureBox5.Image = ribeshanish.Properties.Resources.scissor;
            }
            else if(computerchoice==2)
            {
                pictureBox5.Image = ribeshanish.Properties.Resources.paper;
            }
            else if(computerchoice==3)
            {
                pictureBox5.Image = ribeshanish.Properties.Resources.rock;
            }

            if (playerchoice == 1 && computerchoice == 1)
            {
                label9.Text = "scissor vs scissor is Tie";
                label8.ForeColor = Color.Blue;
                label8.Text = "Its Draw";
            }
            else if (playerchoice == 1 && computerchoice == 2)
            {
                label9.Text = "scissor Beat paper";
                label8.ForeColor = Color.Green;
                label8.Text = "You Win";
            }
            else if (playerchoice == 1 && computerchoice == 3)
            {
                label9.Text = "rock beats scissor";
                label8.ForeColor = Color.Red;
                label8.Text = "You lose";

            }
            else if (playerchoice==2 && computerchoice==1)

            {
                label9.Text = "scissor beats paper";
                label8.ForeColor = Color.Red;
                label8.Text = "you lose";
            }

            else if (playerchoice==2&& computerchoice==2)
            {
                label9.Text = "paper vs paper is Tie";
                label8.ForeColor = Color.Blue;
                label8.Text = "Its Draw";
            

            }
            else if(playerchoice==2&&computerchoice ==3)
            {
                label9.Text = "paper beats rock";
                label8.ForeColor = Color.Green;
                label8.Text = "You Win";

            }
            else if(playerchoice==3&&computerchoice==1)
            {
                label9.Text = "rock beats scissor";
                label8.ForeColor = Color.Green;
                label8.Text = "You Win";

            }
            else if (playerchoice==3&&computerchoice==2)
            {
                label9.Text = "paper beats rock";
                label8.ForeColor = Color.Red;
                label8.Text = "You Lose";
            }
            else if(playerchoice==3&&computerchoice==3)
            {
                label9.Text = "Rock vs Rock is Tie";
                label8.ForeColor = Color.Blue;
                label8.Text = "Its Draw";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = ribeshanish.Properties.Resources.computer;
            pictureBox4.Image = ribeshanish.Properties.Resources.scissor;
            playerchoice = 1;
            label9.Text = "";
            label8.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label8.Text = "";
            pictureBox5.Image = ribeshanish.Properties.Resources.computer;
            pictureBox4.Image = ribeshanish.Properties.Resources.paper;
            playerchoice = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label8.Text = "";
            pictureBox5.Image = ribeshanish.Properties.Resources.computer;
            pictureBox4.Image = ribeshanish.Properties.Resources.rock;
            playerchoice = 3;
        }
    }
}