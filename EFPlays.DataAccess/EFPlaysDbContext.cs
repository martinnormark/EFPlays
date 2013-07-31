using EFPlays.Model;
using System.Data.Entity;

namespace EFPlays.DataAccess
{
	public class EFPlaysDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
	}
}