namespace Contracts.Avia;
/// <summary>
/// Представляет сервисный сбор
/// </summary>
public class Tax
{
    /// <summary>
    /// Значение сбора
    /// </summary>
    public double Amount { get; set; }

    /// <summary>
    /// Код сбора
    /// </summary>
    public string Code { get; set; }
}
