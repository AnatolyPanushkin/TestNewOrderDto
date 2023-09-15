using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class CacheSettings
    {
        [XmlElement(ElementName = "CommonRequestMode")]
        public string CommonRequestMode;
        [XmlElement(ElementName = "OwnerProviderRequestMode")]
        public List<OwnerProviderRequestMode> OwnerProviderRequestModes;

        public CacheSettings()
        {
        }
    }
}
