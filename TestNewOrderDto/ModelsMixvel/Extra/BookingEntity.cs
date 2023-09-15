using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class BookingEntity
	{
        public BookingEntity()
        {
        }

        [XmlElement(ElementName = "Carrier")]
		public Carrier Carrier { get; set; }
	}
}
