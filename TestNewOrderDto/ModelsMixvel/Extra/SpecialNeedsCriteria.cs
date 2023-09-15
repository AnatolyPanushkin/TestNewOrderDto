using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class SpecialNeedsCriteria
    {
        [XmlElement(ElementName = "AddlDataMeasure")]
        public AddlDataMeasure AddlDataMeasure;
        [XmlElement(ElementName = "Qty")]
        public int Qty;
        [XmlElement(ElementName = "SpecialServiceCode")]
        public string SpecialServiceCode;
        public SpecialNeedsCriteria()
        {
        }
    }
}
