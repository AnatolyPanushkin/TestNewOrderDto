using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FareCriteria
    {
        [XmlElement(ElementName = "FareBasisCodes")]
        public List<FareBasisCodes> FareBasisCodes;
        [XmlElement(ElementName = "PrefLevel")]
        public PrefLevel PrefLevel;
        public FareCriteria()
        {
        }
    }
}
