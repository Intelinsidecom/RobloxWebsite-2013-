using System;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Pipeline;

namespace Roblox.Http.ServiceClient;

public class ApiKeyHandler : PipelineHandler<IHttpRequest, IHttpResponse>
{
	private const string _ApiKeyQueryParameterName = "apiKey";

	private const string _ApiKeyHeaderName = "Roblox-Api-Key";

	private readonly Func<string> _GetApiKey;

	private readonly Func<bool> _ApiKeyViaHeaderEnabled;

	public ApiKeyHandler(Func<string> apiKeyGetter, Func<bool> apiKeyViaHeaderEnabledGetter)
	{
		_GetApiKey = apiKeyGetter ?? throw new ArgumentNullException("apiKeyGetter");
		_ApiKeyViaHeaderEnabled = apiKeyViaHeaderEnabledGetter ?? throw new ArgumentNullException("apiKeyViaHeaderEnabledGetter");
	}

	public override void Invoke(IExecutionContext<IHttpRequest, IHttpResponse> context)
	{
		AddApiKey(context.Input);
		base.Invoke(context);
	}

	public override Task InvokeAsync(IExecutionContext<IHttpRequest, IHttpResponse> context, CancellationToken cancellationToken)
	{
		AddApiKey(context.Input);
		return base.InvokeAsync(context, cancellationToken);
	}

	private void AddApiKey(IHttpRequest request)
	{
		if (_ApiKeyViaHeaderEnabled())
		{
			request.Headers.AddOrUpdate("Roblox-Api-Key", _GetApiKey());
		}
		else
		{
			request.Url = AppendApiKey(request.Url);
		}
	}

	private Uri AppendApiKey(Uri url)
	{
		string text = string.Format("{0}={1}", "apiKey", _GetApiKey());
		if (url.AbsoluteUri.Contains(text))
		{
			return url;
		}
		if (url.AbsoluteUri.Contains("?"))
		{
			return new Uri(url.AbsoluteUri + "&" + text);
		}
		return new Uri(url.AbsoluteUri + "?" + text);
	}
}
