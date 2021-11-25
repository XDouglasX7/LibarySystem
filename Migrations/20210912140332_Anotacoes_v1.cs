using Microsoft.EntityFrameworkCore.Migrations;

namespace LibrarySystem.Migrations
{
    public partial class Anotacoes_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Planos_Planoid",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacoes_Clientes_clienteid",
                table: "Movimentacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacoes_Livros_livroid",
                table: "Movimentacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Planos",
                table: "Planos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimentacoes",
                table: "Movimentacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Livros",
                table: "Livros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colaboradores",
                table: "Colaboradores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "preco",
                table: "Movimentacoes");

            migrationBuilder.DropColumn(
                name: "cep",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "rg",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "cep",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "rg",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Planos",
                newName: "Plano");

            migrationBuilder.RenameTable(
                name: "Movimentacoes",
                newName: "Movimentacao");

            migrationBuilder.RenameTable(
                name: "Livros",
                newName: "Livro");

            migrationBuilder.RenameTable(
                name: "Colaboradores",
                newName: "Colaborador");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentacoes_livroid",
                table: "Movimentacao",
                newName: "IX_Movimentacao_livroid");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentacoes_clienteid",
                table: "Movimentacao",
                newName: "IX_Movimentacao_clienteid");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "Livro",
                newName: "preco_venda");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_Planoid",
                table: "Cliente",
                newName: "IX_Cliente_Planoid");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Plano",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Livro",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "preco_compra",
                table: "Livro",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "usuario",
                table: "Colaborador",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Colaborador",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Colaborador",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Colaborador",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Cliente",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Cliente",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plano",
                table: "Plano",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimentacao",
                table: "Movimentacao",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livro",
                table: "Livro",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colaborador",
                table: "Colaborador",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Plano_Planoid",
                table: "Cliente",
                column: "Planoid",
                principalTable: "Plano",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Cliente_clienteid",
                table: "Movimentacao",
                column: "clienteid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Livro_livroid",
                table: "Movimentacao",
                column: "livroid",
                principalTable: "Livro",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Plano_Planoid",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Cliente_clienteid",
                table: "Movimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Livro_livroid",
                table: "Movimentacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plano",
                table: "Plano");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimentacao",
                table: "Movimentacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Livro",
                table: "Livro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colaborador",
                table: "Colaborador");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "preco_compra",
                table: "Livro");

            migrationBuilder.RenameTable(
                name: "Plano",
                newName: "Planos");

            migrationBuilder.RenameTable(
                name: "Movimentacao",
                newName: "Movimentacoes");

            migrationBuilder.RenameTable(
                name: "Livro",
                newName: "Livros");

            migrationBuilder.RenameTable(
                name: "Colaborador",
                newName: "Colaboradores");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentacao_livroid",
                table: "Movimentacoes",
                newName: "IX_Movimentacoes_livroid");

            migrationBuilder.RenameIndex(
                name: "IX_Movimentacao_clienteid",
                table: "Movimentacoes",
                newName: "IX_Movimentacoes_clienteid");

            migrationBuilder.RenameColumn(
                name: "preco_venda",
                table: "Livros",
                newName: "preco");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_Planoid",
                table: "Clientes",
                newName: "IX_Clientes_Planoid");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Planos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddColumn<float>(
                name: "preco",
                table: "Movimentacoes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "usuario",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Colaboradores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cpf",
                table: "Colaboradores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cep",
                table: "Colaboradores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rg",
                table: "Colaboradores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<int>(
                name: "cpf",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cep",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rg",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Planos",
                table: "Planos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimentacoes",
                table: "Movimentacoes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Livros",
                table: "Livros",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colaboradores",
                table: "Colaboradores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Planos_Planoid",
                table: "Clientes",
                column: "Planoid",
                principalTable: "Planos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacoes_Clientes_clienteid",
                table: "Movimentacoes",
                column: "clienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacoes_Livros_livroid",
                table: "Movimentacoes",
                column: "livroid",
                principalTable: "Livros",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
