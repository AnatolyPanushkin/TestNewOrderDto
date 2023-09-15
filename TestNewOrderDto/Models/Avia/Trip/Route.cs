using Contracts.Extansions;
using System.Linq;

namespace Contracts.Avia;
public class Route : IEquatable<Route>
{
    /// <summary>
    /// Транспортные узлы
    /// </summary>
    public List<Segment> Segments { get; set; }

    public bool Equals(Route? other)
    {
        if (other is null) return false;
        if (Object.ReferenceEquals(this, other)) return true;
        if (this.GetType() != other.GetType()) return false;
        return Segments.SequenceEqual(other.Segments);
    }
    public override int GetHashCode() {
        return Segments.GetSequenceHashCode();
    }
    public static bool operator ==(Route lhs, Route rhs)
    {
        if (lhs is null)
        {
            if (rhs is null) return true;
            return false;
        }
        return lhs.Equals(rhs);
    }
    public static bool operator !=(Route lhs, Route rhs) => !(lhs == rhs);
}
