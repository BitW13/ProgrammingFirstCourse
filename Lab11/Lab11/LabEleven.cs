using System;

namespace Lab11
{
    public static class LabEleven
    {
        public static void Main()
        {
            Console.WriteLine("rows:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(-10, 100);

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                bool isPositive = true;

                for (int j = 0; j < n; j++)
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

                    for (int j = 0; j < n; j++)
                    {
                        result *= array[i, j];
                    }

                    Console.WriteLine($"{i} |----| {result}");
                }
            }
        }
    }
}
