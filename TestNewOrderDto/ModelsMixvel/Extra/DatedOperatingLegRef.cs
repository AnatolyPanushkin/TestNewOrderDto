using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class DatedOperatingLegRef
	{
        public DatedOperatingLegRef()
        {
        }

        [XmlElement(ElementName = "DatedOperatingLegRefID")]
		public List<string> DatedOperatingLegRefIDs { get; set; }
	}
}
