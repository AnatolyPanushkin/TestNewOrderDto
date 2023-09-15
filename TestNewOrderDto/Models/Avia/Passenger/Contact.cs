using System.Text.RegularExpressions;

namespace Contracts.Avia;
public class Contact : IValidatable
{
    public string EmailAddress { get; set; }
    public string? OtherAddress { get; set; }
    public string Phone { get; set; }

    public void Validate()
    {
        if (EmailAddress == null || !EmailAddress.Contains("@") || EmailAddress.Length < 3)
            throw new InvalidDataException("Неккоректный Email");
        if(Phone == null || !Regex.IsMatch(Phone, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
            throw new InvalidDataException("Неккоректный номер телефона");
    }
}
