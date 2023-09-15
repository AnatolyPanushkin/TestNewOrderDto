using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class DirectBill
    {
        public DirectBill()
        {
        }

        [XmlElement(ElementName = "BillInfo")]
        public List<string> BillInfoes { get; set; }
    }
}
