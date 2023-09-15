using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PricingMethodCriteria
    {
        [XmlElement(ElementName = "BestPricingOptionText")]
        public string BestPricingOptionText;
        public PricingMethodCriteria()
        {
        }
    }
}
