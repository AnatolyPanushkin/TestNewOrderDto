using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class DictionaryCarrier
    {

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "Code")]
        public List<Code> Codes { get; set; }
        [XmlElement(ElementName = "ShortName")]
        public Name ShortName { get; set; }
        [XmlElement(ElementName = "FullName")]
        public List<Name> FullNames { get; set; }
        public DictionaryCarrier()
        {
        }
    }
}
