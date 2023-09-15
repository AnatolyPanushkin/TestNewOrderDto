using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ProgramCriteria
    {
        [XmlElement(ElementName = "ProgramContract")]
        public ProgramContract ProgramContract;
        [XmlElement(ElementName = "ProgramAccount")]
        public ProgramAccount ProgramAccount;
        [XmlElement(ElementName = "TypeCode")]
        public string TypeCode;
        public ProgramCriteria()
        {
        }
    }
}
