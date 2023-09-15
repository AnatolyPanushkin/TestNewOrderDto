using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Offer
    {
        [XmlElement(ElementName = "BaggageAllowance")]
        public List<BaggageAllowance> BaggageAllowance { get; set; }

        [XmlElement(ElementName = "OfferExpirationTimeLimitDateTime")]
        public string OfferExpirationTimeLimitDateTime { get; set; }

        [XmlElement(ElementName = "OfferID")]
        public string OfferID { get; set; }

        [XmlElement(ElementName = "OfferItem")]
        public List<OfferItem> OfferItems { get; set; }

        [XmlElement(ElementName = "OfferType")]
        public string OfferType { get; set; }

        [XmlElement(ElementName = "OwnerCode")]
        public string OwnerCode { get; set; }

        [XmlElement(ElementName = "ReservationGuideline")]
        public ReservationGuideline ReservationGuideline;

        [XmlElement(ElementName = "TotalPrice")]
        public Price TotalPrice { get; set; }

        [XmlElement(ElementName = "RefundStatus")]
        public string RefundStatus { get; set; }

        [XmlArray(ElementName = "DeleteOrderItem")]
        public List<ExistingOrderItem> ExistingOrderItems { get; set; }
    }
}
