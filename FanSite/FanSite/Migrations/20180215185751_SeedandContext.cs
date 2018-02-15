using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FanSite.Migrations
{
    public partial class SeedandContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fan_Storys_StoryModelID",
                table: "Fan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fan",
                table: "Fan");

            migrationBuilder.RenameTable(
                name: "Fan",
                newName: "Fans");

            migrationBuilder.RenameIndex(
                name: "IX_Fan_StoryModelID",
                table: "Fans",
                newName: "IX_Fans_StoryModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fans",
                table: "Fans",
                column: "FanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Fans_Storys_StoryModelID",
                table: "Fans",
                column: "StoryModelID",
                principalTable: "Storys",
                principalColumn: "StoryModelID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fans_Storys_StoryModelID",
                table: "Fans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fans",
                table: "Fans");

            migrationBuilder.RenameTable(
                name: "Fans",
                newName: "Fan");

            migrationBuilder.RenameIndex(
                name: "IX_Fans_StoryModelID",
                table: "Fan",
                newName: "IX_Fan_StoryModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fan",
                table: "Fan",
                column: "FanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Fan_Storys_StoryModelID",
                table: "Fan",
                column: "StoryModelID",
                principalTable: "Storys",
                principalColumn: "StoryModelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
