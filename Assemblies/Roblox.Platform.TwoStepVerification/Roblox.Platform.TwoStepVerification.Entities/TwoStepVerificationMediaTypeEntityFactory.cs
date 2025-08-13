using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationMediaTypeEntityFactory : ITwoStepVerificationMediaTypeEntityFactory
{
	public ITwoStepVerificationMediaTypeEntity Get(byte id)
	{
		return CalToCachedMssql(TwoStepVerificationMediaType.Get(id));
	}

	public ITwoStepVerificationMediaTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(TwoStepVerificationMediaType.GetByValue(value));
	}

	private static ITwoStepVerificationMediaTypeEntity CalToCachedMssql(TwoStepVerificationMediaType cal)
	{
		if (cal != null)
		{
			return new TwoStepVerificationMediaTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
