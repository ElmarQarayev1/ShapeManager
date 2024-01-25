using System;
namespace ShapeManager
{
	public class Rectangle:Shape
	{
		public double width;
		public double height;
        public override double CalculateArea()
        {
            return width * height;
        }
    }
}

