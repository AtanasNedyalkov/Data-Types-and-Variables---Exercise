using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int litersOfTank = 0;
            for (int i = 0; i <numberOfLines; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                if (capacity>=quantitiesOfWater+litersOfTank)
                {
                    litersOfTank += quantitiesOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litersOfTank);

        }
    }
}
