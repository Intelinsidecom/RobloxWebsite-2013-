using System;

namespace Roblox.Platform.Assets;

/// <summary>
/// A wrapper for untestable code to make the code path testable.
/// </summary>
internal interface IUntestableCodeWrapper
{
	/// <summary>
	/// Executes an <see cref="T:System.Action" /> wrapping an untestable code path.
	/// </summary>
	/// <param name="untestableCode">The untestable code path</param>
	/// <param name="codePathName">Optional name, useful in unit testing when the target method has more than one untestable code paths.</param>
	void Execute(Action untestableCode, string codePathName = null);

	/// <summary>
	/// Executes a <see cref="T:System.Func`1" /> wrapping an untestable code path.
	/// </summary>
	/// <param name="untestableCode">The untestable code path</param>
	/// <param name="codePathName">Optional name, useful in unit testing when the target method has more than one untestable code paths.</param>
	/// <returns>Result object of the code path.</returns>
	TResult Execute<TResult>(Func<TResult> untestableCode, string codePathName = null);
}
