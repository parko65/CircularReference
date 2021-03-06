﻿// <auto-generated />
using CircularReference.Api.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CircularReference.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210225184245_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CircularReference.Shared.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CircularReference.Shared.Models.Hardware", b =>
                {
                    b.Property<int>("HardwareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("HardwareName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HardwareId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Hardwares");
                });

            modelBuilder.Entity("CircularReference.Shared.Models.Software", b =>
                {
                    b.Property<int>("SoftwareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("SoftwareName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SoftwareId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("CircularReference.Shared.Models.Hardware", b =>
                {
                    b.HasOne("CircularReference.Shared.Models.Customer", "Customer")
                        .WithMany("Hardwares")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CircularReference.Shared.Models.Software", b =>
                {
                    b.HasOne("CircularReference.Shared.Models.Customer", "Customer")
                        .WithMany("Softwares")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CircularReference.Shared.Models.Customer", b =>
                {
                    b.Navigation("Hardwares");

                    b.Navigation("Softwares");
                });
#pragma warning restore 612, 618
        }
    }
}
