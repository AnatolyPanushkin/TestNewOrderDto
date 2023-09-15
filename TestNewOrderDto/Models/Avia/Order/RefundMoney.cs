namespace Contracts.Avia;

public class RefundMoney : Price
{
    public string? Id { get; set; }
    public string? Type { get; set; }
    public bool IsRefundable { get; set; }
}
