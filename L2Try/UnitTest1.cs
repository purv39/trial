using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace L2Try
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test_FindHypotenuseLength1()
		{
			Triangle obj = new Triangle();
			double result = obj.FindHypotenuseLength(3, 4);
			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void Test_FindHypotenuseLength2()
		{
			Triangle obj = new Triangle();
			double result = obj.FindHypotenuseLength(5, 12);
			Assert.AreEqual(13, result);
		}
	}
}
