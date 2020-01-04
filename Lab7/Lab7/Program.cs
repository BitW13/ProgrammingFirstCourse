using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1;

            const double E = 0.0001;

            int i = 1;

            while(sum.ToString().Length < E.ToString().Length)
            {
                sum += 1 / (Math.Pow(2, i));

                i++;
            }

            Console.WriteLine(sum);
        }
    }
}
