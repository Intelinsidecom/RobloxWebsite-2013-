using System.Web;

namespace Roblox.Common;

/// <summary>
/// Interface used for RequestProtocolResolver able to resolve for both HttpRequest and HttpRequest base
/// </summary>
public interface IHttpRequestProtocolResolver : IRequestProtocolResolver<HttpRequest>, IRequestProtocolResolver<HttpRequestBase>
{
}
