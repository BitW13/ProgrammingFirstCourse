using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public static class LabThreeOne
    {
        public static void Main()
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
    }
}
