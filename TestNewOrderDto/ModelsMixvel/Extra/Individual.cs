using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Individual
    {
        [XmlElement(ElementName = "Birthdate")]
        public string Birthdate { get; set; }
        [XmlElement(ElementName = "GenderCode")]
        public string GenderCode { get; set; }
        [XmlElement(ElementName = "GivenName")]
        public List<string> GivenNames { get; set; }
        [XmlElement(ElementName = "MiddleName")]
        public List<string> MiddleNames { get; set; }
        [XmlElement(ElementName = "Surname")]
        public string Surname { get; set; }
        [XmlElement(ElementName = "PrefixName")]
        public string PrefixName { get; set; }
        public Individual()
        {

        }
    }
}
