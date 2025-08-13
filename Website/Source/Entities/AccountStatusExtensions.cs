using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox
{
    public static class AccountStatusExtensions
    {
        public static AccountStatus TranslateAccountStatus(byte accountStatusId)
        {
            return AccountStatus.Get(accountStatusId);
        }

        public static byte TranslateToByte(this AccountStatus accountStatus)
        {
            return accountStatus.GetId();
        }
    }
}
