﻿using Algorithms_CSharp_Course;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms_DataStructure_Lib_Tests
{
	internal class LinkedListStack<T>: IEnumerable<T>
	{
		private readonly SinglyLinkedList<T> _items = new SinglyLinkedList<T>();
		
		public bool? IsEmpty => _items.count == 0;
		public int Count => _items.count;

		internal void Push(T v)
		{
			_items.AddFirst(v);
		}

		internal void Pop()
		{
			_items.RemoveFirst();
		}

		internal T Peek()
		{
			return _items.Head.Value;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return _items.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _items.GetEnumerator();
		}
	}
}