using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ProgramContract
    {
        [XmlElement(ElementName = "ContractID")]
        public string ContractID;
        public ProgramContract()
        {
        }
    }
}
