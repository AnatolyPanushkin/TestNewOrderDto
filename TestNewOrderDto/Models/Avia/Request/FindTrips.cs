namespace Contracts.Avia;
public class FindTrips : IValidatable
{
    /// <summary>
    /// Код пункта отправления
    /// </summary>
    public string Departure { get; set; }

    /// <summary>
    /// Код пункта прибытия
    /// </summary>
    public string Arrival { get; set; }

    /// <summary>
    /// Дата вылета туда
    /// </summary>
    public string Date { get; set; }

    /// <summary>
    /// Дата вылета обратно
    /// </summary>
    public string? DateBack { get; set; }

    /// <summary>
    /// Класс бронирования (0 - Эконом, 1 - Бизнес, 2 Первый)
    /// </summary>
    public int Class { get; set; }

    /// <summary>
    /// Список пассажиров в формате ['ADT', 'ADT', 'CNN', 'INF']
    /// </summary>
    public IEnumerable<string> Passengers { get; set; }

    /// <summary>
    /// Флаг, указывающий на поиск c пересадками или без. True - пересадки разрешены, false - только прямые
    /// </summary>
    public bool Stops { get; set; }

    public void Validate()
    {
        try
        {
            if (DateOnly.Parse(Date) < DateOnly.FromDateTime(DateTime.Now))
                throw new NotImplementedException("Дата неккоректна");
        }
        catch
        {
            throw new InvalidDataException("Неврный формат даты");
        }
        if(Class < 0 || Class > 3)
            throw new InvalidDataException("Неизвестный класс бронирования");
    }
}
