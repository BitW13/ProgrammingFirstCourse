using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class LabTwo
    {
        public static void Main()
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
    }
}
