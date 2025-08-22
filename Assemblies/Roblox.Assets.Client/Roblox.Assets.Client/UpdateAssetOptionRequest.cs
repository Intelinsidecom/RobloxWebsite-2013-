namespace Roblox.Assets.Client
{
	public class UpdateAssetOptionRequest
	{
		public long AssetId { get; set; }
		public bool? EnableComments { get; set; }
		public bool? EnableRatings { get; set; }
		public bool? IsCopyLocked { get; set; }
		public bool? IsFriendsOnly { get; set; }
		public long? AllowedGearCategories { get; set; }
		public long? DefaultExpirationInTicks { get; set; }
		public bool? EnforceGenre { get; set; }
		public byte? MinMembershipType { get; set; }
		
		public UpdateAssetOptionRequest(long assetId)
		{
			AssetId = assetId;
		}
		
		public void SetEnableComments(bool enableComments)
		{
			EnableComments = enableComments;
		}
		
		public void SetEnableRatings(bool enableRatings)
		{
			EnableRatings = enableRatings;
		}
		
		public void SetIsCopyLocked(bool isCopyLocked)
		{
			IsCopyLocked = isCopyLocked;
		}
		
		public void SetIsFriendsOnly(bool isFriendsOnly)
		{
			IsFriendsOnly = isFriendsOnly;
		}
		
		public void SetAllowedGearCategories(long allowedGearCategories)
		{
			AllowedGearCategories = allowedGearCategories;
		}
		
		public void SetDefaultExpirationInTicks(long defaultExpirationInTicks)
		{
			DefaultExpirationInTicks = defaultExpirationInTicks;
		}
		
		public void SetEnforceGenre(bool enforceGenre)
		{
			EnforceGenre = enforceGenre;
		}
		
		public void SetMinMembershipType(byte minMembershipType)
		{
			MinMembershipType = minMembershipType;
		}
	}
}
