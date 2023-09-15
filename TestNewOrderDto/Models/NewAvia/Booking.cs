namespace Contracts.Models.NewAvia;

public class Booking
{
    public string Pnr { get; set; } = null!;
    public string Type { get; set; } = null!;
    public BookPrice BookPrice { get; set; } = null!;
    public List<Segment> Segments { get; set;} = null!;
    public List<TickPass> TickPasses { get; set;} = null!;
}
