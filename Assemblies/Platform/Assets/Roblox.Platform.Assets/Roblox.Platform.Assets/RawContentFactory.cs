using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Roblox.Agents;
using Roblox.Platform.Assets.Entities.AssetHash;
using Roblox.Platform.Assets.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

internal class RawContentFactory : IRawContentFactory
{
	private readonly IAssetHashEntityFactory _AssetHashEntityFactory;

	private readonly RobloxContentValidator _RobloxContentValidator;

	public RawContentFactory(IAssetHashEntityFactory assetHashEntityFactory, RobloxContentValidator robloxContentValidator)
	{
		_AssetHashEntityFactory = assetHashEntityFactory ?? throw new PlatformArgumentNullException("assetHashEntityFactory");
		_RobloxContentValidator = robloxContentValidator ?? throw new PlatformArgumentNullException("robloxContentValidator");
	}

	private IRawContent GetRawContent(IAssetHashEntity assetHashEntity)
	{
		if (assetHashEntity == null)
		{
			return null;
		}
		IAgent agent = AgentFactory.MustGet(assetHashEntity.CreatorId);
		CreatorType creatorType = agent.AgentType.ToCreatorType();
		long creatorTargetId = agent.AgentTargetId;
		return new RawContent(_AssetHashEntityFactory, assetHashEntity.Id, assetHashEntity.Hash, assetHashEntity.IsReviewed, assetHashEntity.IsApproved, creatorType, creatorTargetId, assetHashEntity.Created, assetHashEntity.Updated, (AssetType)assetHashEntity.AssetTypeId);
	}

	public IEnumerable<IRawContent> GetByMd5HashPaged(string md5Hash, int startRowIndex, int maximumRows)
	{
		return from p in _AssetHashEntityFactory.GetByMd5HashPaged(md5Hash, startRowIndex, maximumRows)
			select GetRawContent(p);
	}

	public IRawContent GetOrCreate(int assetTypeId, CreatorType creatorType, long creatorTargetId, Stream content, DecompressionMethods decompressionMethod = DecompressionMethods.None, int? expectedContentSize = null, string expectedContentHash = null, string mimeType = null)
	{
		if (expectedContentSize.HasValue && !string.IsNullOrWhiteSpace(expectedContentHash) && !_RobloxContentValidator.ValidateRobloxContent(raiseExceptions: true, content, decompressionMethod, expectedContentSize, expectedContentHash, out string _))
		{
			throw new ApplicationException("New AssetVersion content failed validation.");
		}
		if (assetTypeId == 4)
		{
			StreamReader streamReader = new StreamReader(content);
			Regex versionRegex = new Regex(Settings.Default.MeshAssetVersionValidationRegex);
			string verificationLine = streamReader.ReadLine() ?? string.Empty;
			Match match = versionRegex.Match(verificationLine);
			content.Seek(0L, SeekOrigin.Begin);
			if (!match.Success)
			{
				throw new ApplicationException("The AssetVersion content failed validation.");
			}
		}
		string contentMd5Hash = FilesManager.Singleton.AddFile(content, decompressionMethod, mimeType);
		return GetOrCreate(assetTypeId, creatorType, creatorTargetId, contentMd5Hash);
	}

	public IRawContent GetOrCreate(int assetTypeId, CreatorType creatorType, long creatorTargetId, string contentMd5Hash)
	{
		IAgent agentEntity = AgentFactory.GetByAgentTypeAndAgentTargetId(creatorType.ToAgentType(), creatorTargetId);
		if (agentEntity == null)
		{
			throw new ArgumentException(string.Format("{0} does not exist for the provided arguments: {1} = {2}; {3} = {4}", "agentEntity", "creatorType", creatorType, "creatorTargetId", creatorTargetId));
		}
		ICreator creator = CreatorRef.CreateNewRefFromAgentId(agentEntity.Id).GetCreator();
		IAssetHashEntity assetHashEntity = _AssetHashEntityFactory.GetOrCreate(assetTypeId, contentMd5Hash, creator);
		return GetRawContent(assetHashEntity);
	}

	public IRawContent CheckedGet(long? id)
	{
		IRawContent rawContent = Get(id);
		rawContent.VerifyIsNotNull();
		return rawContent;
	}

	public IRawContent Get(long? id)
	{
		if (!id.HasValue)
		{
			return null;
		}
		IAssetHashEntity assetHashEntity = _AssetHashEntityFactory.Get(id.Value);
		return GetRawContent(assetHashEntity);
	}

	[Obsolete]
	public IRawContent GetByAssetTypeAndMd5hash(int assetTypeId, string md5Hash)
	{
		if (!Enum.IsDefined(typeof(AssetType), assetTypeId))
		{
			throw new PlatformArgumentException($"AssetTypeId: {assetTypeId} doesn't exist in AssetType enum");
		}
		return GetByAssetTypeAndMd5hash((AssetType)assetTypeId, md5Hash);
	}

	public IRawContent GetByAssetTypeAndMd5hash(AssetType assetType, string md5Hash)
	{
		IAssetHashEntity assetHashEntity = _AssetHashEntityFactory.Get((int)assetType, md5Hash);
		return GetRawContent(assetHashEntity);
	}
}
