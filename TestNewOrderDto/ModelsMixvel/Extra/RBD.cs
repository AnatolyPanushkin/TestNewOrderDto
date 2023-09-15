using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class RBD
    {
        [XmlElement(ElementName = "MixRBDInd")]
        public bool MixRBDInd;
        [XmlElement(ElementName = "RBD_Code")]
        public List<string> RBDCodes;
        [XmlElement(ElementName = "Availability")]
        public int Availability;
        public RBD()
        {
        }
    }
}
