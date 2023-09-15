using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class Phone
	{
        public Phone()
        {
        }

        [XmlElement(ElementName = "ContactTypeCode")]
		public string ContactTypeCode { get; set; }
		[XmlElement(ElementName = "ContactTypeText")]
		public string ContactTypeText { get; set; }
		[XmlElement(ElementName = "PhoneNumber")]
		public string PhoneNumber { get; set; }
	}
}
