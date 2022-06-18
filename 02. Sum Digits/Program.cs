using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfChars = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numOfChars; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += symbol;
                
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
