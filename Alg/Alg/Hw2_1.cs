using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg
{
    class Hw2_1
    {
        public class Node <T>
        {
            public T Value { get; set; }
            public Node<T> NextNode { get; set; }
            public Node<T> PrevNode { get; set; }
            public Node(T value)
            {
                Value = value;   
            }

            public static void Print()
            {
                ILinkedList<int> myList = new ILinkedList<int>();
                myList.Add(10);
                myList.Add(20);
                myList.Add(30);
                myList.Add(40);
                myList.PrintList();
                Console.WriteLine("\t");
                myList.Remove(20);
                myList.AddFirst(150);
                myList.PrintList();
                Console.Write("Колличество элементов в списке: ");
                myList.GetCount();
                Console.WriteLine("Введите индекс эеменета, после которого необоходимо вставить ваше число:");
                int ind = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите ваше чило:");
                int uVal = Int32.Parse(Console.ReadLine());
                myList.Insert(ind, uVal);


            }
        }

        //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
        

    }
}
