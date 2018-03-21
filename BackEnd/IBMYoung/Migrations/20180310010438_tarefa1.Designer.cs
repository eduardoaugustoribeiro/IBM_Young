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
    [Migration("20180310010438_tarefa1")]
    partial class tarefa1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IBMYoung.Model.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("active");

                    b.Property<DateTime>("dataCriacao");

                    b.Property<DateTime>("dataExclusao");

                    b.Property<bool>("entregavel");

                    b.Property<int>("nivel");

                    b.Property<string>("status");

                    b.Property<string>("titulo");

                    b.HasKey("Id");

                    b.ToTable("tarefa");
                });

            modelBuilder.Entity("IBMYoung.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("active");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.ToTable("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
