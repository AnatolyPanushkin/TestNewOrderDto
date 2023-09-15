using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ProgramAccount
    {
        [XmlElement(ElementName = "AccountID")]
        public string AccountID;
        public ProgramAccount()
        {
        }
    }
}
