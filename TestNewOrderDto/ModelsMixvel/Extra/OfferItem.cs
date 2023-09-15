using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OfferItem
    {
        [XmlElement(ElementName = "FareDetail")]
        public FareDetail FareDetail;
        [XmlElement(ElementName = "MandatoryInd")]
        public string MandatoryInd;
        [XmlElement(ElementName = "OfferItemID")]
        public string OfferItemID;
        [XmlElement(ElementName = "Price")]
        public Price Price;
        [XmlElement(ElementName = "Service")]
        public List<Service> Services;
        [XmlElement(ElementName = "RefundStatus")]
        public string RefundStatus;
    }
}
