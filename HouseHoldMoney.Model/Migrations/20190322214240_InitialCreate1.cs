using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseHoldMoney.Model.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    TermOfPayment = table.Column<int>(nullable: false),
                    Jan = table.Column<bool>(nullable: false),
                    Feb = table.Column<bool>(nullable: false),
                    Mar = table.Column<bool>(nullable: false),
                    Apr = table.Column<bool>(nullable: false),
                    May = table.Column<bool>(nullable: false),
                    Jun = table.Column<bool>(nullable: false),
                    Jul = table.Column<bool>(nullable: false),
                    Aug = table.Column<bool>(nullable: false),
                    Sep = table.Column<bool>(nullable: false),
                    Oct = table.Column<bool>(nullable: false),
                    Nov = table.Column<bool>(nullable: false),
                    Dec = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TestClasses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestClasses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HouseHoldMoneys",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Organisation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    Automatically = table.Column<bool>(nullable: false),
                    PaymentID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseHoldMoneys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HouseHoldMoneys_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("e2ac9866-2297-4c72-81c4-9603a5ef438b"), true, true, true, true, true, true, true, true, true, true, true, true, 0 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("55c03567-dc2e-4c24-916b-d097e0c53aab"), true, false, false, false, false, false, false, false, false, false, true, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("0ad69806-8d06-4cb5-a36c-b4020c23eeeb"), false, false, false, false, false, false, false, true, false, false, false, true, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("bf41475c-5dc2-4db6-9139-9357eaf32ce9"), false, true, false, true, false, false, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("13b180cd-50fb-4315-b823-d723d2a0ae83"), false, false, false, false, true, true, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("47467bf7-f553-42e9-afbd-497dea79d10c"), false, false, true, false, false, false, true, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("8434d161-d135-4141-b605-b9adbc818c65"), false, false, false, false, false, false, false, false, true, true, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("a7a20d55-863b-487a-94bc-b3ad61a29250"), true, false, false, false, false, false, false, false, false, false, true, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("74641e6a-8b17-4b18-8c0c-f2f4491fa959"), false, false, false, false, false, false, false, true, false, false, false, true, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("ae9833dd-c16e-4914-b25e-c7d22cd5f42f"), false, true, false, true, false, false, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("f0e21bca-bab9-4f33-a440-3b27a5fc92ab"), false, false, false, false, true, true, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("a49234d0-2716-4482-8e87-89a22a468cb1"), false, false, true, false, false, false, true, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("bc022a3d-d073-4053-9c7a-22ff7aa8213d"), false, false, false, false, false, false, false, false, true, true, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("dca67a07-52e1-46d4-8c63-00233436fb9f"), true, false, false, false, false, false, false, false, false, false, true, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("95056ead-6ab6-460c-b34f-db8c06d4963a"), false, true, false, true, false, false, false, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("4eaae91a-384b-4b3b-b3a8-3350303a764e"), false, true, false, true, false, false, false, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("ea86f497-5c68-4abe-b6cf-2c646f01cfe7"), false, false, false, false, true, true, false, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("328a473d-05ac-48b2-ad9f-d5fc9f1661c5"), false, false, true, false, false, false, true, true, false, false, false, true, 2 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("5381016c-7432-43d7-9ba1-74d881dfef45"), false, true, false, true, false, false, false, false, true, true, false, false, 2 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("899ace4d-15cb-487e-bea3-4c80e14e24df"), true, false, false, false, true, true, false, false, false, false, true, false, 2 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("b4330895-361f-4add-bfdd-cd054ce8cced"), true, true, true, true, false, false, true, false, false, false, true, false, 1 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("0d5de3a2-a0b9-446a-a720-a65f85f6e99e"), false, false, false, false, true, true, false, true, true, true, false, true, 1 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("188e9bc4-fe07-4af7-9b92-e5a08943c3c2"), false, false, false, false, false, false, false, false, true, true, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("5c762dbf-2838-4c35-bec6-b45dce1c2f2a"), false, false, true, false, false, false, true, false, false, false, false, false, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_HouseHoldMoneys_PaymentID",
                table: "HouseHoldMoneys",
                column: "PaymentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseHoldMoneys");

            migrationBuilder.DropTable(
                name: "TestClasses");

            migrationBuilder.DropTable(
                name: "Payments");
        }
    }
}
