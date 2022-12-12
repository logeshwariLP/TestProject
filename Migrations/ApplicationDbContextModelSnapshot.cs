﻿// <auto-generated />
using GetEntityDetailsApi.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GetEntityDetailsApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GetEntityDetailsApi.Models.EntityDetails", b =>
                {
                    b.Property<int>("ACN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ACN"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personalEmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ACN");

                    b.ToTable("EntityDetails");

                    b.HasData(
                        new
                        {
                            ACN = 111111,
                            Address = "1st street, AU",
                            EntityName = "AAA Enterprise",
                            personalEmailID = "aaa@test.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
