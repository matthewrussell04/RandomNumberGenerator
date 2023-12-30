using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumberGenerator;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        int minNumber, maxNumber, randomNumber;

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //sets min and max as user inputs
                randomNumber = rng.Next(minNumber, maxNumber+1);
                label1.Text = randomNumber.ToString();

                //if any non digit values entered, set values to 0
                foreach (char c in min.Text)
                {
                    if(!Char.IsDigit(c))
                    {
                        minNumber = 0;
                    }
                }

                foreach (char c in max.Text)
                {
                    if(!Char.IsDigit(c))
                    {
                        maxNumber = 0;
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if(maxNumber < minNumber)
            {
                minNumber = 0; maxNumber = 0;
            }
        }

        private void min_TextChanged(object sender, EventArgs e)
        {
            //stores user input in minNumber
            try
            {
                minNumber = int.Parse(min.Text);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void max_TextChanged(object sender, EventArgs e)
        {
            //stores user input in maxNumber
            try
            {
                maxNumber = int.Parse(max.Text);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
