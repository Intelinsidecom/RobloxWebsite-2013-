using System;
using System.Collections.Generic;
using System.Web;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Platform.Avatar;
using Roblox.Platform.Avatar.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Web.Code.EventStream.WebEvents;
using Roblox.Web.Devices;

namespace Roblox.Web.Code;

public class AvatarTracker : IAvatarTracker
{
	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private readonly IEventStreamer _EventStreamer;

	private IWebEventArgsFactory _WebEventArgsFactory;

	private IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly ILogger _Logger;

	private readonly System.Random _Random;

	private static List<AvatarChangeTypeEnum> _WearItemChangeTypes = new List<AvatarChangeTypeEnum>
	{
		AvatarChangeTypeEnum.WearAccessory,
		AvatarChangeTypeEnum.WearAvatarAnimation,
		AvatarChangeTypeEnum.WearBodyPart,
		AvatarChangeTypeEnum.WearClothing,
		AvatarChangeTypeEnum.WearGear
	};

	private static List<AvatarChangeTypeEnum> _RemoveItemChangeTypes = new List<AvatarChangeTypeEnum>
	{
		AvatarChangeTypeEnum.RemoveAccessory,
		AvatarChangeTypeEnum.RemoveAvatarAnimation,
		AvatarChangeTypeEnum.RemoveBodyPart,
		AvatarChangeTypeEnum.RemoveClothing,
		AvatarChangeTypeEnum.RemoveGear
	};

	public AvatarTracker(ILogger logger, IEphemeralCounterFactory ephemeralCounterFactory, IEventStreamer eventStreamer, IWebEventArgsFactory webEventArgsFactory, System.Random random = null)
	{
		_Logger = logger ?? throw new PlatformArgumentNullException(string.Format("null {0} provided to AvatarTracker.", "logger"));
		_EphemeralCounterFactory = ephemeralCounterFactory ?? throw new PlatformArgumentNullException(string.Format("null {0} provided to AvatarTracker.", "ephemeralCounterFactory"));
		_EventStreamer = eventStreamer ?? throw new PlatformArgumentNullException(string.Format("null {0} provided to AvatarTracker.", "eventStreamer"));
		_WebEventArgsFactory = webEventArgsFactory ?? throw new PlatformArgumentNullException(string.Format("null {0} provided to AvatarTracker.", "webEventArgsFactory"));
		_Random = random ?? new System.Random();
		_ClientDeviceIdentifier = new ClientDeviceIdentifier(new DeviceFactory(logger), new PlatformFactory());
	}

	public void RegisterToDiag(IAvatarFactory avatarFactory)
	{
		avatarFactory.AppearanceChangedEvent += DiagByDeviceTypeLogger;
		avatarFactory.AppearanceChangedEvent += DiagByChangeTypeLogger;
		avatarFactory.AppearanceChangedEvent += DiagBySourceTypeLogger;
	}

	public void RegisterToEventStream(IAvatarFactory avatarFactory)
	{
		avatarFactory.AppearanceChangedEvent += EventStreamLogger;
	}

	public void RegisterToDiag(ITryOnFactory tryOnFactory)
	{
		tryOnFactory.TryOnEvent += DiagByTryOnTypeLogger;
		tryOnFactory.TryOnEvent += DiagByChangeTypeLogger;
	}

	public void RegisterToEventStream(ITryOnFactory tryOnFactory)
	{
		tryOnFactory.TryOnEvent += EventStreamLogger;
	}

	public void UnregisterFromDiag(IAvatarFactory avatarFactory)
	{
		avatarFactory.AppearanceChangedEvent -= DiagByDeviceTypeLogger;
		avatarFactory.AppearanceChangedEvent -= DiagByChangeTypeLogger;
		avatarFactory.AppearanceChangedEvent -= DiagBySourceTypeLogger;
	}

	public void UnregisterFromEventStream(IAvatarFactory avatarFactory)
	{
		avatarFactory.AppearanceChangedEvent -= EventStreamLogger;
	}

	public void UnregisterFromDiag(ITryOnFactory tryOnFactory)
	{
		tryOnFactory.TryOnEvent -= DiagByTryOnTypeLogger;
		tryOnFactory.TryOnEvent -= DiagByChangeTypeLogger;
	}

	public void UnregisterFromEventStream(ITryOnFactory tryOnFactory)
	{
		tryOnFactory.TryOnEvent -= EventStreamLogger;
	}

	private bool ShouldLogToDiag()
	{
		if (Settings.Default.AvatarChangeDiagLoggingPercentage != 100)
		{
			return _Random.Next(100) < Settings.Default.AvatarChangeDiagLoggingPercentage;
		}
		return true;
	}

	private bool ShouldLogToEventStream()
	{
		if (Settings.Default.AvatarChangeEventStreamLoggingPercentage != 100)
		{
			return _Random.Next(100) < Settings.Default.AvatarChangeEventStreamLoggingPercentage;
		}
		return true;
	}

