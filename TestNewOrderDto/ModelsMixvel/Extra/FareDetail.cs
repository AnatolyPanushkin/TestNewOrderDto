using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FareDetail
    {
        public FareDetail()
        {
        }

        [XmlElement(ElementName = "FareComponent")]
        public List<FareComponent> FareComponents { get; set; }
        [XmlElement(ElementName = "PaxRefID")]
        public List<string> PaxRefIDs { get; set; }
        [XmlElement(ElementName = "Price")]
        public Price Price { get; set; }

        [XmlElement(ElementName = "FarePriceType")]
        public FarePriceType FarePriceType { get; set; }

    }
}
