namespace Contracts.Models.NewAvia;

public class Segment
{
    public TravelPoint DeparturePoint { get; set; } = null!;
    public TravelPoint ArrivalPoint { get; set; } = null!;
    public string FlightNumber { get; set; } = null!;
    public Carrier MarketingAirline { get; set; } = null!;
    public Carrier OperatingAirline { get; set; } = null!;
    public string Class { get; set; } = null!;
    public string SubClass { get; set; } = null!;
}
