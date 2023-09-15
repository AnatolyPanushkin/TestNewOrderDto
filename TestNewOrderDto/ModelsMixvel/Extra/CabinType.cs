using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class CabinType
    {
        [XmlElement(ElementName = "CabinTypeCode")]
        public string CabinTypeCode;
        [XmlElement(ElementName = "PrefLevel")]
        public PrefLevel PrefLevel;

        public CabinType()
        {

        }
    }
}
