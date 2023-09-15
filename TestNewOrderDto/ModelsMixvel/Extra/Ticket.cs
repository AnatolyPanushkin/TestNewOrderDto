using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Ticket
    {
        public Ticket()
        {
        }

        [XmlElement(ElementName = "Coupon")]
        public List<Coupon> Coupons { get; set; }

        [XmlElement(ElementName = "TicketReceipt")]
        public TicketReceipt TicketReceipt { get; set; }

        [XmlElement(ElementName = "ReportingTypeCode")]
        public string ReportingTypeCode { get; set; }

        [XmlElement(ElementName = "TicketDocTypeCode")]
        public string TicketDocTypeCode { get; set; }

        [XmlElement(ElementName = "TicketNumber")]
        public string TicketNumber { get; set; }
    }
}
