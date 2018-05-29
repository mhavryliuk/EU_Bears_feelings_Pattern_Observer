using System;

namespace _20180320_Task1_Pattern_Observer
{
    internal class Jack : IObserver
    {
        public string Name { get; set; }

        public Jack(string name, IObservable obs)
        {
            Name = name;
            obs.RegisterObserver(this);
        }

        /// <inheritdoc />
        /// <summary>
        /// The event handler method.
        /// </summary>
        /// <param name="ob">The name of the chosen groom.</param>
        public void Update(object ob)
        {
            RoseChoice notice = (RoseChoice)ob;

            if (notice.Choice == "Jack")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{Name} now meets with Rose");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.WriteLine($"{Name} has upset and ran away...");
                Console.WriteLine($"Rose no longer communicates with {Name}");
            }
        }
    }
}