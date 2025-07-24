using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KiemTraMvc.Migrations
{
    /// <inheritdoc />
    public partial class BangLop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sđt",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Sđt = table.Column<int>(type: "INTEGER", nullable: false),
                    Tuoi = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.FullName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropColumn(
                name: "Sđt",
                table: "Users");
        }
    }
}
