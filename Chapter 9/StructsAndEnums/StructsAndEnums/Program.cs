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

			var defaultDate = new Date();
			Console.WriteLine(defaultDate);

			Date anniversary = new Date(2022, Month.April, 5);
			Console.WriteLine(anniversary);

			Date copyAnniversary = anniversary;
			Console.WriteLine(copyAnniversary);
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
