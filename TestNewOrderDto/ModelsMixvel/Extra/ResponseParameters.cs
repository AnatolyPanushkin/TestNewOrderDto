using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ResponseParameters
    {
        [XmlElement(ElementName = "CurParameter")]
        public CurParameter CurParameter;
        [XmlElement(ElementName = "CacheSettings")]
        public CacheSettings CacheSettings;
        [XmlElement(ElementName = "PricingParameter")]
        public PricingParameter PricingParameter;

        public ResponseParameters()
        {
        }
    }
}
