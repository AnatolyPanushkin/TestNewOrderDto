using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Commission
    {
        [XmlElement(ElementName = "Amount")]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "CommissionCode")]
        public string CommissionCode { get; set; }
        [XmlElement(ElementName = "CommissionName")]
        public string CommissionName { get; set; }
        [XmlElement(ElementName = "PTC")]
        public string PTC { get; set; }

        public Commission()
        {
        }
    }
}
