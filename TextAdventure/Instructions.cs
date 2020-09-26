using System;
using System.Threading;

namespace TextAdventure
{
    public class Instructions
    {
        public Instructions()
        {
            
        }

        public static void Rides()
        {
            Console.WriteLine();
            Console.WriteLine("Here are the list of available rides");
            Console.WriteLine("     1. Teacup Ride");
            Console.WriteLine("     2. Ferris Wheel");
            Console.WriteLine("     3. Merry-Go-Round");
            Console.WriteLine("     4. Bumper Boats");
            Console.WriteLine("     5. Roller Coaster");
            Console.WriteLine("     6. Drop Tower");
            Console.WriteLine();
            Thread.Sleep(1000);
        }


    }
}
