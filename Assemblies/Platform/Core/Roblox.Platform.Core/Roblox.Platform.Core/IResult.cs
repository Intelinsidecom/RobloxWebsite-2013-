namespace Roblox.Platform.Core;

/// <summary>
/// Platform code handles a lot of validation logic, and we need a way to return validation errors to the consumer.
/// This class is the core of what every response object should contain.
/// </summary>
public interface IResult<T> where T : struct
{
	/// <summary>
	/// The response code for the request. Intended to be an enum value indicating either success or a failure reason.
	/// </summary>
	T Response { get; }
}
