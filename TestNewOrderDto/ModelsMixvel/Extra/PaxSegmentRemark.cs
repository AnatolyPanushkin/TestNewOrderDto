using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class PaxSegmentRemark
	{
        public PaxSegmentRemark()
        {
        }

        [XmlElement(ElementName = "PaxSegmentRefID")]
		public string PaxSegmentRefID { get; set; }
		[XmlElement(ElementName = "PaxRefID")]
		public string PaxRefID { get; set; }
		[XmlElement(ElementName = "Type")]
		public string Type { get; set; }
		[XmlElement(ElementName = "Text")]
		public string Text { get; set; }
	}
}
