using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Roblox.Platform.Membership;

namespace Roblox.Website.Providers
{
    public class RobloxRoleProvider : RoleProvider
    {
        private IUserFactory _UserFactory = Global.MembershipDomainFactories.UserFactory;
        private IRoleSetValidator _RoleSetValidator = Global.MembershipDomainFactories.RoleSetValidator;

        public override string ApplicationName { get; set; }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            try
            {
                var user = _UserFactory.GetUserByName(username);
                var roleSets = _RoleSetValidator.GetRoleSets(user);

                var result = from roleSet in roleSets
                             select roleSet.Name;

                return result.ToArray();
            }
            catch
            {
                return new string[0];
            }
        }


        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();

        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }
    }
}