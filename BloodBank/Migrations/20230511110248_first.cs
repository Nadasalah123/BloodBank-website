using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBank.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Communucations",
                columns: table => new
                {
                    person_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    person_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communucations", x => x.person_id);
                });

            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    donor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    donor_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.donor_id);
                });

            migrationBuilder.CreateTable(
                name: "Needers",
                columns: table => new
                {
                    needer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    needer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Needers", x => x.needer_id);
                });

            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    stock_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stock_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donor_id = table.Column<int>(type: "int", nullable: false),
                    needer_id = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.stock_id);
                    table.ForeignKey(
                        name: "FK_stocks_Donors_donor_id",
                        column: x => x.donor_id,
                        principalTable: "Donors",
                        principalColumn: "donor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stocks_Needers_needer_id",
                        column: x => x.needer_id,
                        principalTable: "Needers",
                        principalColumn: "needer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_stocks_donor_id",
                table: "stocks",
                column: "donor_id");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_needer_id",
                table: "stocks",
                column: "needer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Communucations");

            migrationBuilder.DropTable(
                name: "stocks");

            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "Needers");
        }
    }
}
