using System;

namespace StructsAndEnums
{
	// TODO: Implement Date struct
	struct Date
	{
		private int year;
		private Month month;
		private int day;

		public Date(int yy, Month mm, int dd)
		{
			this.year = yy - 1900;
			this.month = mm;
			this.day = dd - 1;
		}

		public override string ToString()
		{
			string data = $"{this.month} {this.day + 1} {this.year + 1900}";
			return data;
		}

		public void AdvanceMonth()
		{
			this.month++;
			if (this.month == Month.December + 1)
			{
				this.month = Month.January;
				this.year++;
			}
		}
	}
}
