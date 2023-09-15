using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class DatedOperatingLeg
    {
        [XmlElement(ElementName = "Arrival")]
        public DepArr Arrival;
        [XmlElement(ElementName = "CarrierAircraftType")]
        public CarrierAircraftType CarrierAircraftType;
        [XmlElement(ElementName = "DatedOperatingLegID")]
        public string DatedOperatingLegID;
        [XmlElement(ElementName = "Dep")]
        public DepArr Dep;
    }
}
