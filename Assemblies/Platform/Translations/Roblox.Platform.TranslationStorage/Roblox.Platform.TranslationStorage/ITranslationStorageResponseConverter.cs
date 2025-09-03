using Roblox.Platform.TranslationStorage.Client;

namespace Roblox.Platform.TranslationStorage;

internal interface ITranslationStorageResponseConverter
{
    DeleteTranslationResponse ConvertDeleteTranslationResponse(Roblox.Platform.TranslationStorage.Client.DeleteTranslationResponse clientResponse);

    CreateOrUpdateTranslationStatus ConvertCreateOrUpdateTranslationResponse(Roblox.Platform.TranslationStorage.Client.CreateOrUpdateTranslationResponse clientResponse);
}
