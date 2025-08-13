using System.Collections.Generic;
using System.Linq;
using Roblox.Classification;
using Roblox.Platform.Core;

namespace Roblox.Platform.Devices;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.Devices.IPlatformFactory" />.
/// </summary>
public class PlatformFactory : IPlatformFactory
{
	private readonly IPlatformTypeTranslator _PlatformTypeTranslator;

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Platform.Devices.PlatformFactory" />
	/// </summary>
	public PlatformFactory()
		: this(new PlatformTypeTranslator(new ApplicationTypeFactory()))
	{
	}

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Platform.Devices.PlatformFactory" />
	/// </summary>
	/// <remarks>Used for unit tests.</remarks>
	/// <param name="platformTypeTranslator">An <see cref="T:Roblox.Platform.Devices.IPlatformTypeTranslator" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="platformTypeTranslator" /> is null.</exception>
	internal PlatformFactory(IPlatformTypeTranslator platformTypeTranslator)
	{
		_PlatformTypeTranslator = platformTypeTranslator ?? throw new PlatformArgumentNullException("platformTypeTranslator");
	}

	public IEnumerable<IPlatform> GetAllPlatforms()
	{
		return from platformType in Roblox.Classification.PlatformType.GetPlatformTypesPaged(0, 254)
			select platformType.Translate(_PlatformTypeTranslator);
	}

	public IPlatform GetById(byte platformTypeId)
	{
		return Roblox.Classification.PlatformType.Get(platformTypeId).Translate(_PlatformTypeTranslator);
	}

	public IPlatform GetByType(PlatformType platformType)
	{
		byte platformTypeId = _PlatformTypeTranslator.ToByte(platformType);
		return GetById(platformTypeId);
	}

	public IPlatform GetByValue(string value)
	{
		return Roblox.Classification.PlatformType.GetByValue(value).Translate(_PlatformTypeTranslator);
	}
}
