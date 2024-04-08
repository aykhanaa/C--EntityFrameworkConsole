﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C__EntityFrameworkConsole.Migrations
{
    public partial class CreatedNameColumnSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Settings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Settings");
        }
    }
}
