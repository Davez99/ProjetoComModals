using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTasksProject.Migrations
{
    public partial class MigrationNewProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exec1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceberNumero = table.Column<int>(nullable: false),
                    Resposta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pergunta = table.Column<string>(nullable: true),
                    RespostaEx2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec3",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Num1 = table.Column<float>(nullable: false),
                    Num2 = table.Column<float>(nullable: false),
                    Operador = table.Column<string>(nullable: true),
                    Resultado = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec4",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdadeEntrada = table.Column<int>(nullable: false),
                    IdadeSaida = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec5",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntradaUser = table.Column<string>(nullable: true),
                    SaidaUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec6",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntradaTexto = table.Column<string>(nullable: true),
                    SaidaTexto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec7",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalarioUser = table.Column<float>(nullable: false),
                    Reajuste = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec8",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceberNome = table.Column<string>(nullable: true),
                    ReceberEmail = table.Column<string>(nullable: true),
                    ReceberRG = table.Column<string>(nullable: true),
                    ResponderAoUser = table.Column<string>(nullable: true),
                    MostrarAoUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec8", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exec9",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUser = table.Column<string>(nullable: true),
                    IdadeUser = table.Column<int>(nullable: false),
                    PesoUser = table.Column<string>(nullable: true),
                    AlturaUser = table.Column<string>(nullable: true),
                    SaidaUser = table.Column<string>(nullable: true),
                    AvisoUser = table.Column<string>(nullable: true),
                    ConteudoUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exec9", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exec1");

            migrationBuilder.DropTable(
                name: "Exec2");

            migrationBuilder.DropTable(
                name: "Exec3");

            migrationBuilder.DropTable(
                name: "Exec4");

            migrationBuilder.DropTable(
                name: "Exec5");

            migrationBuilder.DropTable(
                name: "Exec6");

            migrationBuilder.DropTable(
                name: "Exec7");

            migrationBuilder.DropTable(
                name: "Exec8");

            migrationBuilder.DropTable(
                name: "Exec9");
        }
    }
}
