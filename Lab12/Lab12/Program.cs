using Lab12.Labs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Lab.Lab2();
                        break;
                    case "3.1":
                        Lab.Lab3_1();
                        break;
                    case "3.2":
                        Lab.Lab3_2();
                        break;
                    case "4.1":
                        Lab.Lab4_1();
                        break;
                    case "4.2":
                        Lab.Lab4_2();
                        break;
                    case "5.1":
                        Lab.Lab5_1();
                        break;
                    case "5.2":
                        Lab.Lab5_2();
                        break;
                    case "6.1":
                        Lab.Lab6_1();
                        break;
                    case "6.2":
                        Lab.Lab6_2();
                        break;
                    case "7":
                        Lab.Lab7();
                        break;
                    case "8.1":
                        Lab.Lab8_1();
                        break;
                    case "8.2":
                        Lab.Lab8_2();
                        break;
                    case "9":
                        Lab.Lab9();
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
