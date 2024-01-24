using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Point
	{
		private int x, y;
		private static int objectCount = 0;
		public static int ObjectCount() => objectCount;
		public Point()
		{
			this.x = -1;
			this.y = -1;
			objectCount++;
		}
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
			objectCount++;
		}

		public double DistanceTo(Point other)
		{
			int xDiff = this.x - other.x;
			int yDiff = this.y - other.y;
			double distance = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
			return distance;
		}
	}
}
