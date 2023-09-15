using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class OrderAssociation
	{
        public OrderAssociation()
        {
        }

        [XmlElement(ElementName = "OrderItemRefID")]
		public List<string> OrderItemRefIDs { get; set; }
		[XmlElement(ElementName = "OrderRefID")]
		public string OrderRefID { get; set; }
	}
}
