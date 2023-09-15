using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class ReshopResults
{
    [XmlArray(ElementName = "ReshopOffers")]
    public List<Offer> ReshopOffers { get; set; }
}
