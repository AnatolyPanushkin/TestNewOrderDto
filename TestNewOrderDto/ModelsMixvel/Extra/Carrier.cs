using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Carrier
    {
        [XmlElement(ElementName = "AirlineDesigCode")]
        public string AirlineDesigCode { get; set; }
        [XmlElement(ElementName = "MarketingCarrierFlightNumberText")]
        public List<string> MarketingCarrierFlightNumberTexts { get; set; }
        [XmlElement(ElementName = "Mixvel_AirlineID")]
        public string MixvelAirlineID { get; set; }

        public Carrier()
        {
        }
    }
}
