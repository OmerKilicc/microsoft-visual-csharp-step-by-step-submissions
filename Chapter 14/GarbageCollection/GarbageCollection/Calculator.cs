using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
	internal class Calculator : IDisposable
	{
		private bool isDisposed = false;
		public Calculator() 
		{
			Console.WriteLine("Calculator being created");
		}

		~Calculator() 
		{
			Console.WriteLine("Calculator being finalized");
			this.Dispose();
		}

		public void Dispose()
		{
			if(!this.isDisposed)
				Console.WriteLine("Calculator being disposed");
		
			this.isDisposed = true;
			GC.SuppressFinalize(this);

		}

		public int Divide(int first, int second)
		{
			return first / second;
		}
	}
}
