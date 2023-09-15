using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FormOfPayment
    {
        [XmlAttribute(AttributeName = "id")]
        public string id { get; set; }
        [XmlAttribute(AttributeName = "ChangeDate")]
        public string ChangeDate { get; set; }


        [XmlElement(ElementName = "Code")]
        public Code Code { get; set; }
        [XmlElement(ElementName = "Name")]
        public Name Name { get; set; }

        public FormOfPayment()
        {
        }
    }
}
