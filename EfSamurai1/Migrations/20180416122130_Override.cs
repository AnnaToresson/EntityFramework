using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EfSamurai1.Migrations
{
    public partial class Override : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SamuraiId",
                table: "Battles");

            migrationBuilder.CreateTable(
                name: "SamuraiInBattle",
                columns: table => new
                {
                    SamuraiId = table.Column<int>(nullable: false),
                    BattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamuraiInBattle", x => new { x.SamuraiId, x.BattleId });
                    table.ForeignKey(
                        name: "FK_SamuraiInBattle_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SamuraiInBattle_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SamuraiInBattle_BattleId",
                table: "SamuraiInBattle",
                column: "BattleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamuraiInBattle");

            migrationBuilder.AddColumn<int>(
                name: "SamuraiId",
                table: "Battles",
                nullable: false,
                defaultValue: 0);
        }
    }
}
