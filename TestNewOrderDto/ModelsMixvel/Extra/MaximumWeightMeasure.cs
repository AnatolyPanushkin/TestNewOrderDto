using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class MaximumWeightMeasure
    {
        [XmlText]
        public string Text { get; set; }
        [XmlAttribute(AttributeName = "UnitCode")]
        public string UnitCode { get; set; }
    }
}
