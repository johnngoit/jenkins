using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMvcModule.TestMvcModule.Models;

namespace TestHelloWorld
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Item i = new Item();
			Assert.AreEqual("1", "1");
		}
	}
}
