using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roblox.Web.Maintenance
{
    public class Maintenance
    {
        public bool IsMaintenanceModeEnabled { get; set; }
        public DateTime? MaintenanceStartTime { get; set; }
        public DateTime? MaintenanceEndTime { get; set; }
        public string MaintenanceMessage { get; set; }

        public Maintenance()
        {
            IsMaintenanceModeEnabled = false;
            MaintenanceMessage = "The site is currently under maintenance. Please check back later.";
        }

        public bool IsUnderMaintenance()
        {
            return IsMaintenanceModeEnabled;
        }

        public string GetMaintenanceMessage()
        {
            return MaintenanceMessage;
        }

        public void EnableMaintenanceMode(string message = null)
        {
            IsMaintenanceModeEnabled = true;
            MaintenanceStartTime = DateTime.UtcNow;
            if (!string.IsNullOrEmpty(message))
            {
                MaintenanceMessage = message;
            }
        }

        public void DisableMaintenanceMode()
        {
            IsMaintenanceModeEnabled = false;
            MaintenanceEndTime = DateTime.UtcNow;
        }
    }
}
