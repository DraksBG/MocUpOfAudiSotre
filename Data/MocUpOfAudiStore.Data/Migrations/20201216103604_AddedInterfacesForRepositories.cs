namespace MocUpOfAudiStore.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddedInterfacesForRepositories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduleDate",
                table: "TestDrives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 16, 10, 36, 3, 956, DateTimeKind.Utc).AddTicks(3911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 15, 15, 53, 45, 394, DateTimeKind.Utc).AddTicks(2899));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduleDate",
                table: "TestDrives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 15, 15, 53, 45, 394, DateTimeKind.Utc).AddTicks(2899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 16, 10, 36, 3, 956, DateTimeKind.Utc).AddTicks(3911));
        }
    }
}
