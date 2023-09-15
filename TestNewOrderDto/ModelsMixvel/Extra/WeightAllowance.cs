using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class WeightAllowance
    {
        [XmlElement(ElementName = "MaximumWeightMeasure")]
        public MaximumWeightMeasure MaximumWeightMeasure { get; set; }
    }
}
