﻿using Actividad.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace Actividad.Api.Migrations
{
    [DbContext(typeof(Contexto))]
    internal class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            #pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Actividad.Data.Entities.Usuario", b =>
            {
                b.Property<string>("Id")
                 .HasColumnType("nvarchar(450)");

                b.Property<string>("Apellido")
                 .IsRequired()
                 .HasColumnType("nvarchar(max)");

                b.Property<string>("Clave")
                 .IsRequired()
                 .HasColumnType("nvarchar(max)");

                b.Property<string>("Correo")
                 .IsRequired()
                 .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("Creacion")
                 .HasColumnType("DateTime2");

                b.Property<bool>("Disponible")
                 .HasColumnType("bit");

                b.Property<string>("Foto")
                 .IsRequired()
                 .HasColumnType("nvarchar(max)");

                b.Property<string>("Nombre")
                 .IsRequired()
                 .HasColumnType("nvarchar(max)");

                b.Property<string>("Rol")
                 .IsRequired()
                 .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Usuarios");

                b
                    .HasComment("Administradores del servicio");

                b.HasData(
                    new
                    {
                        Id = "40a2b170-b73e-4768-b61c-2013d7117004",
                        Apellido = "Flores Avalos",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "flores@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 353, DateTimeKind.Local).AddTicks(4735),
                        Disponible = true,
                        Foto = "img/avatares/soporte/f7acaf79-7643-4f32-a6d1-06e08967c800.png",
                        Nombre = "Juan Carlos",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "459b2f4a-5783-48a9-995d-e5d6d3a6d5cd",
                        Apellido = "Galván Guerrero",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "galvan@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1867),
                        Disponible = true,
                        Foto = "img/avatares/soporte/1b4c960a-e6a0-49aa-9c4d-4ff62f180a89.png",
                        Nombre = "Francisco Javier",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "c46fbafe-4c57-4431-bcaa-bf710c3820d9",
                        Apellido = "Alvarez Negrete",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "alvarez@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1900),
                        Disponible = true,
                        Foto = "img/avatares/soporte/85d28f46-b13a-4e64-92e4-6617aaae0645.png",
                        Nombre = "María Guadalupe",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "1feb53fe-1f73-48bb-a061-4e86e0d1de6d",
                        Apellido = "Rego Rodriguez",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "rego@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1918),
                        Disponible = true,
                        Foto = "img/avatares/soporte/94009e44-3263-4841-8dfb-29e9201b65b5.png",
                        Nombre = "María Enriqueta",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "4ecabf9a-4c85-4be0-b64b-1e2b60555f4b",
                        Apellido = "Montaño Araujo",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "montano@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1927),
                        Disponible = true,
                        Foto = "img/avatares/soporte/a257d889-f85b-4fbd-a725-7efe1dcda15f.png",
                        Nombre = "Sergio Adrían",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "890ae5e3-c464-47ec-9ca7-b8c5f4c5277c",
                        Apellido = "Carrasco García",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "carrasco@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1934),
                        Disponible = true,
                        Foto = "img/avatares/soporte/a749f4fc-3703-45ec-9b30-3384add3f9b2.png",
                        Nombre = "Edgar Ramón",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "7583628b-9ab3-42a0-aef8-cdac000f31ad",
                        Apellido = "Negrete Borjas",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "negrete@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1941),
                        Disponible = true,
                        Foto = "img/avatares/soporte/11e17958-6258-4fee-935c-36141f42b334.png",
                        Nombre = "Alejandro Ismael",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "f63ac3f8-b431-4fef-8c31-22e18d796173",
                        Apellido = "Castellanos Berjan",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "castellanos@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1950),
                        Disponible = true,
                        Foto = "img/avatares/soporte/0dca4e14-aec8-48f5-bbfc-bc0d672f2292.png",
                        Nombre = "Esli",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "6eb88418-3934-40f4-a5eb-db32c0260342",
                        Apellido = "Serrano Ramos",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "serrano@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1957),
                        Disponible = true,
                        Foto = "img/avatares/soporte/976062fb-6acf-48c7-adf7-95c4cc52df3f.png",
                        Nombre = "Joel Alejandro",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "95eb6eeb-e4aa-46b6-8482-357c1e9bcbe8",
                        Apellido = "Flores Ruelas",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "flores@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1964),
                        Disponible = true,
                        Foto = "img/avatares/soporte/ecdb9bba-b4f2-4c0f-8e23-116a87be3f51.png",
                        Nombre = "Fernando Alfonso",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "90c069f8-3e16-400d-84ef-2c8261d76e98",
                        Apellido = "Escalera Pérez",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "escalera@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1972),
                        Disponible = true,
                        Foto = "img/avatares/soporte/2e15fa0b-f344-4f71-961a-a4ed52d2dda0.png",
                        Nombre = "Hernán Adalid",
                        Rol = "Soporte"
                    },
                    new
                    {
                        Id = "4f415864-cb8a-4c55-b919-8de23eadc7d5",
                        Apellido = "Bedolla Valencia",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "bedolla@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(1985),
                        Disponible = true,
                        Foto = "img/avatares/administradores/ce01f2f1-c0d6-48e2-9921-18f18c0aa60b.png",
                        Nombre = "Fernando",
                        Rol = "Administrador"
                    },
                    new
                    {
                        Id = "f41548bc-1609-4f1e-a464-7498d8554b09",
                        Apellido = "General",
                        Clave = "OGgFiKDvH7RfNOasdZLhfw==",
                        Correo = "a@ucol.mx",
                        Creacion = new DateTime(2020, 11, 21, 16, 4, 9, 355, DateTimeKind.Local).AddTicks(2022),
                        Disponible = true,
                        Foto = "img/avatares/administradores/f479f33c-497c-48e7-86bf-51c0b96c87b0.png",
                        Nombre = "Administrador",
                        Rol = "Administrador"
                    });
            });
            #pragma warning restore 612, 618
        }
    }
}
