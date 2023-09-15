using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class ShoppingCriteria
    {
        [XmlElement(ElementName = "BaggagePricingCriteria")]
        public BaggagePricingCriteria BaggagePricingCriteria;
        [XmlElement(ElementName = "CarrierCriteria")]
        public List<CarrierCriteria> CarrierCriterias;
        [XmlElement(ElementName = "ConnectionCriteria")]
        public List<ConnectionCriteria> ConnectionCriterias;
        [XmlElement(ElementName = "FareCriteria")]
        public List<FareCriteria> FareCriterias;
        [XmlElement(ElementName = "FlightCriteria")]
        public FlightCriteria FlightCriteria;
        [XmlElement(ElementName = "OwnerCodeCriteria")]
        public OwnerCodeCriteria OwnerCodeCriteria;
        [XmlElement(ElementName = "PricingMethodCriteria")]
        public PricingMethodCriteria PricingMethodCriteria;
        [XmlElement(ElementName = "ProgramCriteria")]
        public List<ProgramCriteria> ProgramCriterias;
        [XmlElement(ElementName = "ServiceCriteria")]
        public List<ServiceCriteria> ServiceCriterias;
        [XmlElement(ElementName = "SpecialNeedsCriteria")]
        public SpecialNeedsCriteria SpecialNeedsCriteria;
        [XmlElement(ElementName = "RefundCriteria")]
        public List<string> RefundCriterias;

        public ShoppingCriteria()
        {
        }
    }
}
