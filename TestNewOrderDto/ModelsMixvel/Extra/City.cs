using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class City
    {
        [XmlAttribute(AttributeName = "id")]
        public string id;
        [XmlAttribute(AttributeName = "ChangeDate")]
        public string ChangeDate;

        [XmlElement(ElementName = "Code")]
        public List<Code> Codes;
        [XmlElement(ElementName = "Name")]
        public List<Name> Names;
        [XmlElement(ElementName = "GPS")]
        public GPS GPS;

        public City()
        {
        }
    }
}
