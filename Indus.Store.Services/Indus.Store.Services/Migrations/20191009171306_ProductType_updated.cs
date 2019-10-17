using Microsoft.EntityFrameworkCore.Migrations;

namespace Indus.Store.Services.Migrations
{
    public partial class ProductType_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "parent_product_type_code",
                table: "Ref_Product_Types");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "Ref_Product_Types");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "parent_product_type_code",
                table: "Ref_Product_Types",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "Ref_Product_Types",
                nullable: false,
                defaultValue: 0);
        }
    }
}
