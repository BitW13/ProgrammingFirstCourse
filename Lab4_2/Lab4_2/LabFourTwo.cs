using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public static class LabFourTwo
    {
        public static void Main()
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
    }
}
