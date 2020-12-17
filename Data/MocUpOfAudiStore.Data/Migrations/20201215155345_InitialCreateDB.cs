namespace MocUpOfAudiStore.Data.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class InitialCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_AspNetUserRoles_AspNetUsers_UserId",
                "AspNetUserRoles");

            migrationBuilder.AddColumn<string>(
                "FirstName",
                "AspNetUsers",
                "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                "LastName",
                "AspNetUsers",
                "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                "FuelTypes",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_FuelTypes", x => x.Id); });

            migrationBuilder.CreateTable(
                "ModelTypes",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_ModelTypes", x => x.Id); });

            migrationBuilder.CreateTable(
                "OptionTypes",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_OptionTypes", x => x.Id); });

            migrationBuilder.CreateTable(
                "Series",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Series", x => x.Id); });

            migrationBuilder.CreateTable(
                "Statuses",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Statuses", x => x.Id); });

            migrationBuilder.CreateTable(
                "Transmissions",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(40)", maxLength: 40, nullable: false),
                    Price = table.Column<decimal>("decimal(18,2)", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Transmissions", x => x.Id); });

            migrationBuilder.CreateTable(
                "Options",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>("decimal(18,2)", nullable: false),
                    OptionTypeId = table.Column<string>("nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        "FK_Options_OptionTypes_OptionTypeId",
                        x => x.OptionTypeId,
                        "OptionTypes",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Engines",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>("decimal(18,2)", nullable: false),
                    TransmissionId = table.Column<string>("nvarchar(450)", nullable: false),
                    Weight_Kg = table.Column<int>("int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                    table.ForeignKey(
                        "FK_Engines_Transmissions_TransmissionId",
                        x => x.TransmissionId,
                        "Transmissions",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "BaseCars",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Acceleration_0_100Km = table.Column<double>("float", nullable: false),
                    CO2Emissions = table.Column<int>("int", nullable: false),
                    ColorName = table.Column<string>("nvarchar(max)", nullable: false),
                    Description = table.Column<string>("nvarchar(1000)", maxLength: 1000, nullable: false),
                    Displacement = table.Column<double>("float", nullable: false),
                    DoorsCount = table.Column<int>("int", nullable: false),
                    EngineId = table.Column<string>("nvarchar(450)", nullable: false),
                    FuelConsumation_City_Litres_100Km = table.Column<double>("float", nullable: false),
                    FuelConsumation_Highway_Litres_100Km = table.Column<double>("float", nullable: false),
                    FuelTypeId = table.Column<string>("nvarchar(450)", nullable: false),
                    HoursePower = table.Column<double>("float", nullable: false),
                    ModelTypeId = table.Column<string>("nvarchar(450)", nullable: false),
                    Name = table.Column<string>("nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>("decimal(18,2)", nullable: false),
                    SeriesId = table.Column<string>("nvarchar(450)", nullable: false),
                    Torque = table.Column<decimal>("decimal(18,2)", nullable: false),
                    Vin = table.Column<string>("nvarchar(17)", maxLength: 17, nullable: false),
                    WarrantyMonthsLeft = table.Column<int>("int", nullable: false),
                    Weight_Kg = table.Column<int>("int", nullable: false),
                    Year = table.Column<string>("nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>("nvarchar(max)", nullable: false),
                    Mileage = table.Column<double>("float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseCars", x => x.Id);
                    table.ForeignKey(
                        "FK_BaseCars_Engines_EngineId",
                        x => x.EngineId,
                        "Engines",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_BaseCars_FuelTypes_FuelTypeId",
                        x => x.FuelTypeId,
                        "FuelTypes",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_BaseCars_ModelTypes_ModelTypeId",
                        x => x.ModelTypeId,
                        "ModelTypes",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_BaseCars_Series_SeriesId",
                        x => x.SeriesId,
                        "Series",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "CarsOptions",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    CarId = table.Column<string>("nvarchar(450)", nullable: true),
                    OptionId = table.Column<string>("nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsOptions", x => x.Id);
                    table.ForeignKey(
                        "FK_CarsOptions_BaseCars_CarId",
                        x => x.CarId,
                        "BaseCars",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_CarsOptions_Options_OptionId",
                        x => x.OptionId,
                        "Options",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "Pictures",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    CarId = table.Column<string>("nvarchar(450)", nullable: false),
                    PublicId = table.Column<string>("nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        "FK_Pictures_BaseCars_CarId",
                        x => x.CarId,
                        "BaseCars",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "TestDrives",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    CarId = table.Column<string>("nvarchar(450)", nullable: false),
                    UserId = table.Column<string>("nvarchar(450)", nullable: false),
                    StatusId = table.Column<string>("nvarchar(450)", nullable: false),
                    ScheduleDate = table.Column<DateTime>("datetime2", nullable: false,
                        defaultValue: new DateTime(2020, 12, 15, 15, 53, 45, 394, DateTimeKind.Utc).AddTicks(2899)),
                    Comment = table.Column<string>("nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDrives", x => x.Id);
                    table.ForeignKey(
                        "FK_TestDrives_AspNetUsers_UserId",
                        x => x.UserId,
                        "AspNetUsers",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_TestDrives_BaseCars_CarId",
                        x => x.CarId,
                        "BaseCars",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_TestDrives_Statuses_StatusId",
                        x => x.StatusId,
                        "Statuses",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_BaseCars_EngineId",
                "BaseCars",
                "EngineId");

            migrationBuilder.CreateIndex(
                "IX_BaseCars_FuelTypeId",
                "BaseCars",
                "FuelTypeId");

            migrationBuilder.CreateIndex(
                "IX_BaseCars_ModelTypeId",
                "BaseCars",
                "ModelTypeId");

            migrationBuilder.CreateIndex(
                "IX_BaseCars_SeriesId",
                "BaseCars",
                "SeriesId");

            migrationBuilder.CreateIndex(
                "IX_CarsOptions_CarId",
                "CarsOptions",
                "CarId");

            migrationBuilder.CreateIndex(
                "IX_CarsOptions_OptionId_CarId",
                "CarsOptions",
                new[] {"OptionId", "CarId"},
                unique: true,
                filter: "[OptionId] IS NOT NULL AND [CarId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                "IX_Engines_Name",
                "Engines",
                "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Engines_TransmissionId",
                "Engines",
                "TransmissionId");

            migrationBuilder.CreateIndex(
                "IX_FuelTypes_Name",
                "FuelTypes",
                "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_ModelTypes_Name",
                "ModelTypes",
                "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Options_Name",
                "Options",
                "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Options_OptionTypeId",
                "Options",
                "OptionTypeId");

            migrationBuilder.CreateIndex(
                "IX_OptionTypes_Name",
                "OptionTypes",
                "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Pictures_CarId",
                "Pictures",
                "CarId");

            migrationBuilder.CreateIndex(
                "IX_Series_Name",
                "Series",
                "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Statuses_Name",
                "Statuses",
                "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_TestDrives_CarId",
                "TestDrives",
                "CarId");

            migrationBuilder.CreateIndex(
                "IX_TestDrives_StatusId",
                "TestDrives",
                "StatusId");

            migrationBuilder.CreateIndex(
                "IX_TestDrives_UserId",
                "TestDrives",
                "UserId");

            migrationBuilder.CreateIndex(
                "IX_Transmissions_Name",
                "Transmissions",
                "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                "FK_AspNetUserRoles_AspNetUsers_UserId",
                "AspNetUserRoles",
                "UserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_AspNetUserRoles_AspNetUsers_UserId",
                "AspNetUserRoles");

            migrationBuilder.DropTable(
                "CarsOptions");

            migrationBuilder.DropTable(
                "Pictures");

            migrationBuilder.DropTable(
                "TestDrives");

            migrationBuilder.DropTable(
                "Options");

            migrationBuilder.DropTable(
                "BaseCars");

            migrationBuilder.DropTable(
                "Statuses");

            migrationBuilder.DropTable(
                "OptionTypes");

            migrationBuilder.DropTable(
                "Engines");

            migrationBuilder.DropTable(
                "FuelTypes");

            migrationBuilder.DropTable(
                "ModelTypes");

            migrationBuilder.DropTable(
                "Series");

            migrationBuilder.DropTable(
                "Transmissions");

            migrationBuilder.DropColumn(
                "FirstName",
                "AspNetUsers");

            migrationBuilder.DropColumn(
                "LastName",
                "AspNetUsers");

            migrationBuilder.AddForeignKey(
                "FK_AspNetUserRoles_AspNetUsers_UserId",
                "AspNetUserRoles",
                "UserId",
                "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}