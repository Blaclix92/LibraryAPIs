using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryAssetsAPI.Migrations
{
    public partial class addInitialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Status_Id",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_Status_Id",
                table: "Video");

            migrationBuilder.CreateIndex(
                name: "IX_Video_StatusId",
                table: "Video",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_StatusId",
                table: "Book",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Status_StatusId",
                table: "Book",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_Status_StatusId",
                table: "Video",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Status_StatusId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_Status_StatusId",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_Video_StatusId",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_Book_StatusId",
                table: "Book");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Status_Id",
                table: "Book",
                column: "Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_Status_Id",
                table: "Video",
                column: "Id",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
