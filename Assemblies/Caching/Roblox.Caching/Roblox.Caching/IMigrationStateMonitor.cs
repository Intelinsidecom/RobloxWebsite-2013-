namespace Roblox.Caching;

public interface IMigrationStateMonitor
{
	void RecordMigrationState(string metricsIdentifier, MigrationStateChange migrationStateChange);
}
