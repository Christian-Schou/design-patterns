using AirportBaggageSystem.Interfaces;
using AirportBaggageSystem.Observers;
using AirportBaggageSystem.Services;

ISubject baggageSystem = new BaggageSystem();
IObserver baggageClaimDisplay = new BaggageClaimDisplay();
IObserver securityGate = new SecurityGate();

baggageSystem.Attach(baggageClaimDisplay);
baggageSystem.Attach(securityGate);

baggageSystem.Notify("B-83182372");

baggageSystem.Detach(securityGate);

baggageSystem.Notify("B-51735461");

baggageSystem.Detach(baggageClaimDisplay);