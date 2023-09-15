using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Code
    {
        [XmlAttribute(AttributeName = "CodeStandart")]
        public string CodeStandart;

        [XmlText]
        public string Value;

    }
}
