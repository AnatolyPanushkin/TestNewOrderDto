using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class MixOrder
    {
        public MixOrder()
        {
        }

        [XmlElement(ElementName = "MixOrderID")]
        public string MixOrderID { get; set; }
        [XmlElement(ElementName = "Order")]
        public Order Order { get; set; }
        [XmlElement(ElementName = "TotalAmount")]
        public Amount TotalAmount { get; set; }
    }
}
