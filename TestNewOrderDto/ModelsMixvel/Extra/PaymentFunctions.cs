using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PaymentFunctions
    {
        public PaymentFunctions()
        {
        }

        [XmlElement(ElementName = "OrderAssociation")]
        public OrderAssociation OrderAssociation { get; set; }
        [XmlElement(ElementName = "PaymentProcessingDetails")]
        public PaymentProcessingDetails PaymentProcessingDetails { get; set; }

        [XmlElement(ElementName = "PaymentProcessingSummary")]
        public PaymentProcessingDetails PaymentProcessingSummary { get; set; }
    }
}
