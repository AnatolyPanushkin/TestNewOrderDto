using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class Price
{
    [XmlElement(ElementName = "BaseAmount")]
    public Amount BaseAmount { get; set; }
    [XmlElement(ElementName = "BaseAmountGuaranteeTimeLimitDateTime")]
    public string BaseAmountGuaranteeTimeLimitDateTime { get; set; }

    [XmlElement(ElementName = "TaxSummary")]
    public TaxSummary TaxSummary { get; set; }
    [XmlElement(ElementName = "TotalAmount")]
    public Amount TotalAmount { get; set; }
}
