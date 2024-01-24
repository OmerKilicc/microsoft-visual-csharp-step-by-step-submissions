using System;

namespace DailyRate
{
	class Program
	{
		static void Main(string[] args)
		{
			(new Program()).run();
		}

		void run()
		{
			double fee = calculateFee(noOfDays: 4);
			Console.WriteLine($"Fee is {fee}");
		}

		private double calculateFee(double theDailyRate = 500.0, int noOfDays = 1)
		{
			Console.WriteLine("calculateFee using two optional parameters");
			return theDailyRate * noOfDays;
		}

		private double calculateFee(double dailyRate = 500.0)
		{
			Console.WriteLine("calculateFee usin one optional parameter");
			int defaultNoOfDays = 1;
			return dailyRate * defaultNoOfDays;
		}

		private double calculateFee()
		{
			Console.WriteLine("calculateFee using hardcoded parameters");
			int defaultNoOfDays = 1;
			double dailyRate = 400.0;
			return dailyRate * defaultNoOfDays;
		}
	}
}
