namespace DayThree_Blog.Migrations
{
    using DayThree_Blog.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DayThree_Blog.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DayThree_Blog.Models.ApplicationDbContext context)
        {
            //Create Roles
            var roleManger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManger.Create(new IdentityRole { Name = "Admin" });
            }
            if (!context.Roles.Any(r => r.Name == "Moderator"))
            {
                roleManger.Create(new IdentityRole { Name = "Moderator" });
            }

            //Create Users
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            if (!context.Users.Any(u => u.Email == "ShawnShroyer@mailinator.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "ShawnShroyer@mailinator.com",
                    Email = "ShawnShroyer@mailinator.com",
                    FirstName = "Shawn",
                    LastName = "Shroyer",
                    DisplayName = "Shawn Shroyer"
                }, "testUser123");
            }

            if (!context.Users.Any(u => u.Email == "JasonTwichell@mailinator.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "JasonTwichell@mailinator.com",
                    Email = "JasonTwichell@mailinator.com",
                    FirstName = "Jason",
                    LastName = "Twichell",
                    DisplayName = "Twitch"
                }, "Abc&123!");
            }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Assign a Role to a user
            var userId = userManager.FindByEmail("ShawnShroyer@mailinator.com").Id;
            userManager.AddToRole(userId, "Admin");

            userId = userManager.FindByEmail("JasonTwichell@mailinator.com").Id;
            userManager.AddToRole(userId, "Moderator");
        }
    }
}
