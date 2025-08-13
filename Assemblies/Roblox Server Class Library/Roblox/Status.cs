using System;

namespace Roblox;

internal class Status
{
	private User User { get; }

	public DateTime Date { get; set; }

	public string Message { get; set; }

	private UserStatus StatusEntity { get; }

	/// <summary>
	/// Creates an object containing user's most recent status update, if present
	/// </summary>
	/// <param name="userID"></param>
	public Status(long userID)
	{
		try
		{
			User = User.Get(userID);
			StatusEntity = UserStatus.GetOrCreate(userID);
			Date = StatusEntity.Updated;
			Message = StatusEntity.Message;
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
		}
	}

	/// <summary>
	/// Updates a user's status
	/// </summary>
	/// <param name="message"></param>
	/// <returns></returns>
	public long Save(string message)
	{
		if (!string.IsNullOrEmpty(Message) && Message == message)
		{
			return StatusEntity.ID;
		}
		Message = message;
		StatusEntity.UserID = User.ID;
		StatusEntity.Message = Message;
		StatusEntity.Save();
		return StatusEntity.ID;
	}
}
