using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ReservationGuideline
    {
        [XmlElement(ElementName = "ReservationLang")]
        public string ReservationLang;
    }
}
