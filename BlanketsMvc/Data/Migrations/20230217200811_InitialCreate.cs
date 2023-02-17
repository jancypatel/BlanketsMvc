using Microsoft.EntityFrameworkCore.Migrations;

namespace BlanketsMvc.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blankets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Pattern = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blankets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blankets");
        }
    }
}
