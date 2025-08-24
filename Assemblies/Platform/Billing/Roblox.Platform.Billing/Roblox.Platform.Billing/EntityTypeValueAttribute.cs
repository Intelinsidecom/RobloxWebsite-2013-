using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
internal class EntityTypeValueAttribute : Attribute
{
	public string Value { get; private set; }

	public EntityTypeValueAttribute(string value)
	{
		if (value == null)
		{
			throw new PlatformArgumentNullException("value");
		}
		Value = value;
	}
}
