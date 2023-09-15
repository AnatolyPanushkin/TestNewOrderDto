using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
	public class PaymentProcessingDetailsPaymentMethod
	{
        public PaymentProcessingDetailsPaymentMethod()
        {
        }

        [XmlElement(ElementName = "AccountableDoc")]
		public AccountableDoc AccountableDoc { get; set; }
        [XmlElement(ElementName = "OtherPaymentMethod")]
        public string OtherPaymentMethod { get; set; }

        [XmlElement(ElementName = "DirectBill")]
        public DirectBill DirectBill { get; set; }

    }
}
