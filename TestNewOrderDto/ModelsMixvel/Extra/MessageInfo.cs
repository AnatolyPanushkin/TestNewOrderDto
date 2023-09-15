using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class MessageInfo
    {
        [XmlAttribute(AttributeName = "MessageId")]
        public string MessageId { get; set; }
        [XmlAttribute(AttributeName = "TimeSent")]
        public string TimeSent { get; set; }

        public MessageInfo()
        {
            MessageId = Guid.NewGuid().ToString();
            TimeSent = DateTime.Now.ToString("s");
        }
    }
}
