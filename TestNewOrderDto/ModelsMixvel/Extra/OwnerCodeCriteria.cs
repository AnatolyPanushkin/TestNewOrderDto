using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class OwnerCodeCriteria
    {
        [XmlElement(ElementName = "Required")]
        public List<RequiredOrExcluded> Requireds;
        [XmlElement(ElementName = "Excluded")]
        public List<RequiredOrExcluded> Excludeds;
        public OwnerCodeCriteria()
        {
        }
    }
}
