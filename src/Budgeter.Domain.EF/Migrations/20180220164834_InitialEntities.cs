using Microsoft.EntityFrameworkCore.Migrations;

namespace Budgeter.Domain.EF.Migrations
{
    public partial class InitialEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "ResourceEntryCategory",
                table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    ParentCategoryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceEntryCategory", x => x.Id);
                    table.ForeignKey(
                        "FK_ResourceEntryCategory_ResourceEntryCategory_ParentCategoryId",
                        x => x.ParentCategoryId,
                        "ResourceEntryCategory",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "ResourceEntry",
                table => new
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
                        "FK_ResourceEntry_ResourceEntryCategory_CategoryId",
                        x => x.CategoryId,
                        "ResourceEntryCategory",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_ResourceEntry_CategoryId",
                "ResourceEntry",
                "CategoryId");

            migrationBuilder.CreateIndex(
                "IX_ResourceEntryCategory_ParentCategoryId",
                "ResourceEntryCategory",
                "ParentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "ResourceEntry");

            migrationBuilder.DropTable(
                "ResourceEntryCategory");
        }
    }
}