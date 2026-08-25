using System;

class Program
{
    static void Main()
    {
        int[] intArray = new int[10];
        int sum = 0;

        for (int x = 0; x < intArray.Length; x++)
        {
            Console.Write($"Enter Score {x + 1}: ");
            intArray[x] = Convert.ToInt32(Console.ReadLine());
            sum += intArray[x];
        }

        int ave = sum / intArray.Length;

        string remark;

        if (ave == 1)
        {
            remark = "poor";
        }
        else if (ave == 2)
        {
            remark = "fair";
        }
        else if (ave == 3)
        {
            remark = "good";
        }
        else if (ave == 4)
        {
            remark = "Very good";
        }
        else if (ave == 5)
        {
            remark = "Excellent";
        }
        else
        {
            remark = "out of range";
        }

        Console.WriteLine("\n--- RESULTS ---");
        Console.WriteLine("Scores: " + string.Join(", ", intArray));
        Console.WriteLine("Average score is: " + ave);
        Console.WriteLine("Remark: " + remark);
    }
}