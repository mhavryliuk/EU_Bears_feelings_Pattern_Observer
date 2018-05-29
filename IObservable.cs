namespace _20180320_Task1_Pattern_Observer
{
    public interface IObservable
    {
        /// <summary>
        /// Observer registration.
        /// </summary>
        /// <param name="observer">Observer.</param>
        void RegisterObserver(IObserver observer);

        /// <summary>
        /// Notification of observers.
        /// </summary>
        void NotifyObservers();
    }
}