namespace Contracts.Models.NewAvia;

public class BookPrice
{
    public double Base { get; set; }
    public double Total { get; set; }
    public Tariff Tariff { get; set; } = null!;
    public IEnumerable<Tax> Taxes { get; set; } = null!;
}
