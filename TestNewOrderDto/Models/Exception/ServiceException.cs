namespace Contracts.Exception;
// Application Exception
public class ServiceException : ApplicationException
{
    public string Code;
    public string ServiceName;
    public ServiceException()
    {
    }

    public ServiceException(string? message) : base(message)
    {
    }
    public ServiceException(string? message, string serviceName) : base(message)
    {
        Code = "400";
        ServiceName = serviceName;
    }

    public ServiceException(IServiceError error, string serviceName) : base(error.Message + ". " + error.OtherMessage ?? "")
    {
        Code = error.OtherCode;
        ServiceName = serviceName;
    }
}
