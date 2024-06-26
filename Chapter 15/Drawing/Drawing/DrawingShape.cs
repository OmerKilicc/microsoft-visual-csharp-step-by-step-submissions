﻿using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Drawing
{
	abstract class DrawingShape
	{
		protected int _size;
		protected Shape shape = null;

		protected int _x = 0;
		public int X { get => this._x; set => this._x = value; }

		protected int _y = 0;
		public int Y { get => this._y; set => this._y = value; }

		public DrawingShape(int size)
		{
			this._size = size;
		}


		public Color color
		{
			set
			{
				if (this.shape is not null)
				{
					SolidColorBrush brush = new SolidColorBrush(value);
					this.shape.Fill = brush;
				}
			}		
		}

		public virtual void Draw(Canvas canvas)
		{
			if (this.shape is null)
			{
				throw new InvalidOperationException("Shape is null");
			}

			this.shape.Height = this._size;
			this.shape.Width = this._size;
			Canvas.SetTop(this.shape, this._y);
			Canvas.SetLeft(this.shape, this._x);
			canvas.Children.Add(this.shape);
		}
	}
}
