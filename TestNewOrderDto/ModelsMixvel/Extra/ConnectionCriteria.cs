using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ConnectionCriteria
    {
        [XmlElement(ElementName = "ConnectionPrefID")]
        public string ConnectionPrefID;
        [XmlElement(ElementName = "VirtualInterlineInd")]
        public bool VirtualInterlineInd;
        [XmlElement(ElementName = "MaximumConnectionQty")]
        public int MaximumConnectionQty;
        [XmlElement(ElementName = "StationCriteria")]
        public StationCriteria StationCriteria;
        public ConnectionCriteria()
        {
        }
    }
}
