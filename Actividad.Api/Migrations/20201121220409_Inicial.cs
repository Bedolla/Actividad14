using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Actividad.Api.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Usuarios",
                table => new
                {
                    Id = table.Column<string>("nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>("nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>("nvarchar(max)", nullable: false),
                    Correo = table.Column<string>("nvarchar(max)", nullable: false),
                    Clave = table.Column<string>("nvarchar(max)", nullable: false),
                    Rol = table.Column<string>("nvarchar(max)", nullable: false),
                    Foto = table.Column<string>("nvarchar(max)", nullable: false),
                    Creacion = table.Column<DateTime>("DateTime2", nullable: false),
                    Disponible = table.Column<bool>("bit", nullable: false)
                },
                constraints: table => table.PrimaryKey("PK_Usuarios", x => x.Id),
                comment: "Administradores del servicio");

            migrationBuilder.InsertData(
                "Usuarios",
                new[] {"Id", "Apellido", "Clave", "Correo", "Creacion", "Disponible", "Foto", "Nombre", "Rol"},
                new object[,]
                {
                    {"40a2b170-b73e-4768-b61c-2013d7117004", "Flores Avalos", "OGgFiKDvH7RfNOasdZLhfw==", "flores@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 353, DateTimeKind.Local).AddTicks(4735), true, "img/avatares/soporte/f7acaf79-7643-4f32-a6d1-06e08967c800.png", "Juan Carlos", "Soporte"},
                    {"459b2f4a-5783-48a9-995d-e5d6d3a6d5cd", "Galván Guerrero", "OGgFiKDvH7RfNOasdZLhfw==", "galvan@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1867), true, "img/avatares/soporte/1b4c960a-e6a0-49aa-9c4d-4ff62f180a89.png", "Francisco Javier", "Soporte"},
                    {"c46fbafe-4c57-4431-bcaa-bf710c3820d9", "Alvarez Negrete", "OGgFiKDvH7RfNOasdZLhfw==", "alvarez@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1900), true, "img/avatares/soporte/85d28f46-b13a-4e64-92e4-6617aaae0645.png", "María Guadalupe", "Soporte"},
                    {"1feb53fe-1f73-48bb-a061-4e86e0d1de6d", "Rego Rodriguez", "OGgFiKDvH7RfNOasdZLhfw==", "rego@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1918), true, "img/avatares/soporte/94009e44-3263-4841-8dfb-29e9201b65b5.png", "María Enriqueta", "Soporte"},
                    {"4ecabf9a-4c85-4be0-b64b-1e2b60555f4b", "Montaño Araujo", "OGgFiKDvH7RfNOasdZLhfw==", "montano@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1927), true, "img/avatares/soporte/a257d889-f85b-4fbd-a725-7efe1dcda15f.png", "Sergio Adrían", "Soporte"},
                    {"890ae5e3-c464-47ec-9ca7-b8c5f4c5277c", "Carrasco García", "OGgFiKDvH7RfNOasdZLhfw==", "carrasco@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1934), true, "img/avatares/soporte/a749f4fc-3703-45ec-9b30-3384add3f9b2.png", "Edgar Ramón", "Soporte"},
                    {"7583628b-9ab3-42a0-aef8-cdac000f31ad", "Negrete Borjas", "OGgFiKDvH7RfNOasdZLhfw==", "negrete@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1941), true, "img/avatares/soporte/11e17958-6258-4fee-935c-36141f42b334.png", "Alejandro Ismael", "Soporte"},
                    {"f63ac3f8-b431-4fef-8c31-22e18d796173", "Castellanos Berjan", "OGgFiKDvH7RfNOasdZLhfw==", "castellanos@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1950), true, "img/avatares/soporte/0dca4e14-aec8-48f5-bbfc-bc0d672f2292.png", "Esli", "Soporte"},
                    {"6eb88418-3934-40f4-a5eb-db32c0260342", "Serrano Ramos", "OGgFiKDvH7RfNOasdZLhfw==", "serrano@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1957), true, "img/avatares/soporte/976062fb-6acf-48c7-adf7-95c4cc52df3f.png", "Joel Alejandro", "Soporte"},
                    {"95eb6eeb-e4aa-46b6-8482-357c1e9bcbe8", "Flores Ruelas", "OGgFiKDvH7RfNOasdZLhfw==", "flores@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1964), true, "img/avatares/soporte/ecdb9bba-b4f2-4c0f-8e23-116a87be3f51.png", "Fernando Alfonso", "Soporte"},
                    {"90c069f8-3e16-400d-84ef-2c8261d76e98", "Escalera Pérez", "OGgFiKDvH7RfNOasdZLhfw==", "escalera@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1972), true, "img/avatares/soporte/2e15fa0b-f344-4f71-961a-a4ed52d2dda0.png", "Hernán Adalid", "Soporte"},
                    {"4f415864-cb8a-4c55-b919-8de23eadc7d5", "Bedolla Valencia", "OGgFiKDvH7RfNOasdZLhfw==", "bedolla@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1985), true, "img/avatares/administradores/ce01f2f1-c0d6-48e2-9921-18f18c0aa60b.png", "Fernando", "Administrador"},
                    {"f41548bc-1609-4f1e-a464-7498d8554b09", "General", "OGgFiKDvH7RfNOasdZLhfw==", "a@ucol.mx", new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(2022), true, "img/avatares/administradores/f479f33c-497c-48e7-86bf-51c0b96c87b0.png", "Administrador", "Administrador"}
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Usuarios");
        }
    }
}
