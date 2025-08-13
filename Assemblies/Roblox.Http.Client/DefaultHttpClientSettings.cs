using System;
using System.Diagnostics.CodeAnalysis;

namespace Roblox.Http.Client;

[ExcludeFromCodeCoverage]
public class DefaultHttpClientSettings : IHttpClientSettings
{
	public string UserAgent { get; } = "Roblox.Http.Client";


	public int MaxRedirects { get; } = 50;


	public TimeSpan RequestTimeout { get; } = TimeSpan.FromSeconds(100.0);


	public event Action<string> SettingChanged;
}
