using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class LoyaltyProgram
    {
        [XmlElement(ElementName = "Carrier")]
        public Carrier Carrier;

        public LoyaltyProgram()
        {
        }
    }
}
