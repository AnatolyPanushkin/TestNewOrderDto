using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class CreateOrder
	{
        public CreateOrder()
        {
        }

        [XmlElement(ElementName = "ExternalBookingRef")]
		public ExternalBookingRef ExternalBookingRef { get; set; }
		[XmlElement(ElementName = "SelectedOffer")]
		public List<SelectedOffer> SelectedOffer { get; set; }
	}
}
