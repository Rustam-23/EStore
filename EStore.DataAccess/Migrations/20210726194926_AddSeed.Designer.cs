﻿// <auto-generated />
using EStore.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EStore.DataAccess.Migrations
{
    [DbContext(typeof(EStoreContext))]
    [Migration("20210726194926_AddSeed")]
    partial class AddSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EStore.Domains.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 3,
                            Name = "LG"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dell"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Bosch"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Siemens"
                        },
                        new
                        {
                            Id = 8,
                            Name = "HP"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Lenovo"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Huawei"
                        });
                });

            modelBuilder.Entity("EStore.Domains.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Телефоны"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Телевизоры"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Холодильники"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ноутбуки"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Принтеры"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Пылесосы"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Сушильные машины"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Электрочайники"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Моноблоки"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Мониторы"
                        });
                });

            modelBuilder.Entity("EStore.Domains.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 2,
                            CategoryId = 1,
                            ImagePath = "",
                            Name = "Iphone 12",
                            Price = 103390m,
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 4,
                            CategoryId = 1,
                            ImagePath = "",
                            Name = "Xiaomi Mi 11 Lite 4G",
                            Price = 30900m,
                            Rating = 7
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 8,
                            CategoryId = 10,
                            ImagePath = "",
                            Name = "Монитор игровой HP X24c",
                            Price = 13490m,
                            Rating = 9
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            CategoryId = 10,
                            ImagePath = "",
                            Name = "Монитор Samsung S24F354FHI",
                            Price = 9490m,
                            Rating = 5
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 10,
                            CategoryId = 4,
                            ImagePath = "",
                            Name = "Ноутбук Huawei MateBook D15 BoB-WAI9",
                            Price = 47490m,
                            Rating = 2
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 9,
                            CategoryId = 4,
                            ImagePath = "",
                            Name = "Ноутбук игровой Lenovo Legion 5 15ACH6H",
                            Price = 109900m,
                            Rating = 5
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 9,
                            CategoryId = 9,
                            ImagePath = "",
                            Name = "Моноблок для бизнеса Lenovo V30a-24IML",
                            Price = 57790m,
                            Rating = 6
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 8,
                            CategoryId = 9,
                            ImagePath = "",
                            Name = "Моноблок HP 22-df0025ur 14P64EA",
                            Price = 42990m,
                            Rating = 5
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 3,
                            CategoryId = 2,
                            ImagePath = "",
                            Name = "Телевизор LG NanoCell 55NANO866NA",
                            Price = 57790m,
                            Rating = 5
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 1,
                            CategoryId = 2,
                            ImagePath = "",
                            Name = "Телевизор Samsung QE50Q67TAU",
                            Price = 52990m,
                            Rating = 5
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 6,
                            CategoryId = 8,
                            ImagePath = "",
                            Name = "Электрочайник Bosch TWK7S05",
                            Price = 8990m,
                            Rating = 4
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 4,
                            CategoryId = 8,
                            ImagePath = "",
                            Name = "Электрочайник Xiaomi Mi Smart Kettle YM-K1501",
                            Price = 32990m,
                            Rating = 1
                        },
                        new
                        {
                            Id = 13,
                            BrandId = 1,
                            CategoryId = 6,
                            ImagePath = "",
                            Name = "Пылесос ручной (handstick) Samsung Jet 70 turbo",
                            Price = 19990m,
                            Rating = 3
                        },
                        new
                        {
                            Id = 14,
                            BrandId = 4,
                            CategoryId = 6,
                            ImagePath = "",
                            Name = "Робот-пылесос Xiaomi Robot Vacuum-Mop",
                            Price = 15390m,
                            Rating = 2
                        },
                        new
                        {
                            Id = 15,
                            BrandId = 8,
                            CategoryId = 5,
                            ImagePath = "",
                            Name = "Лазерный принтер HP Laser 107wr",
                            Price = 8690m,
                            Rating = 9
                        },
                        new
                        {
                            Id = 16,
                            BrandId = 1,
                            CategoryId = 5,
                            ImagePath = "",
                            Name = "Лазерный принтер Samsung Xpress M2020",
                            Price = 93390m,
                            Rating = 10
                        },
                        new
                        {
                            Id = 17,
                            BrandId = 3,
                            CategoryId = 7,
                            ImagePath = "",
                            Name = "Сушильная машина LG DC90V9V9W",
                            Price = 59390m,
                            Rating = 8
                        },
                        new
                        {
                            Id = 18,
                            BrandId = 1,
                            CategoryId = 7,
                            ImagePath = "",
                            Name = "Сушильная машина Samsung DV90TA040AE",
                            Price = 43390m,
                            Rating = 6
                        },
                        new
                        {
                            Id = 19,
                            BrandId = 3,
                            CategoryId = 3,
                            ImagePath = "",
                            Name = "Холодильник LG DoorCoolingи",
                            Price = 39390m,
                            Rating = 3
                        },
                        new
                        {
                            Id = 20,
                            BrandId = 6,
                            CategoryId = 3,
                            ImagePath = "",
                            Name = "Холодильник Bosch Serie",
                            Price = 45990m,
                            Rating = 2
                        });
                });

            modelBuilder.Entity("EStore.Domains.Entities.Product", b =>
                {
                    b.HasOne("EStore.Domains.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EStore.Domains.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EStore.Domains.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EStore.Domains.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
