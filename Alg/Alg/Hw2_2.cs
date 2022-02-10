using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    class Hw2_2
    {
        public static void search()
        {
            Console.Write("Введите от 1 до 10: ");

            int [] put = new int[Int32.Parse(Console.ReadLine())];
            
            Console.Write("Введите искомое значение: ");
            int val = Int32.Parse(Console.ReadLine());
            BinarySearch(put, val);

        }
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
