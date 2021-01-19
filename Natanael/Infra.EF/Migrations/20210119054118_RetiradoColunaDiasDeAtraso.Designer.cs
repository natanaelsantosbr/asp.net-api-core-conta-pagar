﻿// <auto-generated />
using System;
using Infra.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.EF.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210119054118_RetiradoColunaDiasDeAtraso")]
    partial class RetiradoColunaDiasDeAtraso
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Natanael.Dominio.ContasPagar.ContaPagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataDePagamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeVencimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDoCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PercentualDaMulta")
                        .HasColumnType("float");

                    b.Property<double>("PercentualDosJuros")
                        .HasColumnType("float");

                    b.Property<int>("QuantidadeDeDiasEmAtraso")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.Property<double>("ValorCorrigido")
                        .HasColumnType("float");

                    b.Property<double>("ValorDaMulta")
                        .HasColumnType("float");

                    b.Property<double>("ValorDosJuros")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ContasPagar");
                });
#pragma warning restore 612, 618
        }
    }
}
