using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                      System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            char N;



            bool f;


            int a;


            do
            {
                do
                {
                    Console.WriteLine("Ввести N= ");
                    f = char.TryParse(Console.ReadLine(), out N);
                    if (!f)
                    {
                        Console.WriteLine("Помилка введіть ще раз");
                    }
                } while (!f);
                a = (int)N - 32;
                Console.WriteLine((char)a);
            } while (N != '.');



            Console.ReadKey();
        }
    }
}

