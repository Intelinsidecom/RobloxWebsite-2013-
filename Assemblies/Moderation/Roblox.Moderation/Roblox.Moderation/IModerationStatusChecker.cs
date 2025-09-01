namespace Roblox.Moderation
{
    /// <summary>
    /// Generic moderation status checker for any subject type.
    /// </summary>
    /// <typeparam name="TSubject">Type of the subject to moderate.</typeparam>
    public interface IModerationStatusChecker<TSubject>
    {
        /// <summary>
        /// Gets moderation status of the provided subject.
        /// </summary>
        AssetModerationStatus GetModerationStatus(TSubject subject);
    }
}
