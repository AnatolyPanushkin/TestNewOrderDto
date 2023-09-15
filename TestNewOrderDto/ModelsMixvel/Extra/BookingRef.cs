using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class BookingRef
    {
        public BookingRef()
        {
        }

        [XmlElement(ElementName = "BookingEntity")]
        public BookingEntity BookingEntity { get; set; }

        [XmlElement(ElementName = "BookingID")]
        public string BookingID { get; set; }

        [XmlElement(ElementName = "BookingRefTypeCode")]
        public string BookingRefTypeCode { get; set; }

    }
}
