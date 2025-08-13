using System;

namespace Roblox.Http.Client;

public interface IHttpClientSettings
{
	string UserAgent { get; }

	int MaxRedirects { get; }

	TimeSpan RequestTimeout { get; }

	event Action<string> SettingChanged;
}
