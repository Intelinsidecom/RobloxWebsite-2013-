namespace Roblox.Caching;

public enum MigrationState : byte
{
	NoMigration,
	ReadWriteSourceDeleteOnlyDestination,
	ReadWriteSourceWriteOnlyDestination,
	ReadWriteSourceReadDiscardAndWriteDestination,
	WriteOnlySourceReadWriteDestination,
	DeleteOnlySourceReadWriteDestination,
	MigrationComplete
}
