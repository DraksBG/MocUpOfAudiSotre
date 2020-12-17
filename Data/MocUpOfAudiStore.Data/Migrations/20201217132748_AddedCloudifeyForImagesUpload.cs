using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MocUpOfAudiStore.Data.Migrations
{
    public partial class AddedCloudifeyForImagesUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduleDate",
                table: "TestDrives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 17, 13, 27, 48, 344, DateTimeKind.Utc).AddTicks(3416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 16, 11, 39, 11, 880, DateTimeKind.Utc).AddTicks(6716));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduleDate",
                table: "TestDrives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 16, 11, 39, 11, 880, DateTimeKind.Utc).AddTicks(6716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 17, 13, 27, 48, 344, DateTimeKind.Utc).AddTicks(3416));
        }
    }
}
