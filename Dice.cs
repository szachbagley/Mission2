using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Dice
    {
        public int[] roll(int rolls)
        {
            int[] rollOutcomes = new int[11];
            //do as many rolls as specified
            for (int i = 0; i < rolls; i++)
            {
                Random rand = new Random();
                int diceSum;
                //roll first die
                int die1 = rand.Next(1, 7);
                //roll second die
                int die2 = rand.Next(1, 7);
                //calculate result
                diceSum = die1 + die2;
                //increment array according to result
                rollOutcomes[diceSum - 2]++;
            }
            return rollOutcomes;
        }
    }
}
