using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetEntityDetailsApi.Migrations
{
    public partial class EntitydetailstoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntityDetails",
                columns: table => new
                {
                    ACN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personalEmailID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityDetails", x => x.ACN);
                });

            migrationBuilder.InsertData(
                table: "EntityDetails",
                columns: new[] { "ACN", "Address", "EntityName", "personalEmailID" },
                values: new object[] { 111111, "1st street, AU", "AAA Enterprise", "aaa@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntityDetails");
        }
    }
}
