using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false, defaultValue: 10.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 89.0, "Things Fall Apart " },
                    { 2, 25.0, "Night" },
                    { 3, 45.0, "The Kite Runner" },
                    { 4, 55.0, "The Stranger" },
                    { 5, 95.0, "Cry, the Beloved Country" },
                    { 6, 35.0, "Metamorphosis" },
                    { 7, 78.0, "The Odyssey " },
                    { 8, 85.0, "Candide" },
                    { 9, 96.0, "Illiad" },
                    { 10, 98.0, "Life of Pi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
