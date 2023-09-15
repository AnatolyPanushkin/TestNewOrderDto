using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class TaxSummary
{
    [XmlElement(ElementName = "Tax")]
    public List<Tax> Taxes { get; set; }

    [XmlElement(ElementName = "TotalAmount")]
    public Amount TotalAmount { get; set; }

    [XmlElement(ElementName = "CollectionInd")]
    public bool CollectionInd { get; set; }
}
