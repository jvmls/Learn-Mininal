using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace learn_minimal_api.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Adms",
                columns: new[] { "Id", "Email", "Perfil", "Senha" },
                values: new object[] { 1, "admin", "Cleber", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adms",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
