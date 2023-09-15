using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Order
    {
        public Order()
        {
        }

        [XmlElement(ElementName = "BookingRef")]
        public List<BookingRef> BookingRefs { get; set; }

        [XmlElement(ElementName = "OrderID")]
        public string OrderID { get; set; }

        [XmlElement(ElementName = "OrderItem")]
        public List<OrderItem> OrderItems { get; set; }

        [XmlElement(ElementName = "OwnerCode")]
        public string OwnerCode { get; set; }

        [XmlElement(ElementName = "RelevanceDateTime")]
        public DateTime RelevanceDateTime { get; set; }

        [XmlElement(ElementName = "ReservationGuideline")]
        public ReservationGuideline ReservationGuideline { get; set; }

        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [XmlElement(ElementName = "TotalPrice")]
        public Price TotalPrice { get; set; }

        [XmlElement(ElementName = "OperationStatus")]
        public string OperationStatus { get; set; }
    }
}
