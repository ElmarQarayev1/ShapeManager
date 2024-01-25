namespace ShapeManager;

class Program
{
    static void Main(string[] args)
    {
       

        Circle circle1 = new Circle()
        {
            radius = 1
        };
        Rectangle rectangle1 = new Rectangle()
        {
            height = 3,
            width = 3
        };
        Circle circle2 = new Circle()
        {
            radius=1
        };
        ShapeManager shapeManager = new ShapeManager();
      
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(circle1);
        shapeManager.AddShape(rectangle1);
        shapeManager.AddShape(circle2);
        Console.WriteLine($"daire sayi : {shapeManager.GetCircleCount()}");
        Console.WriteLine($"dairelerin saheleri cemi: {shapeManager.GetTotalCircleAreas()}");
        Console.WriteLine($"kvadrat sayi: {shapeManager.GetSquareCount()}");
       
        //for (int i = 0; i < shapeManager.GetCircles().Length; i++)
        //{
        //    Circle circle = shapeManager.GetCircles()[i];

        //    Console.WriteLine(circle.radius);
        //}

        Console.ReadLine();
    }

   
    }




