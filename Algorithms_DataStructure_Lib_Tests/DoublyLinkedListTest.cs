using Algorithms_CSharp_Course;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStructure_Lib_Tests
{
	[TestFixture]
    public class DoublyLinkedListTest
    {
		DoublyLinkedList<int> _list = null;
		[SetUp]
		public void Init()
		{
			_list = new DoublyLinkedList<int>();
		}

		[Test]
		public void EmptyList_EmptyState()
		{
			Assert.IsTrue(_list.IsEmpty);
		}

		[Test]
		public void AddFirst_CorrectState()
		{
			_list.AddFirst(3);
			_list.AddFirst(2);
			_list.AddFirst(1);
			Assert.AreEqual(1, _list.Head.Value);
			Assert.AreEqual(3, _list.Tail.Value);
		}

		[Test]
		public void AddLast_CorrectState()
		{
			_list.AddLast(1);
			_list.AddLast(2);
			_list.AddLast(3);
			Assert.AreEqual(1, _list.Head.Value);
			Assert.AreEqual(3, _list.Tail.Value);
		}

		[Test]
		public void RemoveFirst_Last_Nth_CorrectState()
		{
			_list.AddFirst(3);
			_list.AddFirst(2);
			_list.AddFirst(1);
			_list.AddLast(4);
			_list.AddLast(5);
			_list.AddLast(6);
			_list.RemoveFirst();
			_list.RemoveLast();
			_list.RemoveNthElement(3);
			_list.RemoveNthElement(3);
			Assert.AreEqual(2, _list.Head.Value);
			Assert.AreEqual(3, _list.Tail.Value);
		}
	}
}
