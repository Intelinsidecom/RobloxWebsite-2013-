namespace Roblox.Thumbs;

/// <summary>
/// A json-serializable version of ThumbResult
/// </summary>
public class ScriptThumbResult
{
	public bool final;

	public string url;

	internal ScriptThumbResult(ThumbResult result, bool secureConnection)
	{
		url = result.GetUrl(secureConnection);
		final = result.final;
	}

	public ScriptThumbResult()
	{
	}
}
