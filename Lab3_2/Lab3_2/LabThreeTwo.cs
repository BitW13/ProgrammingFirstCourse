using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public static class LabThreeTwo
    {
        public static void Main()
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
    }
}
