using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class ExistingOrderItem
{
    [XmlElement(ElementName = "OrderItemRefID")]
    public string OrderItemRefID { get; set; }
    [XmlElement(ElementName = "PriceDifferential")]
    public PriceDifferential PriceDifferential { get; set; }
}
