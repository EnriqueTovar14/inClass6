using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Enrique Tovar
//This is my own work
namespace inClass6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dice d1 = new Dice(10);
            Dice d2 = new Dice(10);

            int d1Value = d1.rollDice();
            int d2Value = d2.rollDice();
            int rolls = 0;

            bool snakeEyes = false;
            while (!snakeEyes)
            {
                d1Value = d1.rollDice();
                d2Value = d2.rollDice();
                rolls++;

                this.textBox1.Text = d1Value.ToString();
                this.textBox2.Text = d2Value.ToString();
                if ((d1Value == 1) && (d1Value == d2Value))
                {
                    snakeEyes = true;
                    MessageBox.Show(string.Format("It took " + rolls + " rolls to get snake eyes"));
                }

            }
        }
    }
}
