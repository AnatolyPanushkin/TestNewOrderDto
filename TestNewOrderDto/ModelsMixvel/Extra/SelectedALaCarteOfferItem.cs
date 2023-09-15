using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class SelectedALaCarteOfferItem
	{
        public SelectedALaCarteOfferItem()
        {
        }

        [XmlElement(ElementName = "FlightAssociations")]
		public FlightAssociations FlightAssociations { get; set; }
		[XmlElement(ElementName = "Qty")]
		public string Qty { get; set; }
	}
}
