using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Moderation;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Moderation;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Platform.Moderation.IModerationQueueStatus" />.
/// </summary>
public class ModerationQueueStatus : IModerationQueueStatus
{
	private const int _UnknownLocaleId = 0;

	private const string _UnknownLocaleName = "unknown";

	private const string _TotalKeyName = "total";

	private readonly IModerationLocaleFactory _ModerationLocaleFactory;

	private readonly IModerationQueueMetrics _AbuseReportQueueMetrics;

	private readonly IModerationQueueMetrics _ImageQueueMetrics;

	private readonly IModerationQueueMetrics _VideoQueueMetrics;

	private readonly IModerationQueueMetrics _AudioQueueMetrics;

	private readonly IModerationQueueMetrics _MeshQueueMetrics;

	private readonly IModerationQueueMetrics _PunishmentReviewTaskQueueMetrics;

	private const int _ImageAssetTypeId = 1;

	private const int _AudioAssetTypeId = 3;

	private const int _MeshAssetTypeId = 4;

	private const int _YouTubeVideoAssetTypeId = 33;

	/// <summary>
	/// Default constructor for <see cref="T:Roblox.Platform.Moderation.ModerationQueueStatus" />.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Throws when moderationLocaleFactory, or abuseReportQueueMetrics is null.</exception>
	public ModerationQueueStatus(IModerationLocaleFactory moderationLocaleFactory, IModerationQueueMetrics abuseReportQueueMetrics, IModerationQueueMetrics imageQueueMetrics, IModerationQueueMetrics videoQueueMetrics, IModerationQueueMetrics audioQueueMetrics, IModerationQueueMetrics meshQueueMetrics, IModerationQueueMetrics punishmentReviewTaskQueueMetrics)
	{
		_ModerationLocaleFactory = moderationLocaleFactory ?? throw new ArgumentNullException("moderationLocaleFactory");
		_AbuseReportQueueMetrics = abuseReportQueueMetrics ?? throw new ArgumentNullException("abuseReportQueueMetrics");
		_ImageQueueMetrics = imageQueueMetrics ?? throw new ArgumentNullException("imageQueueMetrics");
		_VideoQueueMetrics = videoQueueMetrics ?? throw new ArgumentNullException("videoQueueMetrics");
		_AudioQueueMetrics = audioQueueMetrics ?? throw new ArgumentNullException("audioQueueMetrics");
		_MeshQueueMetrics = meshQueueMetrics ?? throw new ArgumentNullException("meshQueueMetrics");
		_PunishmentReviewTaskQueueMetrics = punishmentReviewTaskQueueMetrics ?? throw new ArgumentNullException("punishmentReviewTaskQueueMetrics");
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueStatus.GetDashboardStatus(System.Int32,System.Boolean,System.Boolean,System.Boolean)" />
	/// </summary>
	public SerializableLocaleMetrics GetDashboardStatus(int localeId, bool getNewAbuseMetrics, bool getNewAssetMetrics, bool getNewPunishmentMetrics)
	{
		SerializableQueueMetrics abuses = GetAbusesMetrics(localeId, getNewAbuseMetrics);
		SerializableQueueMetrics images = GetAssetsMetrics(localeId, 1, getNewAssetMetrics);
		SerializableQueueMetrics videos = GetAssetsMetrics(localeId, 33, getNewAssetMetrics);
		SerializableQueueMetrics audios = GetAssetsMetrics(localeId, 3, getNewAssetMetrics);
		SerializableQueueMetrics meshes = GetAssetsMetrics(localeId, 4, getNewAssetMetrics);
		SerializableQueueMetrics punishments = GetPunishmentMetrics(localeId, getNewPunishmentMetrics);
		SerializableLocaleMetrics result = default(SerializableLocaleMetrics);
		result.Abuses = abuses;
		result.Images = images;
		result.Videos = videos;
		result.Audios = audios;
		result.Meshes = meshes;
		result.Punishments = punishments;
		return result;
	}

	internal virtual SerializableQueueMetrics GetAbusesMetrics(int localeId, bool getNewMetrics)
	{
		SerializableQueueMetrics result;
		if (!getNewMetrics)
		{
			result = default(SerializableQueueMetrics);
			result.UnmoderatedCount = ReportReviewTask.GetTotalNumberOfOpenTasks();
			result.ActiveAndRecentlyActiveModerators = ReportReviewTask.GetTotalNumberOfActiveModerators();
			result.OldestUnmoderated = ReportReviewTask.GetAgeOfOldestUnmoderatedAbuseTaskInSeconds() / 60;
			return result;
		}
		result = default(SerializableQueueMetrics);
		result.UnmoderatedCount = _AbuseReportQueueMetrics.GetTotalNumberOfOpenTasksByLocale(localeId);
		result.ActiveAndRecentlyActiveModerators = _AbuseReportQueueMetrics.GetTotalNumberOfActiveModeratorsByLocale(localeId);
		result.OldestUnmoderated = _AbuseReportQueueMetrics.GetAgeOfOldestOpenTaskInSecondsByLocale(localeId) / 60;
		return result;
	}

	internal virtual SerializableQueueMetrics GetTotalAbusesMetrics()
	{
		SerializableQueueMetrics result = default(SerializableQueueMetrics);
		result.UnmoderatedCount = _AbuseReportQueueMetrics.GetTotalNumberOfOpenTasks();
		result.ActiveAndRecentlyActiveModerators = _AbuseReportQueueMetrics.GetTotalNumberOfActiveModerators();
		result.OldestUnmoderated = _AbuseReportQueueMetrics.GetAgeOfOldestOpenTaskInSeconds() / 60;
		return result;
	}

	internal virtual SerializableQueueMetrics GetTotalPunishmentMetrics()
	{
		SerializableQueueMetrics result = default(SerializableQueueMetrics);
		result.UnmoderatedCount = _PunishmentReviewTaskQueueMetrics.GetTotalNumberOfOpenTasks();
		result.ActiveAndRecentlyActiveModerators = _PunishmentReviewTaskQueueMetrics.GetTotalNumberOfActiveModerators();
		result.OldestUnmoderated = _PunishmentReviewTaskQueueMetrics.GetAgeOfOldestOpenTaskInSeconds() / 60;
		return result;
	}

	internal virtual SerializableQueueMetrics GetAssetsMetrics(int localeId, int assetTypeId, bool getNewMetrics)
	{
		SerializableQueueMetrics result;
		if (!getNewMetrics)
		{
			result = default(SerializableQueueMetrics);
			result.UnmoderatedCount = AssetReviewTask.GetTotalNumberOfOpenTasks(assetTypeId);
			result.ActiveAndRecentlyActiveModerators = AssetReviewTask.GetTotalNumberOfActiveModerators(assetTypeId);
			result.OldestUnmoderated = AssetReviewTask.GetAgeOfOldestUnmoderatedTaskInSeconds(assetTypeId) / 60;
			return result;
		}
		result = default(SerializableQueueMetrics);
		result.UnmoderatedCount = GetAssetQueueMetrics(assetTypeId).GetTotalNumberOfOpenTasksByLocale(localeId);
		result.ActiveAndRecentlyActiveModerators = GetAssetQueueMetrics(assetTypeId).GetTotalNumberOfActiveModeratorsByLocale(localeId);
		result.OldestUnmoderated = GetAssetQueueMetrics(assetTypeId).GetAgeOfOldestOpenTaskInSecondsByLocale(localeId) / 60;
		return result;
	}

	internal virtual SerializableQueueMetrics GetTotalAssetsMetrics(int assetTypeId)
	{
		SerializableQueueMetrics result = default(SerializableQueueMetrics);
		result.UnmoderatedCount = GetAssetQueueMetrics(assetTypeId).GetTotalNumberOfOpenTasks();
		result.ActiveAndRecentlyActiveModerators = GetAssetQueueMetrics(assetTypeId).GetTotalNumberOfActiveModerators();
		result.OldestUnmoderated = GetAssetQueueMetrics(assetTypeId).GetAgeOfOldestOpenTaskInSeconds() / 60;
		return result;
	}

	internal virtual SerializableQueueMetrics GetPunishmentMetrics(int localeId, bool getNewMetrics)
	{
		SerializableQueueMetrics result;
		if (!getNewMetrics)
		{
			result = default(SerializableQueueMetrics);
			result.UnmoderatedCount = PunishmentReviewTask.GetTotalNumberOfOpenUsers();
			result.ActiveAndRecentlyActiveModerators = PunishmentReviewTask.GetTotalNumberOfActiveModerators();
			result.OldestUnmoderated = PunishmentReviewTask.GetAgeOfOldestUnmoderatedPlayerTaskInSeconds() / 60;
			return result;
		}
		result = default(SerializableQueueMetrics);
		result.UnmoderatedCount = _PunishmentReviewTaskQueueMetrics.GetTotalNumberOfOpenTasksByLocale(localeId);
		result.ActiveAndRecentlyActiveModerators = _PunishmentReviewTaskQueueMetrics.GetTotalNumberOfActiveModeratorsByLocale(localeId);
		result.OldestUnmoderated = _PunishmentReviewTaskQueueMetrics.GetAgeOfOldestOpenTaskInSecondsByLocale(localeId) / 60;
		return result;
	}

	/// <summary>
	/// <inheritdoc cref="M:Roblox.Platform.Moderation.IModerationQueueStatus.GetQueueStatus" />
	/// </summary>
	public IDictionary<string, SerializableLocaleMetrics> GetQueueStatus()
	{
		SerializableLocaleMetrics localeMetrics = GetLocaleMetrics(0);
		Dictionary<string, SerializableLocaleMetrics> queueStatus = new Dictionary<string, SerializableLocaleMetrics> { ["unknown"] = localeMetrics };
		bool[] array = new bool[2] { true, false };
		foreach (bool isActive in array)
		{
			foreach (ISupportedLocale locale in from l in _ModerationLocaleFactory.GetAllModerationLocalesByActiveStatus(isActive)
				select l.SupportedLocale)
			{
				localeMetrics = GetLocaleMetrics(locale.Id);
				queueStatus[locale.LocaleCode] = localeMetrics;
			}
		}
		SerializableLocaleMetrics serializableLocaleMetrics = default(SerializableLocaleMetrics);
		serializableLocaleMetrics.Abuses = GetTotalAbusesMetrics();
		serializableLocaleMetrics.Images = GetTotalAssetsMetrics(1);
		serializableLocaleMetrics.Videos = GetTotalAssetsMetrics(33);
		serializableLocaleMetrics.Audios = GetTotalAssetsMetrics(3);
		serializableLocaleMetrics.Meshes = GetTotalAssetsMetrics(4);
		serializableLocaleMetrics.Punishments = GetTotalPunishmentMetrics();
		SerializableLocaleMetrics totalMetrics = serializableLocaleMetrics;
		queueStatus["total"] = totalMetrics;
		return queueStatus;
	}

	internal virtual SerializableLocaleMetrics GetLocaleMetrics(int localeId)
	{
		SerializableQueueMetrics abuses = GetAbusesMetrics(localeId, getNewMetrics: true);
		SerializableQueueMetrics images = GetAssetsMetrics(localeId, 1, getNewMetrics: true);
		SerializableQueueMetrics videos = GetAssetsMetrics(localeId, 33, getNewMetrics: true);
		SerializableQueueMetrics audios = GetAssetsMetrics(localeId, 3, getNewMetrics: true);
		SerializableQueueMetrics meshes = GetAssetsMetrics(localeId, 4, getNewMetrics: true);
		SerializableQueueMetrics punishments = GetPunishmentMetrics(localeId, getNewMetrics: true);
		SerializableLocaleMetrics result = default(SerializableLocaleMetrics);
		result.Abuses = abuses;
		result.Images = images;
		result.Videos = videos;
		result.Audios = audios;
		result.Meshes = meshes;
		result.Punishments = punishments;
		return result;
	}

	internal virtual IModerationQueueMetrics GetAssetQueueMetrics(int assetTypeId)
	{
		return assetTypeId switch
		{
			1 => _ImageQueueMetrics, 
			33 => _VideoQueueMetrics, 
			3 => _AudioQueueMetrics, 
			4 => _MeshQueueMetrics, 
			_ => throw new ArgumentException($"The Asset Queue Metrics for Asset Type Id : {assetTypeId} is not supported."), 
		};
	}
}
