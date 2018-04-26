using System;
using System.Collections.Generic;

namespace _20180320_Task1_Pattern_Observer
{
    class RoseChoice
    {
        public string Choice { get; set; }
    }

    class Rose : IObservable
    {
        RoseChoice notice; // Выбор жениха

        List<IObserver> observers;

        public Rose()
        {
            observers = new List<IObserver>();
            notice = new RoseChoice();
        }

        // Регистрация наблюдателей
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        // Уведомление наблюдателей
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(notice);
            }
        }

        // Метод, сигнализирующий о запуске события
        public void FlirtEvent()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 3) == 1)   // 1 - выбор Jack'a, 2 - выбор Billy
            {
                Console.WriteLine("Rose сделала выбор в пользу Jack'a\n");
                notice.Choice = "Jack";
            }
            else
            {
                Console.WriteLine("Rose сделала выбор в пользу Billy\n");
                notice.Choice = "Billy";
            }

            NotifyObservers();   // Уведомление Jack'a и Billy о своем выборе
        }
    }
}