using Lab10;
using Lab11;
using Lab11_2;
using Lab12.Labs;
using Lab2;
using Lab3_1;
using Lab3_2;
using Lab4_1;
using Lab4_2;
using Lab5;
using Lab5_2;
using Lab6;
using Lab6_2;
using Lab7;
using Lab8;
using Lab8_2;
using Lab9;
using System;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool next = true;

            while (next)
            {
                Console.WriteLine("Введите номер лабораторной  (введите 'exit' для выхода):");

                string key = Console.ReadLine();

                switch (key)
                {
                    case "2":
                        LabTwo.Main();
                        break;
                    case "3.1":
                        LabThreeOne.Main();
                        break;
                    case "3.2":
                        LabThreeTwo.Main();
                        break;
                    case "4.1":
                        LabFour.Main();
                        break;
                    case "4.2":
                        LabFourTwo.Main();
                        break;
                    case "5.1":
                        LabFive.Main();
                        break;
                    case "5.2":
                        LabFiveTwo.Main();
                        break;
                    case "6.1":
                        LabSix.Main();
                        break;
                    case "6.2":
                        LabSixTwo.Main();
                        break;
                    case "7":
                        LabSeven.Main();
                        break;
                    case "8.1":
                        LabEight.Main();
                        break;
                    case "8.2":
                        LabEightTwo.Main();
                        break;
                    case "9":
                        LabNine.Main();
                        break;
                    case "10":
                        LabTen.Main();
                        break;
                    case "11.1":
                        LabEleven.Main();
                        break;
                    case "11.2":
                        LabElevenTwo.Main();
                        break;
                    case "exit":
                        next = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод!");
                        break;
                }
            }
        }
    }
}
