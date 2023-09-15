using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OwnerProviderRequestMode
    {
        [XmlElement(ElementName = "OwnerProviderRequestMode")]
        public List<OwnerProvider> OwnerProviders;
        [XmlElement(ElementName = "Mode")]
        public string Mode;

        public OwnerProviderRequestMode()
        {
        }
    }
}
