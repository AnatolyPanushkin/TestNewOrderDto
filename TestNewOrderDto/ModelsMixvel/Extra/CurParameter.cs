using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class CurParameter
    {
        [XmlElement(ElementName = "CurCode")]
        public string CurCode;

        public CurParameter()
        {
        }
    }
}
