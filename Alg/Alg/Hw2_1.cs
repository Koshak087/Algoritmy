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
            public static Node<T> Print ()
            {
                ILinkedList.Add(10);

            }
        }

        //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
        

    }
}
