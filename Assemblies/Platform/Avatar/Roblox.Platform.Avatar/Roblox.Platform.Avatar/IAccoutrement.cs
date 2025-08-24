namespace Roblox.Platform.Avatar;

public interface IAccoutrement
{
	long UserID { get; set; }

	long UserAssetID { get; set; }

	void Delete();
}
