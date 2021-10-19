﻿// <auto-generated />
using System;
using AlunoApp.FileContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlunoApp.Migrations
{
    [DbContext(typeof(AlunoAppContext))]
    [Migration("20211018235338_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlunoApp.Models.AlunoModel", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("DATE")
                        .HasColumnName("Data de Nascimento");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("VARCHAR(4)");

                    b.Property<string>("Nome")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("AlunoId");

                    b.ToTable("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}
