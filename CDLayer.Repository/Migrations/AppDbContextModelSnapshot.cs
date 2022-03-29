﻿// <auto-generated />
using System;
using CDLayer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CDLayer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CDLayer.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kitaplar"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("CDLayer.Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3244),
                            Name = "Kalem 1",
                            Price = 100m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3258),
                            Name = "Kalem 2",
                            Price = 200m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3259),
                            Name = "Kalem 3",
                            Price = 300m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3261),
                            Name = "Kitap 1",
                            Price = 300m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3262),
                            Name = "Kitap 2",
                            Price = 300m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3263),
                            Name = "Kitap 3",
                            Price = 300m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3265),
                            Name = "Defter 1",
                            Price = 400m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3266),
                            Name = "Defter 2",
                            Price = 500m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 3, 29, 21, 59, 58, 849, DateTimeKind.Local).AddTicks(3267),
                            Name = "Defter 3",
                            Price = 600m,
                            Stock = 10
                        });
                });

            modelBuilder.Entity("CDLayer.Core.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Kırmızı",
                            Height = 200,
                            ProductId = 1,
                            Width = 100
                        },
                        new
                        {
                            Id = 2,
                            Color = "Mavi",
                            Height = 200,
                            ProductId = 2,
                            Width = 100
                        });
                });

            modelBuilder.Entity("CDLayer.Core.Product", b =>
                {
                    b.HasOne("CDLayer.Core.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CDLayer.Core.ProductFeature", b =>
                {
                    b.HasOne("CDLayer.Core.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("CDLayer.Core.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CDLayer.Core.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CDLayer.Core.Product", b =>
                {
                    b.Navigation("ProductFeature");
                });
#pragma warning restore 612, 618
        }
    }
}
