namespace Contracts.Avia;
/// <summary>
/// Представляет вариант перевозки
/// </summary>
public class Trip
{
    /// <summary>
    /// Guid варианта перевозки
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Маршруты
    /// </summary>
    public List<Route>? Routes { get; set; }

    /// <summary>
    /// Сведения о стоимости и сборах
    /// </summary>
    public Price? Price { get; set; }

    /// <summary>
    /// Данные о багаже
    /// </summary>
    public string? Baggage { get; set; }

    /// <summary>
    /// Поставщик варианта перевозки
    /// </summary>
    public string Provider { get; set; }

    /// <summary>
    /// GDS
    /// </summary>
    public string? GDS { get; set; }

    /// <summary>
    /// Признак возвратности билета
    /// </summary>
    public string? Refund { get; set; }

    /// <summary>
    /// Дополнительные данные в формате JSON
    /// </summary>
    public string? Extra { get; set; }
}
