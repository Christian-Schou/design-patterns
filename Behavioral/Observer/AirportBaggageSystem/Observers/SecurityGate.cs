using AirportBaggageSystem.Interfaces;

namespace AirportBaggageSystem.Observers
{
    /// <summary>
    /// Security Gate Observer
    /// </summary>
    internal class SecurityGate : IObserver
    {
        /// <summary>
        /// Updates the security gate with the specified baggage ID after passing security check.
        /// </summary>
        /// <param name="baggageId">The ID of the baggage that passed security check.</param>
        public void Update(string baggageId)
        {
            Console.WriteLine($"Security gate: Baggage with ID {baggageId} has passed security check.");
        }
    }
}
