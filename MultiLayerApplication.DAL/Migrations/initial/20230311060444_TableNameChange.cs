using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiLayerApplication.DAL.Migrations.initial
{
    /// <inheritdoc />
    public partial class TableNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes");

            migrationBuilder.RenameTable(
                name: "Attributes",
                newName: "ProductAttributes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductAttributes",
                table: "ProductAttributes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductAttributes",
                table: "ProductAttributes");

            migrationBuilder.RenameTable(
                name: "ProductAttributes",
                newName: "Attributes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attributes",
                table: "Attributes",
                column: "Id");
        }
    }
}
