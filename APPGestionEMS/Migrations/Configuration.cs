namespace APPGestionEMS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<APPGestionEMS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APPGestionEMS.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            string administrador = "administrador";
            string profesor = "profesor";
            string alumno = "alumno";
            AddRole(context, administrador);
            AddRole(context, profesor);
            AddRole(context, alumno);
            AddUser(context, "Admin", "Istrador", "admin@upm.es",administrador);
            AddUser(context, "Jessica", "Diaz", "yesica.diaz@upm.es",profesor);
            AddUser(context, "Carolina", "Gallardo", "carolina.gallardop@upm.es",profesor);
            AddUser(context, "Alberto", "Marcos", "alberto.mblasco@alumnos.upm.es",alumno);
            AddUser(context, "Armando", "Guerra", "armandoguerra@alumnos.upm.es",alumno);
            AddUser(context, "Mariano", "Rajoy", "mariano.rajoy@alumnos.upm.es",alumno);
        }
        public void AddRole(ApplicationDbContext context, String role)
        {
            IdentityResult IdRoleResult;
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if (!roleMgr.RoleExists(role))
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = role });
        }
        public void AddUser(ApplicationDbContext context, String name, String surname, String email, String role)
        {
            IdentityResult IdUserResult;
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                Name = name,
                Surname = surname,
                UserName = email,
                Email = email,
            };
            IdUserResult = userMgr.Create(appUser, "123456Aa!");
������������//asociar usuario con role
������������if (!userMgr.IsInRole(userMgr.FindByEmail(email).Id, role))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail(email).Id, role);
            }
        }
    }
}
