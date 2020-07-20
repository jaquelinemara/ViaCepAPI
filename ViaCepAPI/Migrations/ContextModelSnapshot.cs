﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ViaCepAPI.Models;

namespace ViaCepAPI.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ViaCepAPI.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Localidade")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
