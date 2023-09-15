using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OriginDest
    {
        [XmlElement(ElementName = "DestCode")]
        public string DestCode { get; set; }
        [XmlElement(ElementName = "OriginCode")]
        public string OriginCode { get; set; }
        [XmlElement(ElementName = "OriginDestID")]
        public string OriginDestID { get; set; }
        [XmlElement(ElementName = "PaxJourneyRefID")]
        public List<string> PaxJourneyRefIDs { get; set; }
    }
}
