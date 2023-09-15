using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PaxJourney
    {
        [XmlElement(ElementName = "Duration")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "PaxJourneyID")]
        public string PaxJourneyID { get; set; }
        [XmlElement(ElementName = "PaxSegmentRefID")]
        public List<string> PaxSegmentRefIDs { get; set; }
    }
}
