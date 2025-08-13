using System;
using Roblox.Platform.Core;
using Roblox.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

internal class TranslationStorageResponseConverter : ITranslationStorageResponseConverter
{
	public DeleteTranslationResponse ConvertDeleteTranslationResponse(DeleteTranslationResponse clientResponse)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (clientResponse != null)
		{
			DeleteTranslationResponse deleteTranslationResponse = new DeleteTranslationResponse();
			Type typeFromHandle = typeof(OperationStatusCode);
			OperationStatusCode statusCode = clientResponse.StatusCode;
			deleteTranslationResponse.StatusCode = (OperationStatusCode)Enum.Parse(typeFromHandle, ((object)(OperationStatusCode)(ref statusCode)).ToString());
			return deleteTranslationResponse;
		}
		return null;
	}

	public CreateOrUpdateTranslationStatus ConvertCreateOrUpdateTranslationResponse(CreateOrUpdateTranslationResponse clientResponse)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (clientResponse != null)
		{
			Type typeFromHandle = typeof(CreateOrUpdateTranslationStatus);
			CreateOrUpdateTranslationStatus status = clientResponse.Status;
			return (CreateOrUpdateTranslationStatus)Enum.Parse(typeFromHandle, ((object)(CreateOrUpdateTranslationStatus)(ref status)).ToString());
		}
		throw new PlatformArgumentNullException("clientResponse");
	}
}
