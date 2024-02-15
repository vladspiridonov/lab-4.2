using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int Pos = 0;
            int Neg = 0;
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i > 0)
                {
                    Pos++;
                }
                else
                {
                    if (i == 0)
                    {
                        break;
                    }
                    Neg++;
                }
            } while (i != 0);
            int Diff = Pos - Neg;
            if ((Pos == 0) && (Neg == 0))
            {
                Console.WriteLine("Числа не введены");
            }
            else
            {
                if (Diff > 0)
                {
                    Console.WriteLine("Больше положительных");
                }
                else
                {
                    if (Diff == 0)
                    {
                        Console.WriteLine("Кол-во одинаково");
                    }
                    else
                    {
                        Console.WriteLine("Больше отрицательных");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
