using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class CreateServicesAndSeedings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthyCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceLocationId = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false),
                    ServiceSettingId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_ServiceLocations_ServiceLocationId",
                        column: x => x.ServiceLocationId,
                        principalTable: "ServiceLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_ServiceSettings_ServiceSettingId",
                        column: x => x.ServiceSettingId,
                        principalTable: "ServiceSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ServiceLocations",
                columns: new[] { "Id", "City", "CreatedAt", "IsActive", "UpdatedAt", "Zone" },
                values: new object[,]
                {
                    { 1, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "1" },
                    { 2, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "2" },
                    { 3, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "3" },
                    { 4, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "4" },
                    { 5, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "5" },
                    { 6, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "6" },
                    { 7, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "7" },
                    { 8, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "8" },
                    { 9, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "9" },
                    { 10, "Guatemala", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "10" }
                });

            migrationBuilder.InsertData(
                table: "ServiceSettings",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "Velocidad de internet", true, "Velocidad 15Mbps", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "Velocidad de internet", true, "Velocidad 25Mbps", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "Velocidad de internet", true, "Velocidad 50Mbps", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local) },
                    { 4, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "Servicio de cable", true, "Basico 100 canales", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local) },
                    { 5, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), "Servicio de cable", true, "Premium canales adicionaels", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, "Cable", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local), true, "Internet", new DateTime(2025, 4, 28, 10, 35, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceLocationId",
                table: "Services",
                column: "ServiceLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceSettingId",
                table: "Services",
                column: "ServiceSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeId",
                table: "Services",
                column: "ServiceTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServiceLocations");

            migrationBuilder.DropTable(
                name: "ServiceSettings");

            migrationBuilder.DropTable(
                name: "ServiceTypes");
        }
    }
}
