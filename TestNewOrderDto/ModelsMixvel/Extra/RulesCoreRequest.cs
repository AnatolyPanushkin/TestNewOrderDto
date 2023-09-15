using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class RulesCoreRequest
    {
        [XmlElement(ElementName = "OfferRequest")]
        public OfferRequest OfferRequest;
        public RulesCoreRequest()
        {
        }
    }
}
