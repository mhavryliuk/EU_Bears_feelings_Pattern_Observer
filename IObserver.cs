namespace _20180320_Task1_Pattern_Observer
{
    public interface IObserver
    {
        /// <summary>
        /// The event handler method.
        /// </summary>
        /// <param name="ob">The name of the chosen groom.</param>
        void Update(object ob);
    }
}