using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class EmailAddress
	{
        public EmailAddress()
        {
        }

        [XmlElement(ElementName = "ContactTypeCode")]
		public string ContactTypeCode { get; set; }
		[XmlElement(ElementName = "ContactTypeText")]
		public string ContactTypeText { get; set; }
		[XmlElement(ElementName = "EmailAddressText")]
		public string EmailAddressText { get; set; }
	}
}
