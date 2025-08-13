using System;
using Roblox.Economy.Common.Properties;
using Roblox.TransactionEvents;

namespace Roblox.Economy.Common;

public class Helper
{
	private const long _RobloxUserId = 1L;

	private const string _RobuxStipendEvent = "robuxStipendCreditUser";

	public static string DBConnectionString => Settings.Default.DBConnectionString;

	public static string DBConnectionString_Currency => Settings.Default.DBConnectionString_Currency;

	public static string DBConnectionString_AssetSales => Settings.Default.DBConnectionString_AssetSales;

	public static string DBConnectionString_CurrencyEscrows => Settings.Default.DBConnectionString_CurrencyEscrows;

	public static string DBConnectionString_CurrencyExchange => Settings.Default.DBConnectionString_CurrencyExchange;

	public static string DBConnectionString_TransactionHistory => Settings.Default.DBConnectionString_TransactionHistory;

	public static string DBConnectionString_Products => Settings.Default.DBConnectionString_Products;

	public static string DBConnectionString_DeveloperProducts => Settings.Default.DBConnectionString_DeveloperProducts;

	public static string DBConnectionString_Shops => Settings.Default.DBConnectionString_Shops;

	public static void AwardRobuxStipend(long userId, long robux, ITransactionStreamer transactionStreamer, long? saleId, long? paymentId)
	{
		if (robux > 0)
		{
			long robuxBalanceBeforePurchase = UserBalance.GetRobuxBalance(userId);
			UserBalance.CreditRobux(userId, robux);
			TransactionHistory.Submit(userId, TransactionType.CreditID, TransactionOriginType.BuildersClubStipendID, CurrencyType.RobuxID, robux);
			transactionStreamer.StreamTransactionEvent("robuxStipendCreditUser", UserType.User, 1L.ToString(), UserType.User, userId.ToString(), ContentType.Robux, robux, robuxBalanceBeforePurchase, TransactionOriginType.BuildersClubStipendID, "Real Money", DateTime.UtcNow, paymentId, saleId);
		}
	}

	public static void AwardRobuxStipendBonus(long userId, long robux)
	{
		if (robux > 0)
		{
			UserBalance.CreditRobux(userId, robux);
			TransactionHistory.Submit(userId, TransactionType.CreditID, TransactionOriginType.BuildersClubStipendBonusID, CurrencyType.RobuxID, robux);
		}
	}

	public static void AwardRobuxPurchase(long userId, long robux)
	{
		if (robux > 0)
		{
			UserBalance.CreditRobux(userId, robux);
			TransactionHistory.Submit(userId, TransactionType.CreditID, TransactionOriginType.CurrencyPurchaseID, CurrencyType.RobuxID, robux);
		}
	}
}
