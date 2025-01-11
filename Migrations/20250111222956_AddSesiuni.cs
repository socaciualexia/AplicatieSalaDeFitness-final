using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicatieSalaDeFitness.Migrations
{
    /// <inheritdoc />
    public partial class AddSesiuni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sesiune",
                columns: table => new
                {
                    SesiuneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AntrenorId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesiune", x => x.SesiuneId);
                    table.ForeignKey(
                        name: "FK_Sesiune_Antrenor_AntrenorId",
                        column: x => x.AntrenorId,
                        principalTable: "Antrenor",
                        principalColumn: "AntrenorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sesiune_AntrenorId",
                table: "Sesiune",
                column: "AntrenorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sesiune");
        }
    }
}
