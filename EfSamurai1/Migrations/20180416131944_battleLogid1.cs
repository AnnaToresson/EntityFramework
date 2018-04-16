using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EfSamurai1.Migrations
{
    public partial class battleLogid1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BattleLogId",
                table: "Battles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Battles_BattleLogId",
                table: "Battles",
                column: "BattleLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_BattleLog_BattleLogId",
                table: "Battles",
                column: "BattleLogId",
                principalTable: "BattleLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_BattleLog_BattleLogId",
                table: "Battles");

            migrationBuilder.DropIndex(
                name: "IX_Battles_BattleLogId",
                table: "Battles");

            migrationBuilder.AlterColumn<int>(
                name: "BattleLogId",
                table: "Battles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
