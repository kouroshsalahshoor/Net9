using Microsoft.EntityFrameworkCore;
using SportsStore.Auto.Client.Models;
using static System.Net.Mime.MediaTypeNames;

namespace SportsStore.Auto.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(ApplicationDbContext context)
        {
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275
                },
                new Product
                {
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Watersports",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Corner Flags",
                    Description = "Give your playing field a professional touch",
                    Category = "Soccer",
                    Price = 34.95m
                },
                new Product
                {
                    Name = "Stadium",
                    Description = "Flat-packed 35,000-seat stadium",
                    Category = "Soccer",
                    Price = 79500
                },
                new Product
                {
                    Name = "Thinking Cap",
                    Description = "Improve brain efficiency by 75%",
                    Category = "Chess",
                    Price = 16
                },
                new Product
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
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
                    Description = "Gold-plated, diamond-studded King",
                    Category = "Chess",
                    Price = 1200
                }
                );
                context.SaveChanges();
            }

            if (context.People.Count() == 0 && context.Departments.Count() == 0 && context.Locations.Count() == 0)
            {
                Department d1 = new Department { Name = "Sales" };
                Department d2 = new Department { Name = "Development" };
                Department d3 = new Department { Name = "Support" };
                Department d4 = new Department { Name = "Facilities" };
                context.Departments.AddRange(d1, d2, d3, d4);
                context.SaveChanges();
                Location l1 = new Location { City = "Oakland", State = "CA" };
                Location l2 = new Location { City = "San Jose", State = "CA" };
                Location l3 = new Location { City = "New York", State = "NY" };
                context.Locations.AddRange(l1, l2, l3);
                context.People.AddRange(
                new Person
                {
                    Firstname = "Francesca",
                    Surname = "Jacobs",
                    Department = d2,
                    Location = l1
                },
                new Person
                {
                    Firstname = "Charles",
                    Surname = "Fuentes",
                    Department = d2,
                    Location = l3
                },
                new Person
                {
                    Firstname = "Bright",
                    Surname = "Becker",
                    Department = d4,
                    Location = l1
                },
                new Person
                {
                    Firstname = "Murphy",
                    Surname = "Lara",
                    Department = d1,
                    Location = l3
                },
                new Person
                {
                    Firstname = "Beasley",
                    Surname = "Hoffman",
                    Department = d4,
                    Location = l3
                },
                new Person
                {
                    Firstname = "Marks",
                    Surname = "Hays",
                    Department = d4,
                    Location = l1
                },
                new Person
                {
                    Firstname = "Underwood",
                    Surname = "Trujillo",
                    Department = d2,
                    Location = l1
                },
                new Person
                {
                    Firstname = "Randall",
                    Surname = "Lloyd",
                    Department = d3,
                    Location = l2
                },
                new Person
                {
                    Firstname = "Guzman",
                    Surname = "Case",
                    Department = d2,
                    Location = l2
                });
                context.SaveChanges();
            }
        }
    }
}