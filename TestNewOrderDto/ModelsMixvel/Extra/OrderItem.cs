using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OrderItem
    {
        [XmlElement(ElementName = "FareDetail")]
        public FareDetail FareDetail;
        [XmlElement(ElementName = "OrderItemID")]
        public string OrderItemID;
        [XmlElement(ElementName = "OwnerCode")]
        public string OwnerCode;
        [XmlElement(ElementName = "PaymentTimeLimitDateTime")]
        public DateTime PaymentTimeLimitDateTime;
        [XmlElement(ElementName = "Price")]
        public Price Price;
        [XmlElement(ElementName = "Service")]
        public List<Service> Services;
    }
}
