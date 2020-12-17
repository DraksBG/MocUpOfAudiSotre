namespace MocUpOfAudiStore.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedServicesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "ScheduleDate",
                "TestDrives",
                "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 16, 11, 39, 11, 880, DateTimeKind.Utc).AddTicks(6716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 16, 10, 59, 59, 284, DateTimeKind.Utc).AddTicks(3157));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                "ScheduleDate",
                "TestDrives",
                "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 16, 10, 59, 59, 284, DateTimeKind.Utc).AddTicks(3157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 16, 11, 39, 11, 880, DateTimeKind.Utc).AddTicks(6716));
        }
    }
}