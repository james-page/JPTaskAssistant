﻿// <auto-generated />
using System;
using JPTaskAssistant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JPTaskAssistant.Data.JPMigrations
{
    [DbContext(typeof(JPTaskAssistantContext))]
    partial class JPTaskAssistantContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JPTaskAssistant.Data.Models.JPDailyListTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnteredBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JPDailyListTask");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6db6ba69-466f-4b92-8851-af192810c709"),
                            DateEntered = new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6408),
                            EnteredBy = "James",
                            IsCompleted = false,
                            Title = "Create New UI",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("d008e31c-aa26-4acc-9641-d392183ef57c"),
                            DateEntered = new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6449),
                            EnteredBy = "James",
                            IsCompleted = false,
                            Title = "Test Checking Task as Done",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("50dc569a-5a00-4fb5-b6cb-3c2295edc9ca"),
                            DateEntered = new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6451),
                            EnteredBy = "James",
                            IsCompleted = false,
                            Title = "Add and Remove Tasks",
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("dcb6a30d-34e2-4cbd-9200-2c039bf56cba"),
                            DateEntered = new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6452),
                            EnteredBy = "James",
                            IsCompleted = false,
                            Title = "Come Up With Celebration Idea",
                            Type = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
