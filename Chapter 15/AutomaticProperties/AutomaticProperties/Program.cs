using System;

namespace AutomaticProperties
{
	class Program
	{
		static void doWork()
		{
			// TODO:
			Polygon square = new Polygon();
			//Default constructor normalde numSides a 4 değerini atıyor biz burda onu 3 yap öyle ata demiiş oluyorz
			Polygon triangle = new Polygon { NumSides = 3 };
			Polygon pentagon = new Polygon { SideLength = 15.5, NumSides = 5 };

			Console.WriteLine($"Square: number of side is {square.NumSides}, length of the each side is {square.SideLength}");
			Console.WriteLine($"Triangle: number of side is {triangle.NumSides}, length of the each side is {triangle.SideLength}");
			Console.WriteLine($"Pentagon: number of side is {pentagon.NumSides}, length of the each side is {pentagon.SideLength}");

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
