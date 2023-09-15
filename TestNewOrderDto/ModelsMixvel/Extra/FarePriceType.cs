using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FarePriceType
    {
        public FarePriceType()
        {
        }

        [XmlElement(ElementName = "FarePriceTypeCode")]
        public string FarePriceTypeCode { get; set; }

        [XmlElement(ElementName = "Price")]
        public Price Price { get; set; }
    }
}
