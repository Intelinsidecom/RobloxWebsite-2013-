namespace Roblox.Platform.Outfits;

public interface IBodyColorSet
{
	long ID { get; }

	int HeadColorID { get; }

	int LeftArmColorID { get; }

	int LeftLegColorID { get; }

	int RightArmColorID { get; }

	int RightLegColorID { get; }

	int TorsoColorID { get; }

	string BodyColorSetHash { get; }
}
