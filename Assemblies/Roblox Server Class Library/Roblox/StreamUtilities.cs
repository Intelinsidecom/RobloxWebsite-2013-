using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using Roblox.Properties;

namespace Roblox;

public static class StreamUtilities
{
	public static void CopyStream(Stream source, Stream destination)
	{
		byte[] buffer = new byte[32768];
		int bytesRead;
		while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
		{
			destination.Write(buffer, 0, bytesRead);
		}
	}

	public static string StreamToString(Stream source, DecompressionMethods decompressionMethod)
	{
		long initialPosition = 0L;
		if (source.CanSeek)
		{
			initialPosition = source.Position;
		}
		string data;
		using (MemoryStream uncompressedStream = new MemoryStream())
		{
			Uncompress(source, decompressionMethod, uncompressedStream);
			data = Encoding.UTF8.GetString(uncompressedStream.ToArray());
		}
		if (source.CanSeek)
		{
			source.Position = initialPosition;
		}
		return data;
	}

	public static void Uncompress(Stream source, DecompressionMethods method, Stream destination)
	{
		if (method == DecompressionMethods.None)
		{
			CopyStream(source, destination);
			return;
		}
		byte[] buffer = new byte[32768];
		int total = 0;
		using (Stream uncompressedStream = CreateStream(source, method, CompressionMode.Decompress))
		{
			int bytesRead;
			while ((bytesRead = uncompressedStream.Read(buffer, 0, buffer.Length)) > 0)
			{
				total += bytesRead;
				if (total > Settings.Default.MaxFileSize)
				{
					throw new ApplicationException("Roblox.Properties.Settings.Default.MaxFileSize exceeded");
				}
				destination.Write(buffer, 0, bytesRead);
			}
		}
		destination.Seek(0L, SeekOrigin.Begin);
	}

	/// <summary>
	/// Returns a ****Non-Seekable**** Zlib compressor/uncompressor
	/// </summary>
	public static Stream Wrap(Stream inner, DecompressionMethods method, CompressionMode mode)
	{
		return method switch
		{
			DecompressionMethods.GZip => new GZipStream(inner, mode, leaveOpen: true), 
			DecompressionMethods.Deflate => new DeflateStream(inner, mode, leaveOpen: true), 
			_ => throw new ApplicationException("Bad DecompressionMethods " + method), 
		};
	}

	private static Stream CreateStream(Stream stream, DecompressionMethods method, CompressionMode mode)
	{
		return method switch
		{
			DecompressionMethods.GZip => new GZipStream(stream, mode, leaveOpen: true), 
			DecompressionMethods.Deflate => new DeflateStream(stream, mode, leaveOpen: true), 
			_ => throw new ApplicationException($"Bad DecompressionMethod: {method}"), 
		};
	}
}
