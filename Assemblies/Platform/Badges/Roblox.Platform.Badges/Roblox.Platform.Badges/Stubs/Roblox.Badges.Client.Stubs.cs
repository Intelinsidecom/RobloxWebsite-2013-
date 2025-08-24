// Minimal stubs to satisfy references to Roblox.Badges.Client
// These stubs can be replaced by the real Roblox.Badges.Client assembly when available.

namespace Roblox.Badges.Client
{
    public enum AwarderType
    {
        Unknown = 0,
        Place = 1
    }

    public class Awarder
    {
        public AwarderType Type { get; set; }
        public long TargetId { get; set; }
    }

    public enum RecipientType
    {
        User = 0,
        Unknown = 99
    }

    public class Recipient
    {
        public RecipientType Type { get; set; }
        public long TargetId { get; set; }
    }

    public class BadgeIdentifier
    {
        public long Id { get; set; }
    }

    public class Badge
        : BadgeIdentifier
    {
        public Awarder Awarder { get; set; }
        public string Description { get; set; }
        public long ImageId { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
    }

    public class CreateBadgeResult
    {
        public Badge Badge { get; set; }
    }

    public enum OperationStatus
    {
        Success = 0,
        Failure = 1
    }

    public class UpdateBadgeResult
    {
        public OperationStatus OperationStatus { get; set; }
        public System.DateTime Updated { get; set; }
    }

    public class GetBadgeByIdResult
    {
        public Badge Badge { get; set; }
    }

    public class GetBadgesByIdsResult
    {
        public Badge[] Badges { get; set; } = new Badge[0];
    }

    public class AwardBadgeResult
    {
        public OperationStatus OperationStatus { get; set; }
    }

    public class RevokeBadgeResult
    {
        public OperationStatus OperationStatus { get; set; }
    }

    public class IsAwardedResult
    {
        public bool IsAwarded { get; set; }
        public System.DateTime? AwardedDate { get; set; }
    }

    public class AwardedBadge
    {
        public BadgeIdentifier BadgeIdentifier { get; set; }
        public System.DateTime Created { get; set; }
        public Recipient Recipient { get; set; }
    }

    public class GetAwardedBadgesByRecipientResult
    {
        public AwardedBadge[] AwardedBadges { get; set; } = new AwardedBadge[0];
    }

    public class GetBadgesByAwarderResult
    {
        public Badge[] Badges { get; set; } = new Badge[0];
    }

    public interface IBadgesClient
    {
        CreateBadgeResult Create(Badge badge);
        UpdateBadgeResult Update(Badge badge);
        GetBadgeByIdResult GetById(BadgeIdentifier badgeId);
        GetBadgesByIdsResult GetByIds(System.Collections.Generic.IReadOnlyCollection<BadgeIdentifier> badgeIds);
        GetBadgesByAwarderResult GetBadgesByAwarder(Awarder awarder, BadgeIdentifier exclusiveStart, int limit, Roblox.ApiClientBase.SortOrder sortOrder);
        AwardBadgeResult AwardBadge(Recipient recipient, BadgeIdentifier badgeId);
        IsAwardedResult IsAwarded(Recipient recipient, BadgeIdentifier badgeId);
        RevokeBadgeResult RevokeBadge(Recipient recipient, BadgeIdentifier badgeId);
        GetAwardedBadgesByRecipientResult GetAwardedBadgesByRecipient(Recipient recipient, AwardedBadge exclusiveStart, int limit, Roblox.ApiClientBase.SortOrder sortOrder);
    }
}
