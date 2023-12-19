using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pgweb.Migrations
{
    public partial class setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pgs",
                columns: table => new
                {
                    pgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RomeNo = table.Column<int>(type: "int", nullable: false),
                    Rent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresss = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pgs", x => x.pgId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pgs");
        }
    }
}
