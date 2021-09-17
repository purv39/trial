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


		[TestMethod]
		public void TestArea1()
		{
			Triangle obj = new Triangle();
			double result = obj.FindArea(3, 4);
			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void TestArea2()
		{
			Triangle obj = new Triangle();
			double result = obj.FindArea(5, 12);
			Assert.AreEqual(30, result);
		}


		[TestMethod]
		public void Test_FindMissingAngle1()
		{
			Triangle obj = new Triangle();
			double result = obj.FindMissingAngle(30, 80);
			Assert.AreEqual(70, result);
		}

		[TestMethod]
		public void Test_FindMissingAngle2()
		{
			Triangle obj = new Triangle();
			double result = obj.FindMissingAngle(40, 120);
			Assert.AreEqual(20, result);
		}
	}
}
