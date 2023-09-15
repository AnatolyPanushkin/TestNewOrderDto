using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Desc
    {
        [XmlElement(ElementName = "Access")]
        public string Access;
        [XmlElement(ElementName = "DescText")]
        public string DescText;
    }
}
