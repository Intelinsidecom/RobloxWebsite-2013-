using System;
using System.Collections.Generic;
using Roblox.DataV2.Core;

namespace Roblox.TeamCreate.Client
{
    public enum TeamCreateMembershipTargetType
    {
        Unknown = 0,
        User = 1,
        Group = 2
    }

    public class TeamCreateMembershipTarget
    {
        public TeamCreateMembershipTargetType TargetType { get; set; }
        public long TargetId { get; set; }
    }

    public class UniverseIdentifier
    {
        public long Id { get; set; }
    }

    public class TeamCreateMembership
    {
        public TeamCreateMembershipTarget Target { get; set; }
        public UniverseIdentifier Universe { get; set; }
        public DateTime GrantDateTime { get; set; }
    }

    public class TeamCreateMembershipsResponse
    {
        public IReadOnlyCollection<TeamCreateMembership> Memberships { get; set; } = Array.Empty<TeamCreateMembership>();
    }

    // Minimal responses to satisfy platform usage
    public enum OperationStatus
    {
        Success = 0,
        Failure = 1
    }

    public class IsTeamCreateMemberResponse
    {
        public bool IsMember { get; set; }
    }

    public class ModifyTeamCreateMembershipResponse
    {
        public OperationStatus OperationStatus { get; set; }
    }

    public interface ITeamCreateClient
    {
        TeamCreateMembershipsResponse GetTeamCreateMembershipsByUniverse(UniverseIdentifier universe, TeamCreateMembership exclusiveStartMembership, int count, SortOrder sortOrder);
        TeamCreateMembershipsResponse GetTeamCreateMembershipsByMembershipTarget(TeamCreateMembershipTarget target, TeamCreateMembership exclusiveStartMembership, int count, SortOrder sortOrder);
        IsTeamCreateMemberResponse IsTeamCreateMember(TeamCreateMembershipTarget target, UniverseIdentifier universe);
        ModifyTeamCreateMembershipResponse AddTeamCreateMembership(TeamCreateMembershipTarget target, UniverseIdentifier universe);
        ModifyTeamCreateMembershipResponse RemoveTeamCreateMembership(TeamCreateMembershipTarget target, UniverseIdentifier universe);
    }
}

