using NewFeatures.Domain;
using System;
using System.Collections.Generic;

namespace NewFeatures.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyables = new List<IFlyable>
            {
                new Plane(),
                new Rock(),
            };

            foreach(IFlyable flyable in flyables )
            {
                Console.WriteLine($"{flyable.GetType()}\n{flyable.TakeOff()}\n{flyable.Fly()}\n{flyable.Land()}\n\n\n");
            }
        }
    }
}
