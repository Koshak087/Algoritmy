using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    class Hw1_3
    {
        public static void Fib(string[] args)
        {
            Console.Write("Выберете метод рекурсия(1) или метод(2): ");
            int N = Int32.Parse(Console.ReadLine());
            switch (N)
            {
                case 1:

                    Console.Write("Введите номер члена последовательности Фибоначи: ");
                    int n = Int32.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Недопустимое значение.");
                        break;
                    }
                    else
                    {
                        int fib = Fibonachi2(n);
                        Console.WriteLine($"{n} число Фибоначи = {fib}");
                        break;
                    }

                case 2:

                    Console.Write("Введите номер члена последовательности Фибоначи: ");
                    int m = Int32.Parse(Console.ReadLine());
                    if (m < 0)
                    {
                        Console.WriteLine("Недопустимое значение.");
                        break;
                    }
                    else
                    {
                        int fib2 = Fibonachi2(m);
                        Console.WriteLine($"{m} число Фибоначи = {fib2}");
                        break;
                    }
            }
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            else { return Fibonachi(n - 1) + Fibonachi(n - 2); }
        }

        static int Fibonachi2(int n)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }

            return result;
        }

    }
}
