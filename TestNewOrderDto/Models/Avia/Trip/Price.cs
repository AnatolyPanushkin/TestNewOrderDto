namespace Contracts.Avia;
/// <summary>
/// Представляет стоимость перевозки
/// </summary>
public class Price
{
    /// <summary>
    /// Базовая стоимость
    /// </summary>
    public double Base { get; set; }

    /// <summary>
    /// Итоговая стоимость
    /// </summary>
    public double Total { get; set; }

    /// <summary>
    /// Сервисные сборы
    /// </summary>
    public List<Tax>? Taxes { get; set; }
}
