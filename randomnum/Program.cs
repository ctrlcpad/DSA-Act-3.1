using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomnum;

class Program
{

    static void Main(string[] args)
    {
        try
        {
            Random random = new Random();
            string name = "";
            int bet, multiplier = random.Next(2, 6);
            string lucky = "";

            Console.Write("Enter your Name: ");
            name = Console.ReadLine();
            Console.Write("Enter bet amount: ");
            bet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your 6 lucky numbers: ");
            lucky = Console.ReadLine();


            Console.WriteLine("\n ----- DRAW RESULT ----- ");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Amount: {0}", bet);
            Console.WriteLine("Multiplier 4x");
            Console.WriteLine("Prize: " + bet * multiplier);
            Console.WriteLine("Entry No's: {0}", lucky);

            Console.WriteLine(" D R A W R E S U L T");
            Console.WriteLine(random.Next(1, 50) + " " + random.Next(1, 50) + " " + random.Next(1, 50) + " " + random.Next(1, 50) + " " + random.Next(1, 50) + " " + random.Next(1, 50) + " ");

        }
        catch (Exception e)
        {
            Console.WriteLine("Error encountered. " + e.ToString());
        }
        finally
        {
            Console.ReadKey();
        }
    }
}