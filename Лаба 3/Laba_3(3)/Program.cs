using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Digits = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            Console.WriteLine("Чисельный ряд:");
            foreach (int digit in Digits)
            Console.Write(" "+digit);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ряд сортированных чисел:");
            var sortedDigits = from p in Digits where p <= 15 && p >= 5 orderby p select p;


            foreach (int sortedDigit in sortedDigits)

                Console.Write(" "+sortedDigit);

            Console.WriteLine();

            double midvalue = sortedDigits.Average();
            Console.WriteLine("Среднее значение: " + midvalue);

        }
    }
}
