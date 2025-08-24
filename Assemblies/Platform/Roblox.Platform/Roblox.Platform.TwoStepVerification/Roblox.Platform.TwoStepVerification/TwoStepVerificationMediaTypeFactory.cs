using System;
using Roblox.Platform.Core;
using Roblox.Platform.TwoStepVerification.Entities;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationMediaTypeFactory" />
/// </summary>
internal class TwoStepVerificationMediaTypeFactory : ITwoStepVerificationMediaTypeFactory
{
	private readonly ITwoStepVerificationMediaTypeEntityFactory _MediaTypeEntityFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaTypeFactory" />
	/// </summary>
	/// <param name="mediaTypeEntityFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.Entities.ITwoStepVerificationMediaTypeEntityFactory" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="mediaTypeEntityFactory" /> is null.</exception>
	internal TwoStepVerificationMediaTypeFactory(ITwoStepVerificationMediaTypeEntityFactory mediaTypeEntityFactory)
	{
		_MediaTypeEntityFactory = mediaTypeEntityFactory.AssignOrThrowIfNull("mediaTypeEntityFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationMediaTypeFactory.GetIdByValue(Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType)" />
	public byte GetIdByValue(TwoStepVerificationMediaType twoStepVerificationMediaType)
	{
		return (_MediaTypeEntityFactory.GetByValue(twoStepVerificationMediaType.ToString()) ?? throw new PlatformDataIntegrityException($"Missing record for TwoStepVerificationMediaType:{twoStepVerificationMediaType}")).Id;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationMediaTypeFactory.GetValueById(System.Byte)" />
	public TwoStepVerificationMediaType GetValueById(byte id)
	{
		ITwoStepVerificationMediaTypeEntity entity = _MediaTypeEntityFactory.Get(id);
		if (entity == null)
		{
			throw new PlatformDataIntegrityException($"Missing record for TwoStepVerificationMediaTypeID:{id}");
		}
		try
		{
			return (TwoStepVerificationMediaType)Enum.Parse(typeof(TwoStepVerificationMediaType), entity.Value);
		}
		catch (Exception e)
		{
			throw new PlatformDataIntegrityException($"Missing enum value for TwoStepVerificationMediaType:{entity.Value}", e);
		}
	}
}
