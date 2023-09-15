using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class TCHBlank
    {
        [XmlAttribute(AttributeName = "id")]
        public string id;
        [XmlAttribute(AttributeName = "ChangeDate")]

        [XmlElement(ElementName = "BlankForm")]
        public string BlankForm;
        [XmlElement(ElementName = "BlankType")]
        public char BlankType;

        public TCHBlank()
        {
        }
    }
}
