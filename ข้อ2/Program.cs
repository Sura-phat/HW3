using System;
using System.Collections.Generic;

class Program
{
    static bool IsPointInPolygon((double, double) point, List<(double, double)> polygon)
    {
        // implementation of ray casting algorithm
        // returns true if the point is inside the polygon, false otherwise
        double x = point.Item1;
        double y = point.Item2;
        bool inside = false;
        for (int i = 0, j = polygon.Count - 1; i < polygon.Count; j = i++)
        {
            if (((polygon[i].Item2 > y) != (polygon[j].Item2 > y)) &&
                (x < (polygon[j].Item1 - polygon[i].Item1) * (y - polygon[i].Item2) / (polygon[j].Item2 - polygon[i].Item2) + polygon[i].Item1))
            {
                inside = !inside;
            }
        }
        return inside;
    }

    static void Main(string[] args)
    {
        List<(double, double)> polygon = new List<(double, double)>();
        while (true)
        {
            Console.Write("Enter vertex coordinates (x y): ");
            string[] input = Console.ReadLine().Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            if (x == 0 && y == 0)
            {
                break;
            }
            polygon.Add((x, y));
        }

        if (polygon.Count < 3)
        {
            Console.WriteLine("Error: Polygon must have at least 3 vertices.");
        }
        else
        {
            Console.WriteLine("Polygon vertices:");
            foreach ((double, double) vertex in polygon)
            {
                Console.WriteLine(vertex);
            }

            while (true)
            {
                Console.Write("Enter point coordinates (x y): ");
                string[] input = Console.ReadLine().Split();
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                if (x != 0 || y != 0)
                {
                    if (IsPointInPolygon((x, y), polygon))
                    {
                        Console.WriteLine("The point is inside the polygon.");
                    }
                    else
                    {
                        Console.WriteLine("The point is outside the polygon.");
                    }
                    break;
                }
            }
        }
    }
}
