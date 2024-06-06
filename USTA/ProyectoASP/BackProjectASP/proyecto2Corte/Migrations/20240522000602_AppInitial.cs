using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace proyecto2Corte.Migrations
{
    public partial class AppInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Creación de la tabla de roles
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            // Creación de la tabla de usuarios
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            // Creación de la tabla de usuarios personalizados (Usuario)
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            // Creación de la tabla de peticiones (Peticion)
            migrationBuilder.CreateTable(
                name: "Peticion",
                columns: table => new
                {
                    IdPeticion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPeticion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Asunto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peticion", x => x.IdPeticion);
                    
                });

            // Creación de la tabla de respuestas (Respuesta)
            migrationBuilder.CreateTable(
                name: "Respuesta",
                columns: table => new
                {
                    IdRespuesta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRespuesta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RespuestaTexto = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdPeticion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respuesta", x => x.IdRespuesta);
                    table.ForeignKey(
                        name: "FK_Respuesta_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Respuesta_Peticion_IdPeticion",
                        column: x => x.IdPeticion,
                        principalTable: "Peticion",
                        principalColumn: "IdPeticion",
                        onDelete: ReferentialAction.Restrict);
                });

            // Crear índices para las tablas
            

            migrationBuilder.CreateIndex(
                name: "IX_Respuesta_IdUsuario",
                table: "Respuesta",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Respuesta_IdPeticion",
                table: "Respuesta",
                column: "IdPeticion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "AspNetRoles");
            migrationBuilder.DropTable(name: "AspNetUsers");
            migrationBuilder.DropTable(name: "Respuesta");
            migrationBuilder.DropTable(name: "Peticion");
            migrationBuilder.DropTable(name: "Usuario");
        }
    }
}
