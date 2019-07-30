using System;

namespace Algorithms_DataStructure_Lib_Tests
{
	public class ArrayStack<T>
	{
		private T[] _items = null;
		public bool IsEmpty => Count == 0;

		public int Count { get; set; }

		public ArrayStack()
		{
			const int defaultCapacity = 4;
			_items = new T[defaultCapacity];
		}

		public ArrayStack(int capacity)
		{
			_items = new T[capacity];
		}

		public void Push(T v)
		{
			if (_items.Length == Count)
			{
				T[] largerArray = new T[_items.Length * 2];
				Array.Copy(_items, largerArray, _items.Length);
			}

			_items[Count++] = v;
		}

		public void Pop()
		{
			if (IsEmpty)
				throw new NotImplementedException();

			_items[(Count--) - 1] = default(T);
		}

		public T Peek()
		{
			if (IsEmpty)
				throw new NotImplementedException();

			return _items[Count - 1];
		}
	}
}