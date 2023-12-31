﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Tecnica.Domain.Models;

#nullable disable

namespace Prueba_Tecnica.Domain.Migrations
{
    [DbContext(typeof(PruebaTecnicaContext))]
    partial class PruebaTecnicaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prueba_Tecnica.Domain.Models.Articulo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nombre");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("precio");

                    b.HasKey("Id");

                    b.ToTable("articulo");
                });

            modelBuilder.Entity("Prueba_Tecnica.Domain.Models.Contrato", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("CantidadEgresados")
                        .HasColumnType("int")
                        .HasColumnName("cantidadEgresados");

                    b.Property<string>("ColegioCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("colegioCurso");

                    b.Property<string>("ColegioLocalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("colegioLocalidad");

                    b.Property<string>("ColegioNivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("colegioNivel");

                    b.Property<string>("ColegioNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("colegioNombre");

                    b.Property<long>("Comision")
                        .HasColumnType("bigint")
                        .HasColumnName("comision");

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("courseCode");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("estado");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaAlta");

                    b.Property<DateTime?>("FechaEntrega")
                        .HasColumnType("datetime2")
                        .HasColumnName("fechaEntrega");

                    b.Property<string>("MedioEntrega")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("medioEntrega");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("total");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("vendedor");

                    b.HasKey("Id");

                    b.ToTable("contrato");
                });

            modelBuilder.Entity("Prueba_Tecnica.Domain.Models.Pedido", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ArticuloId")
                        .HasColumnType("bigint")
                        .HasColumnName("articulo_id");

                    b.Property<long>("ContractId")
                        .HasColumnType("bigint")
                        .HasColumnName("contract_id");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("createDate");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("createBy");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit")
                        .HasColumnName("deleted");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit")
                        .HasColumnName("enabled");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("updateDate");

                    b.HasKey("Id");

                    b.HasIndex("ArticuloId");

                    b.HasIndex("ContractId");

                    b.ToTable("pedido");
                });

            modelBuilder.Entity("Prueba_Tecnica.Domain.Models.Pedido", b =>
                {
                    b.HasOne("Prueba_Tecnica.Domain.Models.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("ArticuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba_Tecnica.Domain.Models.Contrato", "Contrato")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Articulo");

                    b.Navigation("Contrato");
                });
#pragma warning restore 612, 618
        }
    }
}
