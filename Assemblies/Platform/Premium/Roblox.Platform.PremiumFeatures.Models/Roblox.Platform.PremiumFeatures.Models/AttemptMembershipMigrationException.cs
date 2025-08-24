using System;

namespace Roblox.PremiumFeatures.Models;

public class AttemptMembershipMigrationException : Exception
{
	public MembershipMigrationErrorResponse MembershipMigrationErrorResponse { get; set; }

	public AttemptMembershipMigrationException(MembershipMigrationErrorResponse errorResponse)
	{
		MembershipMigrationErrorResponse = errorResponse;
	}

	public AttemptMembershipMigrationException(string message, MembershipMigrationsErrorCode? errorCode = null)
	{
		MembershipMigrationErrorResponse = new MembershipMigrationErrorResponse
		{
			ErrorCode = (errorCode ?? MembershipMigrationsErrorCode.Unknown),
			ErrorMessage = message
		};
	}
}
