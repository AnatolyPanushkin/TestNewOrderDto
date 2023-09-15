using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ServiceCriteria
    {
        [XmlElement(ElementName = "PrefLevel")]
        public PrefLevel PrefLevel;
        [XmlElement(ElementName = "ServiceCategory")]
        public string ServiceCategory;
        [XmlElement(ElementName = "RFIC")]
        public string RFIC;
        [XmlElement(ElementName = "RFISC")]
        public List<string> RFISCs;
        public ServiceCriteria()
        {
        }
    }
}
