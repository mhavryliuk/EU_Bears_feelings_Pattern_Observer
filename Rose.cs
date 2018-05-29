using System;
using System.Collections.Generic;

namespace _20180320_Task1_Pattern_Observer
{
    internal class RoseChoice
    {
        public string Choice { get; set; }
    }

    internal class Rose : IObservable
    {
        private readonly RoseChoice notice;   // The choice of the groom
        private readonly List<IObserver> observers;

        /// <summary>
        /// The constructor of the Rose class.
        /// </summary>
        public Rose()
        {
            observers = new List<IObserver>();
            notice = new RoseChoice();
        }

        /// <inheritdoc />
        /// <summary>
        /// Observer registration.
        /// </summary>
        /// <param name="observer">Observer.</param>
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <inheritdoc />
        /// <summary>
        /// Notification of observers.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(notice);
            }
        }

        /// <summary>
        /// A method that signals the start of an event.
        /// </summary>
        public void FlirtEvent()
        {
            Random rnd = new Random();

            if (rnd.Next(1, 3) == 1)   // 1 - choice in favor of Jack, 2 - choice in favor of Billy
            {
                Console.WriteLine("Rose opted for Jack\n");
                notice.Choice = "Jack";
            }
            else
            {
                Console.WriteLine("Rose opted for Billy\n");
                notice.Choice = "Billy";
            }

            NotifyObservers();   // Notification for subscribers about the chosen groom.
        }
    }
}