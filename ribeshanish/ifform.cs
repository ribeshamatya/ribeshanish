using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ribeshanish
{
    public partial class ifform : Form
    {
        public ifform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(textBox1.Text);
            double reminder = num % 2;
            if(reminder==0)
            {
                // MessageBox.Show("even");
                label1.Text = "even";
            }
            else

            {
                // MessageBox.Show("odd");
                label1.Text = "odd";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox2.Text);
            
            if(num<0)
            {
                label2.Text = "negative";
            }

            else
            {
                label2.Text = "positive";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox4.Text);

            double m = Convert.ToDouble(textBox8.Text);

            double en = Convert.ToDouble(textBox7.Text);

            double total = c + m + en;

            double percent = (total / 3);

            label3.Text = textBox3.Text + "   roll no " + textBox5.Text;
            label7.Text = "total : " + Convert.ToString(total) + "        percent : " + Convert.ToString(percent)+"%";

            if (percent>=80 && percent<=100)
            {
                label10.Text = "grade A";
            }

            else if (percent>=70 && percent<=80)
            {
                label10.Text = "grade B ";


            } 
            else if (percent >=60 && percent<=70)
            {
                label10.Text = "grade C";
            }
               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox4.Text);

            double m = Convert.ToDouble(textBox8.Text);

            double en = Convert.ToDouble(textBox7.Text);

            double total = c + m + en;

            double percent = (total / 3);

            label3.Text = textBox3.Text + "   roll no " + textBox5.Text;
            label7.Text = "total : " + Convert.ToString(total) + "        percent : " + Convert.ToString(percent) + "%";

            if (percent >= 80 && percent <= 100)
            {
                label10.Text = "grade A";
            }

            else if (percent >= 70 && percent <= 80)
            {
                label10.Text = "grade B ";


            }
            else if (percent >= 60 && percent <= 70)
            {
                label10.Text = "grade C";
            }

        }
    }
}
