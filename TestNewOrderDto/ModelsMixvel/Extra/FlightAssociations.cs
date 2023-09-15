using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class FlightAssociations
	{
        public FlightAssociations()
        {
        }

        [XmlElement(ElementName = "DatedOperatingLegRef")]
		public DatedOperatingLegRef DatedOperatingLegRef { get; set; }
	}
}
