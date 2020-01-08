﻿using System;

namespace Lab9
{
    class Program
    {
        static double GetMultiplicationEvenArrayElements(double[] array)
        {
            double result = 1;

            for (int i = 0; i < array.Length; i += 2)
            {
                result *= array[i];
            }

            return result;
        }

        static double GetSumNumbersBetweenZero(double[] array)
        {
            double result = 0;

            int index = Array.IndexOf(array, 0);

            if (index == -1)
            {
                return result;
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    break;
                }

                result += array[i];
            }

            return result;
        }

        static double[] Sort(double[] array)
        {
            for(int i = 0; i< array.Length; i++)
            {
                for(int j = i+1; j<array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("length of array:");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[n];

            Console.WriteLine("Array elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine(GetMultiplicationEvenArrayElements(array));
            Console.WriteLine(GetSumNumbersBetweenZero(array));

            array = Sort(array);

            foreach(double item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
