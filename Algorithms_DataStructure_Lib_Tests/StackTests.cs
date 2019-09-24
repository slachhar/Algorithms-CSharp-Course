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
	public class StackTests
	{
		[Test]
		public void IsEmpty_EmptyStack_ReturnsTrue()
		{
			var stack = new ArrayStack<int>();
			Assert.IsTrue(stack.IsEmpty);
		}
		[Test]
		public void Count_PushOneItem_ReturnsOne()
		{
			var stack = new ArrayStack<int>();
			stack.Push(1);
			Assert.AreEqual(1, stack.Count);
			Assert.IsFalse(stack.IsEmpty);
		}
		[Test]
		public void Peek_PushTwoItemsAndPop_ReturnsHeadElement()
		{
			var stack = new ArrayStack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Pop();
			Assert.AreEqual(1, stack.Peek());
		}		
	}
}
