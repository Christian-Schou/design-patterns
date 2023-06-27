namespace AirportBaggageSystem.Interfaces
{
    internal interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string baggageId);
    }
}
