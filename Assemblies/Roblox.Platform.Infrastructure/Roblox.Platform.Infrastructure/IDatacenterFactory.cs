using System.Collections.Generic;

namespace Roblox.Platform.Infrastructure;

public interface IDatacenterFactory
{
	IDatacenter GetDatacenterById(int id);

	IReadOnlyCollection<int> GetDatacenterIdsByDatacenterGroupIdNoCaching(int datacenterGroupId);

	IReadOnlyCollection<IDatacenter> GetDatacentersByDatacenterGroupIdNoCaching(int datacenterGroupId);

	IReadOnlyCollection<IDatacenter> GetDatacentersByDatacenterGroupNoCaching(DatacenterGroup datacenterGroup);

	IReadOnlyCollection<int> GetDatacentersIdsByDatacenterGroupNoCaching(DatacenterGroup datacenterGroup);

	int GetDatacenterIdByGameRelayIpAddress(string ip);
}
