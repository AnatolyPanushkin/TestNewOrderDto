using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Name
    {
        [XmlAttribute(AttributeName = "Lang")]
        public string Lang;

        [XmlText]
        public string Value;
    }
}
