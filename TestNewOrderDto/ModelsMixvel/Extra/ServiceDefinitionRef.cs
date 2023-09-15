using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ServiceDefinitionRef
    {
        [XmlArray(ElementName = "ServiceDefinitionRefFlightAssociations")]
        public List<PaxSegmentRef> ServiceDefinitionRefFlightAssociations;
        [XmlElement(ElementName = "ServiceDefinitionRefID")]
        public string ServiceDefinitionRefID;

        public ServiceDefinitionRef()
        {
        }
    }
}
