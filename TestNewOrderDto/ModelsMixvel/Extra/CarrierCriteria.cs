using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class CarrierCriteria
    {
        [XmlElement(ElementName = "Carrier")]
        public List<Carrier> Carriers;
        [XmlElement(ElementName = "CarrierPrefID")]
        public string CarrierPrefID;
        [XmlElement(ElementName = "PrefLevel")]
        public PrefLevel PrefLevel;
        public CarrierCriteria()
        {
        }
    }
}
