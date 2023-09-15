using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PaxJourneyRef
    {
        [XmlElement(ElementName = "PaxJourneyRefID")]
        public List<string> Refs;
    }
}
