using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Mission2;

internal class Program
{
    //a program to roll two dice and display the results.
    private static void Main(string[] args)
    {
        int numRolls;
        string userInput;
        bool isInt;
        int[] results;
        string resultLine;
        double rollPct;
        Dice dr;


        //get input
        Console.WriteLine("Welcome to the dice throwing simulator.");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        userInput = Console.ReadLine();

        //checks if input is integer
        isInt = int.TryParse(userInput, out int result);
        if (isInt)
        {
            //rolls according to user input
            numRolls = int.Parse(userInput);
            dr = new Dice();
            //retrieves arrow from roll method
            results = dr.roll(numRolls);
            //output results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls);
            //result for each number
            for (int i = 0; i < results.Length; i++)
            {
                //calculate percentage of total
                rollPct = Math.Round(100 * ((double)results[i] / numRolls));
                resultLine = (i + 2).ToString() + ": ";
                //generate appropriate number of *s
                for (int j = 0; j < (int)rollPct; j++)
                {
                    resultLine = resultLine + "*";
                }
                Console.WriteLine(resultLine);
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
        else
        {
            Console.WriteLine("Error: Input is not a whole number");
        }

    }
}