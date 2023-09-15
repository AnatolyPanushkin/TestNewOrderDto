using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Pax
    {
        [XmlElement(ElementName = "AgeMeasure")]
        public string AgeMeasure { get; set; }
        [XmlElement(ElementName = "CitizenshipCountryCode")]
        public string CitizenshipCountryCode { get; set; }
        [XmlElement(ElementName = "ContactInfoRefID")]
        public string ContactInfoRefID { get; set; }
        [XmlElement(ElementName = "IdentityDoc")]
        public List<IdentityDoc> IdentityDocs { get; set; }
        [XmlElement(ElementName = "Individual")]
        public Individual Individual { get; set; }
        [XmlElement(ElementName = "LoyaltyProgramAccount")]
        public List<LoyaltyProgramAccount> LoyaltyProgramAccount { get; set; }
        [XmlElement(ElementName = "PaxID")]
        public string PaxID { get; set; }
        [XmlElement(ElementName = "PaxRefID")]
        public string PaxRefID { get; set; }
        [XmlElement(ElementName = "ProfileConsentInd")]
        public bool? ProfileConsentInd { get; set; }
        [XmlElement(ElementName = "PTC")]
        public string PTC { get; set; }
        [XmlElement(ElementName = "MixvelPassengerCategoryId")]
        public string MixvelPassengerCategoryId { get; set; }
        [XmlElement(ElementName = "Remark")]
        public List<Remark> Remarks { get; set; }

        public Pax()
        {

        }
        public bool ShouldSerializeProfileConsentInd()
        {
            return ProfileConsentInd.HasValue;
        }
    }
}
