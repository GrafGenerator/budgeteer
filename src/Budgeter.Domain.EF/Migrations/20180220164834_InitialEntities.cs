using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Budgeter.Domain.EF.Migrations
{
    public partial class InitialEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResourceEntryCategory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    ParentCategoryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceEntryCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceEntryCategory_ResourceEntryCategory_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "ResourceEntryCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResourceEntry",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceEntry_ResourceEntryCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ResourceEntryCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEntry_CategoryId",
                table: "ResourceEntry",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceEntryCategory_ParentCategoryId",
                table: "ResourceEntryCategory",
                column: "ParentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResourceEntry");

            migrationBuilder.DropTable(
                name: "ResourceEntryCategory");
        }
    }
}
