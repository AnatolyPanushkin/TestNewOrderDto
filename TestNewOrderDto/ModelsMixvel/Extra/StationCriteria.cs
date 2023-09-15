using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class StationCriteria
    {
        [XmlElement(ElementName = "PrefLevel")]
        public PrefLevel PrefLevel;
        [XmlElement(ElementName = "Station")]
        public Station Station;
        public StationCriteria()
        {
        }
    }
}
