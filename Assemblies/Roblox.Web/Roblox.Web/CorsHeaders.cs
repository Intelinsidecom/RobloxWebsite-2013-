using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using Roblox.Instrumentation;
using Roblox.Web.Properties;

namespace Roblox.Web;

public static class CorsHeaders
{
	private static readonly string _AllowedMethods = "OPTIONS, TRACE, GET, HEAD, POST, DELETE, PATCH";

	private static readonly string _AccessControlAllowHeaders = string.Join(",", XsrfTokenHelper.TokenHeaderName, "Content-Type", "Pragma", "Cache-Control", "Expires");

	private static readonly CorsOriginValidator _CorsOriginValidator = new CorsOriginValidator(StaticCounterRegistry.Instance);

	/// <summary>
	/// Adds the cors headers for requests using the OPTIONS method.  The browser will make an OPTIONS request before a CORS post, and this will add the necessary headers for the response.
	/// </summary>
	/// <param name="request">The request.</param>
	/// <param name="response">The response.</param>
	public static void AddCorsHeadersForOptions(HttpRequest request, HttpResponse response)
	{
		AddCorsHeadersForOptions(_CorsOriginValidator.GetValidatedOriginToAdd(request.UrlReferrer, request.Headers["Origin"]), delegate(string key, string value)
		{
			response.Headers[key] = value;
		}, new string[0]);
		response.Cache.SetCacheability(HttpCacheability.Private);
		response.Cache.SetExpires(DateTime.Now.AddMinutes(Settings.Default.XsrfWithCorsOptionsCacheTimeInMinutes));
	}

	/// <summary>
	/// Adds the cors headers for requests using the OPTIONS method.  The browser will make an OPTIONS request before a cross-origin POST, and this will add the necessary headers for the response.
	/// </summary>
	/// <param name="request">The request.</param>
	/// <param name="response">The response.</param>
	public static void AddCorsHeadersForOptions(HttpRequestBase request, HttpResponseBase response)
	{
		AddCorsHeadersForOptions(_CorsOriginValidator.GetValidatedOriginToAdd(request.UrlReferrer, request.Headers["Origin"]), delegate(string key, string value)
		{
			response.Headers[key] = value;
		}, new string[0]);
		response.Cache.SetCacheability(HttpCacheability.Private);
		response.Cache.SetExpires(DateTime.Now.AddMinutes(Settings.Default.XsrfWithCorsOptionsCacheTimeInMinutes));
	}

	public static void AddCorsHeadersForOptions(HttpRequestMessage request, HttpResponseMessage response, ICollection<string> customRequestHeaders = null)
	{
		if (customRequestHeaders == null)
		{
			customRequestHeaders = new string[0];
		}
		if (request.Headers.TryGetValues("Origin", out var origins))
		{
			AddCorsHeadersForOptions(_CorsOriginValidator.GetValidatedOriginToAdd(request.Headers.Referrer, origins.FirstOrDefault()), delegate(string key, string value)
			{
				response.Headers.Add(key, value);
			}, customRequestHeaders, addReferenceHeaders: false);
			response.Headers.CacheControl = new CacheControlHeaderValue
			{
				Private = true,
				MaxAge = TimeSpan.FromMinutes(Settings.Default.XsrfWithCorsOptionsCacheTimeInMinutes)
			};
		}
	}

	private static void AddCorsHeadersForOptions(string allowedDomain, Action<string, string> addHeader, ICollection<string> customRequestHeaders, bool addReferenceHeaders = true)
	{
		if (!string.IsNullOrEmpty(allowedDomain))
		{
			string allowedHeaders = _AccessControlAllowHeaders;
			if (customRequestHeaders.Any())
			{
				allowedHeaders = allowedHeaders + "," + string.Join(",", customRequestHeaders);
			}
			addHeader("Access-Control-Allow-Origin", allowedDomain);
			addHeader("Access-Control-Allow-Credentials", "true");
			addHeader("Access-Control-Allow-Headers", allowedHeaders);
			addHeader("Access-Control-Allow-Methods", _AllowedMethods);
			if (Settings.Default.AccessControlMaxAgeHeaderAddedToOptionsRequest)
			{
				addHeader("Access-Control-Max-Age", Settings.Default.AccessControlMaxAgeInSeconds.ToString());
			}
		}
		if (addReferenceHeaders)
		{
			addHeader("Allow", _AllowedMethods);
			addHeader("Public", _AllowedMethods);
		}
	}

	/// <summary>
	/// Adds the needed cors headers for cross-origin GET or POST requests.
	/// </summary>
	/// <param name="request">The request.</param>
	/// <param name="response">The response.</param>
	/// <param name="exposedHeaders">Comma-separated list of custom headers to expose to the client.  Defaults to X-CSRF-TOKEN.</param>
	public static void AddCorsHeaders(HttpRequest request, HttpResponse response, string exposedHeaders = null)
	{
		AddCorsHeaders(_CorsOriginValidator.GetValidatedOriginToAdd(request.UrlReferrer, request.Headers["Origin"]), delegate(string key, string value)
		{
			response.Headers[key] = value;
		}, exposedHeaders);
	}

	/// <summary>
	/// Adds the needed cors headers for cross-origin GET or POST requests.
	/// </summary>
	/// <param name="request">The request.</param>
	/// <param name="response">The response.</param>
	/// <param name="exposedHeaders">Comma-separated list of custom headers to expose to the client.  Defaults to X-CSRF-TOKEN.</param>
	public static void AddCorsHeaders(HttpRequestBase request, HttpResponseBase response, string exposedHeaders = null)
	{
		AddCorsHeaders(_CorsOriginValidator.GetValidatedOriginToAdd(request.UrlReferrer, request.Headers["Origin"]), delegate(string key, string value)
		{
			response.Headers[key] = value;
		}, exposedHeaders);
	}

	private static void AddCorsHeaders(string allowedDomain, Action<string, string> addHeader, string exposedHeaders)
	{
		if (!string.IsNullOrEmpty(allowedDomain))
		{
			if (string.IsNullOrEmpty(exposedHeaders))
			{
				exposedHeaders = XsrfTokenHelper.TokenHeaderName;
			}
			addHeader("Access-Control-Allow-Origin", allowedDomain);
			addHeader("Access-Control-Allow-Credentials", "true");
			addHeader("Access-Control-Expose-Headers", exposedHeaders);
		}
	}
}
