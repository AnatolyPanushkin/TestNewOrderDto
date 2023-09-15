using System.Xml.Serialization;


namespace MixVel.Models.Extra
{
    public class DocFilterCriteria
    {
        public DocFilterCriteria()
        {

        }
        [XmlElement(ElementName = "DocumentNumber")]
        public string DocumentNumber { get; set; }
    }
}
