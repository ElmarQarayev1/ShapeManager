using System;
namespace ShapeManager
{
    public  class ShapeManager
    {
         Shape[] shapes = new Shape[0];

        private  const int maxCircle = 10;

        private const int maxRectangle = 10;

        public  int GetCircleCount()
        {
            int count = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    count++;
                }
            }
            return count;
        }

        public  Circle[] GetCircles()
        { 
            Circle[] circle = new Circle[GetCircleCount()];
            int index = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    circle[index++] = (Circle)shapes[i];
                }
            }
            return circle;

        }

        public  double GetTotalCircleAreas()
        {
            double totalArea = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    totalArea += shapes[i].CalculateArea();

                }

            }
            return totalArea;
            
        }

        public  int GetSquareCount()
        {
            int count = 0;
            for (int i = 0; i <shapes.Length; i++)
            {
                if (shapes[i] is Rectangle)
                {
                    Rectangle rect = (Rectangle)shapes[i];

                    if (rect.height == rect.width)
                    {
                        count++;

                    }
                }

            }
            return count;
        }
        public void AddShape(Shape shape)
        {

            if (shapes.Length < maxCircle + maxRectangle)
            {
                if ((shape is Rectangle && GetRectangleCount() < maxRectangle) ||
                    (shape is Circle && GetCircleCount() < maxCircle))
                {
                    Array.Resize(ref shapes, shapes.Length + 1);
                    shapes[shapes.Length - 1] = shape;
                }
                else
                {
                    Console.WriteLine(" Shape'in tipi dogru deyil ve Tipin limiti dolub limit dolub");
                }
            }
            else
            {
                Console.WriteLine("limit dolub");
            }

        }

        public  int GetRectangleCount()
        {
            int count = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Rectangle)
                {
                    count++;
                }
            }
            return count;

        }



    }
}

