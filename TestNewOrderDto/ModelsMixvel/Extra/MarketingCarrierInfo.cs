using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class MarketingCarrierInfo
    {
        [XmlElement(ElementName = "CarrierDesigCode")]
        public string CarrierDesigCode { get; set; }
        [XmlElement(ElementName = "MarketingCarrierFlightNumberText")]
        public string MarketingCarrierFlightNumberText { get; set; }
    }
}
