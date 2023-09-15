using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class TravelCriteria
    {
        [XmlElement(ElementName = "DateRangeStart")]
        public string DateRangeStart;
        [XmlElement(ElementName = "DateRangeEnd")]
        public string DateRangeEnd;
        [XmlElement(ElementName = "Date")]
        public string Date;
        [XmlElement(ElementName = "IATA_LocationCode")]
        public string LocationCode;
        [XmlElement(ElementName = "Mixvel_LocationID")]
        public string LocationID;
        [XmlElement(ElementName = "Time")]
        public string Time;
        [XmlElement(ElementName = "TimeAfterDuration")]
        public string TimeAfterDuration;
        [XmlElement(ElementName = "TimeBeforeDuration")]
        public string TimeBeforeDuration;

        public TravelCriteria()
        {

        }
    }
}
