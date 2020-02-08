using NewFeatures.Domain;
using System;

namespace NewFeatures.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 3;
            point.Y = 2;

            // not possible due to member access
            // point.Distance = 5.0; 

            Console.WriteLine(point);
        }
    }
}
