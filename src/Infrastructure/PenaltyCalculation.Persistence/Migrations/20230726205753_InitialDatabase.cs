using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PenaltyCalculation.Persistence.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationalHolidays_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckedOut = table.Column<DateTime>(type: "datetime", nullable: false),
                    Returned = table.Column<DateTime>(type: "datetime", nullable: false),
                    QueryPenalty = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "Currency", "Name" },
                values: new object[] { 1, "111", "Turk Lirasi", "Turkey" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "Currency", "Name" },
                values: new object[] { 2, "222", "Cezayir Dinari", "Cezayir" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "Currency", "Name" },
                values: new object[] { 3, "333", "Euro", "Hollanda" });

            migrationBuilder.InsertData(
                table: "NationalHolidays",
                columns: new[] { "Id", "CountryId", "Date", "HolidayName" },
                values: new object[] { 1, 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İşçi Bayramı" });

            migrationBuilder.InsertData(
                table: "NationalHolidays",
                columns: new[] { "Id", "CountryId", "Date", "HolidayName" },
                values: new object[] { 2, 2, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milli Bayram" });

            migrationBuilder.InsertData(
                table: "NationalHolidays",
                columns: new[] { "Id", "CountryId", "Date", "HolidayName" },
                values: new object[] { 3, 3, new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paskalya" });

            migrationBuilder.CreateIndex(
                name: "IX_NationalHolidays_CountryId",
                table: "NationalHolidays",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CountryId",
                table: "Registrations",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalHolidays");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
