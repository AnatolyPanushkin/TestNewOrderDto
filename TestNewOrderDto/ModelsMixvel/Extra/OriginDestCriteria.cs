using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OriginDestCriteria
    {
        [XmlElement(ElementName = "CabinType")]
        public List<CabinType> CabinTypes;
        [XmlElement(ElementName = "CalendarDateCriteria")]
        public CalendarDateCriteria CalendarDateCriteria;
        [XmlElement(ElementName = "CarrierPrefRefID")]
        public List<string> CarrierPrefRefIDs;
        [XmlElement(ElementName = "ConnectionPrefRefID")]
        public string ConnectionPrefRefID;
        /// <summary>
        /// куда
        /// </summary>
        [XmlElement(ElementName = "DestArrivalCriteria")]
        public TravelCriteria DestArrivalCriteria;
        /// <summary>
        /// откуда
        /// </summary>
        [XmlElement(ElementName = "OriginDepCriteria")]
        public TravelCriteria OriginDepCriteria;

        public OriginDestCriteria()
        {
        }
    }
}
