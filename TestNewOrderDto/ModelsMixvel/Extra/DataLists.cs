using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class DataLists
    {
        [XmlArray(ElementName = "ContactInfoList")]
        public List<ContactInfo> ContactInfoList { get; set; }
        [XmlArray(ElementName = "BaggageAllowanceList")]
        public List<BaggageAllowance> BaggageAllowanceList { get; set; }
        [XmlArray(ElementName = "OriginDestList")]
        public List<OriginDest> OriginDestList { get; set; }
        [XmlArray(ElementName = "PaxJourneyList")]
        public List<PaxJourney> PaxJourneyList { get; set; }
        [XmlArray(ElementName = "PaxList")]
        public List<Pax> PaxList { get; set; }
        [XmlArray(ElementName = "PaxSegmentList")]
        public List<PaxSegment> PaxSegmentList { get; set; }
        [XmlArray(ElementName = "PriceClassList")]
        public List<PriceClass> PriceClassList { get; set; }
        [XmlArray(ElementName = "ServiceDefinitionList")]
        public List<ServiceDefinition> ServiceDefinitionList { get; set; }
        [XmlArray(ElementName = "ValidatingPartyList")]
        public List<ValidatingParty> ValidatingPartyList { get; set; }
        [XmlArray(ElementName = "PaxSegmentRemarkList")]
        public List<PaxSegmentRemark> PaxSegmentRemarkList { get; set; }
        [XmlArray(ElementName = "PenaltyList")]
        public List<Penalty> PenaltyList { get; set; }
    }
}
