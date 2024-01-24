using System;

namespace StructsAndEnums
{
	class Program
	{
		static void doWork()
		{
			// TODO: Test the enumeration
			Month firstMonth = Month.January;
			Console.WriteLine(firstMonth);
		}

		static void Main()
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
