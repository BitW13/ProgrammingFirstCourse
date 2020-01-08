using System;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x min:");
            double xMin = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x max:");
            double xMax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("dx:");
            double dX = Convert.ToDouble(Console.ReadLine());

            double e = 0.0001;

            for (double x = xMin; x <= xMax; x += dX)
            {
                double sum = 1 / x;
                int n = 1;
                while ((2 * sum).ToString().Length < e.ToString().Length)
                {
                    sum += 1 / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                    n++;
                }

                Console.WriteLine($"{x} ---  {2 * sum} --- {n}");
            }
        }
    }
}
