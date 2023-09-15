namespace Contracts.Models.NewAvia;

public class OrderDto
{
    public int Id { get; set; }
    public string WorkId { get; set; } = null!;
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// From service
    /// </summary>
    public double BaseCost { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public double Cost { get; set; }
    public string Provider { get; set; } = null!;
    public string GDS { get; set; } = null!;
    public Status Status { get; set; } = null!;
    public List<Booking> Bookings { get; set; } = null!;
}