using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Roblox.Http.Client.Monitoring;

namespace Roblox.IpGeolocation.Client;

/// <summary>
/// Monitored implementation of IpLookupClient
/// </summary>
[GeneratedCode("Roblox.Nswag.Augmentor", "3.0.0.0")]
public class MonitoredIpLookupClient : IIpLookupClient
{
	private readonly IpLookupClient _Client;

	private readonly ClientRequestsMonitor _Monitor;

	/// <summary>
	/// The HttpClient is made available for configuring timeouts, etc.
	/// </summary>
	public HttpClient HttpClient { get; }

	/// <summary>
	/// Constructor for a monitored client. It's recommended to use the
	///  instead of directly creating an
	/// instance.
	/// </summary>
	/// <param name="httpClient"><see cref="P:Roblox.IpGeolocation.Client.MonitoredIpLookupClient.HttpClient" /></param>
	/// <param name="monitor"><see cref="T:Roblox.Http.Client.Monitoring.ClientRequestsMonitor" /></param>
	public MonitoredIpLookupClient(HttpClient httpClient, ClientRequestsMonitor monitor)
	{
		HttpClient = httpClient ?? throw new ArgumentNullException("httpClient");
		_Client = new IpLookupClient(httpClient);
		_Monitor = monitor ?? throw new ArgumentNullException("monitor");
	}

	/// <returns>Success</returns>
	/// <exception cref="T:Roblox.IpGeolocation.Client.SwaggerException">A server side error occurred.</exception>
	public async Task<IpGeolocationResponse> LookupAsync(string ipAddress)
	{
		return await Monitor("Lookup", () => _Client.LookupAsync(ipAddress));
	}

	/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
	/// <returns>Success</returns>
	/// <exception cref="T:Roblox.IpGeolocation.Client.SwaggerException">A server side error occurred.</exception>
	public async Task<IpGeolocationResponse> LookupAsync(string ipAddress, CancellationToken cancellationToken)
	{
		return await Monitor("Lookup", () => _Client.LookupAsync(ipAddress, cancellationToken));
	}

	private async Task Monitor(string methodName, Func<Task> method)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		_Monitor.AddOutstandingRequest(methodName);
		try
		{
			await method();
			_Monitor.AddRequestSuccess(methodName);
			_Monitor.AddResponseTime(methodName, stopwatch);
		}
		catch (Exception)
		{
			_Monitor.AddRequestFailure(methodName);
			throw;
		}
		finally
		{
			_Monitor.RemoveOutstandingRequest(methodName);
		}
	}

	private async Task<T> Monitor<T>(string methodName, Func<Task<T>> method)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		_Monitor.AddOutstandingRequest(methodName);
		try
		{
			T result = await method();
			_Monitor.AddRequestSuccess(methodName);
			_Monitor.AddResponseTime(methodName, stopwatch);
			return result;
		}
		catch (Exception)
		{
			_Monitor.AddRequestFailure(methodName);
			throw;
		}
		finally
		{
			_Monitor.RemoveOutstandingRequest(methodName);
		}
	}
}
