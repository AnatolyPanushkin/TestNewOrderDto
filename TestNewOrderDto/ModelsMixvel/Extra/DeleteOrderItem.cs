using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class DeleteOrderItem
{
    [XmlElement(ElementName = "OrderID")]
    public string OrderID { get; set; }

    [XmlElement(ElementName = "OfferItemID")]
    public string OfferItemID { get; set; }
}
