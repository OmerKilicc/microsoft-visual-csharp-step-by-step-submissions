using System;

namespace GarbageCollection
{
	class Program
	{
		static void doWork()
		{
			// TODO: Test garbage collection
			using (Calculator calculator = new Calculator())
			{
				Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
			}
			Console.WriteLine("Program finishing");
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

			//GC.Collect();
			//GC.WaitForPendingFinalizers();
		}
	}
}
