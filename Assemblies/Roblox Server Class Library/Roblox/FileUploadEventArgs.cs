using System;

namespace Roblox;

public class FileUploadEventArgs : EventArgs
{
	public long TimeInMilliseconds;

	public long FileSizeInBytes;

	public string FileName;

	public string Destination;
}
