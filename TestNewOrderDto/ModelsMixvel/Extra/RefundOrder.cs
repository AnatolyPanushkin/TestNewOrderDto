using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MixVel.Models.Extra;

public class RefundOrder
{
    [XmlElement(ElementName = "OrderRefID")]
    public List<string> OrderRefIDs { get; set; }
}
