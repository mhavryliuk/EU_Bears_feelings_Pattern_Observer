using System;

// Pattern "Observer": https://metanit.com/sharp/patterns/3.2.php

namespace _20180320_Task1_Pattern_Observer
{
    internal class Program
    {
        private static void Main()
        {
            // Create a publisher.
            Rose Rose = new Rose();

            // Create subscribers.
            Billy Billy = new Billy("Billy", Rose);
            Jack Jack = new Jack("Jack", Rose);

            // Run the event handler method.
            Rose.FlirtEvent();            

            Console.Read();
        }
    }
}