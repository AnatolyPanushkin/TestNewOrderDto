namespace Contracts.Models.NewAvia;

public class Document
{
    public string Number { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string CountryCode { get; set; } = null!;
    public DateTime? ExpireDate { get; set; }
}
