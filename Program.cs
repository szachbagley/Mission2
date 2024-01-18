using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls;
        string userInput;
        bool isInt;
        int[] results;
        string resultLine;
        double rollPct;
        double totalPct = 0;
        Dice dr;


        //get input
        Console.WriteLine("Welcome to the dice throwing simulator.");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        userInput = Console.ReadLine();

        //checks if input is integer
        isInt = int.TryParse(userInput, out int result);
        if (isInt)
        {
            numRolls = int.Parse(userInput);
            dr = new Dice();
            results = dr.roll(numRolls);
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls);
            for (int i = 0; i < results.Length; i++)
            {
                rollPct = Math.Round(100 * ((double)results[i] / numRolls));
                totalPct = totalPct + rollPct;
                resultLine = (i + 2).ToString() + ": ";
                for (int j = 0; j < (int)rollPct; j++)
                {
                    resultLine = resultLine + "*";
                }
                Console.WriteLine(resultLine);
            }
            //blah
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            Console.WriteLine("Total pct for testing: " + totalPct);
        }
        else
        {
            Console.WriteLine("Error: Input is not a whole number");
        }

    }
}