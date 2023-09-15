using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OrderRequest
    {
        [XmlElement(ElementName = "OrderRequest")]
        public string OrderID;
    }
}
