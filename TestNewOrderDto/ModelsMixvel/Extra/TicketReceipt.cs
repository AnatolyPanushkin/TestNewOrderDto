using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class TicketReceipt
    {
        public TicketReceipt()
        {
        }

        [XmlElement(ElementName = "URL")]
        public string URL { get; set; }

    }
}
