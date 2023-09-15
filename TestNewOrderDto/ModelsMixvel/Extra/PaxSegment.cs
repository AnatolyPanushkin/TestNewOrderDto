using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PaxSegment
    {
        [XmlElement(ElementName = "Arrival")]
        public DepArr Arrival { get; set; }
        [XmlElement(ElementName = "DatedOperatingLeg")]
        public DatedOperatingLeg DatedOperatingLeg { get; set; }
        [XmlElement(ElementName = "Dep")]
        public DepArr Dep { get; set; }
        [XmlElement(ElementName = "Duration")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "MarketingCarrierInfo")]
        public MarketingCarrierInfo MarketingCarrierInfo { get; set; }
        [XmlElement(ElementName = "PaxSegmentID")]
        public string PaxSegmentID { get; set; }
    }
}
