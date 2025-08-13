using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Configuration.Client;

public interface IConfigurationClient
{
	bool SettingUpdatesAreAvailable(string groupName, DateTime lastModificationDateTime);

	Task<bool> SettingUpdatesAreAvailableAsync(string groupName, DateTime lastModificationDateTime, CancellationToken cancellationToken);

	bool ConnectionStringUpdatesAreAvailable(string groupName, DateTime lastModificationDateTime);

	Task<bool> ConnectionStringUpdatesAreAvailableAsync(string groupName, DateTime lastModificationDateTime, CancellationToken cancellationToken);

	Setting GetSetting(int id);

	Task<Setting> GetSettingAsync(int id, CancellationToken cancellationToken);

	Setting GetSetting(string groupName, string settingName);

	Task<Setting> GetSettingAsync(string groupName, string settingName, CancellationToken cancellationToken);

	ConnectionString GetConnectionString(int id);

	Task<ConnectionString> GetConnectionStringAsync(int id, CancellationToken cancellationToken);

	ConnectionString GetConnectionString(string groupName, string connectionStringName);

	Task<ConnectionString> GetConnectionStringAsync(string groupName, string connectionStringName, CancellationToken cancellationToken);

	[Obsolete("Please use LoadSettingsByGroupName or GetAllSettingsByGroupName instead.")]
	IReadOnlyCollection<Setting> GetSettings(string groupName, int pageSize, int page);

	[Obsolete("Please use LoadSettingsByGroupName or GetAllSettingsByGroupName instead.")]
	Task<IReadOnlyCollection<Setting>> GetSettingsAsync(string groupName, int pageSize, int page, CancellationToken cancellationToken);

	IReadOnlyCollection<ConnectionString> GetConnectionStrings(string groupName, int pageSize, int page);

	Task<IReadOnlyCollection<ConnectionString>> GetConnectionStringsAsync(string groupName, int pageSize, int page, CancellationToken cancellationToken);

	IReadOnlyCollection<ConnectionString> GetAllConnectionStrings(int pageSize, int page);

	Task<IReadOnlyCollection<ConnectionString>> GetAllConnectionStringsAsync(int pageSize, int page, CancellationToken cancellationToken);

	IReadOnlyCollection<string> GetSettingGroupNames(int pageSize, int page);

	Task<IReadOnlyCollection<string>> GetSettingGroupNamesAsync(int pageSize, int page, CancellationToken cancellationToken);

	IReadOnlyCollection<Setting> GetSettingsByPartialName(string partialName, int pageSize, int page, string groupName = null);

	Task<IReadOnlyCollection<Setting>> GetSettingsByPartialNameAsync(string partialName, int pageSize, int page, string groupName = null, CancellationToken cancellationToken = default(CancellationToken));

	[Obsolete("Please use CreateSettingV2 instead.")]
	void CreateSetting(Setting setting);

	[Obsolete("Please use CreateSettingV2 instead.")]
	Task CreateSettingAsync(Setting setting, CancellationToken cancellationToken);

	[Obsolete("Please use CreateSettingV2 instead.")]
	void CreateSetting(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction);

	[Obsolete("Please use CreateSettingV2 instead.")]
	Task CreateSettingAsync(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction, CancellationToken cancellationToken);

	void CreateConnectionString(ConnectionString connectionString);

	Task CreateConnectionStringAsync(ConnectionString connectionString, CancellationToken cancellationToken);

	void CreateConnectionString(string groupName, string connectionStringName, string value);

	Task CreateConnectionStringAsync(string groupName, string connectionStringName, string value, CancellationToken cancellationToken);

	[Obsolete("Please use CreateSettingV2 or UpdateSetting instead.")]
	void SetSetting(Setting setting);

	[Obsolete("Please use CreateSettingV2 or UpdateSetting instead.")]
	Task SetSettingAsync(Setting setting, CancellationToken cancellationToken);

	[Obsolete("Please use CreateSettingV2 or UpdateSetting instead.")]
	void SetSetting(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction);

	[Obsolete("Please use CreateSettingV2 or UpdateSetting instead.")]
	Task SetSettingAsync(string groupName, string settingName, string type, string value, string comment, bool isEnvironmentSpecific, bool isMasked, bool isValueSameForAllTestEnvironments, bool isValueUniqueForProduction, CancellationToken cancellationToken);

	void SetConnectionString(ConnectionString connectionString);

	Task SetConnectionStringAsync(ConnectionString connectionString, CancellationToken cancellationToken);

	void SetConnectionString(string groupName, string connectionStringName, string value);

	Task SetConnectionStringAsync(string groupName, string connectionStringName, string value, CancellationToken cancellationToken);

	void DeleteSetting(int id);

	Task DeleteSettingAsync(int id, CancellationToken cancellationToken);

	void DeleteConnectionString(int id);

	Task DeleteConnectionStringAsync(int id, CancellationToken cancellationToken);

	IReadOnlyCollection<Setting> GetAllSettings(int exclusiveStartSettingId, int count);

	IReadOnlyCollection<Setting> GetAllSettingsByGroupName(string groupName);

	LoadSettingsByGroupNameResult LoadSettingsByGroupName(string groupName, DateTime lastModified);

	void CreateSettingV2(string groupName, string settingName, string type, string value, string comment, SettingFlags settingFlags, int priority, SettingConditions conditions);

	void UpdateSetting(int id, string value, string comment, SettingFlags settingFlags, int priority, SettingConditions conditions, DateTime lastModified);

	void MaskSetting(int id);

	void UnmaskSetting(int id);
}
