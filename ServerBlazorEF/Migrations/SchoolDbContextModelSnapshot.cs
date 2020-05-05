﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerBlazorEF.Models;

namespace ServerBlazorEF.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServerBlazorEF.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = "92c475ca-6168-465f-b022-b2278601705f",
                            FirstName = "Jane",
                            LastName = "Smith",
                            School = "Medicine"
                        },
                        new
                        {
                            StudentId = "453e390c-16af-4b84-a0fd-e4140b072442",
                            FirstName = "John",
                            LastName = "Fisher",
                            School = "Engineering"
                        },
                        new
                        {
                            StudentId = "d711000e-9925-4234-8387-db5b50e35098",
                            FirstName = "Pamela",
                            LastName = "Baker",
                            School = "Food Science"
                        },
                        new
                        {
                            StudentId = "224f1421-85b9-4e00-a4de-8adfa19adf21",
                            FirstName = "Peter",
                            LastName = "Taylor",
                            School = "Mining"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
