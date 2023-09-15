namespace Contracts.Payment;
public class OrderStatusInfo
{
    public string Id { get; set; }
    public string Status { get; set; }
    public int? Cost { get; set; }
    public string Customer { get; set; }
}
