namespace MocUpOfAudiStore.Common.Constants
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class WebConstants
    {
        public const string AdminAreaName = "Admin";

        public const string AdminRoleName = "Admin";
        public const string UserRoleName = "User";
        public const string SupportRoleName = "Support";

        public const string AdminCarsUrl = "/Admin/Cars";
        public const string AdminCreateNewEngineUrl = "/Admin/Engine/AddNew";
        public const string AllFilterTypeModelValue = "All";

        public const string CacheDashboardStatisticsPrepend = "Dashboard";
        public const string CacheNewInventoryPrepend = "NewInventory";
        public const string CacheHomeFilterPrepend = "HomeFilter";
        public const string CacheUsedInventoryPrepend = "UsedInventory";

        public const string CacheCarsType = "__CarsCache__";
        public const string CacheStatisticsType = "__StatisticsCache__";

        public const string CookieAdminCarsSortDirectionKey = "___AdminCarsSortDirection___";
        public const string CookieAdminCarsSortTypeKey = "___AdminCarsSortType___";

        public const string CookieAdminTestDrivesSortDirectionKey = "___AdminTestDrivesSortDirection___";
        public const string CookieAdminTestDrivesSortTypeKey = "___AdminTestDrivesSortType___";

        public const string CookieAdminEngineSortDirectionKey = "___AdminEngineSortDirection___";
        public const string CookieAdminEngineSortTypeKey = "___AdminEngineSortType___";

        public const string CookieUserNewCarsSortDirectionKey = "___UserNewCarsSortDirection___";
        public const string CookieUserNewCarsSortTypeKey = "___UserNewCarsSortType___";

        public const string CookieUserSearchCarsSortDirectionKey = "___UserSearchCarsSortDirection___";
        public const string CookieUserSearchCarsSortTypeKey = "___UserSearchCarsSortType___";

        public const string CookieUserUsedCarsSortDirectionKey = "___UserUsedCarsSortDirection___";
        public const string CookieUserUsedCarsSortTypeKey = "___UserUsedCarsSortType___";

        public const string CookieAdminUsersSortDirectionKey = "___AdminUsersSortDirection___";
        public const string CookieAdminUsersSortTypeKey = "___AdminUsersSortType___";

        public const string CookieAdminOptionsSortDirectionKey = "___AdminOptionsSortDirection___";
        public const string CookieAdminOptionsSortTypeKey = "___AdminOptionsSortType___";

        public const int MinSearchKeyWordLength = 3;

        public const string StatusMessagePrefix = "___customStatusMessage";

        public const int PageSize = 10;

        public const int UserBanDays = 356;

        public const string XFrameOptionsHeader = "X-Frame-Options";
    }
}
