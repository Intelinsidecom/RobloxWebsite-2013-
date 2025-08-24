using System;

namespace Roblox.Diagnostics;

internal class CustomCounterDescriptor<T>
{
	internal string GroupName { get; }

	internal Action<T> Setter { get; }

	public CustomCounterDescriptor(string groupName, object container, Type containerType)
		: this(groupName, CounterHelpers.GetSetter<T>(groupName, container, containerType))
	{
	}

	public CustomCounterDescriptor(string groupName, Action<T> setter)
	{
		GroupName = groupName;
		Setter = setter;
	}
}
