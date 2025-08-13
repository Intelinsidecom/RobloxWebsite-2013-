using System;

namespace Roblox.Platform.Core;

[Obsolete("Please do not add any new extension methods: https://confluence.roblox.com/display/PLATFORM/Coding+guidelines#Codingguidelines-Platform (P3)")]
public static class Extensions
{
	/// <summary>
	/// Extension method used for assignment.It takes care of null argument and
	/// throws <see cref="T:Roblox.Platform.Core.PlatformArgumentNullException" />
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="argument">The argument.</param>
	/// <param name="argumentName">Name of the argument.</param>
	/// <returns>T</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"> <paramref name="argument" />
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException"><paramref name="argumentName" /></exception>
	[Obsolete("Please use C# null propagation instead.")]
	public static T AssignOrThrowIfNull<T>(this T argument, string argumentName)
	{
		if (argumentName == null)
		{
			throw new PlatformArgumentNullException("argumentName");
		}
		if (argumentName.Trim().Length == 0)
		{
			throw new PlatformArgumentException("argumentName");
		}
		if (argument == null)
		{
			throw new PlatformArgumentNullException(argumentName);
		}
		return argument;
	}
}
