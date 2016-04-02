namespace Carrick.Web.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Carrick.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Carrick.Web.Models.ApplicationDbContext context)
        {
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "WilstonScoutTroop",
            //    Email = "wilstonscouttroop@gmail.com",
            //    EmailConfirmed = true,
            //    FirstName = "Wilston",
            //    LastName = "ScoutTroop",
            //    Level = 1,
            //    JoinDate = DateTime.Now.AddYears(-3)
            //};

            //manager.Create(user, "PurpleDen");

            //if (roleManager.Roles.Count() == 0)
            //{
            //    roleManager.Create(new IdentityRole { Name = "SuperAdmin" });
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByName("WilstonScoutTroop");

            //manager.AddToRoles(adminUser.Id, new string[] { "SuperAdmin", "Admin" });
        //}
        }
    }
}
