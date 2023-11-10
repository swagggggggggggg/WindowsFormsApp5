using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private int rand_num;
        private int win_rate = 0;
        private Random random = new Random();


        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";

            try
            {
                int input = Convert.ToInt32(textBox1.Text);
                if (input > rand_num)
                {
                    label3.Text = "Too high, try again.";
                }

                if (input < rand_num)
                {
                    label3.Text = "Too low, try again.";
                }

                if (input == rand_num)
                {
                    win_rate++;
                    textBox2.Text = Convert.ToString(win_rate);
                    label4.Text = "Congartulations! You win!";
                    rand_num = random.Next(1, 101);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid input. Please enter an integer.");
            }
            

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            rand_num = random.Next(1, 101);
            textBox2.Text = Convert.ToString(win_rate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            win_rate = 0;
            textBox2.Text = Convert.ToString(win_rate);
            label3.Text = "";
            label4.Text = "";
            rand_num = random.Next(1, 101);
        }
    }
}
