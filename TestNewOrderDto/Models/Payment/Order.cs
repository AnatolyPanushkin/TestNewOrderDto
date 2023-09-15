namespace Contracts.Payment;
public class Order
{
    /// <summary>
    /// Id заказа в сервисе
    /// </summary>
    public string ServiceId { get; set; }

    /// <summary>
    /// Дата и время создания заказа
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Сумма к оплате по заказу
    /// </summary>
    public double Cost { get; set; }

    /// <summary>
    /// Информация по сервису оплаты
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// Описание заказа
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Статус заказа enum: ["PAID", "CREATED", "REVERSED", "REFUNDED", "REVOKED", 
    /// "DECLINED", "EXPIRED", "AUTHORIZED", "CONFIRMED", "ON_PAYMENT"]
    /// </summary>
    public Status State { get; set; }

    /// <summary>
    /// Информация по QR-коду
    /// </summary>
    public string Url { get; set; }
}
