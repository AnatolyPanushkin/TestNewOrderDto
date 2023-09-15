namespace Contracts.Avia;
public class FlightInfo
{
    public DepartureArrival Departure { get; set; }
    public DepartureArrival Arrival { get; set; }
    public Carrier Carrier { get; set; }
    public string FlightNumber { get; set; }
}
