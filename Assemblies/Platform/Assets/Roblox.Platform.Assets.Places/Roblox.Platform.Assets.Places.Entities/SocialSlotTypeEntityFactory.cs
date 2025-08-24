using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class SocialSlotTypeEntityFactory : ISocialSlotTypeEntityFactory
{
	public ISocialSlotTypeEntity Get(int id)
	{
		return CalToCachedMssql(SocialSlotType.Get(id));
	}

	public ISocialSlotTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(SocialSlotType.GetByValue(value));
	}

	private static ISocialSlotTypeEntity CalToCachedMssql(SocialSlotType cal)
	{
		if (cal != null)
		{
			return new SocialSlotTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.CreatedUtc,
				Updated = cal.UpdatedUtc
			};
		}
		return null;
	}
}
