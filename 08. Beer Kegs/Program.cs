using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string kegModel = String.Empty;
            double volumeOfKeg = 0;
            for (int i = 0; i < numberOfKegs; i++)
            {


                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume>volumeOfKeg)
                {
                    volumeOfKeg = volume;
                    kegModel = model;
                }
            }
            Console.WriteLine(kegModel);
        }
    }
}
