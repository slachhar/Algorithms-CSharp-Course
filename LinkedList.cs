using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp_Course
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int count { get; set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> Node)
        {
            if (count == 0)
            {
                Head = Node;
                Tail = Head;
            }
            else
            {
                Node<T> temp = Head;
                Head = Node;
                Head.Next = temp;
            }
            count++;
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> Node)
        {
            if (count == 0)
            {
                Head = Node;
                Tail = Node;
            }
            else
            {
                Tail.Next = Node;
                Tail = Node;
            }

            count++;
        }

        public void RemoveFirst()
        {
            if (count == 0)
                throw new InvalidOperationException();

            if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
            }
            count--;
        }

        public void RemoveLast()
        {
            if (count == 0) throw new InvalidOperationException();
            if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                Tail = current;
                Tail.Next = null;
            }
            count--;
        }

        public void RemoveNthElement(int n)
        {
            if (count == 0) throw new InvalidOperationException();
            if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Node<T> nodeN1 = Head;
                Node<T> nodeN2 = null;

                for (int i = 1; i < n - 1; i++)
                {
                    nodeN1 = nodeN1.Next;
                }

                nodeN2 = ((nodeN1.Next).Next);
                nodeN1.Next = nodeN2;
            }
            count--;
        }
    }
}
