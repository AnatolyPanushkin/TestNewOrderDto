using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class AddlDataMeasure
    {
        [XmlAttribute(AttributeName = "UnitCode")]
        public string UnitCode;
        [XmlText]
        public int Value;
        public AddlDataMeasure()
        {
        }
    }
}
