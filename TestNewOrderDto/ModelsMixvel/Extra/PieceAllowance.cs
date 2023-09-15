using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PieceAllowance
    {
        public PieceAllowance()
        {
        }

        [XmlElement(ElementName = "TotalQty")]
        public double TotalQty { get; set; }
    }
}
