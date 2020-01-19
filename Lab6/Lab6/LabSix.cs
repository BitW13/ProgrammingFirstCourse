using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class LabSix
    {
        public static void Main()
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
    }
}
