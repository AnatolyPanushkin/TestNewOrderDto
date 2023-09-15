namespace Contracts.Avia;
public enum RequestType
{
    /// <summary>
    /// Проверка доступности
    /// </summary>
    AVAILABILITY,
    /// <summary>
    /// Получение тарифных правил
    /// </summary>
    FARE_RULES,
    /// <summary>
    /// Получение карты мест
    /// </summary>
    SEAT_MAP,
    /// <summary>
    /// Получение актуальной цены 
    /// </summary>
    PRICE,
    /// <summary>
    /// Актуализация перелёта
    /// </summary>
    ACTUALIZE,
    /// <summary>
    /// Получение варианта оценки перелёта тарифами из разных семейств
    /// </summary>
    FARE_FAMILIES
}