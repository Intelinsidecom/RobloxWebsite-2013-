using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.StaticContent.Client;

namespace Roblox.Platform.StaticContent;

/// <inheritdoc cref="T:Roblox.Platform.StaticContent.IContentPack" />
internal class ContentPack : IContentPack
{
	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.Id" />
	public long Id { get; private set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.Name" />
	public string Name { get; private set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.Component" />
	public StaticContentComponent? Component { get; private set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.Enabled" />
	public bool Enabled { get; private set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.Validated" />
	public bool Validated { get; private set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.CssCdnUrls" />
	public ISet<Uri> CssCdnUrls { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.JavaScriptCdnUrls" />
	public ISet<Uri> JavaScriptCdnUrls { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.TranslationResourceNamespaces" />
	public ISet<string> TranslationResourceNamespaces { get; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.ComponentDependencies" />
	public ISet<StaticContentComponent> ComponentDependencies { get; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.Created" />
	public DateTime Created { get; private set; }

	/// <inheritdoc cref="P:Roblox.Platform.StaticContent.IContentPack.Updated" />
	public DateTime Updated { get; private set; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.StaticContent.ContentPack" />.
	/// </summary>
	/// <param name="contentPackResult">The <see cref="T:Roblox.StaticContent.Client.ContentPackResult" /> to fill the properties from.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="contentPackResult" />
	/// </exception>
	public ContentPack(ContentPackResult contentPackResult)
	{
		if (contentPackResult == null)
		{
			throw new ArgumentNullException("contentPackResult");
		}
		HashSet<StaticContentComponent> componentDependencies = new HashSet<StaticContentComponent>();
		string[] componentDependencies2 = contentPackResult.ComponentDependencies;
		for (int j = 0; j < componentDependencies2.Length; j++)
		{
			if (Enum.TryParse<StaticContentComponent>(componentDependencies2[j], ignoreCase: true, out var componentDependency))
			{
				componentDependencies.Add(componentDependency);
			}
		}
		Id = contentPackResult.Id;
		Name = contentPackResult.Name;
		Enabled = contentPackResult.Enabled;
		Validated = contentPackResult.Enabled && contentPackResult.Validated;
		TranslationResourceNamespaces = new HashSet<string>(from i in contentPackResult.Items.Where(IsTranslationResourceNamespace)
			select i.Value);
		ComponentDependencies = componentDependencies;
		Created = contentPackResult.Created;
		Updated = contentPackResult.Updated;
		if (Enum.TryParse<StaticContentComponent>(contentPackResult.Component, ignoreCase: true, out var component))
		{
			Component = component;
		}
	}

	private bool IsTranslationResourceNamespace(ContentPackItemResult contentPackItem)
	{
		if (contentPackItem.Type != ContentPackItemType.TranslationResourceNamespace)
		{
			return false;
		}
		return !string.IsNullOrWhiteSpace(contentPackItem.Value);
	}
}
