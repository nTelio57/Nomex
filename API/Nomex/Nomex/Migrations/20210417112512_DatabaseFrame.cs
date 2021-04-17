using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nomex.Migrations
{
    public partial class DatabaseFrame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveSubstances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveSubstances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPersonals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPersonals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompensated = table.Column<bool>(type: "bit", nullable: false),
                    UsageTemplateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicines_Usages_UsageTemplateId",
                        column: x => x.UsageTemplateId,
                        principalTable: "Usages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalDetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserPersonals_PersonalDetailsId",
                        column: x => x.PersonalDetailsId,
                        principalTable: "UserPersonals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicineActiveSubstances",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    ActiveSubstanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineActiveSubstances", x => new { x.MedicineId, x.ActiveSubstanceId });
                    table.ForeignKey(
                        name: "FK_MedicineActiveSubstances_ActiveSubstances_ActiveSubstanceId",
                        column: x => x.ActiveSubstanceId,
                        principalTable: "ActiveSubstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineActiveSubstances_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    UsageId = table.Column<int>(type: "int", nullable: true),
                    MedicineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Usages_UsageId",
                        column: x => x.UsageId,
                        principalTable: "Usages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Usages",
                columns: new[] { "Id", "Description", "Dosage" },
                values: new object[,]
                {
                    { 1, "Aprašymas vienas", 0 },
                    { 2, "Aprašymas du", 0 },
                    { 3, "Aprašymas trys", 3 },
                    { 4, "Aprašymas keturi", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserPersonals",
                columns: new[] { "Id", "BirthDate", "Name", "PersonalCode", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mantas", "191899", "Pabalys" },
                    { 2, new DateTime(2000, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arminas", "6869869", "Vilunas" },
                    { 3, new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marius", "49844", "Gindriunas" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "PersonalDetailsId", "Salt" },
                values: new object[,]
                {
                    { 1, "vienas@gmail.com", "132456", null, "geras" },
                    { 2, "ddu@gmail.com", "nesakysiu", null, "geresnis" },
                    { 3, "trys@gmail.com", "kaunas", null, "geriausias" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Barcode", "CompanyName", "ExpireDate", "IsCompensated", "Name", "Price", "UsageTemplateId" },
                values: new object[,]
                {
                    { 1, "474127310724", "Takeda Pharma AS", new DateTime(2031, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Ibumetin", 2.2f, 1 },
                    { 2, "215366", "BERLIN-CHEMIE AG", new DateTime(2031, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mezym 20000 V", 6.29f, 2 },
                    { 5, "477131630740", "SIROMED PHARMA", new DateTime(2031, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "LIVE WELL GINKGO PLUS", 7.99f, 2 },
                    { 4, "676194965199", "SIROMED PHARMA", new DateTime(2031, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "VITAMINAS C PRO-LONG", 7.27f, 3 },
                    { 3, "502126522103", "Vitabiotics LTD", new DateTime(2031, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "CARDIOACE", 16.99f, 4 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "MedicineId", "UsageId", "UserId", "ValidUntil" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 3, 3, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, 1, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 2, 2, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicineActiveSubstances_ActiveSubstanceId",
                table: "MedicineActiveSubstances",
                column: "ActiveSubstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_UsageTemplateId",
                table: "Medicines",
                column: "UsageTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_MedicineId",
                table: "Recipes",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UsageId",
                table: "Recipes",
                column: "UsageId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonalDetailsId",
                table: "Users",
                column: "PersonalDetailsId",
                unique: true,
                filter: "[PersonalDetailsId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicineActiveSubstances");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "ActiveSubstances");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Usages");

            migrationBuilder.DropTable(
                name: "UserPersonals");
        }
    }
}
