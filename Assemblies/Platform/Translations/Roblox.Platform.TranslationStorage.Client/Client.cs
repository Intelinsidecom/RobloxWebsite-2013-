using System;
using System.Collections.Generic;
namespace Roblox.Platform.TranslationStorage.Client {

    // Enums mirror names used in platform for string-based Enum.Parse mapping
    public enum ContentVariantType : byte { Production, Draft }
    public enum OperationStatusCode : byte { Unknown, Success, Failure }
    public enum CreateOrUpdateTranslationStatus : byte { Created, Updated, NoChange }

    // Basic DTOs
    public sealed class ContentSourceType
    {
        public string Value { get; set; }
        public string Description { get; set; }
    }

    public sealed class CreateTranslationRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public bool IsSourceVariantAndLocale { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
        public string ContentLocaleType { get; set; }
        public string ContentSourceTargetId { get; set; }
        public string TranslationValue { get; set; }
        public string ChangeAgentType { get; set; }
        public long? ChangeAgentTargetId { get; set; }
    }

    public sealed class UpdateTranslationRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public string ContentSourceTargetId { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
        public string ContentLocaleType { get; set; }
        public string TranslationValue { get; set; }
        public string ChangeAgentType { get; set; }
        public long? ChangeAgentTargetId { get; set; }
    }

    public sealed class CreateOrUpdateTranslationRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public bool IsSourceVariantAndLocale { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
        public string ContentLocaleType { get; set; }
        public string ContentSourceTargetId { get; set; }
        public string TranslationValue { get; set; }
        public string ChangeAgentType { get; set; }
        public long? ChangeAgentTargetId { get; set; }
    }

    public sealed class DeleteTranslationRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
        public string ContentLocaleType { get; set; }
        public string ContentSourceTargetId { get; set; }
        public string ChangeAgentType { get; set; }
        public long? ChangeAgentTargetId { get; set; }
    }

    public sealed class GetTranslationRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public string ContentLocaleType { get; set; }
        public string ContentSourceTargetId { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
    }

    public sealed class GetTranslationsForContentLocalesRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public string ContentSourceTargetId { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
    }

    public sealed class GetTranslationsForContentSourceTargetIdsRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public string ContentLocaleType { get; set; }
        public IReadOnlyCollection<string> ContentSourceTargetIds { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
    }

    public sealed class GetTranslationHistoryRequest
    {
        public ContentSourceType ContentSourceType { get; set; }
        public ContentVariantType ContentVariantType { get; set; }
        public string ContentSourceTargetId { get; set; }
        public string ContentLocaleType { get; set; }
        public string ExclusiveStartId { get; set; }
        public int PageSize { get; set; }
        public object SortOrder { get; set; } // keep loose to avoid dependency
    }

    public sealed class MigrateTranslationsRequest
    {
        public ContentVariantType ContentVariantType { get; set; }
        public IReadOnlyCollection<MigrateTranslation> Migrations { get; set; }
    }

    public sealed class MigrateTranslation
    {
        public ContentSourceType OldContentSourceType { get; set; }
        public string OldContentSourceTargetId { get; set; }
        public ContentSourceType NewContentSourceType { get; set; }
        public string NewContentSourceTargetId { get; set; }
    }

    public sealed class GetOrCreateAutomationTypeRequest
    {
        public string AutomationType { get; set; }
    }

    // Response DTOs
    public sealed class GetTranslationResponse
    {
        public string TranslationValue { get; set; }
    }

    public sealed class ContentLocaleTranslationValue
    {
        public string ContentLocale { get; set; }
        public string TranslationValue { get; set; }
    }

    public sealed class GetTranslationsForContentLocalesResponse
    {
        public IReadOnlyCollection<ContentLocaleTranslationValue> Translations { get; set; }
    }

    public sealed class ContentSourceTargetIdTranslationValue
    {
        public string ContentSourceTargetId { get; set; }
        public string TranslationValue { get; set; }
    }

    public sealed class GetTranslationsForContentSourceTargetIdsResponse
    {
        public IReadOnlyCollection<ContentSourceTargetIdTranslationValue> Translations { get; set; }
    }

    public sealed class TranslationSummary
    {
        public string TranslationValue { get; set; }
        public string ChangeAgentType { get; set; }
        public long? ChangeAgentTargetId { get; set; }
        public DateTime Created { get; set; }
    }

    public sealed class GetTranslationHistoryResponse
    {
        public IReadOnlyCollection<TranslationSummary> History { get; set; }
        public string LastEvaluatedId { get; set; }
    }

    public sealed class CreateOrUpdateTranslationResponse
    {
        public CreateOrUpdateTranslationStatus Status { get; set; }
    }

    public sealed class DeleteTranslationResponse
    {
        public OperationStatusCode StatusCode { get; set; }
    }

    public sealed class GetOrCreateAutomationTypeResponse
    {
        public int AutomationTypeId { get; set; }
    }

    // Client interface
    public interface ITranslationStorageClient
    {
        void CreateTranslation(CreateTranslationRequest request);
        void UpdateTranslation(UpdateTranslationRequest request);
        CreateOrUpdateTranslationResponse CreateOrUpdateTranslation(CreateOrUpdateTranslationRequest request);
        DeleteTranslationResponse DeleteTranslation(DeleteTranslationRequest request);
        GetTranslationResponse GetTranslation(GetTranslationRequest request);
        GetTranslationsForContentLocalesResponse GetTranslationsForContentLocales(GetTranslationsForContentLocalesRequest request);
        GetTranslationsForContentSourceTargetIdsResponse GetTranslationsForContentSourceTargetIds(GetTranslationsForContentSourceTargetIdsRequest request);
        GetTranslationHistoryResponse GetTranslationHistory(GetTranslationHistoryRequest request);
        void MigrateTranslations(MigrateTranslationsRequest request);
        GetOrCreateAutomationTypeResponse GetOrCreateAutomationType(GetOrCreateAutomationTypeRequest request);
    }
}
