using Microsoft.EntityFrameworkCore;

using Liss.Data.EntityFramework.Mappings;
using Liss.Data.Poco;

namespace Liss.Data.EntityFramework
{
	public class LissContext : DbContext
	{
		public LissContext(DbContextOptions options)
			: base(options)
		{
			
		}

		public DbSet<VitalDrug> VitalDrugs { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<VitalDrug>(VitalDrugMapper.CreateMappings);
		}
	}
}
