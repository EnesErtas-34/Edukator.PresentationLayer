using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccessLayer.Migrations
{
    public partial class mig_add_subscribe_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscribes",
                columns: table => new
                {
                    SubscribeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(60)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribes", x => x.SubscribeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribes");
        }
    }
}
