using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public static class LabFive
    {
        public static void Main()
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
    }
}
