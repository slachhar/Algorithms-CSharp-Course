using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp_Course
{
	public class DoublyLinkedNode<T>
	{
		public DoublyLinkedNode<T> Prev { get; set; }
		public DoublyLinkedNode<T> Next { get; set; }
		public T Value { get; set; }
		public DoublyLinkedNode(T value)
		{
			Value = value;
		}
	}
}
