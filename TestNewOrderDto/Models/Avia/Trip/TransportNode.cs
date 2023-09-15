namespace Contracts.Avia;
public class TransportNode : IEquatable<TransportNode>
{
    public string? NameRu { get; set; }
    public string? NameEn { get; set; }
    public string? CodeRu { get; set; }
    public string? CodeEn { get; set; }
    public GPS? Gps { get; set; }
    public string? Terminal { get; set; }
    public string? Type { get; set; }

    public TransportNode(string nameRu, string nameEn, string codeRu, string codeEn, GPS gps)
    {
        NameRu = nameRu;
        NameEn = nameEn;
        CodeRu = codeRu;
        CodeEn = codeEn;
        Gps = gps;
    }
    public TransportNode()
    {
    }

    public bool Equals(TransportNode? other)
    {
        if (Object.ReferenceEquals(other, null)) return false;
        if (Object.ReferenceEquals(this, other)) return true;
        return NameRu == other.NameRu && NameEn == other.NameEn && CodeRu == other.CodeRu && CodeEn == other.CodeEn;
    }
    public override int GetHashCode()
    {
        int hashRu = CodeRu.GetHashCode() ^ NameRu.GetHashCode();
        int hashEn = CodeEn.GetHashCode() ^ NameEn.GetHashCode();
        return hashRu ^ hashEn;
    }
}
