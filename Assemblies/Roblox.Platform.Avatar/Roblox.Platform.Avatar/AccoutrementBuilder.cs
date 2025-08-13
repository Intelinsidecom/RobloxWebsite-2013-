using System;
using System.Data.SqlClient;
using Roblox.Avatar.Client;

namespace Roblox.Platform.Avatar;

/// <inheritdoc />
internal class AccoutrementBuilder : IAccoutrementBuilder
{
	/// <inheritdoc />
	public IAccoutrement CreateNew(long userId, long userAssetId)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			return Accoutrement.CreateNew(userId, userAssetId);
		}
		catch (SqlException ex) when (ex.Number == 2601)
		{
			throw new DuplicateAccoutrementInsertException($"Duplicate accoutrement insertion for UserAssetID={userAssetId} and UserID={userId}", ex);
		}
		catch (AvatarServiceException ex2) when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			string message = ex2.Message;
			AccoutrementError val = (AccoutrementError)1;
			return message == ((object)(AccoutrementError)(ref val)).ToString();
		}).Invoke())
		{
			throw new DuplicateAccoutrementInsertException($"Duplicate accoutrement insertion for UserAssetID={userAssetId} and UserID={userId}", ex2);
		}
	}
}
