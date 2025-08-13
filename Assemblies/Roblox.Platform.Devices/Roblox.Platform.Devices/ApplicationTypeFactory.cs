using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Devices;

internal class ApplicationTypeFactory : IApplicationTypeFactory
{
	private readonly IApplicationTypeEntityFactory _ApplicationTypeEntityFactory;

	public ApplicationTypeFactory()
	{
		_ApplicationTypeEntityFactory = new ApplicationTypeEntityFactory();
	}

	internal ApplicationTypeFactory(IApplicationTypeEntityFactory entityFactory)
	{
		_ApplicationTypeEntityFactory = entityFactory ?? throw new PlatformArgumentNullException("entityFactory");
	}

	public ApplicationType GetById(byte id)
	{
		if (id < 1)
		{
			throw new PlatformArgumentException("id");
		}
		IApplicationTypeEntity entity = _ApplicationTypeEntityFactory.GetById(id);
		return GetByValue(entity.Value);
	}

	public ApplicationType GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new PlatformArgumentException("value");
		}
		if (!Enum.TryParse<ApplicationType>(value, ignoreCase: false, out var applicationType))
		{
			return ApplicationType.Undefined;
		}
		return applicationType;
	}
}
