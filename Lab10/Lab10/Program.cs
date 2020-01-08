using System;
using System.Linq;

namespace Lab10
{
    class Program
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
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i]) > Math.Abs(array[j]))
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        static int IndexOfMin(double[] array)
        {
            return Array.IndexOf(array, array.Min());
        }

        static void Main(string[] args)
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
