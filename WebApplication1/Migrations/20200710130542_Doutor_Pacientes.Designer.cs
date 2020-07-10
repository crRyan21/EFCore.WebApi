﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(PacienteContext))]
    [Migration("20200710130542_Doutor_Pacientes")]
    partial class Doutor_Pacientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Doutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("DirthDate");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Doutores");
                });

            modelBuilder.Entity("WebApplication1.Models.DoutorPaciente", b =>
                {
                    b.Property<int>("DoutorId");

                    b.Property<int>("PacienteId");

                    b.HasKey("DoutorId", "PacienteId");

                    b.HasIndex("PacienteId");

                    b.ToTable("DoutorPacientes");
                });

            modelBuilder.Entity("WebApplication1.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Crm")
                        .IsRequired();

                    b.Property<string>("CrmUf")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("WebApplication1.Models.DoutorPaciente", b =>
                {
                    b.HasOne("WebApplication1.Models.Doutor", "Doutor")
                        .WithMany("MyProperty")
                        .HasForeignKey("DoutorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.Paciente", "Paciente")
                        .WithMany("MyProperty")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
