using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("columns:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, m];

            Console.WriteLine("array elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                bool isPositive = true;

                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0)
                    {
                        isPositive = false;
                        break;
                    }
                }

                if (isPositive)
                {
                    int result = 1;

                    for (int j = 0; j < m; j++)
                    {
                        result *= array[i, j];
                    }

                    Console.WriteLine($"{i} |----| {result}");
                }
            }
        }
    }
}
