using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    public class Coupon
    {
        public Coupon()
        {
        }

        [XmlElement(ElementName = "CouponNumber")]
        public double CouponNumber { get; set; }

        [XmlElement(ElementName = "CouponStatusCode")]
        public string CouponStatusCode { get; set; }

        [XmlElement(ElementName = "FareBasisCode")]
        public string FareBasisCode { get; set; }

        [XmlElement(ElementName = "ServiceRefID")]
        public string ServiceRefID { get; set; }

        [XmlElement(ElementName = "SoldAirlineInfo")]
        public SoldAirlineInfo SoldAirlineInfo { get; set; }
    }
}
