using System.Collections.Generic;
using System.Net;
using Roblox.Pipeline;

namespace Roblox.Http.Client;

public interface IHttpClientBuilder
{
	IReadOnlyCollection<IPipelineHandler<IHttpRequest, IHttpResponse>> Handlers { get; }

	CookieContainer CookieContainer { get; }

	void AppendHandler(IPipelineHandler<IHttpRequest, IHttpResponse> handler);

	void PrependHandler(IPipelineHandler<IHttpRequest, IHttpResponse> handler);

	void AddHandlerAfter<T>(IPipelineHandler<IHttpRequest, IHttpResponse> handler) where T : IPipelineHandler<IHttpRequest, IHttpResponse>;

	void AddHandlerBefore<T>(IPipelineHandler<IHttpRequest, IHttpResponse> handler) where T : IPipelineHandler<IHttpRequest, IHttpResponse>;

	IHttpClient Build();
}
