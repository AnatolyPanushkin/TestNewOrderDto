using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class FareBasisCode
    {
        [XmlAttribute(AttributeName = "AirlineDesigCode")]
        public string AirlineDesigCode;
        [XmlAttribute(AttributeName = "Mixvel_AirlineID")]
        public string AirlineID;
        [XmlText]
        public string Value;
        public FareBasisCode()
        {
        }
    }
}
