using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryAssetsAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "book_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "status_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "video_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    DeweyIndex = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    NumberOfCopies = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Status_Id",
                        column: x => x.Id,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    NumberOfCopies = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Status_Id",
                        column: x => x.Id,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropSequence(
                name: "book_hilo");

            migrationBuilder.DropSequence(
                name: "status_hilo");

            migrationBuilder.DropSequence(
                name: "video_hilo");
        }
    }
}
