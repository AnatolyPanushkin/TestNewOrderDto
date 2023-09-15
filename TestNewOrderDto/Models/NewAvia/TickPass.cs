namespace Contracts.Models.NewAvia;

public class TickPass
{
    public Passenger Passenger { get; set; } = null!;
    public Ticket Ticket { get; set; } = null!;
    public AgencyMarkup AgencyMarkup { get; set; }
}
