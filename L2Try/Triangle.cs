﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Try
{
	class Triangle
	{
		public double FindHypotenuseLength(double a, double b)
		{
			double result = (a * a) + (b * b);

			return Math.Sqrt(result);
			
		}
	}
}
