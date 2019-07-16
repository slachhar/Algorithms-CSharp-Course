using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp_Course
{
	public class DoublyLinkedList<T>
	{
		public DoublyLinkedNode<T> Head { get; set; }
		public DoublyLinkedNode<T> Tail { get; set; }
		public int Count { get; set; }
		public bool IsEmpty => Count == 0;
		public void AddFirst(T value)
		{
			AddFirst(new DoublyLinkedNode<T>(value));
		}

		private void AddFirst(DoublyLinkedNode<T> node)
		{
			if (IsEmpty)
			{
				Head = node;
				Tail = node;
			}
			else
			{
				Head.Prev = node;
				DoublyLinkedNode<T> temp = Head;
				Head = node;
				Head.Next = temp;
			}
			Count++;
		}

		public void AddLast(T value)
		{
			AddLast(new DoublyLinkedNode<T>(value));
		}

		private void AddLast(DoublyLinkedNode<T> node)
		{
			if (IsEmpty)
			{
				Head = node;
				Tail = node;
			}
			else
			{
				DoublyLinkedNode<T> temp = Tail;
				Tail.Next = node;
				Tail = node;
				Tail.Prev = temp;
			}
			Count++;
		}

		public void RemoveFirst()
		{
			if (IsEmpty)
			{
				throw new InvalidOperationException();
			}

			if (Count == 1)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Head = Head.Next;
				Head.Prev = null;
			}
			Count--;
		}

		public void RemoveLast()
		{
			if (IsEmpty)
				throw new InvalidOperationException();

			if (Count == 1)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Tail = Tail.Prev;
				Tail.Next = null;
			}
			Count--;
		}

		public void RemoveNthElement(int n)
		{
			if (IsEmpty)
				throw new InvalidOperationException();

			if (Count == 1)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				if (n == 1)
				{
					RemoveFirst();
				}
				else if (n == Count)
				{
					RemoveLast();
				}
				else {
					DoublyLinkedNode<T> current = Head;
					DoublyLinkedNode<T> currentNext = null;

					for (int i = 1; i < n - 1; i++)
					{
						current = current.Next;
					}

					current.Next = current.Next.Next;
					currentNext = current.Next;
					currentNext.Prev = current;
				}
			}
			Count--;
		}
	}
}
