namespace Roblox.CachingV2.Core;

public interface ICacheOperationFactory
{
	IReadThroughOperation GetReadThroughOperation();

	IReadAroundOperation GetReadAroundOperation();

	IWriteAroundOperation GetWriteAroundOperation();

	IWriteThroughOperation GetWriteThroughOperation();

	IDeleteAroundOperation GetDeleteAroundOperation();

	IReadThroughWithCreationOperation GetReadThroughWithCreationOperation();

	IReadAroundWithCreationOperation GetReadAroundWithCreationOperation();
}
