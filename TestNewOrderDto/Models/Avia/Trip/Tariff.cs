namespace Contracts.Avia;
/// <summary>
/// Данные о заказе
/// </summary>
public class Tariff
{
    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Название тарифа
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Код тарифа
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Багаж
    /// </summary>
    public IEnumerable<string> Baggages { get; set; }

    /// <summary>
    /// Стоимость заказа
    /// </summary>
    public Price Price { get; set; }

    /// <summary>
    /// Список OfferItemId(Mixvel)
    /// </summary>
    public List<PaxOfferAssociation> Extra { get; set; }
    /// <summary>
    /// Список доп услуг, входящих в тариф
    /// </summary>
    public List<Service> Services { get; set; }

}
