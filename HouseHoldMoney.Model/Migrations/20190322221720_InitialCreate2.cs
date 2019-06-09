using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseHoldMoney.Model.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestClasses");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("0ad69806-8d06-4cb5-a36c-b4020c23eeeb"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("0d5de3a2-a0b9-446a-a720-a65f85f6e99e"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("13b180cd-50fb-4315-b823-d723d2a0ae83"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("188e9bc4-fe07-4af7-9b92-e5a08943c3c2"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("328a473d-05ac-48b2-ad9f-d5fc9f1661c5"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("47467bf7-f553-42e9-afbd-497dea79d10c"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("4eaae91a-384b-4b3b-b3a8-3350303a764e"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("5381016c-7432-43d7-9ba1-74d881dfef45"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("55c03567-dc2e-4c24-916b-d097e0c53aab"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("5c762dbf-2838-4c35-bec6-b45dce1c2f2a"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("74641e6a-8b17-4b18-8c0c-f2f4491fa959"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("8434d161-d135-4141-b605-b9adbc818c65"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("899ace4d-15cb-487e-bea3-4c80e14e24df"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("95056ead-6ab6-460c-b34f-db8c06d4963a"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("a49234d0-2716-4482-8e87-89a22a468cb1"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("a7a20d55-863b-487a-94bc-b3ad61a29250"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("ae9833dd-c16e-4914-b25e-c7d22cd5f42f"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("b4330895-361f-4add-bfdd-cd054ce8cced"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("bc022a3d-d073-4053-9c7a-22ff7aa8213d"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("bf41475c-5dc2-4db6-9139-9357eaf32ce9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("dca67a07-52e1-46d4-8c63-00233436fb9f"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("e2ac9866-2297-4c72-81c4-9603a5ef438b"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("ea86f497-5c68-4abe-b6cf-2c646f01cfe7"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("f0e21bca-bab9-4f33-a440-3b27a5fc92ab"));

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("80578511-aa33-419b-8452-c6f31eb80042"), true, true, true, true, true, true, true, true, true, true, true, true, 0 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("b6fb1f15-6640-4780-805f-daee9ca938b4"), true, false, false, false, false, false, false, false, false, false, true, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("971ebfca-f605-4563-a1f5-04f3b367f078"), false, false, false, false, false, false, false, true, false, false, false, true, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("dcf397fe-c181-4286-92bd-1edd195b3895"), false, true, false, true, false, false, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("64b6d2a0-d95a-498a-afc3-59ec498b4410"), false, false, false, false, true, true, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("bfef042c-aa45-4c4f-bd3d-a50a81e4e2be"), false, false, true, false, false, false, true, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("6b8e1584-44d1-470a-90b1-1cd3d4c5c226"), false, false, false, false, false, false, false, false, true, true, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("12339fce-0adc-4610-a5b6-f41f2b910fa1"), true, false, false, false, false, false, false, false, false, false, true, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("30b76e21-cfca-4882-87a6-ba167aa9d1b3"), false, false, false, false, false, false, false, true, false, false, false, true, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("ddfd6516-cc35-434b-84ad-85e69277f07a"), false, true, false, true, false, false, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("6c9780b0-9e27-4833-afbc-3225bf38c7a9"), false, false, false, false, true, true, false, false, false, false, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("82ff28fa-d9ce-4b7d-a233-e8b0b2758739"), false, false, true, false, false, false, true, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("bb1b7cca-86ae-43d9-93a9-bc100449584f"), false, false, false, false, false, false, false, false, true, true, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("f0d8f3cf-c6bc-41e9-afa1-666e278cb599"), true, false, false, false, false, false, false, false, false, false, true, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("d73e06e0-e76d-4450-b6d8-40b85350a912"), false, true, false, true, false, false, false, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("988dd526-d831-461e-865b-8e6aae2cc8d9"), false, true, false, true, false, false, false, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("c8a5c3e2-8b0f-41f6-9223-efa8be522869"), false, false, false, false, true, true, false, false, false, false, false, false, 3 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("e2b5b3f2-c5a1-4bf0-9a53-f61836d6702e"), false, false, true, false, false, false, true, true, false, false, false, true, 2 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("bffb2d5a-cee1-41d6-a777-51ba40363f51"), false, true, false, true, false, false, false, false, true, true, false, false, 2 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("43644941-8078-43f5-81fb-0d71fb902a99"), true, false, false, false, true, true, false, false, false, false, true, false, 2 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("c7df48e6-b5d5-4c4b-a960-69e9335ac227"), true, true, true, true, false, false, true, false, false, false, true, false, 1 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("da3d9a67-77e0-4723-a918-44da5cff4686"), false, false, false, false, true, true, false, true, true, true, false, true, 1 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("38b01a81-9261-45a7-b268-c5a0d3efcb18"), false, false, false, false, false, false, false, false, true, true, false, false, 4 });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "ID", "Apr", "Aug", "Dec", "Feb", "Jan", "Jul", "Jun", "Mar", "May", "Nov", "Oct", "Sep", "TermOfPayment" },
                values: new object[] { new Guid("35f69fd9-30dc-46a2-9ff1-7a6b087b10ea"), false, false, true, false, false, false, true, false, false, false, false, false, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("12339fce-0adc-4610-a5b6-f41f2b910fa1"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("30b76e21-cfca-4882-87a6-ba167aa9d1b3"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("35f69fd9-30dc-46a2-9ff1-7a6b087b10ea"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("38b01a81-9261-45a7-b268-c5a0d3efcb18"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("43644941-8078-43f5-81fb-0d71fb902a99"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("64b6d2a0-d95a-498a-afc3-59ec498b4410"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("6b8e1584-44d1-470a-90b1-1cd3d4c5c226"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("6c9780b0-9e27-4833-afbc-3225bf38c7a9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("80578511-aa33-419b-8452-c6f31eb80042"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("82ff28fa-d9ce-4b7d-a233-e8b0b2758739"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("971ebfca-f605-4563-a1f5-04f3b367f078"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("988dd526-d831-461e-865b-8e6aae2cc8d9"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("b6fb1f15-6640-4780-805f-daee9ca938b4"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("bb1b7cca-86ae-43d9-93a9-bc100449584f"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("bfef042c-aa45-4c4f-bd3d-a50a81e4e2be"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("bffb2d5a-cee1-41d6-a777-51ba40363f51"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("c7df48e6-b5d5-4c4b-a960-69e9335ac227"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("c8a5c3e2-8b0f-41f6-9223-efa8be522869"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("d73e06e0-e76d-4450-b6d8-40b85350a912"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("da3d9a67-77e0-4723-a918-44da5cff4686"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("dcf397fe-c181-4286-92bd-1edd195b3895"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("ddfd6516-cc35-434b-84ad-85e69277f07a"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("e2b5b3f2-c5a1-4bf0-9a53-f61836d6702e"));

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "ID",
                keyValue: new Guid("f0d8f3cf-c6bc-41e9-afa1-666e278cb599"));

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
        }
    }
}
