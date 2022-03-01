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
            double[] array = new double[100000];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                //Console.WriteLine(array[i]);
            }
            double get;
            for (int n = 0; n < array.Length; n++)
            {
                double x;
                double y;
                if (n == 0)
                {
                    x = array[n];
                    y = 0;
                    get = Bench(ref x, ref y);
                    //Console.WriteLine($"{get}");

                }
                else
                {
                    x = array[n - 1];
                    y = array[n];
                    get = Bench(ref x, ref y);
                    //Console.WriteLine($"{get}");

                }

            }

        }
        [Benchmark]
        public void Rand2()
        {
            double[] array = new double[100000];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                //Console.WriteLine(array[i]);
            }
            double get;
            for (int n = 0; n < array.Length; n++)
            {
                double x;
                double y;
                if (n == 0)
                {
                    x = array[n];
                    y = 0;
                    get = Bench(ref x, ref y);
                    //Console.WriteLine($"{get}");
                }
                else
                {
                    x = array[n - 1];
                    y = array[n];
                    get = Bench(ref x, ref y);
                    //Console.WriteLine($"{get}");

                }
            }
        }
        public double Bench(ref double X, ref double Y)
        {
            double n = Y / X;
            return n;
        }

    }
}

