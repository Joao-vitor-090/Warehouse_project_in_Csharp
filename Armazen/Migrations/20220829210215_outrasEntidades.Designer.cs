// <auto-generated />
using System;
using Armazen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Armazen.Migrations
{
    [DbContext(typeof(ArmazenContext))]
    [Migration("20220829210215_outrasEntidades")]
    partial class outrasEntidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Armazen.Models.Deposito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Deposito");
                });

            modelBuilder.Entity("Armazen.Models.RegistroDeVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Quantia")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("RegistroDeVendas");
                });

            modelBuilder.Entity("Armazen.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Aniversario")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DepositoId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("SalarioBase")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DepositoId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Armazen.Models.RegistroDeVenda", b =>
                {
                    b.HasOne("Armazen.Models.Vendedor", "Vendedor")
                        .WithMany("Registros")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("Armazen.Models.Vendedor", b =>
                {
                    b.HasOne("Armazen.Models.Deposito", null)
                        .WithMany("Vendedores")
                        .HasForeignKey("DepositoId");
                });
#pragma warning restore 612, 618
        }
    }
}
