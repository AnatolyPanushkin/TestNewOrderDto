using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class SelectedOffer
	{
        public SelectedOffer()
        {
        }

        [XmlElement(ElementName = "OfferRefID")]
		public string OfferRefID { get; set; }
		[XmlElement(ElementName = "SelectedOfferItem")]
		public List<SelectedOfferItem> SelectedOfferItems { get; set; }
	}
}
