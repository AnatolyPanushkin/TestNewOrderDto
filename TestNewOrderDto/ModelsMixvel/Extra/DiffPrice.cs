using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class DiffPrice
{
    [XmlElement(ElementName = "FareDetail")]
    public FareDetail FareDetail { get; set; }
    [XmlElement(ElementName = "Price")]
    public Price Price { get; set; }
}
