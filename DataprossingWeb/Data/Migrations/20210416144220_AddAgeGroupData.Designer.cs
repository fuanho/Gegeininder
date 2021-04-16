﻿// <auto-generated />
using DataprossingWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataprossingWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210416144220_AddAgeGroupData")]
    partial class AddAgeGroupData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dataprossing.Models.PopulationAgeGroupInBaishaPenghu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("age0")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PopulationAgeGroupInBaishaPenghus");
                });
#pragma warning restore 612, 618
        }
    }
}
