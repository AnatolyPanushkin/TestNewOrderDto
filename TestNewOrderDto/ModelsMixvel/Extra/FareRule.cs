using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FareRule
    {
        [XmlElement(ElementName = "Remark")]
        public Remark Remark;
    }
}
