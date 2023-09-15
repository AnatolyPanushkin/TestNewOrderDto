using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OrderFilterCriteria
    {
        public OrderFilterCriteria()
        {

        }
        [XmlElement(ElementName = "DocFilterCriteria")]
        public DocFilterCriteria? DocFilterCriteria { get; set; }
        [XmlElement(ElementName = "Order")]
        public Order? Order { get; set; }
        [XmlElement(ElementName = "MixOrder")]
        public MixOrder? MixOrder { get; set; }
    }
}
