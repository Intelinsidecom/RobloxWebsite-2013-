namespace Roblox.Platform.Infrastructure;

public interface IDatacenter
{
	int Id { get; }

	string Name { get; }

	int VendorId { get; }

	double? Latitude { get; }

	double? Longitude { get; }
}
