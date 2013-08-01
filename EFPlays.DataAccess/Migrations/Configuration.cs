namespace EFPlays.DataAccess.Migrations
{
	using EFPlays.Model;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<EFPlays.DataAccess.EFPlaysDbContext>
	{
		public Configuration()
		{
#if (DEBUG)
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;
#else
			AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = false;
#endif
		}

		protected override void Seed(EFPlays.DataAccess.EFPlaysDbContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//

			context.Users.AddOrUpdate(new User
			{
				Id = 1,
				FirstName = "Martin",
				LastName = "Normark",
				EMail = "me@me.com",
				PhoneNumber = "12345678",
				DateOfBirth = new DateTime(1982, 02, 09),
				Country = "Denmark"
			});
		}
	}
}