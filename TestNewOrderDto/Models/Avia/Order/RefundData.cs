namespace Contracts.Avia;
public class RefundData
{
    public IEnumerable<RefundMoney> ToRefund { get ; set; }
    public IEnumerable<RefundMoney> Penalty { get; set; }
    public bool Refundable { get; set; }
    public string? ReasonPhrase { get; set; }
}
