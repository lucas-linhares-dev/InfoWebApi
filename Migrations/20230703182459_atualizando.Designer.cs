﻿// <auto-generated />
using InfoWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfoWeb.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230703182459_atualizando")]
    partial class atualizando
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InfoWeb.Models.FormaPag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("descricao")
                        .HasColumnType("int")
                        .HasColumnName("descricao");

                    b.Property<int>("nome")
                        .HasColumnType("int")
                        .HasColumnName("nome");

                    b.HasKey("id");

                    b.ToTable("formaspag");
                });
#pragma warning restore 612, 618
        }
    }
}
