using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class ChangeOrder
{
    [XmlElement(ElementName = "UpdateOrderItem")]
    public UpdateOrderItem UpdateOrderItem { get; set; }
}
