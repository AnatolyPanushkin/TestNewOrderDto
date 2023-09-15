using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class BaggagePricingCriteria
    {
        [XmlElement(ElementName = "BaggageOptionCode")]
        public List<string> BaggageOptionCodes;
        public BaggagePricingCriteria()
        {
        }
    }
}
