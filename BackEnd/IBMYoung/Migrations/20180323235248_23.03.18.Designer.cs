﻿// <auto-generated />
using IBMYoung.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace IBMYoung.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20180323235248_23.03.18")]
    partial class _230318
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IBMYoung.Model.Alternativa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MyProperty");

                    b.Property<bool>("correta");

                    b.Property<int>("questaoid");

                    b.Property<string>("textoAlternativa");

                    b.HasKey("ID");

                    b.HasIndex("questaoid");

                    b.ToTable("Alternativas");
                });

            modelBuilder.Entity("IBMYoung.Model.Aprendiz", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataEntrada");

                    b.Property<DateTime>("dataSaida");

                    b.Property<int>("instituicaoid");

                    b.Property<int>("nivel");

                    b.Property<string>("nome");

                    b.Property<string>("sobrenome");

                    b.Property<int>("usuarioid");

                    b.HasKey("ID");

                    b.HasIndex("instituicaoid");

                    b.HasIndex("usuarioid");

                    b.ToTable("Aprendizes");
                });

            modelBuilder.Entity("IBMYoung.Model.Boletim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AprendizID");

                    b.Property<int>("anoReferencia");

                    b.Property<DateTime>("dataCadastro");

                    b.Property<float>("frequencia");

                    b.Property<string>("mesReferencia");

                    b.Property<float>("nota");

                    b.Property<string>("observacao");

                    b.HasKey("ID");

                    b.HasIndex("AprendizID");

                    b.ToTable("Boletins");
                });

            modelBuilder.Entity("IBMYoung.Model.Funcionario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome");

                    b.Property<int>("usuarioid");

                    b.HasKey("ID");

                    b.HasIndex("usuarioid");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("IBMYoung.Model.Instituicao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome");

                    b.HasKey("ID");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("IBMYoung.Model.Questao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("conteudo");

                    b.Property<int>("tarefaid");

                    b.Property<string>("titulo");

                    b.HasKey("ID");

                    b.HasIndex("tarefaid");

                    b.ToTable("Questoes");
                });

            modelBuilder.Entity("IBMYoung.Model.Replica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataCriacao");

                    b.Property<string>("texto");

                    b.Property<int>("topicoid");

                    b.HasKey("ID");

                    b.HasIndex("topicoid");

                    b.ToTable("Replicas");
                });

            modelBuilder.Entity("IBMYoung.Model.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AprendizID");

                    b.Property<bool>("active");

                    b.Property<string>("conteudo");

                    b.Property<DateTime>("dataCriacao");

                    b.Property<DateTime>("dataExclusao");

                    b.Property<bool>("entregavel");

                    b.Property<bool>("multEscolha");

                    b.Property<int>("nivel");

                    b.Property<string>("titulo");

                    b.Property<int>("usuarioid");

                    b.HasKey("Id");

                    b.HasIndex("AprendizID");

                    b.HasIndex("usuarioid");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("IBMYoung.Model.Topico", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataCriacao");

                    b.Property<string>("texto");

                    b.Property<string>("titulo");

                    b.HasKey("ID");

                    b.ToTable("Topicos");
                });

            modelBuilder.Entity("IBMYoung.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("active");

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("tipo");

                    b.Property<string>("username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("IBMYoung.Model.Alternativa", b =>
                {
                    b.HasOne("IBMYoung.Model.Questao", "questao")
                        .WithMany("alternativaId")
                        .HasForeignKey("questaoid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IBMYoung.Model.Aprendiz", b =>
                {
                    b.HasOne("IBMYoung.Model.Instituicao", "instituicao")
                        .WithMany("Aprendizes")
                        .HasForeignKey("instituicaoid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IBMYoung.Model.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IBMYoung.Model.Boletim", b =>
                {
                    b.HasOne("IBMYoung.Model.Aprendiz")
                        .WithMany("boletins")
                        .HasForeignKey("AprendizID");
                });

            modelBuilder.Entity("IBMYoung.Model.Funcionario", b =>
                {
                    b.HasOne("IBMYoung.Model.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IBMYoung.Model.Questao", b =>
                {
                    b.HasOne("IBMYoung.Model.Tarefa", "tarefa")
                        .WithMany("questoes")
                        .HasForeignKey("tarefaid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IBMYoung.Model.Replica", b =>
                {
                    b.HasOne("IBMYoung.Model.Topico", "topico")
                        .WithMany("replicas")
                        .HasForeignKey("topicoid")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IBMYoung.Model.Tarefa", b =>
                {
                    b.HasOne("IBMYoung.Model.Aprendiz")
                        .WithMany("tarefas")
                        .HasForeignKey("AprendizID");

                    b.HasOne("IBMYoung.Model.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
