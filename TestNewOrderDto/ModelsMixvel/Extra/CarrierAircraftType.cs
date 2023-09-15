using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class CarrierAircraftType
    {
        [XmlElement(ElementName = "CarrierAircraftTypeCode")]
        public string CarrierAircraftTypeCode;
    }
}
