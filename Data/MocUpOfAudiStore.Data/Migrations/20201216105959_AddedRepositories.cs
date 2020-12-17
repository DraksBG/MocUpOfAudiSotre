namespace MocUpOfAudiStore.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedRepositories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "ScheduleDate",
                "TestDrives",
                "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 16, 10, 59, 59, 284, DateTimeKind.Utc).AddTicks(3157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 16, 10, 36, 3, 956, DateTimeKind.Utc).AddTicks(3911));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "ScheduleDate",
                "TestDrives",
                "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 16, 10, 36, 3, 956, DateTimeKind.Utc).AddTicks(3911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 16, 10, 59, 59, 284, DateTimeKind.Utc).AddTicks(3157));
        }
    }
}