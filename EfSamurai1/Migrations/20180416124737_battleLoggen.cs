using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EfSamurai1.Migrations
{
    public partial class battleLoggen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "BattleLog",
                newName: "BattlesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BattlesId",
                table: "BattleLog",
                newName: "BattleId");
        }
    }
}
