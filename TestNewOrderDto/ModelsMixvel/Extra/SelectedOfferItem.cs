using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class SelectedOfferItem
	{
        public SelectedOfferItem()
        {
        }

        [XmlElement(ElementName = "OfferItemRefID")]
		public string OfferItemRefID { get; set; }
		[XmlElement(ElementName = "PaxRefID")]
		public List<string> PaxRefIDs { get; set; }
		[XmlElement(ElementName = "SelectedALaCarteOfferItem")]
		public SelectedALaCarteOfferItem SelectedALaCarteOfferItem { get; set; }
		[XmlElement(ElementName = "SelectedSeat")]
		public SelectedSeat SelectedSeat { get; set; }
	}
}
