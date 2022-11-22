using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categoria(categoriaName,Descricao)" + 
                "VALUES('Normal','lanche feito com igredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categoria(categoriaName,Descricao)" +
                "VALUES('Natural','lanche feito com ingredientes intregais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categoria");

        }
    }
}
