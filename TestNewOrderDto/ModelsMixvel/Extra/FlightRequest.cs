using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FlightRequest
    {
        public FlightRequest()
        {
        }

        [XmlElement(ElementName = "FlightRequestOriginDestinationsCriteria")]
        public FlightRequestOriginDestinationsCriteria FlightRequestOriginDestinationsCriteria { get; set; }
    }
}
