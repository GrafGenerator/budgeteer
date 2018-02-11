using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Budgeter.Domain.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResourceDeltaCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    ParentCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceDeltaCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceDeltaCategory_ResourceDeltaCategory_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "ResourceDeltaCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ResourceDelta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceDelta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceDelta_ResourceDeltaCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ResourceDeltaCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceDelta_CategoryId",
                table: "ResourceDelta",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceDeltaCategory_ParentCategoryId",
                table: "ResourceDeltaCategory",
                column: "ParentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResourceDelta");

            migrationBuilder.DropTable(
                name: "ResourceDeltaCategory");
        }
    }
}
