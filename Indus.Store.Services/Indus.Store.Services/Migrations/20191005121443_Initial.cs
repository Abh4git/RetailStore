using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Indus.Store.Services.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    address_line1 = table.Column<string>(nullable: true),
                    address_line2 = table.Column<string>(nullable: true),
                    address_line3 = table.Column<string>(nullable: true),
                    address_line4 = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    county_or_province = table.Column<string>(nullable: true),
                    email_address = table.Column<string>(nullable: true),
                    first_name = table.Column<string>(nullable: true),
                    gender = table.Column<int>(nullable: false),
                    last_name = table.Column<string>(nullable: true),
                    login_name = table.Column<string>(nullable: true),
                    login_password = table.Column<string>(nullable: true),
                    middle_name = table.Column<string>(nullable: true),
                    organization_name = table.Column<string>(nullable: true),
                    organization_or_person = table.Column<byte>(nullable: false),
                    phone_number = table.Column<string>(nullable: true),
                    town_city = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product_color = table.Column<string>(nullable: true),
                    product_description = table.Column<string>(nullable: true),
                    product_name = table.Column<string>(nullable: true),
                    product_other_details = table.Column<string>(nullable: true),
                    product_price = table.Column<double>(nullable: false),
                    product_size = table.Column<string>(nullable: true),
                    product_type_code = table.Column<int>(nullable: false),
                    return_merchant_authorization_nr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_id);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Invoice_Statuses",
                columns: table => new
                {
                    invoice_status_code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    invoice_status_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Invoice_Statuses", x => x.invoice_status_code);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Order_Item_Statuses",
                columns: table => new
                {
                    order_item_status_code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    order_item_status_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Order_Item_Statuses", x => x.order_item_status_code);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Order_Status",
                columns: table => new
                {
                    order_status_code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    order_status_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Order_Status", x => x.order_status_code);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Payment_Types",
                columns: table => new
                {
                    payment_type_code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    payment_type_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Payment_Types", x => x.payment_type_code);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    order_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(nullable: false),
                    date_order_placed = table.Column<DateTime>(nullable: false),
                    order_details = table.Column<string>(nullable: true),
                    order_status_code = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Ref_Order_Status_order_status_code",
                        column: x => x.order_status_code,
                        principalTable: "Ref_Order_Status",
                        principalColumn: "order_status_code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Payment_Details",
                columns: table => new
                {
                    customer_payment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    credit_card_detail = table.Column<string>(nullable: true),
                    customer_id = table.Column<int>(nullable: false),
                    customer_payment_type_code = table.Column<int>(nullable: false),
                    payment_details = table.Column<string>(nullable: true),
                    Ref_Payment_Typespayment_type_code = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Payment_Details", x => x.customer_payment_id);
                    table.ForeignKey(
                        name: "FK_Customer_Payment_Details_Ref_Payment_Types_Ref_Payment_Typespayment_type_code",
                        column: x => x.Ref_Payment_Typespayment_type_code,
                        principalTable: "Ref_Payment_Types",
                        principalColumn: "payment_type_code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Payment_Details_Customers_customer_id",
                        column: x => x.customer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    invoice_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    invoice_date = table.Column<DateTime>(nullable: false),
                    invoice_details = table.Column<string>(nullable: true),
                    invoice_status_code = table.Column<int>(nullable: false),
                    order_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.invoice_number);
                    table.ForeignKey(
                        name: "FK_Invoices_Ref_Invoice_Statuses_invoice_status_code",
                        column: x => x.invoice_status_code,
                        principalTable: "Ref_Invoice_Statuses",
                        principalColumn: "invoice_status_code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_Orders_order_id",
                        column: x => x.order_id,
                        principalTable: "Orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Items",
                columns: table => new
                {
                    order_item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    order_id = table.Column<int>(nullable: false),
                    order_item_price = table.Column<int>(nullable: false),
                    order_item_quantity = table.Column<int>(nullable: false),
                    order_item_status_code = table.Column<int>(nullable: false),
                    other_order_item_details = table.Column<string>(nullable: true),
                    product_id = table.Column<int>(nullable: false),
                    RMA_issued_by = table.Column<string>(nullable: true),
                    RMA_issued_date = table.Column<DateTime>(nullable: false),
                    RMA_number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Items", x => x.order_item_id);
                    table.ForeignKey(
                        name: "FK_Order_Items_Orders_order_id",
                        column: x => x.order_id,
                        principalTable: "Orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Items_Ref_Order_Item_Statuses_order_item_status_code",
                        column: x => x.order_item_status_code,
                        principalTable: "Ref_Order_Item_Statuses",
                        principalColumn: "order_item_status_code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    invoice_number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    invoice_number1 = table.Column<int>(nullable: true),
                    payment_amount = table.Column<decimal>(nullable: false),
                    payment_date = table.Column<DateTime>(nullable: false),
                    payment_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.invoice_number);
                    table.ForeignKey(
                        name: "FK_Payments_Invoices_invoice_number1",
                        column: x => x.invoice_number1,
                        principalTable: "Invoices",
                        principalColumn: "invoice_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    shipment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    invoice_number = table.Column<int>(nullable: false),
                    order_id = table.Column<int>(nullable: true),
                    other_shipment_details = table.Column<string>(nullable: true),
                    shipment_date = table.Column<DateTime>(nullable: false),
                    shipment_tracking_number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.shipment_id);
                    table.ForeignKey(
                        name: "FK_Shipments_Invoices_invoice_number",
                        column: x => x.invoice_number,
                        principalTable: "Invoices",
                        principalColumn: "invoice_number",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipments_Orders_order_id",
                        column: x => x.order_id,
                        principalTable: "Orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipment_Items",
                columns: table => new
                {
                    shipment_Item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    order_Item_id = table.Column<int>(nullable: false),
                    shipment_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipment_Items", x => x.shipment_Item_id);
                    table.ForeignKey(
                        name: "FK_Shipment_Items_Order_Items_order_Item_id",
                        column: x => x.order_Item_id,
                        principalTable: "Order_Items",
                        principalColumn: "order_item_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipment_Items_Shipments_shipment_id",
                        column: x => x.shipment_id,
                        principalTable: "Shipments",
                        principalColumn: "shipment_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Payment_Details_Ref_Payment_Typespayment_type_code",
                table: "Customer_Payment_Details",
                column: "Ref_Payment_Typespayment_type_code");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Payment_Details_customer_id",
                table: "Customer_Payment_Details",
                column: "customer_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_invoice_status_code",
                table: "Invoices",
                column: "invoice_status_code");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_order_id",
                table: "Invoices",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Items_order_id",
                table: "Order_Items",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Items_order_item_status_code",
                table: "Order_Items",
                column: "order_item_status_code");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customer_id",
                table: "Orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_order_status_code",
                table: "Orders",
                column: "order_status_code");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_invoice_number1",
                table: "Payments",
                column: "invoice_number1");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_Items_order_Item_id",
                table: "Shipment_Items",
                column: "order_Item_id");

            migrationBuilder.CreateIndex(
                name: "IX_Shipment_Items_shipment_id",
                table: "Shipment_Items",
                column: "shipment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_invoice_number",
                table: "Shipments",
                column: "invoice_number");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_order_id",
                table: "Shipments",
                column: "order_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Payment_Details");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Shipment_Items");

            migrationBuilder.DropTable(
                name: "Ref_Payment_Types");

            migrationBuilder.DropTable(
                name: "Order_Items");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "Ref_Order_Item_Statuses");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Ref_Invoice_Statuses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Ref_Order_Status");
        }
    }
}
