using Microsoft.EntityFrameworkCore.Migrations;

namespace Edukator.DataAccessLayer.Migrations
{
    public partial class mig_add_coursesfeature_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoursesFeatures",
                columns: table => new
                {
                    CoursesFeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageText1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageText2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageText3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesFeatures", x => x.CoursesFeatureID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesFeatures");
        }
    }
}
