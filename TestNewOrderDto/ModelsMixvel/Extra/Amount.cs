using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class Amount
{
    [XmlAttribute(AttributeName = "CurCode")]
    public string CurCode { get; set; }
    [XmlText]
    public double Value { get; set; }
}
