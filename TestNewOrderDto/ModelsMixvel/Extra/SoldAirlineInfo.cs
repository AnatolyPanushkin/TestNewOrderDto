﻿using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class SoldAirlineInfo
    {
        public SoldAirlineInfo()
        {
        }

        [XmlElement(ElementName = "PaxSegmentRefID")]
        public string PaxSegmentRefID { get; set; }
    }
}
