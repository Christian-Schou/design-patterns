using AirportBaggageSystem.Interfaces;

namespace AirportBaggageSystem.Observers
{
    internal class BaggageClaimDisplay : IObserver
    {
        public void Update(string baggageId)
        {
            Console.WriteLine($"Baggage claim display: Baggage with ID {baggageId} is ready for pickup.");
        }
    }
}
