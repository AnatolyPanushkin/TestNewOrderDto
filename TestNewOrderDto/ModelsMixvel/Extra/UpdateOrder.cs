using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MixVel.Models.Extra;
public class UpdateOrder
{
    /// <summary>
    /// Устаревшее
    /// </summary>
    [XmlElement(ElementName = "CancelOrder")]
    public CancelOrder CancelOrder { get; set; }
    [XmlElement(ElementName = "RefundOrder")]
    public RefundOrder RefundOrder { get; set; }
}
