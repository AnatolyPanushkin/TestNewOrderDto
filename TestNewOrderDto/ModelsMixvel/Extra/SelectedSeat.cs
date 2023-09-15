using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class SelectedSeat
	{
        public SelectedSeat()
        {
        }

        [XmlElement(ElementName = "ColumnID")]
		public string ColumnID { get; set; }
		[XmlElement(ElementName = "SeatRowNumber")]
		public string SeatRowNumber { get; set; }
	}
}
