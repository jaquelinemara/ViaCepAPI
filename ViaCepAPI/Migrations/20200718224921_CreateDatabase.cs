using Microsoft.EntityFrameworkCore.Migrations;

namespace ViaCepAPI.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Localidade = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
