namespace Roblox.ApiClientBase;

public class ExclusiveStartInfo<T>
{
	public int Count { get; set; }

	public Roblox.DataV2.Core.SortOrder SortOrder { get; set; }

	public T ExclusiveStartObject { get; set; }
}
