using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EfSamurai1.Migrations
{
    public partial class battleLogid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "BattleLog");

            migrationBuilder.AddColumn<int>(
                name: "BattleLogId",
                table: "Battles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BattleLogId",
                table: "Battles");

            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "BattleLog",
                nullable: false,
                defaultValue: 0);
        }
    }
}
