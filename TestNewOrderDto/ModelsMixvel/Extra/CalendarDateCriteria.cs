using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class CalendarDateCriteria
    {
        [XmlElement(ElementName = "DaysAfterNumber")]
        public string DaysAfterNumber;
        [XmlElement(ElementName = "DaysBeforeNumber")]
        public string DaysBeforeNumber;

        public CalendarDateCriteria()
        {

        }
    }
}
