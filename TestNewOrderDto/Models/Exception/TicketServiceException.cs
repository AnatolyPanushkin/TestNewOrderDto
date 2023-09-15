namespace Contracts.Exception;
public class TicketServiceException : ServiceException
{
    public IResponse Context { get; init; }
    public TicketServiceException(IResponse context) : base(context.GetError(), context.Provider)
    {
        this.Context = context;
    }
}