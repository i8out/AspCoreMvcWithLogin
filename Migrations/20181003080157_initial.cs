﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCoreMVCWithLogin.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "Address", "Email", "IsActive", "Name" },
                values: new object[] { 1, "Taguig", "alpha@mail.com", true, "Alpha Corp" });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "Address", "Email", "IsActive", "Name" },
                values: new object[] { 2, "Pasig", "beta@mail.com", true, "Beta Corp" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
