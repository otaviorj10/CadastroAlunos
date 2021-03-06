// <auto-generated />
using AlunosWeb.FileTheContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlunosWeb.Migrations
{
    [DbContext(typeof(FileContext))]
    [Migration("20211018170750_inicio_2")]
    partial class inicio_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlunosWeb.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeAluno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvaId")
                        .HasColumnType("int");

                    b.Property<int>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("AlunoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("AlunosWeb.Models.Prova", b =>
                {
                    b.Property<int>("ProvaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeMateria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NotaDaProva")
                        .HasColumnType("float");

                    b.HasKey("ProvaId");

                    b.HasIndex("AlunoId");

                    b.ToTable("Prova");
                });

            modelBuilder.Entity("AlunosWeb.Models.Turma", b =>
                {
                    b.Property<int>("TurmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeTurma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurmaId");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("AlunosWeb.Models.Aluno", b =>
                {
                    b.HasOne("AlunosWeb.Models.Turma", "Turma")
                        .WithMany("alunos")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("AlunosWeb.Models.Prova", b =>
                {
                    b.HasOne("AlunosWeb.Models.Aluno", "aluno")
                        .WithMany("provas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");
                });

            modelBuilder.Entity("AlunosWeb.Models.Aluno", b =>
                {
                    b.Navigation("provas");
                });

            modelBuilder.Entity("AlunosWeb.Models.Turma", b =>
                {
                    b.Navigation("alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
