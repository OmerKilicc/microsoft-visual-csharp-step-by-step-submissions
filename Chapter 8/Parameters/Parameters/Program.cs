﻿using System;

namespace Parameters
{
	class Program
	{
		static void doWork()
		{
			
			int i = 0;
			Console.WriteLine($"Value of i is : {i}");
			Pass.Value(ref i);
			Console.WriteLine($"Value of i is : {i}");
			

			WrappedInt wi = new WrappedInt();
			Console.WriteLine(wi.Number);
			Pass.Reference(wi);
			Console.WriteLine(wi.Number);
		}

		static void Main(string[] args)
		{
			try
			{
				doWork();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
