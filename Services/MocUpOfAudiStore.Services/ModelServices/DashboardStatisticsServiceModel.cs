namespace MocUpOfAudiStore.Services.ModelServices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DashboardStatisticsServiceModel
    {
        public int TotalNewCarsTestDrivesCount { get; set; }

        public int NewCarsTestDrivesFromPast24HoursCount { get; set; }

        public int TotalUsedCarsTestDrivesCount { get; set; }

        public int UsedCarsTestDrivesFromPast24HoursCount { get; set; }

        public int TotalTestDrivesFromPast24HoursCount { get; set; }

        public int TotalUsersCount { get; set; }

        public int NewCarsCount { get; set; }

        public int UsedCarsCount { get; set; }
    }
}
