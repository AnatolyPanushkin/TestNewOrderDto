using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ServiceAssociations
    {
        [XmlElement(ElementName = "PaxJourneyRef")]
        public PaxJourneyRef PaxJourneyRef;
        [XmlElement(ElementName = "PaxSegmentRefID")]
        public string PaxSegmentRefID;
        [XmlElement(ElementName = "ServiceDefinitionRef")]
        public ServiceDefinitionRef ServiceDefinitionRef;

    }
}
