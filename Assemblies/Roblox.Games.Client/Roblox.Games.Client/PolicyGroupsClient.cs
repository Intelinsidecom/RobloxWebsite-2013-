using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Roblox.ApiClientBase;
using Roblox.Configuration;
using Roblox.Games.Client.Properties;

namespace Roblox.Games.Client;

public class PolicyGroupsClient : GuardedApiClientBase
{
	private readonly Func<string> _ApiKeyGetter;

	private readonly Func<string> _ServiceUrlGetter;

	public override string Name => "PolicyGroupsClient";

	protected override string ApiKey => _ApiKeyGetter();

	protected override string Endpoint => _ServiceUrlGetter();

	protected override TimeSpan Timeout => SettingsV3.Default.PolicyGroupsClientTimeout;

	public PolicyGroupsClient(Func<string> apiKeyGetter)
		: this(apiKeyGetter, () => RobloxEnvironment.GetApiEndpoint("games"))
	{
	}

	public PolicyGroupsClient(Func<string> apiKeyGetter, Func<string> serviceUrlGetter)
	{
		_ApiKeyGetter = apiKeyGetter ?? throw new ArgumentNullException("apiKeyGetter");
		_ServiceUrlGetter = serviceUrlGetter ?? throw new ArgumentNullException("serviceUrlGetter");
	}

