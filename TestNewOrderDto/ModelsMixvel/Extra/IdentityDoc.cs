using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class IdentityDoc
    {
        [XmlElement(ElementName = "ExpiryDate")]
        public string ExpiryDate { get; set; }
        [XmlElement(ElementName = "IdentityDocID")]
        public string IdentityDocID { get; set; }
        [XmlElement(ElementName = "IdentityDocTypeCode")]
        public string IdentityDocTypeCode { get; set; }
        [XmlElement(ElementName = "IssueDate")]
        public string IssueDate { get; set; }
        [XmlElement(ElementName = "IssuingCountryCode")]
        public string IssuingCountryCode { get; set; }
        [XmlElement(ElementName = "ResidenceCountryCode")]
        public string ResidenceCountryCode { get; set; }
        [XmlElement(ElementName = "Surname")]
        public string Surname { get; set; }
        public IdentityDoc()
        {

        }
    }
}
