using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=n ; i++)
            {
                string letter = Console.ReadLine();
                sum += int.Parse(letter);

            }
            Console.WriteLine(sum);
        }
    }
}
