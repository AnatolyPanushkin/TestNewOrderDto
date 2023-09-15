using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public  class PriceDifferential
{
    [XmlElement(ElementName = "DiffPrice")]
    public DiffPrice DiffPrice { get; set; }
}
