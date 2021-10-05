using FoodShop.Data.Entities;
using FoodShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of FoodShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of FoodShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of FoodShop" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Rau củ",
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     Name = "Bánh kẹo",
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Bánh quy",
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 2 }
                );
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "lehuuam741@gmail.com",
                NormalizedEmail = "lehuuam741@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345"),
                SecurityStamp = string.Empty,
                FirstName = "Tam",
                LastName = "Le",
                Dob = new DateTime(2000, 07, 25)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }

    }
}

