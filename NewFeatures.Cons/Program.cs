using NewFeatures.Domain;
using System;
using System.Collections.Generic;

namespace NewFeatures.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            #region readonly
            Point point = new Point();
            point.X = 3;
            point.Y = 2;

            // not possible due to member access
            // point.Distance = 5.0; 

            //Console.WriteLine(point);
            #endregion

            #region defaultinterfacemethods
            List<IFlyable> flyables = new List<IFlyable>
            {
                new Plane(),
                new Rock(),
            };

            foreach(IFlyable flyable in flyables )
            {
                Console.WriteLine($"{flyable.GetType()}\n{flyable.TakeOff()}\n{flyable.Fly()}\n{flyable.Land()}\n\n\n");
            }
            #endregion
        }
    }
}
