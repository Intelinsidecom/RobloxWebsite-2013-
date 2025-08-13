using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Security;

namespace Roblox.Website.WebCode
{
    public class SignupHelper
    {
        private RobloxResourceSet ControlsResources;

        public SignupHelper(CultureInfo cultureInfo)
        {
            ControlsResources = new RobloxResourceSet("CommonUI.Controls", cultureInfo);
        }

        public Dictionary<int, string> GetMonths(bool abbreviated = false, bool usePlaceholder = true)
        {
            Dictionary<int, string> months;
            if (abbreviated)
            {
                months = new Dictionary<int, string>()
                {
                    {0, ControlsResources["Label.Month"]},
                    {1, ControlsResources["Label.JanuaryAbbreviated"]},
                    {2, ControlsResources["Label.FebruaryAbbreviated"]},
                    {3, ControlsResources["Label.MarchAbbreviated"]},
                    {4, ControlsResources["Label.AprilAbbreviated"]},
                    {5, ControlsResources["Label.May"]},
                    {6, ControlsResources["Label.June"]},
                    {7, ControlsResources["Label.July"]},
                    {8, ControlsResources["Label.AugustAbbreviated"]},
                    {9, ControlsResources["Label.SeptemberAbbreviated"]},
                    {10, ControlsResources["Label.OctoberAbbreviated"]},
                    {11, ControlsResources["Label.NovemberAbbreviated"]},
                    {12, ControlsResources["Label.DecemberAbbreviated"]}
                };
            }
            else
            {
                months = new Dictionary<int, string>()
                {
                    {0, ControlsResources["Label.Month"]},
                    {1, ControlsResources["Label.January"]},
                    {2, ControlsResources["Label.February"]},
                    {3, ControlsResources["Label.March"]},
                    {4, ControlsResources["Label.April"]},
                    {5, ControlsResources["Label.May"]},
                    {6, ControlsResources["Label.June"]},
                    {7, ControlsResources["Label.July"]},
                    {8, ControlsResources["Label.August"]},
                    {9, ControlsResources["Label.September"]},
                    {10, ControlsResources["Label.October"]},
                    {11, ControlsResources["Label.November"]},
                    {12, ControlsResources["Label.December"]}
                };
            }

            if (!usePlaceholder)
                months.Remove(0);

            return months;
        }

        public Dictionary<int, string> GetDays()
        {
            var days = new Dictionary<int, string>()
            {
                {0, ControlsResources["Label.Day"]}
            };
            for (int i = 1; i <= 31; i++)
                days[i] = i.ToString();

            return days;
        }

        public Dictionary<int, string> GetYears()
        {
            var years = new Dictionary<int, string>()
            {
                {0, ControlsResources["Label.Year"]}
            };
            int thisYear = DateTime.Today.Year;
            for (int i = thisYear - 1; i >= thisYear - 100; i--)
                years[i] = i.ToString();

            return years;
        }

        public MembershipCreateStatus DoSignup(string days, string months, string years,
            byte gender, string name, string pass, string passConfirm)
        {
            if (pass != passConfirm)
            {
                return MembershipCreateStatus.InvalidPassword;
            }

            var birthday = new DateTime(Convert.ToInt32(years), Convert.ToInt32(months), Convert.ToInt32(days));

            MembershipCreateStatus status;
            Membership.CreateUser(name, pass, null, null, null, true, null, out status);

            return status;
        }

        public string GetRedirectUrlForSignupStatus(MembershipCreateStatus status)
        {
            string url;

            switch (status)
            {
                case MembershipCreateStatus.Success:
                    url = "/";
                    break;
                case MembershipCreateStatus.ProviderError:
                    url = "~/RobloxDefaultErrorPage.aspx?code=500";
                    break;
                default:
                    url = "~/RobloxDefaultErrorPage.aspx?code=400";
                    break;
            }

            return url;
        }
    }
}