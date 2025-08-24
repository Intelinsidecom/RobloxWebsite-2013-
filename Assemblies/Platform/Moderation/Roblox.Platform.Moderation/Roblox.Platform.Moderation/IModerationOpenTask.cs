using Roblox.Platform.Localization.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Moderation;

/// <summary>
/// An interface represents an open moderation task that is to be worked on by a moderator.
/// An effective wrapper around <see cref="T:Roblox.Platform.Moderation.ISqsOpenTask" /> as well associated review task entity 
/// in order for a moderator to work on and then to perform the removal of the message from the queue
/// and mark the ReviewTask entity in the database as reviewed.
/// </summary>
public interface IModerationOpenTask : ISqsOpenTask, IOpenTask
{
	/// <summary>
	/// Checks if the task has been reviewed, and if so, delete the open task from the queue
	/// </summary>
	/// <returns>True when a review task has been created for the report and marked as reviewed, false otherwise.</returns>
	bool IfIsReviewedThenDelete();

	/// <summary>
	/// Closes the open task
	/// * Marks the ReviewTask in the database as reviewed
	/// * Deletes the open task from the consumer
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="moderatorIdentity" /> is null.</exception>
	void Close(IUserIdentifier moderatorIdentity);

	/// <summary>
	/// If moderatorIdentity is provided, this method will update the Report's Locale, create a new task on the language queue specified by the newLocale, and delete this task from the current queue.
	/// NewLocale may be null, and if so, indicates this should be published to the 'unknown language' queue.
	///
	/// If moderatorIdentity is null, this method creates a new task on the language queue specifed by this object's Locale property, and the newLocale parameter is ignored.
	/// </summary>
	/// <param name="newLocaleIdentifier">The locale to associate this Report with. May be null, indicating that the locale is 'unknown'.</param>
	/// <param name="moderatorIdentity">The moderator who is changing the locale associated with this Report. If null, no change is made, and this task is deleted and recreated at the back of the queue.</param>
	void Republish(ISupportedLocaleIdentifier newLocaleIdentifier = null, IUserIdentifier moderatorIdentity = null);
}
