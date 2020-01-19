using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public static class LabTen
    {
        static int IndexOfNegativeNumber(double[] array, int startIndex)
        {
            int index = -1;

            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        static double GetSumNumbersBetweenNegativeNumbers(double[] array)
        {
            double result = 0;

            int index = IndexOfNegativeNumber(array, 0);

            if (index == -1)
            {
                return result;
            }

            int endIndex = IndexOfNegativeNumber(array, index + 1);

            if (endIndex == -1)
            {
                endIndex = array.Length;
            }

            for (int i = index + 1; i < endIndex; i++)
            {
                result += array[i];
            }

            return result;
        }

        static double[] Sort(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > 1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (Math.Abs(array[j]) <= 1)
                        {
                            double temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;

                            break;
                        }
                    }
                }
            }

            return array;
        }

        static int IndexOfMin(double[] array)
        {
            return Array.IndexOf(array, array.Min());
        }

        public static void Main()
        {
            Console.WriteLine("length of array:");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[n];

            Console.WriteLine("array elements:");

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine(IndexOfMin(array));
            Console.WriteLine(GetSumNumbersBetweenNegativeNumbers(array));

            array = Sort(array);

            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
