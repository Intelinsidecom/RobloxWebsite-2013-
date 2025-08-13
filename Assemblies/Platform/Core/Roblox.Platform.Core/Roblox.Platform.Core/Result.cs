namespace Roblox.Platform.Core;

/// <inheritdoc cref="T:Roblox.Platform.Core.IResult`1" />
public class Result<T> : IResult<T> where T : struct
{
	/// <inheritdoc cref="P:Roblox.Platform.Core.IResult`1.Response" />
	public T Response { get; }

	/// <remark>
	/// Having the constructor be public is better than having each assembly have to create their own base Result class
	/// </remark>
	/// <param name="response">Enum response value. Cannot be null.</param>
	public Result(T response)
	{
		Response = response;
	}
}
