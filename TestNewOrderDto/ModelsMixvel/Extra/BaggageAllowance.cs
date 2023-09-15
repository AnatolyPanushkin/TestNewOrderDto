using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class BaggageAllowance
    {
        
        [XmlElement(ElementName = "BaggageAllowanceID")]
        public string BaggageAllowanceID;
        [XmlElement(ElementName = "PieceAllowance")]
        public PieceAllowance PieceAllowance;
        [XmlElement(ElementName = "TypeCode")]
        public string TypeCode;
        [XmlElement(ElementName = "WeightAllowance")]
        public WeightAllowance WeightAllowance;
        [XmlElement(ElementName = "BaggageAllowanceRefID")]
        public string BaggageAllowanceRefID;
        [XmlElement(ElementName = "BaggageFlightAssociations")]
        public BaggageFlightAssociations BaggageFlightAssociations;
        [XmlElement(ElementName = "PaxRefID")]
        public List<string> PaxRefIDs;

    }
}
