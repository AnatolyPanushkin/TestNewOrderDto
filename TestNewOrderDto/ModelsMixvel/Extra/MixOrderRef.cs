using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class MixOrderRef
    {
        [XmlElement]
        public string MixOrderID { get; set; }
        [XmlElement(ElementName = "Order")]
        public Order Order { get; set; }
    }
}
