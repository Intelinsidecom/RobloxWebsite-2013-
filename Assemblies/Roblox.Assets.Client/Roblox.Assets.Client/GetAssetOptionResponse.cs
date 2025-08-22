using System;

namespace Roblox.Assets.Client
{
	public class GetAssetOptionResponse
	{
		public long Id { get; set; }
		public long AssetId { get; set; }
		public bool EnableComments { get; set; }
		public bool EnableRatings { get; set; }
		public bool IsCopyLocked { get; set; }
		public bool IsFriendsOnly { get; set; }
		public long AllowedGearCategories { get; set; }
		public long DefaultExpirationInTicks { get; set; }
		public bool EnforceGenre { get; set; }
		public byte MinMembershipType { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}
