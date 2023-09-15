using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OffersGroup
    {
        [XmlArray(ElementName = "CarrierOffers")]
        public List<Offer> CarrierOffers;
    }
}
