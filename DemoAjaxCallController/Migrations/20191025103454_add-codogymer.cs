using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoAjaxCallController.Migrations
{
    public partial class addcodogymer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Codegymers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    IsDepTrai = table.Column<bool>(nullable: false),
                    IsGiau = table.Column<bool>(nullable: false),
                    IsThongMinh = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codegymers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Codegymers",
                columns: new[] { "Id", "IsDepTrai", "IsGiau", "IsThongMinh", "Name" },
                values: new object[,]
                {
                    { 1, false, false, false, "Le Van Bon" },
                    { 2, false, false, false, "Nguyen Van Quy" },
                    { 3, false, false, false, "Bui Hoang Long" },
                    { 4, false, false, false, "Phan Van My" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Codegymers");
        }
    }
}
