using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SportStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product() {
                        Name = "Kayak",
                        Description = "boat for one person",
                        Price = 275,
                        Category = "Watersport"},
                    new Product()
                    {
                        Name = "LifeJacket",
                        Description = "Protective and fashionable",
                        Price = 48.95m,
                        Category = "Watersport"
                    },
                    new Product()
                    {
                        Name = "Soccer ball",
                        Description = "FIFA approved",
                        Price = 19.5m,
                        Category = "Soccer"
                    },
                    new Product()
                    {
                        Name = "Corner flag",
                        Description = "Give your play professional",
                        Price = 34.95m,
                        Category = "Soccer"
                    },
                    new Product()
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000 seats",
                        Price = 79950m,
                        Category = "Soccer"
                    },
                    new Product()
                    {
                        Name = "Thinking cap",
                        Description = "Improve brain by 75%",
                        Price = 16m,
                        Category = "Chess"
                    },
                    new Product()
                    {
                        Name = "Unsteday chair",
                        Description = "Super chair for big ass",
                        Price = 29.95m,
                        Category = "Chess"
                    },
                    new Product()
                    {
                        Name = "Human chess board",
                        Description = "A fun game for family",
                        Price = 75,
                        Category = "Chess"
                    },
                    new Product()
                    {
                        Name = "Bling-bling king",
                        Description = "Proze for winner",
                        Price = 1200,
                        Category = "Chess"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
