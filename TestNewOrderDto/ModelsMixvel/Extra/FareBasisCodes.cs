using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FareBasisCodes
    {
        [XmlElement(ElementName = "FareBasisCodes")]
        public List<FareBasisCode> FareBasisCode;
        public FareBasisCodes()
        {
        }
    }
}
