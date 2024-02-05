using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
	internal class Utils
	{
		public static int Sum(params int[] paramList) 
		{
			Console.WriteLine("Usin parameter list");

			if (paramList is null)
				throw new ArgumentNullException("Utils.Sum: null parameter list");

			if (paramList.Length == 0)
				throw new ArgumentException("Utils.Sum: empty parameter list");

			int sumTotal = 0;
			foreach (int param in paramList)
			{
				sumTotal += param;
			}
			return sumTotal;
		}

		public static int Sum(int first = 1, int second = 2, int third = 3, int fourth = 4)
		{
			Console.WriteLine("Usin optional parameters list");

			int sumTotal = first + second + third + fourth;
			return sumTotal;
		}
	}
}
