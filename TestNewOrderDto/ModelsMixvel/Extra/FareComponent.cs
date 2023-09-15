using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FareComponent
    {
        [XmlElement(ElementName = "CabinType")]
        public CabinType CabinType;
        [XmlElement(ElementName = "FareBasisCode")]
        public string FareBasisCode;
        [XmlElement(ElementName = "FareRule")]
        public FareRule FareRule;
        [XmlElement(ElementName = "PaxSegmentRefID")]
        public string PaxSegmentRefID;
        [XmlElement(ElementName = "Price")]
        public Price Price;
        [XmlElement(ElementName = "PriceClassRefID")]
        public string PriceClassRefID;
        [XmlElement(ElementName = "RBD")]
        public RBD RBD;
    }
}
