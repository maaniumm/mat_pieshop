using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser> // To connect app and database and allow authentication and scaffolding
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) // To add "real" data to the database in migration
        {
            base.OnModelCreating(modelBuilder);

            //Kategorie
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Serniki" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Torty" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Vegan" });

            //Ciasta
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "New York Cheesecake",
                Price = 12.95M,
                ShortDescription = "Najelpszy Nowojorski sernik!",
                LongDescription = "Najelpszy Nowojorski sernik!",
                CategoryId = 1,
                ImgUrl = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/5E8CF016-026E-4859-AAA3-BDC530349537/Derivates/2ECB4E65-17DA-416B-ABD0-4DD330B5B934.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImgThumbUrl = "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/5E8CF016-026E-4859-AAA3-BDC530349537/Derivates/2ECB4E65-17DA-416B-ABD0-4DD330B5B934.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Sernik krolewski",
                Price = 8.99M,
                ShortDescription = "Kruche ciasto z dodatkiem kakao i idealna masa serowa!",
                LongDescription = "Kruche ciasto z dodatkiem kakao i idealna masa serowa!",
                CategoryId = 1,
                ImgUrl = "https://d3iamf8ydd24h9.cloudfront.net/pictures/articles/2018/11/659622-v-1080x1080.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImgThumbUrl = "https://d3iamf8ydd24h9.cloudfront.net/pictures/articles/2018/11/659622-v-1080x1080.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Tort orzechowy",
                Price = 11.95M,
                ShortDescription = "Delikatny orzechowy krem...",
                LongDescription = "Delikatny orzechowy krem...",
                CategoryId = 2,
                ImgUrl = "https://pk1.pocztakwiatowa.pl/media/catalog/product/xc/image/t/o/tort_orzechowy.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImgThumbUrl = "https://pk1.pocztakwiatowa.pl/media/catalog/product/xc/image/t/o/tort_orzechowy.jpg",
                AllergyInformation = ""
            });
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Tofumisu",
                Price = 25M,
                ShortDescription = "Tofumisu - tiramisu w wersji Vegan!",
                LongDescription = "Tofumisu - tiramisu w wersji Vegan!",
                CategoryId = 3,
                ImgUrl = "https://wszystkiegoslodkiego.pl/storage/images/202110/tofumisu-1.webp",
                InStock = true,
                IsPieOfTheWeek = false,
                ImgThumbUrl = "https://wszystkiegoslodkiego.pl/storage/images/202110/tofumisu-1.webp",
                AllergyInformation = ""
            });
        }
    }
}
