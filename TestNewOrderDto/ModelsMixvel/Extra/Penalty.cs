using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class Penalty
{
    [XmlElement(ElementName = "AppCode")]
    public string AppCode { get; set; }

    [XmlElement(ElementName = "CancelFeeInd")]
    public bool CancelFeeInd { get; set; }

    [XmlElement(ElementName = "PenaltyID")]
    public string PenaltyID { get; set; }

    [XmlElement(ElementName = "Price")]
    public Price Price { get; set; }

    [XmlElement(ElementName = "TypeCode")]
    public string TypeCode { get; set; }
}
