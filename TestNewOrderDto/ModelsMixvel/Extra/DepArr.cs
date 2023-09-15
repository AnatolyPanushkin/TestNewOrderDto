using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class DepArr
    {
        [XmlElement(ElementName = "AircraftScheduledDateTime")]
        public DateTime AircraftScheduledDateTime { get; set; }
        [XmlElement(ElementName = "IATA_LocationCode")]
        public string LocationCode { get; set; }
        [XmlElement(ElementName = "StationName")]
        public string StationName { get; set; }
        [XmlElement(ElementName = "TerminalName")]
        public string TerminalName { get; set; }
    }
}
