namespace Contracts.Avia;
/// <summary>
/// Представляет транспортный узел
/// </summary>
public class Segment : IEquatable<Segment> 
{
    public Segment()
    {
    }
    public Segment(DepartureArrival departure, DepartureArrival arrival)
    {
        Departure = departure;
        Arrival = arrival;
        TravelTime = Arrival.Date - Departure.Date; ;
    }

    /// <summary>
    /// Сведения о пункте отправления
    /// </summary>
    public DepartureArrival Departure { get; set; }

    /// <summary>
    /// Сведения о пункте прибытия
    /// </summary>
    public DepartureArrival Arrival { get; set; }

    /// <summary>
    /// Сведения о перевозчике
    /// </summary>
    public string Carrier { get; set; }

    /// <summary>
    /// Время на перелет
    /// </summary>
    public TimeSpan TravelTime { get; set; }
    
    /// <summary>
    /// Номер рейса
    /// </summary>
    public string FlightNumber { get; set; }

    public bool Equals(Segment? other)
    {
        if (other is null) return false;
        if (Object.ReferenceEquals(this, other)) return true;
        if (this.GetType() != other.GetType()) return false;
        return (Departure == other.Departure) && (Arrival == other.Arrival);
    }
    public override int GetHashCode() => (Arrival, Departure).GetHashCode();
    public static bool operator ==(Segment lhs, Segment rhs)
    {
        if (lhs is null)
        {
            if (rhs is null) return true;
            return false;
        }
        return lhs.Equals(rhs);
    }
    public static bool operator !=(Segment lhs, Segment rhs) => !(lhs == rhs);
}
