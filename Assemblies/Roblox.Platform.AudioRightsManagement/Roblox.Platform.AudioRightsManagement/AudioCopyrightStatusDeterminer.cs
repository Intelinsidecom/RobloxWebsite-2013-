using System;
using Roblox.CatalogItemChangePublisher;
using Roblox.ContentRights.Client;
using Roblox.CopyrightedAudioDetection.Client;
using Roblox.Platform.Assets;

namespace Roblox.Platform.AudioRightsManagement;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.AudioRightsManagement.IAudioCopyrightStatusDeterminer" />.
/// </summary>
public class AudioCopyrightStatusDeterminer : IAudioCopyrightStatusDeterminer
{
	private readonly IContentRightsClient _ContentRightsClient;

	private readonly ICopyrightedAudioFileDetectionClient _CopyrightedAudioFileDetectionClient;

	private readonly Func<string, string> _Md5HashToS3UrlGetter;

	private readonly ICatalogItemChangePublisher _CatalogItemChangePublisher;

	private const string _AudioValidationSource = "AudibleMagic";

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.AudioRightsManagement.AudioCopyrightStatusDeterminer" />.
	/// </summary>
	/// <param name="contentRightsClient">An <see cref="T:Roblox.ContentRights.Client.IContentRightsClient" /></param>
	/// <param name="copyrightedAudioFileDetectionClient">An <see cref="T:Roblox.CopyrightedAudioDetection.Client.ICopyrightedAudioFileDetectionClient" /></param>
	/// <param name="md5HashToS3UrlGetter">A <see cref="T:System.Func`2" /> to map a <see cref="T:Roblox.Platform.Assets.IRawContent" />'s md5 content to a s3 url. Exists because the S3 handling code is static.</param>
	/// <param name="catalogItemChangePublisher">An <see cref="T:Roblox.CatalogItemChangePublisher.ICatalogItemChangePublisher" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="contentRightsClient" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="copyrightedAudioFileDetectionClient" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="md5HashToS3UrlGetter" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="catalogItemChangePublisher" /></exception>
	public AudioCopyrightStatusDeterminer(IContentRightsClient contentRightsClient, ICopyrightedAudioFileDetectionClient copyrightedAudioFileDetectionClient, Func<string, string> md5HashToS3UrlGetter, ICatalogItemChangePublisher catalogItemChangePublisher)
	{
		_ContentRightsClient = contentRightsClient ?? throw new ArgumentNullException("contentRightsClient");
		_CopyrightedAudioFileDetectionClient = copyrightedAudioFileDetectionClient ?? throw new ArgumentNullException("copyrightedAudioFileDetectionClient");
		_Md5HashToS3UrlGetter = md5HashToS3UrlGetter ?? throw new ArgumentNullException("md5HashToS3UrlGetter");
		_CatalogItemChangePublisher = catalogItemChangePublisher ?? throw new ArgumentNullException("catalogItemChangePublisher");
	}

	/// <inheritdoc />
	public bool DetermineAudioVersionCopyrightStatus(IAssetVersion assetVersion)
	{
		if (assetVersion == null)
		{
			throw new ArgumentNullException("assetVersion");
		}
		IRawContent rawContent = assetVersion.GetRawContent();
		if (rawContent == null)
		{
			throw new ArgumentException("AssetVersion does not have valid raw content.", "rawContent");
		}
		if (_ContentRightsClient.AreContentRightsProtected(ContentType.Audio.ToString(), rawContent.Md5Hash))
		{
			return true;
		}
		string url = _Md5HashToS3UrlGetter(rawContent.Md5Hash);
		if (string.IsNullOrEmpty(url))
		{
			throw new Exception("md5HashToS3UrlGetter returned a null or empty string.");
		}
		var (evaluatedIsProtected, metadata) = _CopyrightedAudioFileDetectionClient.IsAudioFileCopyrightProtected(url);
		if (evaluatedIsProtected)
		{
			_ContentRightsClient.SetContentRights(ContentType.Audio.ToString(), rawContent.Md5Hash, "AudibleMagic", metadata);
			_CatalogItemChangePublisher.Publish(assetVersion.AssetId);
		}
		return evaluatedIsProtected;
	}

	/// <inheritdoc />
	public AudioCopyrightStatus DetermineAudioVersionFileStatus(IAssetVersion assetVersion)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		if (assetVersion == null)
		{
			throw new ArgumentNullException("assetVersion");
		}
		IRawContent rawContent = assetVersion.GetRawContent();
		if (rawContent == null)
		{
			throw new ArgumentException("AssetVersion does not have valid raw content.", "rawContent");
		}
		if (_ContentRightsClient.AreContentRightsProtected(ContentType.Audio.ToString(), rawContent.Md5Hash))
		{
			return AudioCopyrightStatus.Copyrighted;
		}
		string url = _Md5HashToS3UrlGetter(rawContent.Md5Hash);
		if (string.IsNullOrEmpty(url))
		{
			throw new Exception("md5HashToS3UrlGetter returned a null or empty string.");
		}
		AudioFileCopyrightProtectedResponse response = _CopyrightedAudioFileDetectionClient.AudioFileCopyrightProtected(url);
		if ((int)response.FileStatus == 3)
		{
			return AudioCopyrightStatus.Invalid;
		}
		if ((int)response.CopyrightStatus == 1)
		{
			_ContentRightsClient.SetContentRights(ContentType.Audio.ToString(), rawContent.Md5Hash, "AudibleMagic", response.RawResponse);
			_CatalogItemChangePublisher.Publish(assetVersion.AssetId);
			return AudioCopyrightStatus.Copyrighted;
		}
		if ((int)response.CopyrightStatus == 0)
		{
			return AudioCopyrightStatus.Ok;
		}
		return AudioCopyrightStatus.Unknown;
	}
}
