using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class ContactInfo
	{
        public ContactInfo()
        {
        }

        [XmlElement(ElementName = "ContactInfoID")]
		public string ContactInfoID { get; set; }
		[XmlElement(ElementName = "EmailAddress")]
		public EmailAddress EmailAddress { get; set; }
		[XmlElement(ElementName = "OtherAddress")]
		public OtherAddress OtherAddress { get; set; }
		[XmlElement(ElementName = "Phone")]
		public List<Phone> Phones { get; set; }
	}
}
