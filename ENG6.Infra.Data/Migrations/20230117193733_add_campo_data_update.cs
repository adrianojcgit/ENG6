using Microsoft.EntityFrameworkCore.Migrations;

namespace ENG6.Infra.Data.Migrations
{
    public partial class add_campo_data_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDataAtualizacao",
                table: "Clientes",
                newName: "DataAtualizacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "Clientes",
                newName: "DataDataAtualizacao");
        }
    }
}
