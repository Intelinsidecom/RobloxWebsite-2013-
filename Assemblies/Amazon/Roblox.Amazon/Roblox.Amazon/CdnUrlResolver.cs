using System;
using System.Text;
using Roblox.Amazon.Properties;

namespace Roblox.Amazon;

internal class CdnUrlResolver
{
	public class ResolverException : Exception
	{
		public ResolverException(string message)
			: base(message)
		{
		}
	}

	/// <summary>
	///     Converts the url from the format t0.roblox.com to the one specified in the setting for CDN url
	///     eg: t0.roblox.com ---&gt;  t0roblox-a.akamaihd.net
	/// </summary>
	/// <param name="bucket">The bucket including the subdomain and roblox domain</param>
	/// <returns>Returns the CDN url for the particular subdomain</returns>
	public static string GetCdnUrl(string bucket)
	{
		StringBuilder urlBuilder = new StringBuilder();
		if (bucket != null && !bucket.Equals("") && bucket.Contains("."))
		{
			string subdomain = bucket.Substring(0, bucket.IndexOf('.'));
			urlBuilder.Append(Settings.Default.CdnUrlForAssets.Replace("{SUBDOMAIN}", subdomain));
			urlBuilder.Append("/");
			return urlBuilder.ToString();
		}
		throw new ResolverException("Could not resolve the cdn url for: " + bucket);
	}
}
