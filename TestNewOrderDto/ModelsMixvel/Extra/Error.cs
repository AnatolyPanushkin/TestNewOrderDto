using Contracts;
using System.Xml.Serialization;

namespace MixVel.Models.Extra
{
    [Serializable]
    [XmlRoot("Error")]
    public class Error : IServiceError
    {
        [XmlElement("ErrorType")]
        public string ErrorType { get; set; }
        [XmlElement("CanRetry")]
        public bool CanRetry { get; set; }
        [XmlElement("Code")]
        public string Code { get; set; }
        [XmlElement("DescText")]
        public string DescText { get; set; }
        [XmlElement("LangCode")]
        public string LangCode { get; set; }

        public int StatusCode => 400;

        public string? OtherCode => Code;

        public string Message => DescText;

        public string OtherMessage => "";

        public string ToJSONString()
        {
            throw new NotImplementedException();
        }
    }
}
public interface IServiceError
{
    public int StatusCode { get; }
    public string? OtherCode { get; }
    public string Message { get; }
    public string OtherMessage { get; }
    public string ToJSONString();
}