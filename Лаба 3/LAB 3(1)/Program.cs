using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace LAB_3_1
{
    namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> Digits = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };

                Console.WriteLine("Дан список цифр от 1 до 9:");
                foreach (var number in Digits)
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Введите значение Х: ");
                int x = Convert.ToInt32(Console.ReadLine());

                if(x<1 || x > 9)
                {
                    Console.WriteLine("null");
                }

                Digits.Reverse(0, x - 1);
                Digits.Reverse(x, 9 - x);

                Console.WriteLine();
                Console.WriteLine("Сортированный список цифр:");
                foreach (var number in Digits)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
    