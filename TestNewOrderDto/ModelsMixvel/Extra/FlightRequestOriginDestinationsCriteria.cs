using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FlightRequestOriginDestinationsCriteria
    {
        [XmlElement(ElementName = "OriginDestCriteria")]
        public List<OriginDestCriteria> OriginDestCriterias { get; set; }

        public FlightRequestOriginDestinationsCriteria()
        {

        }
    }
}
