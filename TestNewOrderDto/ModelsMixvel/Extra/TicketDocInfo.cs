using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class TicketDocInfo
    {
        public TicketDocInfo()
        {
        }

        [XmlElement(ElementName = "BookingRef")]
        public List<BookingRef> BookingRefs { get; set; }

        [XmlElement(ElementName = "FareDetail")]
        public FareDetail FareDetail { get; set; }

        [XmlElement(ElementName = "IssueDateTime")]
        public DateTime IssueDateTime { get; set; }

        [XmlElement(ElementName = "PaxRefID")]
        public string PaxRefID { get; set; }

        [XmlElement(ElementName = "Ticket")]
        public Ticket Ticket { get; set; }
    }
}
