using AirportBaggageSystem.Interfaces;

namespace AirportBaggageSystem.Observers
{
    /// <summary>
    /// Baggage Claim Display Observer
    /// </summary>
    internal class BaggageClaimDisplay : IObserver
    {
        /// <summary>
        /// Updates the baggage claim display with the specified baggage ID.
        /// </summary>
        /// <param name="baggageId">The ID of the baggage.</param>
        public void Update(string baggageId)
        {
            Console.WriteLine($"Baggage claim display: Baggage with ID {baggageId} is ready for pickup.");
        }
    }
}
