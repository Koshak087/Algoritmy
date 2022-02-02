using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alg
{
    class Hw1_1
    {
        
        public static void Number(string[] args)
        {
            Console.Write("Введите число: ");
            int N = Int32.Parse(Console.ReadLine());
            int d = 0;
            int i = 2;
            if (i < N)
            {
                if (N % i == 0)
                {
                    d++;
                    i++;
                }
                else
                    i++;
            }
            else
            {
                if (d == 0)
                {

                    Console.WriteLine($"{N} простое число");
                }

                else
                {
                    Console.WriteLine($"{N} не протое число");
                }
            }
            

        }
    }
}
