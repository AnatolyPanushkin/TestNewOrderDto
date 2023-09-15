using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PrefLevel
    {
        [XmlElement(ElementName = "PrefLevelCode")]
        public string PrefLevelCode;

        public PrefLevel()
        {

        }
    }
}
