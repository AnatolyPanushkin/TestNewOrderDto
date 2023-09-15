using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PriceClass
    {
        [XmlElement(ElementName = "Code")]
        public string Code;
        [XmlElement(ElementName = "Desc")]
        public List<Desc> Descs;
        [XmlElement(ElementName = "Name")]
        public string Name;
        [XmlElement(ElementName = "PriceClassID")]
        public string PriceClassID;
    }
}
