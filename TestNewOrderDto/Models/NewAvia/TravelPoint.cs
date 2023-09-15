namespace Contracts.Models.NewAvia;

public class TravelPoint : IATA
{
    public string? Terminal { get; set; }
    public DateTime Date { get; set; }
    public City City { get; set; } = null!;
}
