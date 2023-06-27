namespace AirportBaggageSystem.Interfaces
{
    /// <summary>
    /// Observer for Airport Baggage System
    /// </summary>
    internal interface IObserver
    {
        /// <summary>
        /// Updates the observer with the specified baggage ID.
        /// </summary>
        /// <param name="baggageId">The ID of the baggage being updated.</param>
        void Update(string baggageId);
    }
}
