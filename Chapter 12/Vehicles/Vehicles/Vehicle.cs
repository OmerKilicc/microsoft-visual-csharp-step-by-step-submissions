using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
	internal class Vehicle
	{
		public void StartEngine(string noiseToMakeWhenStarting) => Console.WriteLine($"Starting engine: {noiseToMakeWhenStarting}");
		public void StopEngine(string noiseToMakeWhenStopping) => Console.WriteLine($"Starting engine: {noiseToMakeWhenStopping}");

		public virtual void Drive() => Console.WriteLine("Default implementation of the Drive method");
	}
}
