using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class BaggageFlightAssociations
    {
        [XmlArray(ElementName = "PaxSegmentRef")]
        public List<PaxSegmentRef> PaxSegmentRefs;
    }
}
