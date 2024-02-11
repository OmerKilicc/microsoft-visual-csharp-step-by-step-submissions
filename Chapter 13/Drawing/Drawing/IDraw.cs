using Windows.UI.Xaml.Controls;
using System;

namespace Drawing
{
	internal interface IDraw
	{
		void SetLocation(int xCoord, int yCoord);
		void Draw(Canvas canvas);
	}
}
