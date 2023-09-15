using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class PricedOffer
	{
        public PricedOffer()
        {
        }

        [XmlElement(ElementName = "SelectedOffer")]
		public List<SelectedOffer> SelectedOffers { get; set; }
	}
}
