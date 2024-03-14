using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFun.Migrations
{
    /// <inheritdoc />
    public partial class SecondOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Foods",
                newName: "VendorName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VendorName",
                table: "Foods",
                newName: "Description");
        }
    }
}
