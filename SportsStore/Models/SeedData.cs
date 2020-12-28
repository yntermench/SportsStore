using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "WaterSports", Price = 275
                    },

                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "WaterSports", Price = 48.95m
                    },

                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer", Price = 19.50m
                    },

                    new Product
                    {
                        Name = "Corner flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },

                    new Product
                    {
                        Name = "Stadium",
                        Description = "Flat packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },

                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency 75% ",
                        Category = "Chess",
                        Price = 16
                    },

                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secrently give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },

                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },

                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-stated King",
                        Category = "Chess",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
