using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Rules
    {
        [XmlElement(ElementName = "AirlineDesigCode")]
        public string AirlineDesigCode;
        [XmlElement(ElementName = "FareRuleText")]
        public FareRule FareRule;
        [XmlElement(ElementName = "PaxSegmentRefID")]
        public string PaxSegmentRefID;
    }
}
