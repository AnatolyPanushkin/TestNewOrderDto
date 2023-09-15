namespace Contracts.Models.NewAvia;

public class Ticket
{
    public string Number { get; set; } = null!;
    public DateTime Date { get; set; }
    public bool Refund { get; set; }
    public bool Excange { get; set; }
    public Receipt? OtherReceipt { get; set; }
}
