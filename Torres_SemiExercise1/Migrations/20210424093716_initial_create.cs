using Microsoft.EntityFrameworkCore.Migrations;

namespace Torres_SemiExercise1.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientModel",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(nullable: false),
                    ClientAge = table.Column<int>(nullable: false),
                    ClientAddress = table.Column<string>(nullable: false),
                    ClientContactNo = table.Column<int>(nullable: false),
                    ClientEmailAdd = table.Column<string>(nullable: false),
                    ClientSubscription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientModel", x => x.ClientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientModel");
        }
    }
}
