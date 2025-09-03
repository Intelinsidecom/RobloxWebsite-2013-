using System;
using Roblox.Platform.Core;
using Client = Roblox.Platform.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

internal class TranslationStorageResponseConverter : ITranslationStorageResponseConverter
{
    public DeleteTranslationResponse ConvertDeleteTranslationResponse(Client.DeleteTranslationResponse clientResponse)
    {
        //IL_0014: Unknown result type (might be due to invalid IL or missing references)
        //IL_0019: Unknown result type (might be due to invalid IL or missing references)
        if (clientResponse != null)
        {
            DeleteTranslationResponse deleteTranslationResponse = new DeleteTranslationResponse();
            Type typeFromHandle = typeof(OperationStatusCode);
            Client.OperationStatusCode clientStatus = clientResponse.StatusCode;
            deleteTranslationResponse.StatusCode = (OperationStatusCode)Enum.Parse(typeFromHandle, clientStatus.ToString());
            return deleteTranslationResponse;
        }
        return null;
    }

    public CreateOrUpdateTranslationStatus ConvertCreateOrUpdateTranslationResponse(Client.CreateOrUpdateTranslationResponse clientResponse)
    {
        //IL_000e: Unknown result type (might be due to invalid IL or missing references)
        //IL_0013: Unknown result type (might be due to invalid IL or missing references)
        if (clientResponse != null)
        {
            Type typeFromHandle = typeof(CreateOrUpdateTranslationStatus);
            Client.CreateOrUpdateTranslationStatus clientStatus = clientResponse.Status;
            return (CreateOrUpdateTranslationStatus)Enum.Parse(typeFromHandle, clientStatus.ToString());
        }
        throw new PlatformArgumentNullException("clientResponse");
    }
}
