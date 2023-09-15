namespace Contracts.Avia;
public class Meta
{
    public List<Carrier> Carriers { get; set; }
    public TransportNodes TransportNodes { get; set; }
    public IEnumerable<string> Baggage { get; set; }
    public PriceRange Prices { get; set; }
    public IEnumerable<string> Providers{ get; set; }
}
