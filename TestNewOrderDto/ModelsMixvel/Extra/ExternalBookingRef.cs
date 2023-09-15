using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class ExternalBookingRef
	{
        public ExternalBookingRef()
        {
        }

        [XmlElement(ElementName = "BookingEntity")]
		public BookingEntity BookingEntity { get; set; }
		[XmlElement(ElementName = "BookingID")]
		public string BookingID { get; set; }
	}
}
