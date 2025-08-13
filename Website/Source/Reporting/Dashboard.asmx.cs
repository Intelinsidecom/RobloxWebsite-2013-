using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;

namespace Roblox.Website.Reporting
{
    /// <summary>
    /// Summary description for DashboardService
    /// </summary>
    [WebService(Namespace = "http://roblox.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class DashboardService : System.Web.Services.WebService
    {
        public class DashboardGridStatus
        {
            public string LegacyServerHealth { get; set; }
            public double LegacyIdleProcessors { get; set; }
            public double LegacyTotalProcessors { get; set; }
            public int LegacyJobsRunning { get; set; }
            public int LegacyJobsWaiting { get; set; }
            public decimal TotalCoresAllocated { get; set; }
            public decimal TotalCoresRunning { get; set; }
            public int CoreUtilizationPercentage { get; set; }
            public int TotalRunningJobCount { get; set; }
            public int TotalWaitingJobCount { get; set; }
            public int EnabledMachineCount { get; set; }
            public int AliveMachineCount { get; set; }
            public int MachineHealthPercentage { get; set; }
            public int AbuseReportsActiveModerators { get; set; }
            public int ImagesActiveModerators { get; set; }
            public int VideosActiveModerators { get; set; }
            public int AudiosActiveModerators { get; set; }
            public int PlayersActiveModerators { get; set; }
            public int AbuseReports { get; set; }
            public int UnmoderatedImages { get; set; }
            public int UnmoderatedVideos { get; set; }
            public int UnmoderatedAudios { get; set; }
            public int UnmoderatedPlayers { get; set; }
            public int OldestAbuseReport { get; set; }
            public int OldestUnmoderatedImage { get; set; }
            public int OldestUnmoderatedVideo { get; set; }
            public int OldestUnmoderatedAudio { get; set; }
            public int OldestUnmoderatedPlayer { get; set; }
            public int TotalPlayers { get; set; }
            public int TotalGames { get; set; }
            public string PlayerRatio { get; set; }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DashboardGridStatus GetGridStatus()
        {
            return new DashboardGridStatus();
        }
    }
}