	private void SetupEventArgs(AvatarChangedEventArgs args)
	{
		if (!args.RequestDataSetup)
		{
			args.BrowserType = Browser.GetBrowser(HttpContext.Current).ToString();
			WebEventArgs webEventArgs = _WebEventArgsFactory.Create<WebEventArgs>(HttpContext.Current);
			args.ReferrerUrl = webEventArgs.ReferrerUrl;
			args.CurrentUrl = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path);
			args.PlatformTypeId = webEventArgs.PlatformTypeId;
			args.DeviceType = _ClientDeviceIdentifier.GetDeviceType(webEventArgs.UserAgent);
			args.UserAgent = webEventArgs.UserAgent;
			args.BrowserTrackerId = webEventArgs.BrowserTrackerId;
			args.UserId = webEventArgs.UserId;
			args.AvatarChangeSource = GetSource(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path), webEventArgs.ReferrerUrl, args.DeviceType, args.PlatformTypeId.GetValueOrDefault(), webEventArgs.UserAgent, webEventArgs.Target, args.AvatarChangeType, _Logger, _Random);
			args.RequestDataSetup = true;
		}
	}

	private void DiagByDeviceTypeLogger(AvatarChangedEventArgs args)
	{
		if (!ShouldLogToDiag())
		{
			return;
		}
		try
		{
			SetupEventArgs(args);
			string counterName = $"AvatarChangeByDevice_{args.DeviceType}";
			_EphemeralCounterFactory.GetCounter(counterName)?.Increment();
		}
		catch (Exception e)
		{
			_Logger?.Error(e);
		}
	}

	private void DiagByTryOnTypeLogger(AvatarChangedEventArgs args)
	{
		if (!ShouldLogToDiag())
		{
			return;
		}
		try
		{
			SetupEventArgs(args);
			string counterName = $"TryOn_{args.WearAssetTypeId}";
			_EphemeralCounterFactory.GetCounter(counterName)?.Increment();
		}
		catch (Exception e)
		{
			_Logger?.Error(e);
		}
	}

	private void DiagByChangeTypeLogger(AvatarChangedEventArgs args)
	{
		if (!ShouldLogToDiag())
		{
			return;
		}
		try
		{
			SetupEventArgs(args);
			string counterName = $"AvatarChangeByType_{args.AvatarChangeType}";
			_EphemeralCounterFactory.GetCounter(counterName)?.Increment();
		}
		catch (Exception e)
		{
			_Logger?.Error(e);
		}
	}

	private void DiagBySourceTypeLogger(AvatarChangedEventArgs args)
	{
		if (!ShouldLogToDiag())
		{
			return;
		}
		try
		{
			SetupEventArgs(args);
			string counterName = $"AvatarChangeBySource_{args.AvatarChangeSource}";
			_EphemeralCounterFactory.GetCounter(counterName)?.Increment();
		}
		catch (Exception e)
		{
			_Logger?.Error(e);
		}
	}

	private void EventStreamLogger(AvatarChangedEventArgs args)
	{
		if (!ShouldLogToEventStream())
		{
			return;
		}
		try
		{
			SetupEventArgs(args);
			args.Target = EventTarget.Avatar;
			new AvatarChangedEvent(_EventStreamer, args).Stream();
		}
		catch (Exception e)
		{
			_Logger?.Error(e);
		}
	}

	/// <summary>
	/// Very rough attempt to interpret where an avatar change request is actually coming from, from the user's perspective.
	///
	/// i.e. what action did the user take to change their avatar?
	///
	/// This is complicated by the fact that certain pages are available from within the mobile app
	/// and also available directly.
	///
	///
	/// </summary>
	public static AvatarChangeSourceEnum GetSource(string currentUrl, string referrer, DeviceType? deviceType, int? platformTypeId, string userAgent, EventTarget target, AvatarChangeTypeEnum changeType, ILogger logger = null, System.Random random = null)
	{
		try
		{
			AvatarChangeSourceEnum? resolution = null;
			string currentPage = currentUrl?.ToLower();
			string referringPage = referrer?.ToLower();
			if (target == EventTarget.ApiProxy)
			{
				resolution = AvatarChangeSourceEnum.XBox;
			}
			else if ((currentPage != null && currentPage.Contains("character.aspx")) || (referringPage != null && referringPage.Contains("character.aspx")))
			{
				resolution = AvatarChangeSourceEnum.AvatarPage;
			}
			else if (referringPage != null && referringPage.Contains("/my/avatar"))
			{
				resolution = AvatarChangeSourceEnum.AvatarPageV2;
			}
			else if (referringPage != null && referringPage.EndsWith("/docs") && referringPage.Contains("avatar") && target == EventTarget.AvatarApi)
			{
				resolution = AvatarChangeSourceEnum.SwaggerDocs;
			}
			else if (referringPage != null && referringPage.Contains("v1/avatar/assets") && target == EventTarget.AvatarApi && (_WearItemChangeTypes.Contains(changeType) || _RemoveItemChangeTypes.Contains(changeType)))
			{
				resolution = AvatarChangeSourceEnum.ItemPage;
			}
			else if (currentPage != null && currentPage.Contains("toggle-wear") && target == EventTarget.Www)
			{
				resolution = ((!userAgent.ToLower().Contains("roblox") || !deviceType.HasValue || (deviceType != DeviceType.Phone && deviceType != DeviceType.Tablet)) ? new AvatarChangeSourceEnum?(AvatarChangeSourceEnum.ItemPage) : new AvatarChangeSourceEnum?(AvatarChangeSourceEnum.MobileApp));
			}
			else if (currentPage != null && currentPage.Contains("/catalog/wearorremoveitem"))
			{
				resolution = AvatarChangeSourceEnum.MobileItemPage;
			}
			else if (target == EventTarget.AvatarApi)
			{
				resolution = AvatarChangeSourceEnum.InGameAvatarEditor;
			}
			else
			{
				resolution = AvatarChangeSourceEnum.Unknown;
				if (random != null && random.Next(100) < Settings.Default.LogUnknownSourceAvatarChangePercentage)
				{
					string msg = $"Logged avatar change from unknown source: \ncurrentUrl {currentUrl} \nreferrer {referrer} \ndeviceType {deviceType} \nplat {platformTypeId}\nua {userAgent} \ntarget {target}";
					logger?.Error(msg);
				}
			}
			return resolution.Value;
		}
		catch (Exception ex)
		{
			logger?.Error(ex);
			return AvatarChangeSourceEnum.Unknown;
		}
	}
}
