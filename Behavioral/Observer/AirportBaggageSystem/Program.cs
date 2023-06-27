using AirportBaggageSystem.Interfaces;
using AirportBaggageSystem.Observers;
using AirportBaggageSystem.Services;

// Create an instance of the BaggageSystem class which implements ISubject
ISubject baggageSystem = new BaggageSystem();

// Create instances of the observers: BaggageClaimDisplay and SecurityGate
IObserver baggageClaimDisplay = new BaggageClaimDisplay();
IObserver securityGate = new SecurityGate();

// Attach the observers to the baggage system
baggageSystem.Attach(securityGate); // Attach the SecurityGate observer
baggageSystem.Attach(baggageClaimDisplay); // Attach the BaggageClaimDisplay observer

// Notify the observers with a specific baggage ID
baggageSystem.Notify("B-83182372"); // Notifies both observers with baggage ID "B-83182372"

// Detach the security gate observer from the baggage system
baggageSystem.Detach(securityGate); // Detach the SecurityGate observer

// Notify the remaining observer with a different baggage ID
baggageSystem.Notify("B-51735461"); // Notifies the BaggageClaimDisplay observer with baggage ID "B-51735461"

// Detach the baggage claim display observer from the baggage system
baggageSystem.Detach(baggageClaimDisplay); // Detach the BaggageClaimDisplay observer