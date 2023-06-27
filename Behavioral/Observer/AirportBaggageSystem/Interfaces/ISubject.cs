namespace AirportBaggageSystem.Interfaces
{
    /// <summary>
    /// Subject interface for Airport Baggage System
    /// </summary>
    internal interface ISubject
    {
        /// <summary>
        /// Attaches an observer to the subject.
        /// </summary>
        /// <param name="observer">The observer to attach.</param>
        void Attach(IObserver observer);

        /// <summary>
        /// Detaches an observer from the subject.
        /// </summary>
        /// <param name="observer">The observer to detach.</param>
        void Detach(IObserver observer);

        /// <summary>
        /// Notifies all attached observers with the provided baggage ID.
        /// </summary>
        /// <param name="baggageId">The ID of the baggage.</param>
        void Notify(string baggageId);
    }
}
