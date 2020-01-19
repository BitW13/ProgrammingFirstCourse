using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public static class LabFiveTwo
    {
        public static void Main()
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
    }
}
