using System;

class CircleIntersect
{
    static void Main()
    {
        double x1, y1, r1, x2, y2, r2;

        // Get input from user
        Console.Write("Enter center coordinates (x1, y1) of circle 1: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter radius r1 of circle 1: ");
        r1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter center coordinates (x2, y2) of circle 2: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter radius r2 of circle 2: ");
        r2 = Convert.ToDouble(Console.ReadLine());

        // Calculate distance between centers
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        // Check if circles intersect
        if (distance < r1 + r2)
        {
            // Calculate intersection points
            double x = (Math.Pow(r1, 2) - Math.Pow(r2, 2) + Math.Pow(distance, 2)) / (2 * distance);
            double y = Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(x, 2));
            double xcoord1 = x1 + x * (x2 - x1) / distance;
            double ycoord1 = y1 + y * (y2 - y1) / distance;
            double xcoord2 = x1 + x * (x2 - x1) / distance;
            double ycoord2 = y1 - y * (y2 - y1) / distance;

            // Output intersection points
            Console.WriteLine("The circles intersect at the following points:");
            Console.WriteLine("({0}, {1})", xcoord1, ycoord1);
            Console.WriteLine("({0}, {1})", xcoord2, ycoord2);
        }
        else
        {
            Console.WriteLine("The circles do not intersect.");
        }

        Console.ReadLine();
    }
}
