using System.Threading;
using System.Threading.Tasks;
using Roblox.DataV2.Core;

namespace Roblox.StaticContent.Client;

public interface IStaticContentClient
{
	StaticContentResult CreateContentPack(string name, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies);

	Task<StaticContentResult> CreateContentPackAsync(string name, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies, CancellationToken cancellationToken);

	ContentPackResult[] GetContentPacks(string component, bool? enabled, bool? validated, SortOrder sortOrder, long? exclusiveStartContentPackId, int count);

	Task<ContentPackResult[]> GetContentPacksAsync(string component, bool? enabled, bool? validated, SortOrder sortOrder, long? exclusiveStartContentPackId, int count, CancellationToken cancellationToken);

	StaticContentResult UpdateContentPack(long id, bool enabled, bool validated);

	Task<StaticContentResult> UpdateContentPackAsync(long id, bool enabled, bool validated, CancellationToken cancellationToken);

	UploadImageResult UploadImage(string imageName, byte[] imageContent);

	Task<UploadImageResult> UploadImageAsync(string imageName, byte[] imageContent, CancellationToken cancellationToken);

	UploadSourceMapResult UploadSourceMap(string sourceMapName, string sourceMapContent);

	Task<UploadSourceMapResult> UploadSourceMapAsync(string sourceMapName, string sourceMapContent, CancellationToken cancellationToken);

	StaticContentResult CreateDevelopmentContentPack(string workspace, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies);

	Task<StaticContentResult> CreateDevelopmentContentPackAsync(string workspace, string componentName, string cssContent, string javaScriptContent, string[] translationResourceNamespaces, string[] componentDependencies, CancellationToken cancellationToken);

	string GetRawContent(long contentPackItemId);

	Task<string> GetRawContentAsync(long contentPackItemId, CancellationToken cancellationToken);
}
