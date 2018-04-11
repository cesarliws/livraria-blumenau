﻿// <auto-generated />
using LivrariaBlumenau.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LivrariaBlumenau.Migrations
{
    [DbContext(typeof(DbEntities))]
    [Migration("20180411012904_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LivrariaBlumenau.Models.Livro", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active");

                    b.Property<string>("Autor");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DataPublicacao");

                    b.Property<string>("Descricao");

                    b.Property<string>("Edicao");

                    b.Property<DateTime>("EditedAt");

                    b.Property<string>("Editora");

                    b.Property<long?>("Estoque");

                    b.Property<string>("ISBN10");

                    b.Property<string>("ISBN13");

                    b.Property<string>("Idioma");

                    b.Property<int?>("Paginas");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
