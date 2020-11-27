/* Taiyo Suzuki
 * November 27, 2020
 * Random number guessing game
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int num;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            num = randGen.Next(1, 101);
            toDelete.Text = $"{num}";
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(numInput.Text);
            if (guess > num)
            {
                outputLabel.Text = "Too high!";
            }
            else if (guess < num)
            {
                outputLabel.Text = "Too low!";
            }
            else if (guess == num)
            {
                outputLabel.Text = "You got it!";
            }



        }
    }
}
