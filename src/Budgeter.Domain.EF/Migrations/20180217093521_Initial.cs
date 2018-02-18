using Microsoft.EntityFrameworkCore.Migrations;

namespace Budgeter.Domain.EF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "ResourceDeltaCategory",
                table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    ParentCategoryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceDeltaCategory", x => x.Id);
                    table.ForeignKey(
                        "FK_ResourceDeltaCategory_ResourceDeltaCategory_ParentCategoryId",
                        x => x.ParentCategoryId,
                        "ResourceDeltaCategory",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "ResourceDelta",
                table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceDelta", x => x.Id);
                    table.ForeignKey(
                        "FK_ResourceDelta_ResourceDeltaCategory_CategoryId",
                        x => x.CategoryId,
                        "ResourceDeltaCategory",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_ResourceDelta_CategoryId",
                "ResourceDelta",
                "CategoryId");

            migrationBuilder.CreateIndex(
                "IX_ResourceDeltaCategory_ParentCategoryId",
                "ResourceDeltaCategory",
                "ParentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "ResourceDelta");

            migrationBuilder.DropTable(
                "ResourceDeltaCategory");
        }
    }
}