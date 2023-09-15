namespace Contracts.Avia;
/// <summary>
/// Представляет перевозчика
/// </summary>
public class Carrier : IEquatable<Carrier>
{
    public Carrier()
    {
    }
    public Carrier(string id, string name, string code, string desigCode)
    {
        Id = id;
        Name = name;
        Code = code;
        DigitCode = desigCode;
    }

    /// <summary>
    /// GUID перевозчика
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Наименование пеервозчика
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Код перевозчика
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Цифровой код перевозчика
    /// </summary>
    public string DigitCode { get; set; }

    /// <summary>
    /// Ссылка на изображение логотипа
    /// </summary>
    public string? ImgUrl { get; set; }

    public bool Equals(Carrier? other)
    {
        if (Object.ReferenceEquals(other, null)) return false;
        if (Object.ReferenceEquals(this, other)) return true;
        return Code.Equals(other.Code) && Name.Equals(other.Name);
    }
    public override int GetHashCode()
    {
        int hashProductName = Name == null ? 0 : Name.GetHashCode();
        int hashProductCode = Code.GetHashCode();
        return hashProductName ^ hashProductCode;
    }
}
