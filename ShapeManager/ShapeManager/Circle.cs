using System;
namespace ShapeManager
{
	public class Circle:Shape
	{
		public double radius;

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

