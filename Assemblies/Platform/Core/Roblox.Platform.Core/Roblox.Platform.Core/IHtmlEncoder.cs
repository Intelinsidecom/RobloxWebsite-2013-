namespace Roblox.Platform.Core;

public interface IHtmlEncoder
{
	string Encode(string content);

	string Decode(string content);
}
