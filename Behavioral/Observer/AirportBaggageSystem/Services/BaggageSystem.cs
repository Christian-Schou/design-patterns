using AirportBaggageSystem.Interfaces;

namespace AirportBaggageSystem.Services
{
    internal class BaggageSystem : ISubject
    {
        // List to hold all observers that should be updated
        // when the BaggageSystem is notified about an update
        private List<IObserver> _observers = new List<IObserver>();

        /// <summary>
        /// Attaches an observer to the baggage system.
        /// </summary>
        /// <param name="observer">The observer to attach.</param>
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Detaches an observer from the baggage system.
        /// </summary>
        /// <param name="observer">The observer to detach.</param>
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all attached observers with the specified baggage ID.
        /// </summary>
        /// <param name="baggageId">The ID of the baggage.</param>
        public void Notify(string baggageId)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(baggageId); // Call the Update method on each observer
            }
        }
    }
}
