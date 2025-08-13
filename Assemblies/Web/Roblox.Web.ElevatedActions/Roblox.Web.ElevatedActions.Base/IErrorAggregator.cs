namespace Roblox.Web.ElevatedActions.Base;

public interface IErrorAggregator<in TError, out TAggregation>
{
	TAggregation Errors { get; }

	void Push(TError error);
}
