using System;
using EStore.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace EStore.DataAccess
{
    public class EStoreContext : DbContext
    {
        public EStoreContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Specification> Specifications { get; set; }
        
        public DbSet<ProductSpecification> ProductSpecifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSpecification>()
                .HasKey(ps => new { ps.ProductId, ps.SpecificationId });

            modelBuilder.Entity<ProductSpecification>()
                .HasOne(ps => ps.Product)
                .WithMany(p => p.ProductSpecifications)
                .HasForeignKey(ps => ps.ProductId);

            modelBuilder.Entity<ProductSpecification>()
                .HasOne(ps => ps.Specification)
                .WithMany(s => s.ProductSpecifications)
                .HasForeignKey(ps => ps.SpecificationId);
            
            modelBuilder.Entity<Brand>().HasData(
                new Brand[] 
                {
                    new Brand { Id=1, Name="Samsung"},
                    new Brand { Id=2, Name="Apple"},
                    new Brand { Id=3, Name="LG"},
                    new Brand { Id=4, Name="Xiaomi"},
                    new Brand { Id=5, Name="Dell"},
                    new Brand { Id=6, Name="Bosch"},
                    new Brand { Id=7, Name="Siemens"},
                    new Brand { Id=8, Name="HP"},
                    new Brand { Id=9, Name="Lenovo"},
                    new Brand { Id=10, Name="Huawei"}
                });
            
            modelBuilder.Entity<Category>().HasData(
                new Category[] 
                {
                    new Category { Id=1, Name="Телефоны"},
                    new Category { Id=2, Name="Телевизоры"},
                    new Category { Id=3, Name="Холодильники"},
                    new Category { Id=4, Name="Ноутбуки"},
                    new Category { Id=5, Name="Принтеры"},
                    new Category { Id=6, Name="Пылесосы"},
                    new Category { Id=7, Name="Сушильные машины"},
                    new Category { Id=8, Name="Электрочайники"},
                    new Category { Id=9, Name="Моноблоки"},
                    new Category { Id=10, Name="Мониторы"}
                });
            
            modelBuilder.Entity<Product>().HasData(
                new Product[] 
                {
                    new Product { Id=1, Name="Iphone 12", BrandId = 2, CategoryId = 1, Price = 103390, ImagePath = "", Rating = 5},
                    new Product { Id=2, Name="Xiaomi Mi 11 Lite 4G", BrandId = 4, CategoryId = 1, Price = 30900, ImagePath = "", Rating = 7},
                    new Product { Id=3, Name="Монитор игровой HP X24c", BrandId = 8, CategoryId = 10, Price = 13490, ImagePath = "", Rating = 9},
                    new Product { Id=4, Name="Монитор Samsung S24F354FHI", BrandId = 1, CategoryId = 10, Price = 9490, ImagePath = "", Rating = 5},
                    new Product { Id=5, Name="Ноутбук Huawei MateBook D15 BoB-WAI9", BrandId = 10, CategoryId = 4, Price = 47490, ImagePath = "", Rating = 2},
                    new Product { Id=6, Name="Ноутбук игровой Lenovo Legion 5 15ACH6H", BrandId = 9, CategoryId = 4, Price = 109900, ImagePath = "", Rating = 5},
                    new Product { Id=7, Name="Моноблок для бизнеса Lenovo V30a-24IML", BrandId = 9, CategoryId = 9, Price = 57790, ImagePath = "", Rating = 6},
                    new Product { Id=8, Name="Моноблок HP 22-df0025ur 14P64EA", BrandId = 8, CategoryId = 9, Price = 42990, ImagePath = "", Rating = 5},
                    new Product { Id=9, Name="Телевизор LG NanoCell 55NANO866NA", BrandId = 3, CategoryId = 2, Price = 57790, ImagePath = "", Rating = 5},
                    new Product { Id=10, Name="Телевизор Samsung QE50Q67TAU", BrandId = 1, CategoryId = 2, Price = 52990, ImagePath = "", Rating = 5},
                    new Product { Id=11, Name="Электрочайник Bosch TWK7S05", BrandId = 6, CategoryId = 8, Price = 8990, ImagePath = "", Rating = 4},
                    new Product { Id=12, Name="Электрочайник Xiaomi Mi Smart Kettle YM-K1501", BrandId = 4, CategoryId = 8, Price = 32990, ImagePath = "", Rating = 1},
                    new Product { Id=13, Name="Пылесос ручной (handstick) Samsung Jet 70 turbo", BrandId = 1, CategoryId = 6, Price = 19990, ImagePath = "", Rating = 3},
                    new Product { Id=14, Name="Робот-пылесос Xiaomi Robot Vacuum-Mop", BrandId = 4, CategoryId = 6, Price = 15390, ImagePath = "", Rating = 2},
                    new Product { Id=15, Name="Лазерный принтер HP Laser 107wr", BrandId = 8, CategoryId = 5, Price = 8690, ImagePath = "", Rating = 9},
                    new Product { Id=16, Name="Лазерный принтер Samsung Xpress M2020", BrandId = 1, CategoryId = 5, Price = 93390, ImagePath = "", Rating = 10},
                    new Product { Id=17, Name="Сушильная машина LG DC90V9V9W", BrandId = 3, CategoryId = 7, Price = 59390, ImagePath = "", Rating = 8},
                    new Product { Id=18, Name="Сушильная машина Samsung DV90TA040AE", BrandId = 1, CategoryId = 7, Price = 43390, ImagePath = "", Rating = 6},
                    new Product { Id=19, Name="Холодильник LG DoorCoolingи", BrandId = 3, CategoryId = 3, Price = 39390, ImagePath = "", Rating = 3},
                    new Product { Id=20, Name="Холодильник Bosch Serie", BrandId = 6, CategoryId = 3, Price = 45990, ImagePath = "", Rating = 2}
                });
            
            modelBuilder.Entity<Specification>().HasData(
                new Specification[] 
                {
                    new Specification { Id=1, Name="Цвет", SpecificationType = ESpecificationType.SpecString},
                    new Specification { Id=2, Name="Вес", SpecificationType = ESpecificationType.SpecDecimal},
                    new Specification { Id=3, Name="Подсветка", SpecificationType = ESpecificationType.SpecBoolean},
                    new Specification { Id=4, Name="Диагональ экрана", SpecificationType = ESpecificationType.SpecDecimal}
                    });
            
            modelBuilder.Entity<ProductSpecification>().HasData(
                new ProductSpecification[] 
                {
                    new ProductSpecification { ProductId = 1, SpecificationId = 1, SpecString = "Красный"},
                    new ProductSpecification { ProductId = 1, SpecificationId = 2, SpecDecimal = (decimal?) 0.18},
                    new ProductSpecification { ProductId = 1, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 1, SpecificationId = 4, SpecDecimal = 5},
                    new ProductSpecification { ProductId = 2, SpecificationId = 1, SpecString = "Синий"},
                    new ProductSpecification { ProductId = 2, SpecificationId = 2, SpecDecimal = (decimal?) 0.5},
                    new ProductSpecification { ProductId = 2, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 2, SpecificationId = 4, SpecDecimal = 5},
                    new ProductSpecification { ProductId = 3, SpecificationId = 1, SpecString = "Синий"},
                    new ProductSpecification { ProductId = 3, SpecificationId = 2, SpecDecimal = 1},
                    new ProductSpecification { ProductId = 3, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 3, SpecificationId = 4, SpecDecimal = 21},
                    new ProductSpecification { ProductId = 4, SpecificationId = 1, SpecString = "Белый"},
                    new ProductSpecification { ProductId = 4, SpecificationId = 2, SpecDecimal = (decimal?) 1.5},
                    new ProductSpecification { ProductId = 4, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 4, SpecificationId = 4, SpecDecimal = 19},
                    new ProductSpecification { ProductId = 5, SpecificationId = 1, SpecString = "Черный"},
                    new ProductSpecification { ProductId = 5, SpecificationId = 2, SpecDecimal = (decimal?) 1.5},
                    new ProductSpecification { ProductId = 5, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 5, SpecificationId = 4, SpecDecimal = 13},
                    new ProductSpecification { ProductId = 6, SpecificationId = 1, SpecString = "Синий"},
                    new ProductSpecification { ProductId = 6, SpecificationId = 2, SpecDecimal = (decimal?) 1.5},
                    new ProductSpecification { ProductId = 6, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 6, SpecificationId = 4, SpecDecimal = 15},
                    new ProductSpecification { ProductId = 7, SpecificationId = 1, SpecString = "Черный"},
                    new ProductSpecification { ProductId = 7, SpecificationId = 2, SpecDecimal = (decimal?) 3.5},
                    new ProductSpecification { ProductId = 7, SpecificationId = 3, SpecBoolean = false},
                    new ProductSpecification { ProductId = 7, SpecificationId = 4, SpecDecimal = 62},
                    new ProductSpecification { ProductId = 8, SpecificationId = 1, SpecString = "Белый"},
                    new ProductSpecification { ProductId = 8, SpecificationId = 2, SpecDecimal = (decimal?) 2.6},
                    new ProductSpecification { ProductId = 8, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 8, SpecificationId = 4, SpecDecimal = 34},
                    new ProductSpecification { ProductId = 9, SpecificationId = 1, SpecString = "Черный"},
                    new ProductSpecification { ProductId = 9, SpecificationId = 2, SpecDecimal = (decimal?) 2.5},
                    new ProductSpecification { ProductId = 9, SpecificationId = 3, SpecBoolean = false},
                    new ProductSpecification { ProductId = 9, SpecificationId = 4, SpecDecimal = 55},
                    new ProductSpecification { ProductId = 10, SpecificationId = 1, SpecString = "Красный"},
                    new ProductSpecification { ProductId = 10, SpecificationId = 2, SpecDecimal = 2},
                    new ProductSpecification { ProductId = 10, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 10, SpecificationId = 4, SpecDecimal = 43},
                    new ProductSpecification { ProductId = 11, SpecificationId = 1, SpecString = "Красный"},
                    new ProductSpecification { ProductId = 11, SpecificationId = 2, SpecDecimal = (decimal?) 0.5},
                    new ProductSpecification { ProductId = 12, SpecificationId = 1, SpecString = "Красный"},
                    new ProductSpecification { ProductId = 12, SpecificationId = 2, SpecDecimal = (decimal?) 0.3},
                    new ProductSpecification { ProductId = 12, SpecificationId = 3, SpecBoolean = true},
                    new ProductSpecification { ProductId = 13, SpecificationId = 1, SpecString = "Белый"},
                    new ProductSpecification { ProductId = 13, SpecificationId = 2, SpecDecimal = 2},
                    new ProductSpecification { ProductId = 14, SpecificationId = 1, SpecString = "Белый"},
                    new ProductSpecification { ProductId = 14, SpecificationId = 2, SpecDecimal = 3},
                    new ProductSpecification { ProductId = 15, SpecificationId = 1, SpecString = "Синий"},
                    new ProductSpecification { ProductId = 15, SpecificationId = 2, SpecDecimal = 3},
                    new ProductSpecification { ProductId = 16, SpecificationId = 1, SpecString = "Черный"},
                    new ProductSpecification { ProductId = 16, SpecificationId = 2, SpecDecimal = 3},
                    new ProductSpecification { ProductId = 17, SpecificationId = 1, SpecString = "Черный"},
                    new ProductSpecification { ProductId = 17, SpecificationId = 2, SpecDecimal = 15},
                    new ProductSpecification { ProductId = 18, SpecificationId = 1, SpecString = "Белый"},
                    new ProductSpecification { ProductId = 18, SpecificationId = 2, SpecDecimal = 25},
                    new ProductSpecification { ProductId = 18, SpecificationId = 3,SpecBoolean = true},
                    new ProductSpecification { ProductId = 19, SpecificationId = 1, SpecString = "Белый"},
                    new ProductSpecification { ProductId = 19, SpecificationId = 2,SpecDecimal = 25},
                    new ProductSpecification { ProductId = 19, SpecificationId = 3,SpecBoolean = true},
                    new ProductSpecification { ProductId = 19, SpecificationId = 4,SpecDecimal = 19},
                    new ProductSpecification { ProductId = 20, SpecificationId = 1, SpecString = "Красный"},
                    new ProductSpecification { ProductId = 20, SpecificationId = 2, SpecDecimal = 30}
                });
        }
    }
    
}