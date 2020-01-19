using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2
{
    public static class LabElevenTwo
    {
        static int GetNumberOfColumnsContainsZero(int[,] array, int rows, int columns)
        {
            int result = 0;

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (array[i, j] == 0)
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }

        static int GetNumberOfRowContainsMostNumberOfSameValue(int[,] array, int rows, int columns)
        {
            int index = -1;
            int numberForAllRows = 0;

            for (int i = 0; i < rows; i++)
            {
                int value = array[i, 0];
                int number = 0;

                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == value)
                    {
                        number++;
                    }
                    else
                    {
                        if (number > numberForAllRows)
                        {
                            numberForAllRows = number;
                            index = i;
                        }

                        number = 0;
                    }

                    value = array[i, j];
                }
            }

            return index;
        }

        public static void Main()
        {
            Console.WriteLine("n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("m:");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n, m];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-10, 100);

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(GetNumberOfColumnsContainsZero(array, n, m));

            Console.WriteLine(GetNumberOfRowContainsMostNumberOfSameValue(array, n, m));
        }
    }
}
