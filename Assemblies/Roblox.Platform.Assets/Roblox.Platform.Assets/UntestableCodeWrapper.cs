using System;

namespace Roblox.Platform.Assets;

/// <inheritdoc cref="T:Roblox.Platform.Assets.IUntestableCodeWrapper" />
internal class UntestableCodeWrapper : IUntestableCodeWrapper
{
	/// <inheritdoc cref="M:Roblox.Platform.Assets.IUntestableCodeWrapper.Execute(System.Action,System.String)" />
	public void Execute(Action untestableCode, string codePathName = null)
	{
		untestableCode();
	}

	/// <inheritdoc cref="M:Roblox.Platform.Assets.IUntestableCodeWrapper.Execute``1(System.Func{``0},System.String)" />
	public TResult Execute<TResult>(Func<TResult> untestableCode, string codePathName = null)
	{
		return untestableCode();
	}
}
