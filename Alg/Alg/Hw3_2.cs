using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace Alg
{
    struct Hw3_2
    {
        public static void Result(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public struct BechmarkStruct
    {
        [Benchmark]

        public void Rand()
        {
            object[] array = new object[100000];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                //Console.WriteLine(array[i]);
            }
            object get;
            for (int n = 0; n < array.Length; n++)
            {
                object x;
                object y;
                if (n == 0)
                {
                    x = array[n];
                    y = 0;
                    get = Bench(x, y);
                    //Console.WriteLine($"{get}");

                }
                else
                {
                    x = array[n - 1];
                    y = array[n];
                    get = Bench(x, y);
                    //Console.WriteLine($"{get}");

                }

            }

        }
        [Benchmark]
        public void Rand2()
        {
            object[] array = new object[100000];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                //Console.WriteLine(array[i]);
            }
            object get;
            for (int n = 0; n < array.Length; n++)
            {
                object x;
                object y;
                if (n == 0)
                {
                    x = array[n];
                    y = 0;
                    get = Bench(x, y);
                    //Console.WriteLine($"{get}");
                }
                else
                {
                    x = array[n - 1];
                    y = array[n];
                    get = Bench(x, y);
                    //Console.WriteLine($"{get}");

                }
            }
        }
        public object Bench( object X, object Y)
        {
            double x = Convert.ToDouble(X);
            double y = Convert.ToDouble(Y);
            double n = y / x;
            return n;
        }

    }
}

