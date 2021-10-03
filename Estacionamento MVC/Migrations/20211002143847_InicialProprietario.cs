using Microsoft.EntityFrameworkCore.Migrations;

namespace Estacionamento_MVC.Migrations
{
    public partial class InicialProprietario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estilo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Placa = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    NomePessoa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    NumVaga = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraEntrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraSaida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pago = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propietario");
        }
    }
}
