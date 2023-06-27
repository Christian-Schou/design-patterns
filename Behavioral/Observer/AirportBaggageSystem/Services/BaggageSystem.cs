using AirportBaggageSystem.Interfaces;

namespace AirportBaggageSystem.Services
{
    internal class BaggageSystem : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string baggageId)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(baggageId);
            }
        }
    }
}
