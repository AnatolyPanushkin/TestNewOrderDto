using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class Paxs
{
    [XmlArray(ElementName = "Pax")]
    public List<Pax> Paxes;
    public Paxs()
    {

    }
}
