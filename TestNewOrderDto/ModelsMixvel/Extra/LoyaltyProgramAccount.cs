using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class LoyaltyProgramAccount
    {
        [XmlElement(ElementName = "AccountNumber")]
        public string AccountNumber;
        [XmlElement(ElementName = "LoyaltyProgram")]
        public LoyaltyProgram LoyaltyProgram;
        [XmlElement(ElementName = "PaxSegmentRefID")]
        public List<string> PaxSegmentRefIDs;
        public LoyaltyProgramAccount()
        {

        }
    }
}
