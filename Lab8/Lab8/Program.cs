using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
