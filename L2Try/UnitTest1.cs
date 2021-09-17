using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace L2Try
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Test_HypotenuseLength1()
		{
			Triangle obj = new Triangle();
			double result = obj.FindHypotenuseLength(3, 4);
			Assert.AreEqual(5, result);
		}
	}
}
