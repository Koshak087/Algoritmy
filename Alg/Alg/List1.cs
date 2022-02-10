using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alg.Hw2_1;

namespace Alg
{
    internal class ILinkedList<T>
    {

        Node<T> head { get; set; } // головной/первый элемент
        Node<T> tail { get; set; } // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);

            if (head == null)
                head = node;
            else
            {
                tail.NextNode = node;
                node.PrevNode = tail;
            }
            tail = node;
            count++;
        }
        public void Insert(int index, T value)
        {
            Node<T> node = head;
            int i = 0;
            if (index > count || index < 0)
                Console.WriteLine("Некорректное значение индекса.");
            else
            {
                do
                {
                    node = node.NextNode;
                    i++;
                }
                while (i < index);
                node.NextNode = Add(value);
                count++;
            }
               
        }
        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            Node<T> temp = head;
            node.NextNode = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.PrevNode = node;
            count++;
        }
        // удаление
        public bool Remove(T value)
        {
            Node<T> current = head;

            // поиск удаляемого узла
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    break;
                }
                current = current.NextNode;
            }
            if (current != null)
            {
                // если узел не последний
                if (current.NextNode != null)
                {
                    current.NextNode.PrevNode = current.PrevNode;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = current.PrevNode;
                }

                // если узел не первый
                if (current.PrevNode != null)
                {
                    current.PrevNode.NextNode = current.NextNode;
                }
                else
                {
                    // если первый, переустанавливаем head
                    head = current.NextNode;
                }
                count--;
                return true;
            }
            return false;
        }

            public void GetCount()
        {
            Console.WriteLine($"'{count}' - колличество элементов в списке");
        }
            
            public bool IsEmpty { get { return count == 0; } }

            public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }

            public bool Contains(T value)
            {
                Node<T> current = head;
                while (current != null)
                {
                    if (current.Value.Equals(value))
                        return true;
                    current = current.NextNode;
                }
                return false;
            }
        public void PrintList()
        {
            Node<T> currentNode = head;
            do
            {
                Console.WriteLine($"{currentNode.Value}\t");
                currentNode = currentNode.NextNode;
            }
            while (currentNode.NextNode != null);
            
            Console.WriteLine($"{currentNode.Value}\t");
        
            }
        }
        

            
     }