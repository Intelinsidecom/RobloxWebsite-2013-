using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Currency.Client;
using Roblox.Economy;
using Roblox.Economy.Common;
using Roblox.EventLog;
using Roblox;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.VirtualCurrency;
using Roblox.TransactionEvents;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Implements <see cref="T:Roblox.Platform.AssetMedia.IYouTubeVideoBroker" />.
/// </summary>
public class YouTubeVideoBroker : IYouTubeVideoBroker
{
	private const string _RefundVideoPurchase = "refundVideoPurchase";

	private readonly ICurrencyAuthority _CurrencyAuthority;

	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;


	private readonly ILogger _Logger;

	private readonly ITransactionStreamer _TransactionStreamer;

	private readonly IUserFactory _UserFactory;

	[ExcludeFromCodeCoverage]
	internal virtual int RobuxCurrencyId => CurrencyType.RobuxID;

	[ExcludeFromCodeCoverage]
	internal virtual long YouTubeVideoProductId => Product.YouTubeMediaItem.ID;

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.YouTubeVideoBroker" />.
	/// </summary>
	/// <param name="currencyAuthority">An <see cref="T:Roblox.Currency.Client.ICurrencyAuthority" />.</param>
	/// <param name="assetOwnershipAuthority">An <see cref="T:Roblox.Platform.AssetOwnership.IAssetOwnershipAuthority" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="currencyAuthority" />
	/// - <paramref name="assetOwnershipAuthority" />
	/// - <paramref name="logger" />
	/// </exception>
	public YouTubeVideoBroker(ICurrencyAuthority currencyAuthority, IAssetOwnershipAuthority assetOwnershipAuthority, ILogger logger, ITransactionStreamer transactionStreamer, IUserFactory userFactory)
	{
		_CurrencyAuthority = currencyAuthority ?? throw new ArgumentNullException("currencyAuthority");
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new ArgumentNullException("assetOwnershipAuthority");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_TransactionStreamer = transactionStreamer ?? throw new ArgumentNullException("transactionStreamer");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetMedia.IYouTubeVideoBroker.PurchaseVideo(Roblox.Platform.Membership.IUser,Roblox.Platform.Devices.PlatformType,System.Int64,System.Nullable{System.Int64}@)" />
	public void PurchaseVideo(IUser actingUser, PlatformType initiatingPlatformType, long videoCostInRobux, out long? saleId)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (actingUser == null)
		{
			throw new ArgumentNullException("actingUser");
		}
		Roblox.EconomyHelper.TransactionStatus status = default;
		bool ok;
		// Use reflection to avoid compile-time dependency on Roblox.Marketplace.Client types (SaleLocationType, PurchaseProductResult)
		var marketType = typeof(Market);
		var methods = marketType.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
		System.Reflection.MethodInfo target = null;
		foreach (var m in methods)
		{
			if (m.Name == "PurchaseProduct")
			{
				var ps = m.GetParameters();
				// Look for the bool-returning overload with at least 7 params where 7th is by-ref (status)
				if (m.ReturnType == typeof(bool) && ps.Length >= 7 && ps[6].ParameterType.IsByRef)
				{
					target = m;
					break;
				}
			}
		}
		if (target == null)
		{
			throw new PlatformOperationUnavailableException("Unable to locate Market.PurchaseProduct method.");
		}
		object[] args = new object[]
		{
			(long)Convert.ToInt32(actingUser.Id),
			0L,
			YouTubeVideoProductId,
			videoCostInRobux,
			false,
			(byte)initiatingPlatformType,
			status,
			Type.Missing,
			Type.Missing,
			Type.Missing
		};
		var result = target.Invoke(null, args);
		status = (Roblox.EconomyHelper.TransactionStatus)args[6];
		ok = result is bool b && b;
		saleId = null;
		if (!ok)
		{
			if ((int)status == 4)
			{
				throw new InsufficientFundsException("The user does not have enough funds to purchase video");
			}
			_Logger.Warning($"Unable to complete YouTube video sale: {status}");
			throw new PlatformOperationUnavailableException($"Unable to complete sale: {status}");
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetMedia.IYouTubeVideoBroker.RefundVideo(Roblox.Platform.Membership.IUser,System.Int64,System.Nullable{System.Int64})" />
	public void RefundVideo(IUser actingUser, long videoCostInRobux, long? saleId)
	{
		if (actingUser == null)
		{
			throw new ArgumentNullException("actingUser");
		}
		try
		{
			long balanceBefore = _CurrencyAuthority.GetRobuxBalance(actingUser.Id);
			_CurrencyAuthority.CreditRobux((long)Convert.ToInt32(actingUser.Id), videoCostInRobux);
			RecordRefundTransaction(actingUser.Id, videoCostInRobux);
			_TransactionStreamer.StreamTransactionEvent("refundVideoPurchase", UserType.User, _UserFactory.GetRobloxSystemUserId().ToString(), UserType.User, actingUser.Id.ToString(), ContentType.Asset, videoCostInRobux, balanceBefore, TransactionOriginType.MiscellaneousAdjustmentID, "Virtual Economy", DateTime.UtcNow, null, saleId);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual void RecordRefundTransaction(long userId, long robuxAmount)
	{
		TransactionHistory.Submit(userId, TransactionType.AdjustmentID, TransactionOriginType.MiscellaneousAdjustmentID, CurrencyType.RobuxID, robuxAmount);
	}
}
