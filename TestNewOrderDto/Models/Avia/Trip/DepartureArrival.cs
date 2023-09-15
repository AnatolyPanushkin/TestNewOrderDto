namespace Contracts.Avia;
public class DepartureArrival : IEquatable<DepartureArrival>
{
    public DepartureArrival()
    {
    }
    public DepartureArrival(string date, string code, string name, string terminal)
    {
        Date = DateTime.Parse(date);
        Code = code;
        Name = name;
        Terminal = terminal;
    }

    /// <summary>
    /// Время отправления или прибытия
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Код аэропорта
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Название города
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Название терминала
    /// </summary>
    public string? Terminal { get; set; }

    public bool Equals(DepartureArrival? other)
    {
        if (other is null) return false;
        if (Object.ReferenceEquals(this, other)) return true;
        if (this.GetType() != other.GetType()) return false;
        return (Date == other.Date) && (Code == other.Code);
    }
    public override int GetHashCode() => (Date, Code).GetHashCode();
    public static bool operator ==(DepartureArrival lhs, DepartureArrival rhs)
    {
        if (lhs is null)
        {
            if (rhs is null) return true;
            return false;
        }
        return lhs.Equals(rhs);
    }

    public static bool operator !=(DepartureArrival lhs, DepartureArrival rhs) => !(lhs == rhs);
}
