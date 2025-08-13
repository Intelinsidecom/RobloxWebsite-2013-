namespace Roblox;

public enum FileTransferStatus
{
	DoesNotExistInTempStore = 1,
	AlreadyExistsOnPermanentStore,
	TransferToPermanentStoreSucceeded,
	ErrorDownloadingFromTempStore,
	ErrorUploadingToPermanentStore,
	ErrorVerifyingFileOnPermanentStore,
	ErrorSettingContentLocationToPermanentStore,
	ErrorDeletingFromTemporaryStore,
	ErrorRemovingTempStoreLocationId,
	DeleteFromTempStoreSucceeded,
	ErrorQueueingFileForDeletion
}
