namespace Contracts.Models.NewAvia;

public abstract class IATA
{
    public string? Code { get; set; } = null!;
    public string? Name { get; set; } = null!;
}
