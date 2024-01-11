using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BHotels",
                columns: table => new
                {
                    BookHotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BHotels", x => x.BookHotelID);
                });

            migrationBuilder.CreateTable(
                name: "BTours",
                columns: table => new
                {
                    BookTourID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourStrartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TourEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BTours", x => x.BookTourID);
                });

            migrationBuilder.CreateTable(
                name: "HotelAvailabilities",
                columns: table => new
                {
                    HotelAvailabilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvailableFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAvailabilities", x => x.HotelAvailabilityID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvailableSpaces = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageID);
                });

            migrationBuilder.CreateTable(
                name: "TourAvailabilities",
                columns: table => new
                {
                    TourAvailabilityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvailableFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableTo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourAvailabilities", x => x.TourAvailabilityID);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvailibleSpaces = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BHotels");

            migrationBuilder.DropTable(
                name: "BTours");

            migrationBuilder.DropTable(
                name: "HotelAvailabilities");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "TourAvailabilities");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
