using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Service
    {
        [XmlElement(ElementName = "PaxRefID")]
        public List<string> PaxRefID;
        [XmlElement(ElementName = "ValidatingPartyRefID")]
        public string ValidatingPartyRefID;
        [XmlElement(ElementName = "ServiceAssociations")]
        public ServiceAssociations ServiceAssociations;
        [XmlElement(ElementName = "ServiceID")]
        public string ServiceID;
        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode;

        public Service()
        {
        }
    }
}
