using Contracts.Accounts;

namespace Contracts.Avia;
public class Order
{
    public string WorkId { get; set; }
    public Contact ContactInfo { get; set; }
    public IEnumerable<Passenger> Passengers { get; set; }
    public IEnumerable<Ticket> Tickets { get; set; }
    public DateTime CreatedAt { get; set; }
    public IEnumerable<FlightInfo> Flights { get; set; }
    public int Status { get; set; }
    public Price Cost { get; set; }
    public Account CreatedBy {get; set; }
    public string Provider { get; set; }
    public string GDS { get; set; }
}
