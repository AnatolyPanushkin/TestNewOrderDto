using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ValidatingParty
    {
        [XmlElement(ElementName = "ValidatingPartyID")]
        public string ValidatingPartyID;
        [XmlElement(ElementName = "ValidatingPartyCode")]
        public string ValidatingPartyCode;
        [XmlElement(ElementName = "ValidatingPartyName")]
        public string ValidatingPartyName;
        [XmlElement(ElementName = "ValidatingPartyDesigCode")]
        public string ValidatingPartyDesigCode;
    }
}
