using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PricingParameter
    {
        [XmlElement(ElementName = "CommissionIncluded")]
        public List<Commission> CommissionIncluded;

        public PricingParameter()
        {
        }
    }
}
