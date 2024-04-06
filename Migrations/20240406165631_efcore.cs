using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace prog1ef.Migrations
{
    public partial class efcore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department_and_name_manager",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptnamemanger = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_and_name_manager", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "moneys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSN = table.Column<long>(type: "bigint", nullable: false),
                    blus_salary = table.Column<int>(type: "int", nullable: false),
                    Department_and_name_managerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moneys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_moneys_Department_and_name_manager_Department_and_name_managerID",
                        column: x => x.Department_and_name_managerID,
                        principalTable: "Department_and_name_manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "register",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Numberphone = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSN = table.Column<long>(type: "bigint", maxLength: 14, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    confirmpaswword = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Department_and_name_managerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register", x => x.Id);
                    table.ForeignKey(
                        name: "FK_register_Department_and_name_manager_Department_and_name_managerID",
                        column: x => x.Department_and_name_managerID,
                        principalTable: "Department_and_name_manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numberphone = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<float>(type: "real", nullable: false),
                    SSN = table.Column<long>(type: "bigint", maxLength: 14, nullable: false),
                    sheft = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    depID = table.Column<int>(type: "int", nullable: false),
                    MoneyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_Department_and_name_manager_depID",
                        column: x => x.depID,
                        principalTable: "Department_and_name_manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_moneys_MoneyID",
                        column: x => x.MoneyID,
                        principalTable: "moneys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSN = table.Column<long>(type: "bigint", nullable: false),
                    RegisterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_logins_register_RegisterId",
                        column: x => x.RegisterId,
                        principalTable: "register",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_depID",
                table: "employees",
                column: "depID");

            migrationBuilder.CreateIndex(
                name: "IX_employees_MoneyID",
                table: "employees",
                column: "MoneyID");

            migrationBuilder.CreateIndex(
                name: "IX_logins_RegisterId",
                table: "logins",
                column: "RegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_moneys_Department_and_name_managerID",
                table: "moneys",
                column: "Department_and_name_managerID");

            migrationBuilder.CreateIndex(
                name: "IX_register_Department_and_name_managerID",
                table: "register",
                column: "Department_and_name_managerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "logins");

            migrationBuilder.DropTable(
                name: "moneys");

            migrationBuilder.DropTable(
                name: "register");

            migrationBuilder.DropTable(
                name: "Department_and_name_manager");
        }
    }
}
