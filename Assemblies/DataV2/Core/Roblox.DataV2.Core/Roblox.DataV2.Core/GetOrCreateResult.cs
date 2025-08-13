namespace Roblox.DataV2.Core;

public class GetOrCreateResult<TValue>
{
	public TValue Value { get; }

	public bool Created { get; }

	public GetOrCreateResult(TValue value, bool created)
	{
		Value = value;
		Created = created;
	}
}
