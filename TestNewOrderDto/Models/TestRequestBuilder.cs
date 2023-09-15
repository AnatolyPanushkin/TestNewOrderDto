namespace Contracts.Models;

/// <summary>
/// Тестовая фигня, изучаю этот вопрос
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRequestBuilderole<T> : IBuilder<T> where T : IRequest
{
    /// <summary>
    /// Генерирует пустой шаблон обьекта запроса
    /// </summary>
    /// <returns></returns>
    protected T GenerateTemplate();
}
public interface IRequestConfiguration
{
    public string Token { get;}  
}
public abstract class RequestBuilder<T> : IRequestBuilderole<T> where T : IRequest
{
    public IRequestConfiguration _config;
    T _message;
    public RequestBuilder(IRequestConfiguration config)
    {
        _config = config;
        _message = GenerateTemplate();
    }
    public T Build()
    {
        var temp = GenerateTemplate();
        _message = temp;
        return temp;
    }

    public abstract T GenerateTemplate();
}
public class ServiceConfiguration : IRequestConfiguration
{
    string SomeToken;
    public string Token => SomeToken;
}
public class Model : IRequest
{
    public IRequestBody Body { get; set; }
}
public class RequestBody : IRequestBody
{
    public string Text { get; set; }
}
public class BookBuilderole : RequestBuilder<Model>
{
    public BookBuilderole(IRequestConfiguration config) : base(config)
    {
    }

    public override Model GenerateTemplate()
    {
        var template = new Model();
        template.Body = new RequestBody()
        {
            Text = _config.Token
        };
        return template;
    }
}