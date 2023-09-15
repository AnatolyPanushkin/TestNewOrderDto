using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class OtherAddress
	{
        public OtherAddress()
        {
        }

        [XmlElement(ElementName = "ContactTypeCode")]
		public string ContactTypeCode { get; set; }
		[XmlElement(ElementName = "ContactTypeText")]
		public string ContactTypeText { get; set; }
		[XmlElement(ElementName = "OtherAddressText")]
		public string OtherAddressText { get; set; }
	}
}
