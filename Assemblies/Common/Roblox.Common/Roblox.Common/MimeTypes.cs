using Microsoft.Win32;

namespace Roblox.Common;

public class MimeTypes
{
	public static string GetExtensionFromMime(string mimeType)
	{
		try
		{
			RegistryKey key = Registry.ClassesRoot.OpenSubKey("Mime\\Database\\Content Type\\" + mimeType, writable: false);
			if (key == null)
			{
				return null;
			}
			string str = key.GetValue("Extension") as string;
			if (string.IsNullOrEmpty(str))
			{
				return string.Empty;
			}
			return str;
		}
		catch
		{
			return string.Empty;
		}
	}

	public static string GetMimeFromExtension(string ext)
	{
		RegistryKey key = Registry.ClassesRoot.OpenSubKey(ext, writable: false);
		if (key == null)
		{
			return null;
		}
		return key.GetValue("Content Type") as string;
	}
}
