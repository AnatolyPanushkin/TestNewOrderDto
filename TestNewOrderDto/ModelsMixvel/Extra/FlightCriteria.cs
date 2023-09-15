using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FlightCriteria
    {
        [XmlElement(ElementName = "RBD")]
        public RBD RBD;
        public FlightCriteria()
        {
        }
    }
}
