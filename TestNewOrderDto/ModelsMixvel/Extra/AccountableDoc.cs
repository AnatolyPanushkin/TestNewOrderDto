using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class AccountableDoc
	{
        public AccountableDoc()
        {
        }

        [XmlElement(ElementName = "DateOfIssue")]
		public string DateOfIssue { get; set; }
		[XmlElement(ElementName = "DocNumber")]
		public string DocNumber { get; set; }
		[XmlElement(ElementName = "DocType")]
		public string DocType { get; set; }
	}
}
