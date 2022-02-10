using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alg
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            do
            {
                Console.Write("Введите число номер задания (для задания 1 первого урока исп 1_1 и т.д., для выхода введите 'exit'): ");
                n = Console.ReadLine();
                switch (n)
                {
                    case "1_1":
                        Hw1_1.Number(null);
                        break;
                    case "1_3":
                        Hw1_3.Fib(null);
                        break;
                    case "2_1":
                        Hw2_1.Node<T>.(null);
                        break;
                        
                }
            }
            while (n == "exit");
            
        }

    }
}
