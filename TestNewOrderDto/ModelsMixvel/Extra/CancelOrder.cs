using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class CancelOrder
{
    [XmlElement(ElementName = "OrderRefID", IsNullable = true)]
    public List<string> OrderRefIDs { get; set; }
}
