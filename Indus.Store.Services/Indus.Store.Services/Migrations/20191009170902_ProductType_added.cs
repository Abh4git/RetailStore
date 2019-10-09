using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Indus.Store.Services.Migrations
{
    public partial class ProductType_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ref_Product_Types",
                columns: table => new
                {
                    product_type_code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    parent_product_type_code = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    product_type_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Product_Types", x => x.product_type_code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ref_Product_Types");
        }
    }
}
