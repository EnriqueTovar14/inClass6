using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Enrique Tovar
//This is my own work
namespace inClass6
{
    class Dice
    {
        private int numSides;
        static Random rnd = new Random();
        public Dice (int n)
        {
            numSides = n;
        }
        public int rollDice()
        {
            return rnd.Next(4,20) % numSides + 1;
        }
    }
}
