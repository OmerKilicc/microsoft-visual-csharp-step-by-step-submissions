﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
	internal class Car : Vehicle
	{
		public void Accelerate() => Console.WriteLine("Accelerating");
		public void Breake() => Console.WriteLine("Braking");
		public override void Drive() => Console.WriteLine("Motoring");

	}
}
