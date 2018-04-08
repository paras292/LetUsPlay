namespace LetUsPlay.Migrations
{
    using LetUsPlay.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LetUsPlay.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LetUsPlay.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (context.Locations.Count() == 0)
            {
                context.Locations.AddOrUpdate(new Location { LocationName = "H1" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H2" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H3" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H4" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H5" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H6" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H7" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H8" });
                context.Locations.AddOrUpdate(new Location { LocationName = "H9" });
            }

        }
    }
}
