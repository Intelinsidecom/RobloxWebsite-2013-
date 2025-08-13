namespace Roblox.Http.Client;

public interface IHttpRequestBuilderSettings
{
	string Endpoint { get; }

	bool EncodeQueryParametersEnabled { get; }
}
