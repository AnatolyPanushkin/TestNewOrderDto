using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Tax
    {
        [XmlElement(ElementName = "Amount")]
        public Amount Amount;

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode;

        [XmlElement(ElementName = "CollectionInd")]
        public bool CollectionInd { get; set; }
    }
}
