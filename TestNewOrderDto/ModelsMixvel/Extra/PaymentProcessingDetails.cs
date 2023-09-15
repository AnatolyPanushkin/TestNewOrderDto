using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class PaymentProcessingDetails
	{
        public PaymentProcessingDetails()
        {
        }

        [XmlElement(ElementName = "Amount")]
		public Amount Amount { get; set; }
		[XmlElement(ElementName = "PaymentID")]
		public string PaymentID { get; set; }
		[XmlElement(ElementName = "PaymentProcessingDetailsPaymentMethod")]
		public PaymentProcessingDetailsPaymentMethod PaymentProcessingDetailsPaymentMethod { get; set; }
	}
}
