using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LAB_3_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Cars = new Dictionary<int, string>()
            {
               {1,"Mercedes" },
               {2,"BMW" },
               {3,"Volvo" },
               {4,"Volkswagen" },
               {5,"Renault" },
                {6,"Toyota" }
            };

            File.WriteAllText("Dictionary.json", JsonConvert.SerializeObject(Cars));

            Console.WriteLine("Dictionary:");
            foreach (var auto in Cars)
            {
                Console.WriteLine($"key: {auto.Key} value: {auto.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Введите ключ к словарю наименьшого наименьшого ключа, который будет равен ключу: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int a = Cars.Count;

            if (x > a || x <= 0)
            {
                Console.WriteLine("null");
            }

            if (x > 0 && x <= a)
            {
                Console.WriteLine($"Отриманий ключ: {x}");
            }
        }

    }
}