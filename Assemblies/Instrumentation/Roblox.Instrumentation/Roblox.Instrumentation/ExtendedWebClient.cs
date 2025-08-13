using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;

namespace Roblox.Instrumentation;

internal class ExtendedWebClient : WebClient
{
	private const int _TimeoutInMilliseconds = 20000;

	internal void UploadStringGzipped(string address, string data, string username, string password)
	{
		byte[] data2 = GZip(data);
		base.Headers.Add("content-encoding", "gzip");
		AddAuthorizationHeader(username, password);
		UploadData(address, data2);
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		WebRequest webRequest = base.GetWebRequest(uri);
		if (webRequest != null)
		{
			webRequest.Timeout = 20000;
		}
		return webRequest;
	}

	private static byte[] GZip(string str)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		using MemoryStream memoryStream = new MemoryStream();
		GZipStream val = new GZipStream((Stream)memoryStream, (CompressionMode)1, true);
		try
		{
			((Stream)(object)val).Write(bytes, 0, bytes.Length);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return memoryStream.ToArray();
	}

	private void AddAuthorizationHeader(string username, string password)
	{
		if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
		{
			string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(username + ":" + password));
			string value = "Basic " + text;
			base.Headers[HttpRequestHeader.Authorization] = value;
		}
	}
}