	public PolicyGroup GetPolicyGroupByName(string name)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("name", name)
		};
		return Get<PolicyGroup>("/v1.0/PolicyGroups/GetPolicyGroupByName", queryStringParameters);
	}

	public PolicyGroup[] GetAllPolicyGroups(int? exclusiveStartId, int count, SortOrder sortOrder)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("exclusiveStartId", exclusiveStartId),
			new KeyValuePair<string, object>("maxRows", count),
			new KeyValuePair<string, object>("sortOrder", sortOrder)
		};
		return Get<PolicyGroup[]>("/v1.0/PolicyGroups/GetAllPolicyGroups", queryStringParameters);
	}

	public int CreatePolicyGroup(string name, string rccVersion = null, string applicationName = null)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("name", name)
		};
		if (!string.IsNullOrWhiteSpace(rccVersion))
		{
			list.Add(new KeyValuePair<string, object>("rccVersion", rccVersion));
		}
		if (!string.IsNullOrWhiteSpace(applicationName))
		{
			list.Add(new KeyValuePair<string, object>("applicationName", applicationName));
		}
		return Post<int>("/v1.0/PolicyGroups/CreatePolicyGroup", list);
	}

	public void UpdatePolicyGroup(int id, string name, string rccVersion = null, string applicationName = null)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id),
			new KeyValuePair<string, object>("name", name)
		};
		if (!string.IsNullOrWhiteSpace(rccVersion))
		{
			list.Add(new KeyValuePair<string, object>("rccVersion", rccVersion));
		}
		if (!string.IsNullOrWhiteSpace(applicationName))
		{
			list.Add(new KeyValuePair<string, object>("applicationName", applicationName));
		}
		Post("/v1.0/PolicyGroups/UpdatePolicyGroup", list);
	}

	public void DeletePolicyGroup(int id)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id)
		};
		Post("/v1.0/PolicyGroups/DeletePolicyGroup", queryStringParameters);
	}

	public PolicyGroupDatacenter[] GetPolicyGroupDatacentersByDatacenterIds(int[] datacenterIds)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("datacenterIds", datacenterIds)
		};
		return Get<PolicyGroupDatacenter[]>("/v1.0/PolicyGroups/GetPolicyGroupDatacentersByDatacenterIds", queryStringParameters);
	}

	public int CreatePolicyGroupDatacenter(int policyGroupId, int datacenterId)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("policyGroupId", policyGroupId),
			new KeyValuePair<string, object>("datacenterId", datacenterId)
		};
		return Post<int>("/v1.0/PolicyGroups/CreatePolicyGroupDatacenter", queryStringParameters);
	}

	public void UpdatePolicyGroupDatacenter(int id, int policyGroupId)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id),
			new KeyValuePair<string, object>("policyGroupId", policyGroupId)
		};
		Post("/v1.0/PolicyGroups/UpdatePolicyGroupDatacenter", queryStringParameters);
	}

	public PolicyGroupServer GetPolicyGroupServer(int id)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id)
		};
		return Get<PolicyGroupServer>("/v1.0/PolicyGroups/GetPolicyGroupServer", queryStringParameters);
	}

	public PolicyGroupServer[] GetAllPolicyGroupServers(int? exclusiveStartId, int count, SortOrder sortOrder)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("exclusiveStartId", exclusiveStartId),
			new KeyValuePair<string, object>("maxRows", count),
			new KeyValuePair<string, object>("sortOrder", sortOrder)
		};
		return Get<PolicyGroupServer[]>("/v1.0/PolicyGroups/GetAllPolicyGroupServers", queryStringParameters);
	}

	public int CreatePolicyGroupServer(int policyGroupId, int serverId)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("policyGroupId", policyGroupId),
			new KeyValuePair<string, object>("serverId", serverId)
		};
		return Post<int>("/v1.0/PolicyGroups/CreatePolicyGroupServer", queryStringParameters);
	}

	public LocationGroup GetLocationGroup(int id)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id)
		};
		return Get<LocationGroup>("/v1.0/PolicyGroups/GetLocationGroup", queryStringParameters);
	}

	public LocationGroup GetLocationGroupByName(string name)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("name", name)
		};
		return Get<LocationGroup>("/v1.0/PolicyGroups/GetLocationGroupByName", queryStringParameters);
	}

	public LocationGroup[] GetAllLocationGroups(int? exclusiveStartId, int count, SortOrder sortOrder)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("exclusiveStartId", exclusiveStartId),
			new KeyValuePair<string, object>("maxRows", count),
			new KeyValuePair<string, object>("sortOrder", sortOrder)
		};
		return Get<LocationGroup[]>("/v1.0/PolicyGroups/GetAllLocationGroups", queryStringParameters);
	}

	public int CreateLocationGroup(string name)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("name", name)
		};
		return Post<int>("/v1.0/PolicyGroups/CreateLocationGroup", queryStringParameters);
	}

	public void UpdateLocationGroup(int id, string name)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id),
			new KeyValuePair<string, object>("name", name)
		};
		Post("/v1.0/PolicyGroups/UpdateLocationGroup", queryStringParameters);
	}

	public void DeleteLocationGroup(int id)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id)
		};
		Post("/v1.0/PolicyGroups/DeleteLocationGroup", queryStringParameters);
	}

	public LocationGroupMember[] GetLocationGroupMembersByLocationGroupId(int locationGroupId, long? exclusiveStartId, int count, SortOrder sortOrder)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("locationGroupId", locationGroupId),
			new KeyValuePair<string, object>("exclusiveStartId", exclusiveStartId),
			new KeyValuePair<string, object>("maxRows", count),
			new KeyValuePair<string, object>("sortOrder", sortOrder)
		};
		return Get<LocationGroupMember[]>("/v1.0/PolicyGroups/GetLocationGroupMembersByLocationGroupId", queryStringParameters);
	}

	public LocationGroupMember[] GetLocationGroupMembersByLocations(IReadOnlyCollection<Location> locations)
	{
		string jsonPostData = JsonConvert.SerializeObject(new GetLocationGroupMembersPostData
		{
			Locations = locations
		});
		return PostJson<LocationGroupMember[]>("/v1.0/PolicyGroups/GetLocationGroupMembersByLocations", null, null, jsonPostData);
	}

	public long CreateLocationGroupMember(int locationGroupId, Location location)
	{
		string jsonPostData = JsonConvert.SerializeObject(new CreateLocationGroupMemberPostData
		{
			LocationGroupId = locationGroupId,
			Location = location
		});
		return PostJson<long>("/v1.0/PolicyGroups/CreateLocationGroupMember", null, null, jsonPostData);
	}

	public void UpdateLocationGroupMember(long id, int locationGroupId)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id),
			new KeyValuePair<string, object>("locationGroupId", locationGroupId)
		};
		Post("/v1.0/PolicyGroups/UpdateLocationGroupMember", queryStringParameters);
	}

	public void DeleteLocationGroupMember(long id)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("id", id)
		};
		Post("/v1.0/PolicyGroups/DeleteLocationGroupMember", queryStringParameters);
	}

	public PolicyGroupMember[] GetPolicyGroupMembersByLocationGroupId(int locationGroupId, long? exclusiveStartId, int count, SortOrder sortOrder)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("locationGroupId", locationGroupId),
			new KeyValuePair<string, object>("exclusiveStartId", exclusiveStartId),
			new KeyValuePair<string, object>("maxRows", count),
			new KeyValuePair<string, object>("sortOrder", sortOrder)
		};
		return Get<PolicyGroupMember[]>("/v1.0/PolicyGroups/GetPolicyGroupMembersByLocationGroupId", queryStringParameters);
	}

	public PolicyGroupMember[] GetPolicyGroupMembersByPolicyGroupId(int policyGroupId, long? exclusiveStartId, int count, SortOrder sortOrder)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("policyGroupId", policyGroupId),
			new KeyValuePair<string, object>("exclusiveStartId", exclusiveStartId),
			new KeyValuePair<string, object>("maxRows", count),
			new KeyValuePair<string, object>("sortOrder", sortOrder)
		};
		return Get<PolicyGroupMember[]>("/v1.0/PolicyGroups/GetPolicyGroupMembersByPolicyGroupId", queryStringParameters);
	}

	public void CreateOrUpdatePolicyGroupMembers(IReadOnlyCollection<PolicyGroupMember> policyGroupMembers)
	{
		string jsonPostData = JsonConvert.SerializeObject(new UpdatePolicyGroupMembersPostData
		{
			PolicyGroupMembers = policyGroupMembers
		});
		PostJson("/v1.0/PolicyGroups/UpdatePolicyGroupMembers", null, null, jsonPostData);
	}

	public void DeletePolicyGroupMembers(long[] ids)
	{
		List<KeyValuePair<string, object>> queryStringParameters = new List<KeyValuePair<string, object>>
		{
			new KeyValuePair<string, object>("ids", ids)
		};
		Post("/v1.0/PolicyGroups/DeletePolicyGroupMembers", queryStringParameters);
	}
}
