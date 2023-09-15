using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class GPS
    {
        [XmlAttribute(AttributeName = "Latitude")]
        public double Latitude { get; set; }
        [XmlAttribute(AttributeName = "Longitude")]
        public double Longitude { get; set; }
        public GPS()
        {
        }
    }
}
