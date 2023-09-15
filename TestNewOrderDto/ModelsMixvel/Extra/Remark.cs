using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Remark
    {
        [XmlElement(ElementName = "RemarkText")]
        public string RemarkText;
        [XmlElement(ElementName = "Timestamp")]
        public string Timestamp;

        public Remark()
        {
        }
    }
}
