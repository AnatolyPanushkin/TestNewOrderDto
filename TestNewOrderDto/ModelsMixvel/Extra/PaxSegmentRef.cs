
using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class PaxSegmentRef
    {
        [XmlElement(ElementName = "PaxSegmentRefID")]
        public string PaxSegmentRefIDs;
    }
}
