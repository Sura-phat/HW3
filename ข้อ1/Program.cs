using System;

class Program
{
    static void Main(string[] args)
    {
        double x1, y1, x2, y2, x3, y3;

        // get input from user
        Console.Write("Enter coordinates of first point on the circle: ");
        string[] point1 = Console.ReadLine().Split(' ');
        x1 = double.Parse(point1[0]);
        y1 = double.Parse(point1[1]);

        Console.Write("Enter coordinates of second point on the circle: ");
        string[] point2 = Console.ReadLine().Split(' ');
        x2 = double.Parse(point2[0]);
        y2 = double.Parse(point2[1]);

        Console.Write("Enter coordinates of third point on the circle: ");
        string[] point3 = Console.ReadLine().Split(' ');
        x3 = double.Parse(point3[0]);
        y3 = double.Parse(point3[1]);

        // calculate center of the circle
        double x = ((y2 - y1) * (y3 * y3 - y1 * y1 + x3 * x3 - x1 * x1) - (y3 - y1) * (y2 * y2 - y1 * y1 + x2 * x2 - x1 * x1)) / (2 * (y3 - y1) * (x2 - x1) - 2 * (y2 - y1) * (x3 - x1));
        double y = ((x2 - x1) * (x3 * x3 - x1 * x1 + y3 * y3 - y1 * y1) - (x3 - x1) * (x2 * x2 - x1 * x1 + y2 * y2 - y1 * y1)) / (2 * (x3 - x1) * (y2 - y1) - 2 * (x2 - x1) * (y3 - y1));

        // calculate radius of the circle
        double radius = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1) );

        // display center and radius of the circle
        Console.WriteLine("Center point of the circle: ({0}, {1})", x, y);
        Console.WriteLine("Radius of the circle: {0}", radius);
    }
}
