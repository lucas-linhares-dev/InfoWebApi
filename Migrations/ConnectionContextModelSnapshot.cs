﻿// <auto-generated />
using System;
using InfoWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfoWeb.Migrations
{
    [DbContext(typeof(Context))]
    partial class ConnectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InfoWeb.Models.CentroCusto", b =>
                {
                    b.Property<int>("cen_codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cen_codigo"));

                    b.Property<string>("cen_descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("cen_dtalteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("cen_dtcadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("cen_usu_alteracao")
                        .HasColumnType("int");

                    b.Property<int>("cen_usu_cadastro")
                        .HasColumnType("int");

                    b.HasKey("cen_codigo");

                    b.ToTable("CentrosCusto");
                });

            modelBuilder.Entity("InfoWeb.Models.ContaPagar", b =>
                {
                    b.Property<int>("pag_codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pag_codigo"));

                    b.Property<int?>("cen_codigo")
                        .HasColumnType("int");

                    b.Property<bool>("debtesouraria")
                        .HasColumnType("bit");

                    b.Property<int>("fpg_codigo")
                        .HasColumnType("int");

                    b.Property<int?>("loj_codigo")
                        .HasColumnType("int");

                    b.Property<string>("pag_documento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("pag_dtalteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("pag_dtcadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("pag_dtcomp")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("pag_dtlanc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("pag_dtpag")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("pag_dtvenc")
                        .HasColumnType("datetime2");

                    b.Property<string>("pag_historico")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<TimeSpan>("pag_hora")
                        .HasColumnType("time");

                    b.Property<string>("pag_id_refs")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("pag_numNfe")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("pag_situacao")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("pag_usu_alteracao")
                        .HasColumnType("int");

                    b.Property<int>("pag_usu_cadastro")
                        .HasColumnType("int");

                    b.Property<decimal>("pag_vlracresc")
                        .HasMaxLength(15)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("pag_vlrdesc")
                        .HasMaxLength(15)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("pag_vlrdoc")
                        .HasMaxLength(15)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("pag_vlrmulta")
                        .HasMaxLength(15)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("pag_vlrpagar")
                        .HasMaxLength(15)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("pag_vlrpago")
                        .HasMaxLength(15)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("pes_codigo")
                        .HasColumnType("int");

                    b.Property<int?>("tes_codigo")
                        .HasColumnType("int");

                    b.HasKey("pag_codigo");

                    b.HasIndex("cen_codigo");

                    b.HasIndex("fpg_codigo");

                    b.ToTable("ContasPagar");
                });

            modelBuilder.Entity("InfoWeb.Models.FormaPag", b =>
                {
                    b.Property<int>("fpg_codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fpg_codigo"));

                    b.Property<string>("fpg_descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("fpg_dtalteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fpg_dtcadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("fpg_usu_alteracao")
                        .HasColumnType("int");

                    b.Property<int>("fpg_usu_cadastro")
                        .HasColumnType("int");

                    b.HasKey("fpg_codigo");

                    b.ToTable("FormasPag");
                });

            modelBuilder.Entity("InfoWeb.Models.ContaPagar", b =>
                {
                    b.HasOne("InfoWeb.Models.CentroCusto", null)
                        .WithMany()
                        .HasForeignKey("cen_codigo")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InfoWeb.Models.FormaPag", null)
                        .WithMany()
                        .HasForeignKey("fpg_codigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
