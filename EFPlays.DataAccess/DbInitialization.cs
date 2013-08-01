using System.Data.Entity;

namespace EFPlays.DataAccess
{
	public class DbInitialization
	{
		public static void Run()
		{
			Database.SetInitializer<EFPlaysDbContext>(new MigrateDatabaseToLatestVersion<EFPlaysDbContext, EFPlays.DataAccess.Migrations.Configuration>());

			using (var context = new EFPlaysDbContext())
			{
	#if (DEBUG)
				context.Database.Initialize(true);
	#else
				context.Database.Initialize(false);
	#endif
			}
		}
	}
}