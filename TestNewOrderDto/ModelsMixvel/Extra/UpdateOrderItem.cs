using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class UpdateOrderItem
{
    [XmlArray(ElementName = "DeleteOrderItemList")]
    public List<DeleteOrderItem> DeleteOrderItemList { get; set; }
}
