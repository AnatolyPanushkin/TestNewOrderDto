using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OfferRequest
    {
        [XmlElement(ElementName = "OfferID")]
        public string OfferID;
    }
}
