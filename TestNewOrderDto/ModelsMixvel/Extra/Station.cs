using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Station
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "Code")]
        public List<Code> Codes {get; set; }
        [XmlElement(ElementName = "ShortName")]
        public Name ShortName { get; set; }
        [XmlElement(ElementName = "FullName")]
        public List<Name> FullNames { get; set; }
        [XmlElement(ElementName = "GPS")]
        public GPS GPS { get; set; }
        [XmlElement(ElementName = "ToponymID")]
        public string ToponymID { get; set; }
        [XmlElement(ElementName = "StationType")]
        public string StationType { get; set; }

        [XmlElement(ElementName = "IATA_LocationCode")]
        public string LocationCode { get; set; }
        [XmlElement(ElementName = "Mixvel_LocationID")]
        public string LocationID { get; set; }
        public Station()
        {
        }
    }
}
