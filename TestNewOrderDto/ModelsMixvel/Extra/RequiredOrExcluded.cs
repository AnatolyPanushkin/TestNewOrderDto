using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class RequiredOrExcluded
    {
        [XmlElement(ElementName = "OwnerCode")]
        public string OwnerCode;
        [XmlElement(ElementName = "Provider")]
        public string Provider;
        public RequiredOrExcluded()
        {
        }
    }
}
