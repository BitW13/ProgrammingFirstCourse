using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.Labs
{
    public static class Lab
    {
        public static void Lab2()
        {
            int first = 0;
            int second = 0;
            int third = 0;
            string firststr = "";
            string secondstr = "";
            string thirdstr = "";
            bool isFirstInt = false;
            bool isSecondInt = false;
            bool isThirdInt = false;

            while (isFirstInt && isSecondInt && isThirdInt)
            {
                Console.WriteLine("Введите числа");

                firststr = Console.ReadLine();
                secondstr = Console.ReadLine();
                thirdstr = Console.ReadLine();

                isFirstInt = Int32.TryParse(firststr, out first);
                isSecondInt = Int32.TryParse(secondstr, out second);
                isThirdInt = Int32.TryParse(thirdstr, out third);

            }

            int sum = first + second + third;

            Console.WriteLine("Сумма: " + first + "+" + second + "+" + third + "=" + sum);
            Console.ReadKey();
        }

        public static void Lab3_1()
        {
            double A = InputNum("Введите Х");
            double B = InputNum("Введите Y");

            if (A > B)
            {
                double C = A;
                A = B;
                B = C;
            }

            Console.WriteLine($"A = {A}, B = {B}");

            double InputNum(string text)
            {
                bool bNumIsCorrect = false;
                double ReturnValue = 0.0;
                do
                {
                    Console.WriteLine(text);
                    bNumIsCorrect = double.TryParse(Console.ReadLine(), out ReturnValue);
                }
                while (!bNumIsCorrect);

                return ReturnValue;
            }

            Console.ReadKey();
        }

        public static void Lab3_2()
        {
            int nNum = 3;
            int sum = 0;
            List<int> nums = new List<int>();

            for (int i = 0; i < nNum; i++)
            {
                nums.Add(InputNum());
            }

            Console.Write("Сумма чисел: ");

            for (int i = 0; i < nNum; i++)
            {
                Console.Write(nums[i] + " + ");
                sum += nums[i];
            }

            Console.Write("\b\b= " + sum);

            int InputNum()
            {
                bool bNumIsCorrect = false;
                int ReturnValueInt = 0;
                do
                {
                    Console.WriteLine("Введите число");
                    bNumIsCorrect = Int32.TryParse(Console.ReadLine(), out ReturnValueInt);
                }
                while (!bNumIsCorrect);

                return ReturnValueInt;
            }

            Console.ReadKey();
        }

        public static void Lab4_1()
        {
            byte numofchannel = InputNum("Введите номер канала");

            switch (numofchannel)
            {
                case 1: Console.WriteLine("Канал ОНТ \nПопулярные передачи: Новости, Прогноз погоды, Итоги недели"); break;
                case 2: Console.WriteLine("Канал Беларусь 1 \nПопулярные передачи: Новости, Прогноз погоды, Новости региона"); break;
                case 3: Console.WriteLine("Канал Беларусь 2 \nПопулярные передачи: Новости, Прогноз погоды, Телебарометр"); break;
                case 4: Console.WriteLine("Канал Беларусь 3 \nПопулярные передачи: Новости, Прогноз погоды, Новости спорта"); break;
                case 5: Console.WriteLine("Канал СТВ \nПопулярные передачи: Новости, Прогноз погоды, Новости спорта"); break;
                default: Console.WriteLine("Указанного канала не существует"); break;
            }

            byte InputNum(string text)
            {
                bool bNumIsCorrect = false;
                byte ReturnValue = 0;
                do
                {
                    Console.WriteLine(text);
                    bNumIsCorrect = Byte.TryParse(Console.ReadLine(), out ReturnValue);
                }
                while (!bNumIsCorrect);

                return ReturnValue;
            }

            Console.ReadKey();
        }

        public static void Lab4_2()
        {
            double x = InputNum("Введите x");
            double y = InputNum("Введите y");
            double z = 0.0;

            if (y != 0 && Math.Abs(x) > Math.Abs(y))
            {
                z = Math.Atan(x / y);
            }
            else
            if (y != 0 && Math.Abs(x) <= Math.Abs(y))
            {
                z = Math.Asin(x / y);
            }
            else
            {
                z = 0;
            }

            double InputNum(string text)
            {
                bool bNumIsCorrect = false;
                double ReturnValue = 0.0;
                do
                {
                    Console.WriteLine(text);
                    bNumIsCorrect = double.TryParse(Console.ReadLine(), out ReturnValue);
                }
                while (!bNumIsCorrect);

                return ReturnValue;
            }

            Console.WriteLine(z);
            Console.ReadKey();
        }

        public static void Lab5_1()
        {
            byte numofchannel = InputNum("Введите номер канала");

            switch (numofchannel)
            {
                case 1: Console.WriteLine("Канал ОНТ \nПопулярные передачи: Новости, Прогноз погоды, Итоги недели"); break;
                case 2: Console.WriteLine("Канал Беларусь 1 \nПопулярные передачи: Новости, Прогноз погоды, Новости региона"); break;
                case 3: Console.WriteLine("Канал Беларусь 2 \nПопулярные передачи: Новости, Прогноз погоды, Телебарометр"); break;
                case 4: Console.WriteLine("Канал Беларусь 3 \nПопулярные передачи: Новости, Прогноз погоды, Новости спорта"); break;
                case 5: Console.WriteLine("Канал СТВ \nПопулярные передачи: Новости, Прогноз погоды, Новости спорта"); break;
                default: Console.WriteLine("Указанного канала не существует"); break;
            }

            byte InputNum(string text)
            {
                bool bNumIsCorrect = false;
                byte ReturnValue = 0;
                do
                {
                    Console.WriteLine(text);
                    bNumIsCorrect = Byte.TryParse(Console.ReadLine(), out ReturnValue);
                }
                while (!bNumIsCorrect);

                return ReturnValue;
            }

            Console.ReadKey();
        }

        public static void Lab5_2()
        {
            int min = InputNum("Введите количество минут");
            double quater = (double)min / 15;
            int num = 0;

            if (0 < quater && quater < 1) num = 1;
            else if (quater > 1 && quater < 2) num = 2;
            else if (quater > 2 && quater < 3) num = 3;
            else num = 4;

            switch (num)
            {
                case 1: Console.WriteLine("Это первая четверть часа"); break;
                case 2: Console.WriteLine("Это вторая четверть часа"); break;
                case 3: Console.WriteLine("Это третья четверть часа"); break;
                case 4: Console.WriteLine("Это четвертая четверть часа"); break;
                default: Console.WriteLine("Введены некорректные данные"); break;
            }

            int InputNum(string text)
            {
                bool bNumIsCorrect = false;
                int ReturnValue = 0;
                do
                {
                    Console.WriteLine(text);
                    bNumIsCorrect = Int32.TryParse(Console.ReadLine(), out ReturnValue);
                }
                while (!bNumIsCorrect);

                return ReturnValue;
            }

            Console.ReadKey();
        }

        public static void Lab6_1()
        {
            int n = InputNum("Введите число n");
            double sum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int fac = 1;

                for (int g = 1; g <= n; g++)
                {
                    fac *= g;
                }

                sum = Math.Pow(i, 2) / fac;
                sum += sum;
                //Console.WriteLine(sum);
            }

            Console.WriteLine("Сумма равна " + sum);

            int InputNum(string text)
            {
                bool bNumIsCorrect = false;
                int ReturnValue = 0;
                do
                {
                    Console.WriteLine(text);
                    bNumIsCorrect = Int32.TryParse(Console.ReadLine(), out ReturnValue);
                }
                while (!bNumIsCorrect);

                return ReturnValue;
            }

            Console.ReadKey();
        }

        public static void Lab6_2()
        {
            int n = InputNum("Введите число n");
            double sum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int fac = 1;

                for (int g = 1; g <= n; g++)
                {
                    fac *= g;
                }

                sum = Math.Pow(i, 2) / fac;
                sum += sum;
            }

            Console.WriteLine("Сумма равна " + sum);

            int InputNum(string text)
            {
                bool bNumIsCorrect = false;
                int ReturnValue = 0;
                do
                {
                    Console.WriteLine(text);
                    bNumIsCorrect = Int32.TryParse(Console.ReadLine(), out ReturnValue);
                }
                while (!bNumIsCorrect);

                return ReturnValue;
            }

            Console.ReadKey();
        }

        public static void Lab7()
        {
            double sum = 1;

            const double E = 0.0001;

            int i = 1;

            while (sum.ToString().Length < E.ToString().Length)
            {
                sum += 1 / (Math.Pow(2, i));

                i++;
            }

            Console.WriteLine(sum);
        }

        public static void Lab8_1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(1);
                }
                Console.WriteLine();
            }
        }

        public static void Lab8_2()
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

        public static void Lab9()
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

            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
        }

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
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public static void Lab10()
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
            Console.WriteLine(array.Min());
            Console.WriteLine(GetSumNumbersBetweenNegativeNumbers(array));

            array = SortByAbs(array);

            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
        }

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

        static double[] SortByAbs(double[] array)
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

        public static void Lab11_1()
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

        public static void Lab11_2()
        {
            Console.WriteLine("n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("m:");
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

            Console.WriteLine(GetNumberOfRowContainsZero(array, n, m));

            Console.WriteLine(GetNumberOfRowContainsMostNumberOfSameValue(array, n, m));
        }

        static int GetNumberOfRowContainsZero(int[,] array, int rows, int columns)
        {
            int result = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
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
    }
}
