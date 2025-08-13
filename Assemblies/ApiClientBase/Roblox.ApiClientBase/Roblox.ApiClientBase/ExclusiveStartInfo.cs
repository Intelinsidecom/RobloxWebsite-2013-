namespace Roblox.ApiClientBase;

public class ExclusiveStartInfo<T>
{
	public int Count { get; set; }

	public SortOrder SortOrder { get; set; }

	public T ExclusiveStartObject { get; set; }
}
