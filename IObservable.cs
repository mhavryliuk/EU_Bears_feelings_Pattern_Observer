namespace _20180320_Task1_Pattern_Observer
{
    interface IObservable
    {
        void RegisterObserver(IObserver o);   // Регистрация наблюдателя
        void NotifyObservers();               // Уведомление наблюдателей
    }
}