using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ServiceDefinition
    {

        [XmlElement(ElementName = "Name")]
        public string Name;
        [XmlElement(ElementName = "OwnerCode")]
        public string OwnerCode;
        [XmlElement(ElementName = "RFIC")]
        public string RFIC;
        [XmlElement(ElementName = "RFISC")]
        public string RFISC;
        [XmlElement(ElementName = "ServiceGroup")]
        public string ServiceGroup;
        [XmlElement(ElementName = "ServiceDefinitionID")]
        public string ServiceDefinitionID;

        public ServiceDefinition()
        {
        }
    }
}
