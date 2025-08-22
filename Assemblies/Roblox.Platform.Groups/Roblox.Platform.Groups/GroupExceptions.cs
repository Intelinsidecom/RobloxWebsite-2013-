using System;

namespace Roblox.Platform.Groups
{
    // Minimal stub to satisfy catch sites in GroupManagement
    public class UserAlreadyGroupMemberException : Exception
    {
        public UserAlreadyGroupMemberException() { }
        public UserAlreadyGroupMemberException(string message) : base(message) { }
        public UserAlreadyGroupMemberException(string message, Exception inner) : base(message, inner) { }
    }
}
