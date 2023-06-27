using AirportBaggageSystem.Interfaces;

namespace AirportBaggageSystem.Observers
{
    internal class SecurityGate : IObserver
    {
        public void Update(string baggageId)
        {
            Console.WriteLine($"Security gate: Baggage with ID {baggageId} has passed security check.");
        }
    }
}
